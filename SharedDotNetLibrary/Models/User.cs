using System;
using SQLite;
using Newtonsoft.Json;


namespace SharedDotNetLibrary.Models
{
    public class User
    {


        [PrimaryKey]
        [JsonProperty("user_id")]
        public int ID { get; set; }

        [JsonProperty("fname")]
        public string FirstName { get; set; }

        [JsonProperty("lname")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }


        public User()
        {


        }
    }
}
