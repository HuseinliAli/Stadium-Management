using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Client.Utilities.Constants
{
    public static class Urls
    {
        public static string APIBaseAddress= "https://localhost:7173/api";
        public static string TokenFilePath = "user.txt";
        public static string Register = $"{APIBaseAddress}/auth/register";
        public static string Login = $"{APIBaseAddress}/auth/login";
    }
    public static class AdminUrls
    {
        public static string BaseUrl = $"{Urls.APIBaseAddress}/admin";
    }
    public static class StadiumUrls
    {
        public static string BaseUrl = $"{Urls.APIBaseAddress}/stadiums";
        public static string ByUser = $"{BaseUrl}/byuser?id=";
    }
    public static class CenterUrls
    {
        public static string BaseUrl = $"{Urls.APIBaseAddress}/centers";
        public static string Filter = $"{BaseUrl}?$filter=";
        public static string ByUser = $"{BaseUrl}/byuser?id=";
      
    }
    public static class RentUrls
    {
        public static string BaseUrl = $"{Urls.APIBaseAddress}/rents";
        public static string Checkout1 = $"{BaseUrl}/checkout1";
        public static string Checkout2 = $"{BaseUrl}/checkout2";
        public static string GetDetails = $"{BaseUrl}/getdetails";
    }
    public static class UserUrls
    {
        public static string BaseUrl = $"{Urls.APIBaseAddress}/users";
        public static string GetAll = $"{UserUrls.BaseUrl}/getall";
        public static string GetRolesById = $"{UserUrls.BaseUrl}/getrolesbyid?id=";
        public static string RemoveFromRole = $"{BaseUrl}/removefromrole";
        public static string AddRoleTo = $"{UserUrls.BaseUrl}/addroleto";
        public static string GetAllClaims = $"{BaseUrl}/getallclaims";
        public static string Filter = $"{GetAll}?$filter=";
    }
}
