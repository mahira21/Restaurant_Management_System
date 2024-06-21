using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResManaged3.App;
using ResManaged3.UI.Containers;

namespace ResManaged3.UI.Elements
{
    public partial class CartItem : UserControl
    {
        string code, name;
        int quantity;
        double priceEach, priceTotal;

        public string Code
        {
            get { return code; }
            set
            {
                code = value;
                lblCode.Text = value;
                Invalidate();
            }
        }
        public string ItemName
        {
            get { return name; }
            set
            {
                name = value;
                lblItemName.Text = value;
                Invalidate();
            }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                lblQuantity.Text = ""+quantity;
                Invalidate();
            }
        }
        public double PriceEach
        {
            get { return priceEach; }
            set
            {
                priceEach = value;
                lblPriceEach.Text = ""+value;
                Invalidate();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            CheckOutApp.RemoveItem(this.Code);
            Item.CountCartItem();
            CheckOut.Upd.Invoke();
        }

        public double PriceTotal
        {
            get { return priceTotal; }
            set
            {
                priceTotal = value;
                lblPriceTotal.Text = "" + value;
                Invalidate();
            }
        }
        public CartItem()
        {
            InitializeComponent();
        }
    }
}
