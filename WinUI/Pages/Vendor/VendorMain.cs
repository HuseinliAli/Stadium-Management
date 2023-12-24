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
    public partial class VendorMain : Form
    {
       
        public VendorMain(string name)
        {
            InitializeComponent();
            rentsPage1.BringToFront();
           
            userFullNameLbl.Text=name;
        }

        private void stadiumBtn_Click(object sender, EventArgs e)
        {
            stadiumsPage1.BringToFront();
        }

        private void centersBtn_Click(object sender, EventArgs e)
        {
            centerPage1.BringToFront();
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            rentsPage1.BringToFront();
        }
    }
}
