using ResManaged3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManaged3.App
{
    class PersonalInfoApp
    {
        User user, newuser;
        public PersonalInfoApp(User newuser)
        {
            this.newuser = newuser;
        }

        public string UpdateProfile()
        {
            //Business Logic
            RegData regData = new RegData(newuser);
            return regData.UpdateProfile();
        }
    }
}
