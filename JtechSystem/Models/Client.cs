using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JtechSystem.Models
{
    public class Client : User
    {
        public Company Company { get; set; }

        public Client(Company company, int id, string name, string login, string password) : base(id, name, login, password)
        {
            Company = company;
        }
    }
}
