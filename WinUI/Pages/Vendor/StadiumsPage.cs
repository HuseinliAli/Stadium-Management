using Client.Clients;
using Entities.Concrete;
using Entities.Dtos.Stadiums;
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
    public partial class StadiumsPage : UserControl
    {
        private System.Windows.Forms.Timer hideNotificationTimer;
        public StadiumsPage()
        {
            InitializeComponent();

            notification.Visible = false;
            hideNotificationTimer = new System.Windows.Forms.Timer();
            hideNotificationTimer.Interval = 4000;
            hideNotificationTimer.Tick += HideNotificationTimer_Tick;
            StadiumsPage_Load(null,null);
        }

        private async void StadiumsPage_Load(object sender, EventArgs e)
        {
            //var client = new StadiumClient();
            //var stadiums = await client.GetByUser();
            FillComboBox();
            searchTxt_TextChanged(null, null);
            //  FillLayoutPanel(stadiums.OrderByDescending(x => x.CreatedDate).ToList());
        }
        private async void FillLayoutPanel(List<Stadium> stadiums)
        {
            centerPanel.Controls.Clear();
            int count = 1;
            foreach (var stadium in stadiums)
            {
                var uc = new StadiumCard();
                uc.Count=count.ToString();
                uc.HallName = stadium.HallName;
                uc.Evening=stadium.PriceEvening.ToString();
                uc.Afternoon=stadium.PriceAfternoon.ToString();
                uc.Morning=stadium.PriceMorning.ToString();
                count++;
                uc.Visible=true;
                centerPanel.Controls.Add(uc);
            }
        }
        private async void FillComboBox()
        {
            var client = new CenterClient();
            var result = await client.GetCentersByUserId();
            centersComboBox.DataSource = result;
            centersComboBox.ValueMember="Id";
            centersComboBox.DisplayMember="Name";
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            var dto = new AddOrUpdateStadiumDto()
            {
                HallName=nameLbl.Text,
                CenterId=int.Parse(centersComboBox.SelectedValue.ToString()),
                PriceAfternoon=double.Parse(afternoon.Text),
                PriceEvening=double.Parse(evening.Text),
                PriceMorning=double.Parse(morning.Text)
            };
            var client = new StadiumClient();
            var result = await client.AddStadium(dto);
            notification.Visible=true;
            notificationTxt.Text = result.Message;
            if (result.Success)
            {
                notification.FillColor=Color.FromArgb(224, 254, 207);
                notification.Invalidate();
                hideNotificationTimer.Start();
            }
            else
            {
                notification.FillColor = Color.Red;
                notification.Invalidate();
                hideNotificationTimer.Start();
            }
            StadiumsPage_Load(null, null);
          
        }
        private void HideNotificationTimer_Tick(object sender, EventArgs e)
        {
            notification.Visible = false;

            hideNotificationTimer.Stop();
        }

        private async void searchTxt_TextChanged(object sender, EventArgs e)
        {
            var client = new StadiumClient();
            List<Stadium> stadiums = new();
            stadiums = await client.GetByUser();
            if (!string.IsNullOrWhiteSpace(searchTxt.Text))
            {
               
                stadiums = stadiums.Where(x => x.HallName.ToLower().Contains(searchTxt.Text.ToLower())).ToList();
            }
            else
            {
                stadiums =  await client.GetByUser();
            }
            FillLayoutPanel(stadiums.OrderByDescending(x => x.CreatedDate).ToList());
        }
    }
}
