using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResManaged3.App;
using ResManaged3.Data;
using ResManaged3.UI.Elements;

namespace ResManaged3.UI.Containers
{
    public partial class ModifyItem : Form
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";

        Dashboard dashboard;
        string imageloc = "";
        byte[] xByte;
        public ModifyItem()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            //Item item = new Item();
            //item.Location(482, 115);
            //item.Location = new Point(482, 115);
            //item.Enabled = false;
            //this.Controls.Add(item);

        }

        public ModifyItem(Dashboard dashboard):this()
        {
            this.dashboard = dashboard;
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            pnlRight.BackColor = Color.FromArgb(249, 170, 51);
            pnlBottom.BackColor = Color.FromArgb(249, 170, 51);
            pnlLeft.BackColor = Color.FromArgb(249, 170, 51);
            pnlTop.BackColor = Color.FromArgb(249, 170, 51);
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            pnlRight.BackColor = Color.FromArgb(241, 241, 241);
            pnlBottom.BackColor = Color.FromArgb(241, 241, 241);
            pnlLeft.BackColor = Color.FromArgb(241, 241, 241);
            pnlTop.BackColor = Color.FromArgb(241, 241, 241);
        }

        private void TbTitle_TextChanged(object sender, EventArgs e)
        {
            lblTitle.Text = tbItemCode.Text;
        }

        private void TbDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescription.Text = tbDescription.Text;
        }

        private void TbPriceTag_TextChanged(object sender, EventArgs e)
        {
            lblPriceTag.Text = tbPriceTag.Text;
        }

        bool img = false;

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //pbFoodPic.ImageLocation = open.FileName;
                imageloc = open.FileName;
            }
            if(imageloc!=string.Empty)
            {
                pbFoodPic.ImageLocation = imageloc;

                img = true;

            }


        }

        private void BtnUpdateItem_Click(object sender, EventArgs e)
        {
            if(true)
            {

                if (img == true)
                {
                    Bitmap bmp = new Bitmap(imageloc);
                    FileStream fs = new FileStream(imageloc, FileMode.Open, FileAccess.Read);
                    xByte = new byte[fs.Length];
                    fs.Read(xByte, 0, Convert.ToInt32(fs.Length));
                    fs.Close();
                }


                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update itemTable set image = @image, title = @title, description = @description, price = @price where itemcode = @itemcode", con);

                    cmd.CommandType = CommandType.Text;


                    cmd.Parameters.AddWithValue("@itemcode", Convert.ToInt32(tbItemCode.Text));

                    cmd.Parameters.AddWithValue("@image", xByte);
                    cmd.Parameters.AddWithValue("@title", tbTitle.Text);
                    cmd.Parameters.AddWithValue("@description", tbDescription.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDouble(tbPriceTag.Text.Trim()));

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Item Updated successfully", "updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ResetSubmission();
                }
            }
        }

        

        private void ResetSubmission()
        {
            tbItemCode.ResetText();
            tbTitle.ResetText();
            tbDescription.ResetText();
            tbItemCode.ResetText();
            tbPriceTag.ResetText();

            lblDescription.Text = "Description goes here";
            lblTitle.Text = "Title goes here";
            lblPriceTag.Text = "Price";
            pbFoodPic.Image = null;
            imageloc = "";
            xByte = null;
        }

        private void BtnCancelChanges_Click(object sender, EventArgs e)
        {

            ResetSubmission();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from itemTable where itemcode = @itemcode", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@itemcode", tbItemCode.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    //lbItemCode = Convert.ToInt32(reader[0]);

                    byte[] myImage = new byte[0];
                    myImage = (byte[])reader[1];
                    MemoryStream stream = new MemoryStream(myImage);
                    pbFoodPic.Image = Image.FromStream(stream);

                    ImageConverter imageConverter = new ImageConverter();
                    xByte = (byte[])imageConverter.ConvertTo(pbFoodPic.Image, typeof(byte[]));

                    lblTitle.Text = tbTitle.Text = reader[2].ToString();
                    lblDescription.Text = tbDescription.Text = reader[3].ToString();
                    lblPriceTag.Text =tbPriceTag.Text = reader[4].ToString();
                }

                reader.Close();
                con.Close();

            }
        }

        private void RemoveItem_Load(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(tbItemCode.Text!=string.Empty)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from itemTable where itemcode = @itemcode", con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@itemcode", tbItemCode.Text);


                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Item Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    ResetSubmission();


                }
            }
        }
    }
}
