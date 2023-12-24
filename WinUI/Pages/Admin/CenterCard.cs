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
    public partial class CenterCard : UserControl
    {
        public string Count { get { return countLbl.Text; } set { countLbl.Text=value; } }
        public string Name { get { return nameTxt.Text; } set { nameTxt.Text=value; } }
        public string Email { get { return emailLbl.Text; } set { emailLbl.Text=value; } }
        public string Phone { get { return phoneLbl.Text; } set { phoneLbl.Text=value; } }
        public string CreatedBy { get { return createdByLbl.Text; } set { createdByLbl.Text=value; } }
        public string StadiumCount { get { return stadiumCountLbl.Text; } set { stadiumCountLbl.Text=value; } }
        public string View { get { return viewLnk.Links[0].ToString(); } set { viewLnk.Links.Add(0,1000,value); } }
        public CenterCard()
        {
            InitializeComponent();
        }

    }
}
