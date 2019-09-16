using MyAuthen.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAuthen.Helpers
{
    class DatabaseAdapter
    {
        private SQLiteConnection Conn { get; }
        public DatabaseAdapter(string dabasePath)
        {
            //คอนเซ็บ DI
            Conn = new SQLiteConnection(dabasePath);
        }
        public List<User> GetUsers()
        {
            //SQl command mapping
            var result = Conn.Query<User>("select * from UserPassword");
            return result;
        }

        public User GetUser(string username)
        {
            //SQl command mapping
            var result = Conn.Query<User>("select * from UserPassword where Username = ?",new String[] { username}).SingleOrDefault();
            return result;
        }
        public int AddUser(User user)
        {
            var count = Conn.Insert(user);
            return count;
        }

        public int EditUser(User user)
        {
            var data = GetUser(user.UserName);
            if(data == null)
            {
                return 0;
            }

            data.Password = user.Password;
            var count = Conn.Update(data);
            return count;
        }

        public void DeleteUser()
        {
            Conn.DeleteAll<User>();
        }

    }
}
