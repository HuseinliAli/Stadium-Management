using Framework.Entities.Users;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Client.Utilities.FileHelpers;
using Client.Utilities.Constants;
using Entities.Dtos.Users;
using Newtonsoft.Json;
using Framework.Utilities.Results;
using Entities.Dtos.Centers;
using Framework.Entities;
using System.IO;
using Entities.Dtos.Admin;


namespace Client.Clients
{
    public class UserClient
    {
        public async Task<DashboardDto> AdminDashboard()
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                var response = await client.GetAsync($"{AdminUrls.BaseUrl}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<DashboardDto>(result);
                }
                return new();
            }
        }
        public async Task<List<UserWithRolesDto>> GetAll()
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                var response = await client.GetAsync($"{UserUrls.GetAll}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<UserWithRolesDto>>(result);
                }
                return new List<UserWithRolesDto>();
            }
        }
        public async Task CreateUser(UserForRegisterDto dto)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(dto);
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                await client.PostAsync($"{Urls.Register}", new StringContent(json, Encoding.UTF8, "application/json"));
            }
        }
        public async Task<List<UserWithRolesDto>> GetAll(string searchedByEmail)
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                HttpResponseMessage response;
                if (string.IsNullOrWhiteSpace(searchedByEmail))
                {
                    response = await client.GetAsync(UserUrls.GetAll);
                }
                else
                {
                    string encodedSearchTerm = Uri.EscapeDataString(searchedByEmail);
                    response = await client.GetAsync($"{UserUrls.Filter}contains(email,'{encodedSearchTerm}')");
                }

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<UserWithRolesDto>>(result);
                }
                return new();
            }
        }

      
        public async Task Remove(int id)
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                await client.DeleteAsync($"{UserUrls.BaseUrl}?id={id}");
            }
        }

        public async Task<UserWithRoleWithIdsDto> GetRolesById(int id)
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                var response = await client.GetAsync($"{UserUrls.GetRolesById}{id}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<UserWithRoleWithIdsDto>(result);
                }
                return null;
            }
        }

        public async Task RemoveUserFromRole(int userId, int claimId)
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                await client.DeleteAsync($"{UserUrls.RemoveFromRole}?userId={userId}&claimId={claimId}");
            }
        }
        public async Task AddRoleTo(UserOperation userOperation)
        {
            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(userOperation);
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                await client.PostAsync($"{UserUrls.AddRoleTo}", new StringContent(json, Encoding.UTF8, "application/json"));
            }
        }

        public async Task<List<OperationClaim>> GetAllClaims()
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                var response = await client.GetAsync(UserUrls.GetAllClaims);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<OperationClaim>>(result);
                }
                return new();
            }
        }
    }
}
