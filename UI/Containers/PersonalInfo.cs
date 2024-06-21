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

    public partial class PersonalInfo : Form
    {
        User user;
        UserEnd userEnd;
        Dashboard dashboard;
        public PersonalInfo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }
        public PersonalInfo(User user, UserEnd userEnd) : this()
        {
            this.user = user;
            this.userEnd = userEnd;
            InitiateInfo();
        }
        public PersonalInfo(User user, Dashboard dashboard) : this()
        {
            this.user = user;
            this.dashboard = dashboard;
            InitiateInfo();
        }
        public void InitiateInfo()
        {
            tbUserName.Text = user.UserName;
            tbName.Text = user.Name;
            dateTimePicker1.Value = user.Date;
            if (user.Gender.Equals(1))
                rbM.Checked = true;
            else if (user.Gender.Equals(2))
                rbF.Checked = true;
            else if (user.Gender.Equals(3))
                rbO.Checked = true;
            tbEmail.Text = user.Email;
            tbMobile.Text = user.Mobile;
            tbAddress.Text = user.Address;
            tbPassword.Text = user.Password;
        }




        private void TbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '\0';
        }

        private void BtnCancelChanges_Click(object sender, EventArgs e)
        {
            InitiateInfo();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                User newuser = new User();
                newuser.UserName = tbUserName.Text.Trim();
                newuser.Name = tbName.Text.Trim();
                newuser.Date = dateTimePicker1.Value;
                newuser.Gender = GetGender();
                newuser.Email = tbEmail.Text.Trim();
                newuser.Mobile = tbMobile.Text.Trim();
                newuser.Address = tbAddress.Text.Trim();
                newuser.Password = tbPassword.Text.Trim();
                newuser.UserType = 0;
                PersonalInfoApp personalInfoApp = new PersonalInfoApp(newuser);
                string msg = personalInfoApp.UpdateProfile();
                UpdateUserObject(newuser);
                Console.WriteLine("aft "+user.Name);
                if(userEnd!=null)
                    userEnd.UpdateName();
                if (dashboard != null)
                    dashboard.UpdateName();
                ShowMessage(msg);

                
            }
            else
            {
                return;
            }
        }

        private void UpdateUserObject(User newuser)
        {
            user.UserName=newuser.UserName;
            user.Name=newuser.Name;
            user.Date=newuser.Date;
            user.Gender=newuser.Gender;
            user.Email=newuser.Email;
            user.Mobile = newuser.Mobile;
            user.Address = newuser.Address;
            user.Password = newuser.Password;
            user.UserType = newuser.UserType;
        }

        private bool Valid()
        {
            if (tbUserName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Username can not be empty", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (tbName.Text.Equals(string.Empty))
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
            if (tbPassword.Text.Equals(string.Empty))
            {
                MessageBox.Show("Password can not be empty", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //if (!dtpUsed)
            //{
            //    MessageBox.Show("Date of birth have to be selected", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            if (rbF.Checked == false && rbM.Checked == false && rbO.Checked == false)
            {
                MessageBox.Show("Gender have to be selected", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void ShowMessage(string msg)
        {
            if (msg.Equals("Profile Updated Successfully"))
            {
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(msg, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
