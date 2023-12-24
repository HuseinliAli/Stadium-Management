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
    public partial class UserCard : UserControl
    {
        public string Count { get { return countLbl.Text; } set { countLbl.Text=value; } }
        public int Id { get; set; }
        public string FirstName { get { return firtsNameLbl.Text; } set { firtsNameLbl.Text=value; } }
        public string LastName { get { return lastNameLbl.Text; } set { lastNameLbl.Text=value; } }
        public string Email { get { return emailLbl.Text; } set { emailLbl.Text=value; } }
        public List<string> Roles
        {
            get { return roleBox.DataSource as List<string>; }
            set { roleBox.DataSource = value; }
        }
        public UserCard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new UserDeleteModal(new UserWithRolesDto() { Email=Email, UserId= Id, FirstName=FirstName, LastName=LastName });
            form.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var form = new UserEditModal( Id, Email);
            form.ShowDialog();
        }
    }
}
