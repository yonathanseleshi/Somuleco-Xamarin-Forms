using System;
using SharedDotNetLibrary.DAOs;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace SharedDotNetLibrary.Services
{
    public class AuthService
    {

        HttpClient _client;

        public AuthService()
        {
            _client = new HttpClient();

        }




    }
}
