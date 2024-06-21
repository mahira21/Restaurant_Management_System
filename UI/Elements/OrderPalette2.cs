using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResManaged3.UI.Elements
{
    public partial class OrderPalette2 : UserControl
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";

        public OrderPalette2()
        {
            InitializeComponent();
        }

        public int OrderID
        {
            get
            {
                return Convert.ToInt32(lblOrderID.Text);
            }
            set
            {
                lblOrderID.Text = value.ToString();
            }
        }

        public double Bill
        {
            get
            {
                return Convert.ToDouble(lblBill.Text);
            }
            set
            {
                lblBill.Text = value.ToString();
            }
        }

        public List<Label> Items
        {
            set
            {
                
                foreach (Label label in value)
                {
                    flowLayoutPanel1.Controls.Add(label);
                }

            }
        }



        public string AddPhn
        {
            get { return lblAddPhn.Text; }
            set { lblAddPhn.Text = value; }
        }

        

        public int ParentTab
        {
            set
            {
                if(value == 0)
                {
                    pnlButtons2.Visible = false;
                    //Invalidate();
                }
                else if(value == 1)
                {
                    pnlButtons.Visible = false;
                }
                else
                {
                    pnlButtons.Controls.Clear();
                    pnlButtons2.Controls.Clear();
                    
                    
                }
            }
        }

        public int Status
        {
            set 
            {
                if (value == 0)
                {
                    Label label = new Label() { Dock = DockStyle.Fill };
                    label.Text = "Order Placed";
                    label.BackColor = Color.White;
                    label.ForeColor = Color.Black;
                    label.Font = new Font("Open Sans", 11);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    pnlButtons2.Controls.Add(label);

                    Label label2 = new Label() { Dock = DockStyle.Fill };
                    label2.Text = "Your order will be reviewed soon!";
                    label2.BackColor = Color.White;
                    label2.ForeColor = Color.FromArgb(87, 89, 91);
                    label2.Font = new Font("Open Sans", 9);
                    label2.TextAlign = ContentAlignment.MiddleCenter;
                    pnlButtons.Controls.Add(label2);
                }
                else if (value == 1)
                {
                    Label label = new Label() { Dock = DockStyle.Fill };
                    label.Text = "Order Accespted";
                    label.BackColor = Color.White;
                    label.ForeColor = Color.FromArgb(76, 175, 80);
                    label.Font = new Font("Open Sans", 11);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    pnlButtons2.Controls.Add(label);

                    Label label2 = new Label() { Dock = DockStyle.Fill };
                    label2.Text = "We are preparing your order!";
                    label2.BackColor = Color.White;
                    label2.ForeColor = Color.FromArgb(87, 89, 91);
                    label2.Font = new Font("Open Sans", 9);
                    label2.TextAlign = ContentAlignment.MiddleCenter;
                    pnlButtons.Controls.Add(label2);
                }
                else if (value == 2)
                {
                    Label label = new Label() { Dock = DockStyle.Fill };
                    label.Text = "Order Cancelled";
                    label.BackColor = Color.White;
                    label.ForeColor = Color.FromArgb(253, 85, 35);
                    label.Font = new Font("Open Sans", 11);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    pnlButtons2.Controls.Add(label);

                    Label label2 = new Label() { Dock = DockStyle.Fill };
                    label2.Text = "Sorry we had to cancel your order!";
                    label2.BackColor = Color.White;
                    label2.ForeColor = Color.FromArgb(87, 89, 91);
                    label2.Font = new Font("Open Sans", 9);
                    label2.TextAlign = ContentAlignment.MiddleCenter;
                    pnlButtons.Controls.Add(label2);
                }
                else if(value == 3)
                {
                    Label label = new Label() { Dock = DockStyle.Fill };
                    label.Text = "Order Delivered";
                    label.BackColor = Color.White;
                    label.ForeColor = Color.FromArgb(60, 158, 251);
                    label.Font = new Font("Open Sans", 11);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    pnlButtons2.Controls.Add(label);

                    Label label2 = new Label() { Dock = DockStyle.Fill };
                    label2.Text = "Your order will be delivered soon!";
                    label2.BackColor = Color.White;
                    label2.ForeColor = Color.FromArgb(87, 89, 91);
                    label2.Font = new Font("Open Sans", 9);
                    label2.TextAlign = ContentAlignment.MiddleCenter;
                    pnlButtons.Controls.Add(label2);
                }
            }
        }


        public void Update(int status)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update orderTable set status = @status where orderID = @orderID;", con);

                cmd.CommandType = CommandType.Text;


                //cmd.Parameters.AddWithValue("@BorrowerID", textBox1.Text);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@orderID", OrderID);



                cmd.ExecuteNonQuery();
                con.Close();

            }
        }



        private void btnDeliver_Click(object sender, EventArgs e)
        {
            Update(3);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Update(4);
            this.Dispose();
        }

        private void btnAccept_Click_2(object sender, EventArgs e)
        {
            Update(1);
            this.Dispose();
        }

        private void btnReject_Click_2(object sender, EventArgs e)
        {
            Update(2);
            this.Dispose();
        }
    }
}
