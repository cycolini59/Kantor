using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantor
{
    internal class Account
    {

        private int id;
        private string name;
        private string password;
        public Account(string name, string password)
        {
            id = Service.Accounts.Count()+1;
            this.name = name;
            this.password = password;
            Service.Accounts.Add(this);
        }
        
        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getPassword()
        {
            return password;
        }

    }
}
