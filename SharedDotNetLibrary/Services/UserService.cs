using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedDotNetLibrary.Models;


namespace SharedDotNetLibrary.Services
{
    public class UserService
    {

        HttpClient _client;


        public UserService()
        {
            _client = new HttpClient();

        }



        public async Task<User> GetUserDataAsync(string uri)
        {
           User userData = null;
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    userData = JsonConvert.DeserializeObject<User>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return userData;
        }
    }
}
