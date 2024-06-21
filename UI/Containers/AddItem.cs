using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResManaged3.App;
using ResManaged3.Data;
using ResManaged3.UI.Elements;

namespace ResManaged3.UI.Containers
{
    public partial class AddItem : Form
    {
        Dashboard dashboard;
        string imageloc = "";

        public AddItem()
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

        public AddItem(Dashboard dashboard):this()
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
            lblTitle.Text = tbTitle.Text;
        }

        private void TbDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescription.Text = tbDescription.Text;
        }

        private void TbPriceTag_TextChanged(object sender, EventArgs e)
        {
            lblPriceTag.Text = tbPriceTag.Text;
        }

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

            }


        }

        private void BtnConfirmItem_Click(object sender, EventArgs e)
        {
            if(true)
            {
                ItemClass itemClass = new ItemClass();
                itemClass.Title = tbTitle.Text;
                itemClass.Description = tbDescription.Text;
                itemClass.Price = Convert.ToDouble(tbPriceTag.Text);
                itemClass.ImageLoc = imageloc;

                ItemData itemData = new ItemData(itemClass);
                string msg = itemData.AddItem();
                ShowMessage(msg);
                ResetSubmission();
            }
        }

        private void ShowMessage(string msg)
        {
            if (msg.Equals("Item added Successfully"))
            {
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(msg, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetSubmission()
        {
            tbDescription.ResetText();
            tbTitle.ResetText();
            tbPriceTag.ResetText();

            lblDescription.Text = "Description goes here";
            lblTitle.Text = "Title goes here";
            lblPriceTag.Text = "Price";
            pbFoodPic.Image = null;
            imageloc = "";
        }

        private void BtnCancelChanges_Click(object sender, EventArgs e)
        {
            ResetSubmission();
        }
    }
}
