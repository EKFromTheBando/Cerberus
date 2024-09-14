using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cerberus.Cerberus.Helpers
{
    public class IPHelper
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetPublicIPAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://api.ipify.org?format=json");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                return result.ip;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving IP address: " + ex.Message);
                return null;
            }
        }
    }
}
