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

namespace WinUI.Pages.Admin
{
    public partial class CreateUserModal : Form
    {
        public CreateUserModal()
        {
            InitializeComponent();
        }

        private async void createUserBtn_Click(object sender, EventArgs e)
        {  
            var user = new UserForRegisterDto()
            {
                Email=emailTxt.Text,
                Password=passwordTxt.Text,
                FirstName=nameTxt.Text,
                LastName=surnameTxt.Text,
            };
            var client = new UserClient();
            await client.CreateUser(user);
            this.Close();
        }
    }
}
