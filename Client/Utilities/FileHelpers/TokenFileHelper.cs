using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Utilities.FileHelpers
{
    public static class TokenFileHelper
    {
        public static void WriteTokenToJsonFile(string filePath, string token)
        {
            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            File.WriteAllText(filePath, token);
        }

        public static string ReadTokenFromJsonFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return null;
            }
            return File.ReadAllText(filePath);
        }
    }
}
