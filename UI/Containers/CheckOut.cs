using ResManaged3.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResManaged3.UI.Elements;

namespace ResManaged3.UI.Containers
{
    public partial class CheckOut : Form
    {
        public static double TotalPrice = 0;
        public static Label lblTotalPrice;

        public static upd Upd;
        public static ClearCartDel clearCartDel;

        private User user;
        private UserEnd userEnd;

        public CheckOut()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            lblTotalPrice = lblPriceTotal;
            //CheckOutApp.Calculate(panel3);

            PopulateCart();


            Upd = this.UpdateTotalPrice;

            Upd.Invoke();

            clearCartDel = ClearCart;

        }
        public CheckOut(User user, UserEnd userEnd):this()
        {
            this.user = user;
            this.userEnd = userEnd;
        }

        private void PopulateCart()
        {
            
            foreach (CartItemApp i in CheckOutApp.itemApps)
            {
                CartItem cartItem = new CartItem();
                cartItem.Code = i.ItemCode;
                cartItem.ItemName = i.ItemName;
                cartItem.Quantity = i.Quantity;
                cartItem.PriceEach = i.PriceTag;
                cartItem.PriceTotal = i.PriceTag * i.Quantity;
                cartItem.Dock = DockStyle.Top;

                panel3.Controls.Add(cartItem);

                TotalPrice = TotalPrice + cartItem.PriceTotal;

                lblPriceTotal.Text = "" + TotalPrice;
            }
        }

        public delegate void ClearCartDel();
        public void ClearCart()
        {
            BtnClearCart_Click(btnClearCart, new EventArgs());
        }
        private void BtnClearCart_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ccc");
            panel3.Controls.Clear();

            CheckOutApp.itemApps.Clear();

            UpdateCartButton();
            UpdateTotalPrice();


        }

        public delegate void upd();

        

        public void UpdateTotalPrice()
        {
            TotalPrice = CheckOutApp.CalculateTotalPrice();
            lblPriceTotal.Text = CheckOutApp.CalculateTotalPrice().ToString();
            //MessageBox.Show(CheckOutApp.CalculateTotalPrice().ToString());
            this.Refresh();
        }


        static Button btnCheckOut;
        public  void UpdateCartButton()
        {
            if (btnCheckOut == null)
            {
                if (this.Parent.Parent is UserEnd)
                {
                    UserEnd userEnd = this.Parent.Parent as UserEnd;
                    Control[] controls = userEnd.Controls.Find("btnCheckOut", true);// as Button;
                    if (controls.Length > 0)
                    {
                        if (controls[0] is Button)
                        {
                            btnCheckOut = controls[0] as Button;
                        }
                    }
                }
            }

            btnCheckOut.Text = "( " + CheckOutApp.TotalItems() + " )    Check Out";
        }


        private void BtnConfirmOrder_Click(object sender, EventArgs e)
        {
            
            CheckOutApp.PlaceOrder(user);
            BtnClearCart_Click(btnClearCart, new EventArgs());
            userEnd.BtnAllItemsInvoke();
        }
    }
}
