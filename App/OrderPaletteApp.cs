using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManaged3.App
{
    class OrderPaletteApp
    {
        public int OrderID { get; set; }
        public double Bill { get; set; }
        public string AddPhn { get; set; }
        public List<string> itemnames { get; set; }
        public int Status { get; set; }
    }
}
