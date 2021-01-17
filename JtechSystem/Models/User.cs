using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtechSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string login, string password)
        {
            Id = id;
            Name = name;
            Login = login;
            Password = password;
        }
    }
}
