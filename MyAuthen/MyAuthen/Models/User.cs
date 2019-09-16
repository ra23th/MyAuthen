using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAuthen.Models
{
    // Data annotation
    [Table("UserPassword")] //map datle
    class User
    {       
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string username,string password)
        {
            UserName = username;
            Password = password;
        }

        public User()
        {

        }
    }
}
