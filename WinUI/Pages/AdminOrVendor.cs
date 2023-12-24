using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Pages.Admin;
using WinUI.Pages.Vendor;

namespace WinUI.Pages
{
    public partial class AdminOrVendor : Form
    {
        private string _username;
        public AdminOrVendor(string username)
        {
            InitializeComponent();
            _username=username;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new AdminMain(_username);
            form.Show();
            this.Visible=false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var form = new VendorMain(_username);
            form.Show();
            this.Visible=false;
        }
    }
}
