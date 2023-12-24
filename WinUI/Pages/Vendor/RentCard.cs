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
    public partial class RentCard : UserControl
    {
        public int Id { get; set; }
        public string Count { get { return countLbl.Text; } set { countLbl.Text=value; } }
        public string StartFinish { get { return startFinishLbl.Text; } set { startFinishLbl.Text=value; } }
        public string Price { get { return price.Text; } set { price.Text=value; } }
        public string StadiumName { get { return stadiumLbl.Text; } set { stadiumLbl.Text=value; } }
        public string UserName { get { return userLbl.Text; } set { userLbl.Text=value; } }
        public string RentedAt { get { return rentedAtLbl.Text; } set { rentedAtLbl.Text=value; } }

        public RentCard()
        {
            InitializeComponent();
        }
    }
}
