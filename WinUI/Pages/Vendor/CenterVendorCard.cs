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
    public partial class CenterVendorCard : UserControl
    {
        public int Id { get; set; }
        public string Count { get { return countLbl.Text; } set { countLbl.Text=value; } }
        public string CenterName
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text=value; }
        }
        public string Email
        {
            get { return emailLbl.Text; }
            set { emailLbl.Text=value; }
        }
        public CenterVendorCard()
        {
            InitializeComponent();
        }

      
    }
}
