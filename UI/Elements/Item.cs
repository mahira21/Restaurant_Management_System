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

namespace ResManaged3.UI.Elements
{
    

    public partial class Item : UserControl
    {
        string itemID;
        public string ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        //UserEnd userEnd;
        Image foodPic;
        string title, description, priceTag;
        public Image FoodPic
        {
            get { return foodPic; }
            set
            {
                foodPic = value;
                pbFoodPic.Image = value;
                Invalidate();
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                lblTitle.Text = value;
                Invalidate();
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                lblDescription.Text = value;
                Invalidate();
            }
        }
        public string PriceTag
        {
            get { return priceTag; }
            set
            {
                priceTag = value;
                lblPriceTag.Text = value;
                Invalidate();
            }
        }

        public static Button btnCheckOut;
        public Item()
        {
            InitializeComponent();

        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {

            if (btnCheckOut == null)
            {
                if (this.Parent.Parent.Parent.Parent is UserEnd)
                {
                    UserEnd userEnd = this.Parent.Parent.Parent.Parent as UserEnd;
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
            Console.WriteLine("ll");

            CheckOutApp.AddItem(ItemID, Title, PriceTag);

            

            CountCartItem();

        }

        public static void CountCartItem()
        {
            Console.WriteLine(CheckOutApp.TotalItems());
            btnCheckOut.Text = "( " + CheckOutApp.TotalItems() + " )    Check Out";
            Console.WriteLine(btnCheckOut.Text);
            btnCheckOut.Refresh();
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pnlRight.BackColor = Color.FromArgb(249, 170, 51);
            pnlBottom.BackColor = Color.FromArgb(249, 170, 51);
            pnlLeft.BackColor = Color.FromArgb(249, 170, 51);
            pnlTop.BackColor = Color.FromArgb(249, 170, 51);
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pnlRight.BackColor = Color.FromArgb(241, 241, 241);
            pnlBottom.BackColor = Color.FromArgb(241, 241, 241);
            pnlLeft.BackColor = Color.FromArgb(241, 241, 241);
            pnlTop.BackColor = Color.FromArgb(241, 241, 241);
        }
    }
}
