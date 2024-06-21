using ResManaged3.App;
using ResManaged3.UI.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResManaged3.UI.Containers
{
    public partial class TrackOrder : Form
    {
        OrderApp orderApp;
        User user;
        public TrackOrder()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;


           
        }

        public TrackOrder(User user): this()
        {
            this.user = user;
            ShowPendingOrders();
        }

        async void ShowPendingOrders()
        {
            if (orderApp == null)
            {
                orderApp = new OrderApp(user);
            }
            //PendingItemApp 
            //List<OrderPaletteApp> orderPaletteApps = orderApp.GetOrderPalettes(0);
            Task<List<OrderPaletteApp>> task = new Task<List<OrderPaletteApp>>(orderApp.GetMyOrderPalettes);
            task.Start();

            List<OrderPaletteApp> orderPaletteApps = await task;



            foreach (OrderPaletteApp orderPaletteApp in orderPaletteApps)
            {
                OrderPalette2 orderPalette2 = new OrderPalette2();

                orderPalette2.OrderID = orderPaletteApp.OrderID;
                orderPalette2.Bill = orderPaletteApp.Bill;
                orderPalette2.AddPhn = orderPaletteApp.AddPhn;

                List<Label> labels = new List<Label>();

                foreach (string str in orderPaletteApp.itemnames)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Margin = new Padding(3, 5, 3, 5);
                    label.Padding = new Padding(3, 5, 3, 5);
                    label.BackColor = Color.FromArgb(180, 52, 73, 85);
                    label.ForeColor = Color.White;
                    label.Font = new Font("Open Sans", 9);
                    label.Text = str;
                    labels.Add(label);
                }

                orderPalette2.Items = labels;
                orderPalette2.ParentTab = 2;
                orderPalette2.Status = orderPaletteApp.Status;
                //Control[] controls = orderPalette2.Controls.Find("pnlButtons2", true);
                //controls[0] as Pa

                orderPalette2.Dock = DockStyle.Top;

                panel1.Controls.Add(orderPalette2);

            }
        }

    }
}
