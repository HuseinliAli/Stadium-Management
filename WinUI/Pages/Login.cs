using Client.Clients;
using Client.Utilities.Constants;
using Client.Utilities.FileHelpers;
using Entities.Dtos.Users;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Pages.Admin;
using WinUI.Pages.Vendor;

namespace WinUI.Pages
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var loginDto = new UserForLoginDto() { Email = emailTxt.Text.ToLower(), Password = passwordTxt.Text };
            var authClient = new AuthClient();
            var token = await authClient.Login(loginDto);

            TokenFileHelper.WriteTokenToJsonFile(Urls.TokenFilePath, token);
            var readedToken = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
            var roles = FindRole(readedToken);
            var username = FindName(readedToken);
            if (roles !=null)
            {
                if(roles.Contains("vendor") && roles.Contains("admin"))
                {
                    var form = new AdminOrVendor(username);
                    form.Show();
                    this.Visible=false;
                }else
                if (roles.Contains("vendor"))
                {
                    var vendorForm = new VendorMain(username);
                    vendorForm.Show();
                    this.Visible=false;
                }
                else if (roles.Contains("admin"))
                {
                    var adminForm = new AdminMain(username);
                    adminForm.Show();
                    this.Visible = false;
                }
            }
        }



        public List<string> FindRole(string token)
        {
            var decodedToken = new JwtSecurityToken(token);
            var roles = decodedToken?.Claims.Where(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").Select(c => c.Value).ToList();
            return roles;
        }

        public string FindName(string token)
        {
            var decodedToken = new JwtSecurityToken(token);
            string name = decodedToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").Value;
            return name;
        }

        private void registerLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Register();
            form.ShowDialog();
        }
    }
}
