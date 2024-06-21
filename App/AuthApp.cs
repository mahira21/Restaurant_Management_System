using ResManaged3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManaged3.App
{
    class AuthApp
    {
        string username, password;
        public AuthApp(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User GetProfile()
        {
            AuthData authData = new AuthData(username, password);
            return authData.GetProfile();
        }
    }
}
