using Business.Messages;
using Client.Utilities.Constants;
using Client.Utilities.FileHelpers;
using Entities.Concrete;
using Entities.Dtos.Centers;
using Entities.Dtos.Stadiums;
using Framework.Utilities.Results;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Clients
{
    public class CenterClient
    {
        public async Task<List<CenterDetailDto>> GetCenters()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{CenterUrls.BaseUrl}");

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<CenterDetailDto>>(result);
                }
                return new();
            }
        }

        public async Task<List<Center>> GetCentersByUserId()
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                var response = await client.GetAsync($"{CenterUrls.ByUser}{FindId(token)}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Center>>(result);
                }
                return new();
            }
        }

        public async Task<IResult> AddCenter(AddOrUpdateCenterDto dto)
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                dto.UserId = FindId(token);
                var json = JsonConvert.SerializeObject(dto);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                var response = await client.PostAsync($"{CenterUrls.BaseUrl}", new StringContent(json, Encoding.UTF8, "application/json"));
                var result = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<SuccessResult>(result);
                }
                return new ErrorResult(CenterResultMessage.AddFailed);
            }
        }
        public async Task<List<CenterDetailDto>> GetCenters(string searchByName)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response;
                if (string.IsNullOrWhiteSpace(searchByName))
                {
                    response = await client.GetAsync(CenterUrls.BaseUrl);
                }
                else
                {
                    string encodedSearchTerm = Uri.EscapeDataString(searchByName);
                    response = await client.GetAsync($"{CenterUrls.Filter}contains(name,'{encodedSearchTerm}')");
                }

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<CenterDetailDto>>(result);
                }
                return new();
            }
        }
        private int FindId(string token)
        {
            var decodedToken = new JwtSecurityToken(token);
            string nameIdentifier = decodedToken?.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            return int.Parse(nameIdentifier);
        }


    }
}
