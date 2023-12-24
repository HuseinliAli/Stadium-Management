using Client.Clients;
using Entities.Dtos.Centers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.Pages.Admin
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void HomePage_Load(object sender, EventArgs e)
        {
            var centerClient = new CenterClient();
            FillFlowLayout(await centerClient.GetCenters());
            FillDashboard();
        }
        private async void FillDashboard()
        {
            var adminClient = new UserClient();
            var result = await adminClient.AdminDashboard();
            centerCountLbl.Text=result.ThisMonthCenterCount.ToString();
            centerCountLbl.Text=result.ThisMonthCenterCount.ToString();

            rentedCountLbl.Text=result.ThisMonthRentCount.ToString();
            centerCountLbl.Text=result.ThisMonthCenterCount.ToString();

            userCountLbl.Text=result.ThisMonthUserCount.ToString();
            centerCountLbl.Text=result.ThisMonthCenterCount.ToString();

            stadiumCountLbl.Text=result.ThisMonthStadiumCount.ToString();
            centerCountLbl.Text=result.ThisMonthCenterCount.ToString();
        }
        private async void searchTxt_TextChanged(object sender, EventArgs e)
        {
            var client = new CenterClient();
            FillFlowLayout(await client.GetCenters(searchTxt.Text));
        }



        private void FillFlowLayout(List<CenterDetailDto> centers)
        {
            centerLytPnl.Controls.Clear();
            int count = 1;
            foreach (var center in centers)
            {
                var uc = new CenterCard();
                uc.Count=$"{count.ToString()}.";
                uc.Name=center.Name;
                uc.Email=center.Email;
                uc.StadiumCount=center.StadiumCount.ToString();
                uc.Phone=center.Number;
                uc.View="https://google.com";
                uc.CreatedBy=center.CreatedBy;
                uc.Visible=true;
                centerLytPnl.Controls.Add(uc);
                count++;
            }
        }

    }
}
