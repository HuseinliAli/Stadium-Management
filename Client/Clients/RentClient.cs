using Business.Abstract;
using Business.Concrete;
using Business.Messages;
using Client.Utilities.Constants;
using Client.Utilities.FileHelpers;
using Entities.Concrete;
using Entities.Dtos.Centers;
using Entities.Dtos.Rents;
using Framework.Utilities.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Client.Clients
{
    public class RentClient
    {
     
        public async Task<IDataResult<AddOrUpdateRentDto>> Checkout1(AddOrUpdateRentDto dto)
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                dto.UserId=FindId(token);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                var json = JsonConvert.SerializeObject(dto);
                var response = await client.PostAsync($"{RentUrls.Checkout1}", new StringContent(json, Encoding.UTF8, "application/json"));
                var result = await response.Content.ReadAsStringAsync();
                
                if (response.IsSuccessStatusCode)
                {
                    
                    return JsonConvert.DeserializeObject<SuccessDataResult<AddOrUpdateRentDto>>(result);
                }
                return JsonConvert.DeserializeObject<ErrorDataResult<AddOrUpdateRentDto>>(result); 
            }
        }

        public async Task<List<GetDetailRentDto>> GetDetails()
        {
            using (var client= new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                var response = await client.GetAsync($"{RentUrls.GetDetails}");
                int id = FindId(token);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var list = JsonConvert.DeserializeObject<List<GetDetailRentDto>>(result);
                    return list.Where(x=>x.UserId == id).ToList();
                }
                return  new();
            }
        }
        public async Task<IResult> Add(AddOrUpdateRentDto dto)
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                dto.UserId = FindId(token);
                var json = JsonConvert.SerializeObject(dto);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                var response = await client.PostAsync($"{RentUrls.BaseUrl}", new StringContent(json, Encoding.UTF8, "application/json"));
                var result = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<SuccessResult>(result);
                }
                return new ErrorResult(RentResultMessage.AddFailed);
            }
        }

        public async Task<AddOrUpdateRentDto> Checkout2(AddOrUpdateRentDto dto)
        {
            using (var client = new HttpClient())
            {
                var token = TokenFileHelper.ReadTokenFromJsonFile(Urls.TokenFilePath);
                dto.UserId=FindId(token);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer "+ token);
                var json = JsonConvert.SerializeObject(dto);
                var response = await client.PostAsync($"{RentUrls.Checkout2}", new StringContent(json, Encoding.UTF8, "application/json"));
                var result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {

                    return JsonConvert.DeserializeObject<AddOrUpdateRentDto>(result);
                }
                return JsonConvert.DeserializeObject<AddOrUpdateRentDto>(result);
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
