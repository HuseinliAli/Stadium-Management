using Business.Abstract;
using Client.Clients;
using Entities.Concrete;
using Entities.Dtos.Centers;
using Entities.Dtos.Rents;
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
    public partial class CenterPage : UserControl
    {
        private System.Windows.Forms.Timer hideNotificationTimer;
        public CenterPage()
        {
            InitializeComponent();

            notification.Visible = false;
            hideNotificationTimer = new System.Windows.Forms.Timer();
            hideNotificationTimer.Interval = 4000;
            hideNotificationTimer.Tick += HideNotificationTimer_Tick;
        }

        private async void CenterPage_Load(object sender, EventArgs e)
        {
            searchTxt_TextChanged(null, null);
            //var client = new CenterClient();
            //var centers = await client.GetCentersByUserId();
            //FillFlowLayout(centers.OrderByDescending(x=>x.CreatedDate).ToList());
        }

        private async void FillFlowLayout(List<Center> centers)
        {
            centerPanel.Controls.Clear();
            int count = 1;
            foreach (var center in centers)
            {
                var uc = new CenterVendorCard();
                uc.Count=count.ToString();
                uc.Id=center.Id;
                uc.CenterName = center.Name;
                uc.Email=center.Email;
                uc.Visible=true;
                centerPanel.Controls.Add(uc);
                count++;
            }
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            var dto = new AddOrUpdateCenterDto()
            {
                Name=centerName.Text,
                Email=emailTxt.Text,
                Number=numberTxt.Text,
                Address=addressTxt.Text,
            };
            var client = new CenterClient();
            var result = await client.AddCenter(dto);
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
            CenterPage_Load(null, null);
        }
        private void HideNotificationTimer_Tick(object sender, EventArgs e)
        {
            notification.Visible = false;

            hideNotificationTimer.Stop();
        }

        private async void searchTxt_TextChanged(object sender, EventArgs e)
        {
            var client = new CenterClient();
            List<Center> centers = new();
            centers = await client.GetCentersByUserId();
            if (!string.IsNullOrWhiteSpace(searchTxt.Text))
            {
              
                centers = centers.Where(x=>x.Name.ToLower().Contains(searchTxt.Text.ToLower())).ToList();
            }
            else
            {
                centers =  await client.GetCentersByUserId();
            }
            FillFlowLayout(centers.OrderByDescending(x=>x.CreatedDate).ToList());
        }
    }
}
