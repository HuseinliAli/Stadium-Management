using Client.Clients;
using Entities.Dtos.Rents;
using Framework.Utilities.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.Pages.Vendor
{
    public partial class RentsPage : UserControl
    {
        public RentsPage()
        {
            InitializeComponent();
            dateTimePicker.MinDate = DateTime.Now;
            checkoutPanel.Visible=false;
            RentsPage_Load(null, null);

        }

        public async void RentsPage_Load(object sender, EventArgs e)
        {
            await FillStadiumComboBox();
            await FillFlowLayout();
            checkoutPanel.Visible=false;
        }
        private async Task FillFlowLayout()
        {
            rentFlowPnl.Controls.Clear();
            var client = new RentClient();
            var result = await client.GetDetails();
            int count = 1;

            foreach (var rent in result)
            {
                var uc = new RentCard();
                uc.Count=count.ToString();
                count++;
                uc.StartFinish = rent.Start.ToShortDateString()+rent.Finish.ToShortDateString();
                uc.UserName = rent.UserEmail;
                uc.StadiumName = rent.StadiumName;
                uc.Price = rent.Price.ToString();
                uc.RentedAt = rent.CreatedAt.ToShortDateString();
                uc.Visible=true;
                rentFlowPnl.Controls.Add(uc);
            }
        }
        private async Task FillStadiumComboBox()
        {
            var client = new StadiumClient();
            var stadiums = await client.GetByUser();
            stadiumsCombobx.DataSource = stadiums;
            stadiumsCombobx.ValueMember = "Id";
            stadiumsCombobx.DisplayMember = "HallName";
        }

        private async void checkoutBtn_Click(object sender, EventArgs e)
        {
            var dto = new AddOrUpdateRentDto()
            {
                Start=dateTimePicker.Value,
                StadiumId=int.Parse(stadiumsCombobx.SelectedValue.ToString())
            };
            var client = new RentClient();
            checkoutPanel.Visible=true;
            var result1 = await client.Checkout1(dto);

            if (result1!=null)
            {
                if (result1.Success)
                {
                    var result2 = await client.Checkout2(dto);
                    if (result2!=null)
                    {

                        price.Text=Math.Round(result2.Price, 2).ToString();
                        tax.Text=Math.Round(result2.Tax, 2).ToString();
                        totalPrice.Text=Math.Round(result2.TotalPrice, 2).ToString();
                        isAvailable.Text = "Available";
                        isAvailable.ForeColor = Color.Green;
                        rentBtn.Enabled=true;
                    }
                }
               
                else
                {
                    isAvailable.Text = "Busy";
                    isAvailable.ForeColor = Color.Red;
                    rentBtn.Enabled=false;
                }
            }
            
        }

        private async void rentBtn_Click(object sender, EventArgs e)
        {
            var dto = new AddOrUpdateRentDto()
            {
                Start=dateTimePicker.Value,
                StadiumId=int.Parse(stadiumsCombobx.SelectedValue.ToString())
            };
            var client = new RentClient();
            await client.Add(dto);
            RentsPage_Load(null, null);
        }
    }
}
