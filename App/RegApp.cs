using ResManaged3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManaged3.App
{
    class RegApp
    {
        User user;
        public RegApp(User usr)
        {
            user = usr;
        }

        public string CreateProfile()
        {
            //Business Logic
            RegData regData = new RegData(user);
            return regData.CreateProfile();
        }
    }
}
