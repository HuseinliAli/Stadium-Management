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
    public partial class StadiumCard : UserControl
    {
        public int Id { get; set; }
        public string Count { get { return countLbl.Text; } set { countLbl.Text=value; } }
        public string HallName { get { return nameLbl.Text; } set { nameLbl.Text=value; } }
        public string Morning { get { return morningLbl.Text; } set { morningLbl.Text=value; } }
        public string Afternoon { get { return afternoon.Text; } set { afternoon.Text=value; } }
        public string Evening { get { return evening.Text; } set { evening.Text=value; } }

        public StadiumCard()
        {
            InitializeComponent();
        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
