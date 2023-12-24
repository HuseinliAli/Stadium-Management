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
    public partial class UserRoleCard : UserControl
    {
        public int Id { get; set; }
        public string Count { get { return countLbl.Text; } set { countLbl.Text=value; } }
        public string RoleName { get { return roleNameLbl.Text; } set { roleNameLbl.Text=value; } }

        private int _userId;
        private string _userName;
        public UserRoleCard(int userId, string userName)
        {
            InitializeComponent();
            _userId = userId;
            _userName = userName;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new UserRoleDeleteModal(_userId, _userName, new Framework.Entities.Users.OperationClaim() { Id=Id, Name=RoleName });
            form.ShowDialog();
        }

     
    }
}
