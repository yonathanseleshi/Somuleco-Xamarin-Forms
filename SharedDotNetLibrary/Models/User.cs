using System;
using SQLite;


namespace SharedDotNetLibrary.Models
{
    public class User
    {


        [PrimaryKey]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

    }
}
