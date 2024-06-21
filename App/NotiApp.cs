using ResManaged3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Threading;
using System.Windows.Forms;
//using System.Timers;

namespace ResManaged3.App
{
    class NotiApp
    {
        private NotiData notiData;
        public NotiApp()
        {
            notiData = new NotiData();
        }
        public int GetNotiCount()
        {
            return notiData.GetNotiCount();
        }
    }
}
