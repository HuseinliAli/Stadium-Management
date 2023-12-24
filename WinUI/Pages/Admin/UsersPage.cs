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
    public partial class UsersPage : UserControl
    {
        private List<UserWithRolesDto> _users = new();
        public UsersPage()
        {
            InitializeComponent();

        }

        public async void UsersPage_Load(object sender, EventArgs e)
        {
            var userClient = new UserClient();
            _users = await userClient.GetAll();
            FillFlowLayout(_users);
            FillComboBox(await userClient.GetAllClaims());
        }
        private void FillComboBox(List<OperationClaim> claims)
        {
            claims.Insert(0, new OperationClaim() { Name="All" });
            claimsCombobx.DataSource = claims;
            claimsCombobx.ValueMember="Id";
            claimsCombobx.DisplayMember="Name";
        }
        private void FillFlowLayout(List<UserWithRolesDto> users)
        {
            userLytPnl.Controls.Clear();
            int count = 1;
            foreach (var user in users)
            {
                var uc = new UserCard();
                uc.Id=user.UserId;
                uc.Count=count.ToString();
                uc.FirstName=user.FirstName;
                uc.LastName=user.LastName;
                uc.Email=user.Email;
                if (user.RoleNames.Count>0)
                {
                    uc.Roles=user.RoleNames;
                }
                count++;
                uc.Visible=true;
                userLytPnl.Controls.Add(uc);
            }

        }

        private async void searchTxt_TextChanged(object sender, EventArgs e)
        {
            var userClient = new UserClient();
            _users = await userClient.GetAll(searchTxt.Text);
            FillFlowLayout(_users);
        }

        private async void claimsCombobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedClaim = ((OperationClaim)claimsCombobx.SelectedItem).Name;
            List<UserWithRolesDto> users = new();
            if (selectedClaim !="All")
            {
                users = _users.Where(x => x.RoleNames.Contains(selectedClaim)).ToList();
                FillFlowLayout(users);
            }
            else
            {
                FillFlowLayout(_users);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            UsersPage_Load(null, null);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var form = new CreateUserModal();
            form.ShowDialog();
        }
    }
}
