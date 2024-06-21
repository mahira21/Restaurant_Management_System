using ResManaged3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManaged3.App
{
    class OrderApp
    {
        

        User user;
        public OrderApp()
        {

        }

        public OrderApp(User user) //: this ()
        {
            this.user = user;
        }
        public List<OrderPaletteApp> GetPendingOrderPalettes()
        {
            Order order = new Order();
            List<OrderPaletteApp> orderPaletteApps = order.GetOrderPalettes("select * from orderTable where status = 0");
            
            orderPaletteApps.Reverse();


            return orderPaletteApps;
        }
        public List<OrderPaletteApp> GetTakenOrderPalettes()
        {
            Order order = new Order();
            List<OrderPaletteApp> orderPaletteApps = order.GetOrderPalettes("select * from orderTable where status = 1");

            orderPaletteApps.Reverse();


            return orderPaletteApps;
        }
        public List<OrderPaletteApp> GetMyOrderPalettes()
        {
            Order order = new Order();
            List<OrderPaletteApp> orderPaletteApps = order.GetOrderPalettes("select * from orderTable where ( status = 0 or status = 1 ) and userID = '"+user.UserName+"'");

            orderPaletteApps.Reverse();


            return orderPaletteApps;
        }
        public List<OrderPaletteApp> GetMyAllOrderPalettes()
        {
            Order order = new Order();
            List<OrderPaletteApp> orderPaletteApps = order.GetOrderPalettes("select * from orderTable where userID = '" + user.UserName + "'");

            orderPaletteApps.Reverse();


            return orderPaletteApps;
        }
    }
}
