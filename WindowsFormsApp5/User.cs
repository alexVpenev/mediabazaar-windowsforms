using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class User
    {
        private string username;
        private string password;
        private ACCESS access;

        public string Username { get { return this.username; } private set { Username = value; } }
        public string Password { get { return this.password; } private set { Password = value; } }
        public ACCESS Access { get { return this.access; } private set { Access = value; } }

        public User(string username, string password, ACCESS access)
        {
            this.username = username;
            this.password = password;
            this.access = access;
        }
    }
}
