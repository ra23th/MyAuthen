using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAuthen.Models
{
    // Data annotation
    [Table("UserPassword")] //map datle
    public class User
    {       
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [Ignore]
        public String BackgroundColor
            //เปลี่ยนสี
        {
            get
            {
                if(id % 2 == 0)
                {
                    return "#f3f5f4";
                }
                return "#ffffff";
            }
        }

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
