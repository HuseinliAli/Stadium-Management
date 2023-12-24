using Client.Clients;
using Entities.Dtos.Users;
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
    public partial class UserEditModal : Form
    {
        private int _userId;
        private string _email;

        public UserEditModal(int userId, string email)
        {
            InitializeComponent();
            _userId = userId;
            _email = email;
            emailLabel.Text=_email;

        }
        private async Task UserEditModal_Activated(object sender, EventArgs e)
        {
            //  UserEditModal_Load(null, null);
            // await LoadData();
        }

        private void FillFlowLayout(List<OperationClaim> claims)
        {
            var count = 1;
            if (claims.Count>0)
            {
                foreach (var claim in claims)
                {
                    var uc = new UserRoleCard(_userId, _email);
                    uc.Count=$"{count.ToString()}.";
                    uc.RoleName=claim.Name;
                    uc.Id=claim.Id;
                    uc.Visible=true;
                    rolesLytPnl.Controls.Add(uc);
                    count++;
                }
            }

        }

        public void UserEditModal_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public async void LoadData()
        {
            rolesLytPnl.Controls.Clear();
            var client = new UserClient();
            var user = await client.GetRolesById(_userId);
            var claims = await client.GetAllClaims();
            roleBox.DataSource=claims;
            roleBox.ValueMember="Id";
            roleBox.DisplayMember="Name";

            FillFlowLayout(user.Claims);
        }
        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            var client = new UserClient();
            await client.AddRoleTo(new UserOperation()
            {
                UserId=_userId,
                OperationClaimId=int.Parse(roleBox.SelectedValue.ToString())
            });
            LoadData();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void guna2Button1_Click_1(object sender, EventArgs e)
        {
            var form = new UsersPage();
            form.UsersPage_Load(null, null);
           // this.Close();
        }

        private void UserEditModal_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
