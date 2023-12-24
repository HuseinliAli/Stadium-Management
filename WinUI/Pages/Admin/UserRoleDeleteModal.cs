using Client.Clients;
using Framework.Entities.Users;
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
    public partial class UserRoleDeleteModal : Form
    {
        int _userId;
        string _userName;
        OperationClaim _role;
        public UserRoleDeleteModal(int userId, string userName, OperationClaim role)
        {
            InitializeComponent();
            _userId = userId;
            _userName = userName;
            _role = role;
            userNameLbl.Text=_userName;
            roleNameLbl.Text= _role.Name;
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            var client = new UserClient();
            await client.RemoveUserFromRole(_userId, _role.Id);
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserRoleDeleteModal_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = new UserEditModal(_userId, _userName);
            form.LoadData();
        }

        private void UserRoleDeleteModal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new UserEditModal(_userId, _userName);
            form.LoadData();
        }
    }
}
