using Client.Clients;
using Entities.Concrete;
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
    public partial class AdminMain : Form
    {
        private readonly string _userName;
        public AdminMain(string userName)
        {
            InitializeComponent();
            _userName=userName;
            userFullNameLbl.Text=$"Hi, {_userName}";
        }

        private async void AdminMain_Load(object sender, EventArgs e)
        {
            homePage2.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homePage2.BringToFront();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            usersPage1.BringToFront();
        }

        private void AdminMain_Activated(object sender, EventArgs e)
        {

        }

    
    }
}
