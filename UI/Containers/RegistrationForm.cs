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

namespace ResManaged3.UI.Containers
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

        }

        public bool RoleVisible
        {
            set
            {
                if(value==true)
                {
                    panel41.Visible = true;
                    btnBack.Text = "Clear Changes";
                    Invalidate();
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent is Landing)
            {
                Console.WriteLine("ok");
                Landing landing = this.Parent.Parent as Landing;
                landing.Contain(landing.GetLoginForm());
            }
            else
            {
                ResetSubmission();
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if(Valid())
            {
                User user = new User();
                user.UserName = tbUserName.Text.Trim();
                user.Name = tbName.Text.Trim();
                user.Date = dateTimePicker1.Value;
                user.Gender = GetGender();
                user.Email = tbEmail.Text.Trim();
                user.Mobile = tbMobile.Text.Trim();
                user.Address = tbAddress.Text.Trim();
                user.Password = tbPassword.Text.Trim();
                user.UserType = GetUserType();
                RegApp regApp = new RegApp(user);
                string msg = regApp.CreateProfile();
                ShowMessage(msg);
                //ResetSubmission();
                //BtnBack_Click(btnBack, new EventArgs());
            }
            else
            {
                return;
            }
        }

        private bool Valid()
        {
            if(tbUserName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Username can not be empty", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(tbName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Name can not be empty", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (tbAddress.Text.Equals(string.Empty))
            {
                MessageBox.Show("Address can not be empty", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (tbMobile.Text.Equals(string.Empty))
            {
                MessageBox.Show("Mobile Number can not be empty", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (tbEmail.Text.Equals(string.Empty))
            {
                MessageBox.Show("Email can not be empty", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(tbPassword.Text.Equals(string.Empty))
            {
                MessageBox.Show("Password can not be empty", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!dtpUsed)
            {
                MessageBox.Show("Date of birth have to be selected", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(rbF.Checked==false && rbM.Checked == false && rbO.Checked == false)
            {
                MessageBox.Show("Gender have to be selected", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rbManager.Checked == false && rbCook.Checked == false && rbUser.Checked == false)
            {
                MessageBox.Show("User Type have to be selected", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private int GetGender()
        {
            if (rbM.Checked)
                return 1;
            else if (rbF.Checked)
                return 2;
            else if (rbO.Checked)
                return 3;
            else
                return 0;
        }
        private int GetUserType()
        {
            if (rbManager.Checked)
                return 1;
            else if (rbCook.Checked)
                return 2;
            else if (rbUser.Checked)
                return 0;
            else
                return 0;
        }

        private bool dtpUsed = false;
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpUsed = true;
        }

        private void ShowMessage(string msg)
        {
            if(msg.Equals("Profile Created Successfully"))
            {
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ResetSubmission();
                BtnBack_Click(btnBack, new EventArgs());
            }
            else if(msg.Equals("Username is not available"))
            {
                MessageBox.Show(msg, "Opps!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(msg, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetSubmission()
        {
            tbUserName.ResetText();
            tbName.ResetText();
            dateTimePicker1.ResetText();
            rbF.Checked = false; rbO.Checked = false; rbM.Checked = false;
            tbEmail.ResetText();
            tbMobile.ResetText();
            tbAddress.ResetText();
            tbPassword.ResetText();
            rbManager.Checked = false; rbCook.Checked = false; rbUser.Checked = false;
        }
    }
}
