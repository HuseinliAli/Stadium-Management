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
    public partial class UserDeleteModal : Form
    {
        private UserWithRolesDto _user;
        public UserDeleteModal(UserWithRolesDto user)
        {
            InitializeComponent();
            _user = user;
            fullName.Text=$"{_user.FirstName} {_user.LastName}";
            email.Text=_user.Email;
        }

        private void exit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            var client = new UserClient();
            await client.Remove(_user.UserId);
     
            this.Close();
        }
    }
}
