using Client.Clients;
using Entities.Dtos.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.Pages
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Login();
            form.Show();
            this.Visible=false;
        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            var dto = new UserForRegisterDto()
            {
                FirstName = nameTxt.Text,
                LastName=surnameTxt.Text,
                Email=emailTxt.Text.ToLower(),
                Password=passwordTxt.Text
            };
            var client = new AuthClient();
            await client.Register(dto);
            this.Close();
        }
    }
}
