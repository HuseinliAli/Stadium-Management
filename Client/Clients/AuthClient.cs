using Client.Utilities.Constants;
using Client.Utilities.FileHelpers;
using Entities.Dtos.Users;
using Framework.Entities;
using Framework.Utilities.Security.JWT;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Clients
{
    public class AuthClient
    {
        public async Task<string> Login(UserForLoginDto dto)
        {
            return await Auth(dto, Urls.Login);
        }

        public async Task<string> Register(UserForRegisterDto dto)
        {
            return await Auth(dto, Urls.Register);
        }

        private async Task<string> Auth(IDto dto, string path)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(dto);
                var response = await client.PostAsync(path, new StringContent(json, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    var token = JsonConvert.DeserializeObject<AccessToken>(responseData)?.Token;
                    TokenFileHelper.WriteTokenToJsonFile(Urls.TokenFilePath, token);
                
                    return token;
                }
                return null;
            }
        }


    }
}
