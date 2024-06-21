using ResManaged3.App;
using ResManaged3.UI.Elements;

using ResManaged3.UI.Containers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ResManaged3.UI
{
    public partial class Dashboard : Form
    {

        private User user, trouser;
        private AddItem addItem;
        private PendingOrders pendingOrders;
        private ModifyItem removeItem;
        private MenuAllItems menuAllItems;
        private ShowAllItem showAllItem;
        private PersonalInfo personalInfo;
        private NotiApp notiApp;
        SoundPlayer sound = new SoundPlayer(@"C:\Users\Siam\Downloads\notisound.wav");



        public Dashboard()
        {
            InitializeComponent();

            ShowDropDown(pnlManageOrdersDD);
            //BtnAddItems_Click(btnAddItems, new EventArgs());
            BtnPendingOrders_Click(btnAddItems, new EventArgs());

        }

        public Dashboard(User user) : this()
        {
            this.user = user;
            lblNameOfUser.Text = user.Name;

            timer1.Interval = 5000;

            timer1.Start();
        }
        public void UpdateName()
        {
            Console.WriteLine(this.user.Name);
            lblNameOfUser.Text = this.user.Name;
        }

        public void ShowDropDown(Panel pnlDD)
        {
            if (pnlDD.Visible == false)
            {
                HideDropDown();
                pnlDD.Visible = true;
            }
            else
            {
                pnlDD.Visible = false;
            }
        }

        private void BtnManageEmployees_Click(object sender, EventArgs e)
        {
            ShowDropDown(pnlManageEmployeesDD);
        }

        private void BtnManageMenu_Click(object sender, EventArgs e)
        {
            ShowDropDown(pnlManageMenuDD);
        }

        private void BtnManageOrders_Click(object sender, EventArgs e)
        {
            ShowDropDown(pnlManageOrdersDD);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(ShowLanding);
            //th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        void ShowLanding()
        {
            Landing landing = new Landing();
            Application.Run(landing);
        }

        private void BtnAddItems_Click(object sender, EventArgs e)
        {
            if(addItem==null)
            {
                addItem = new AddItem(this);
                Contain(addItem);

            }
            else
            {
                Contain(addItem);
            }
             
        }

        private void Contain(Control control)
        {
            if (!pnlContainer.Controls.Contains(control))
            {
                pnlContainer.Controls.Clear();
                pnlContainer.Controls.Add(control);
                pnlContainer.Tag = control;
                if(control is RegistrationForm)
                {
                    pnlContainer.Padding = new Padding(90, 0, 90, 0);
                }
                else
                {
                    pnlContainer.Padding = new Padding(0, 0, 0, 0);
                }
                control.Show();
            }
        }

        private void BtnPendingOrders_Click(object sender, EventArgs e)
        {
            pendingOrders = new PendingOrders();
            Contain(pendingOrders);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if(removeItem==null)
            {
                removeItem = new ModifyItem();
            }
            Contain(removeItem);
        }

        private void BtnAllItem_Click(object sender, EventArgs e)
        {
            showAllItem = new ShowAllItem();
            Contain(showAllItem);
        }

        private void btnTakenOrders_Click(object sender, EventArgs e)
        {
            TakenOrders takenOrders = new TakenOrders();
            Contain(takenOrders);
        }

        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm() { RoleVisible = true };
            Contain(registrationForm);
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            if (personalInfo == null)
            {
                personalInfo = new PersonalInfo(user, this);
                Contain(personalInfo);
            }
            else
            {
                Contain(personalInfo);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(lblNotiCount.Text);
            if (notiApp==null)
            {
                notiApp = new NotiApp();
            }
            int count = notiApp.GetNotiCount();
            if(temp<count)
            {
                // sound = new SoundPlayer(@"C:\Users\Siam\Downloads\notisound.mp3");
                sound.Play();
            }

            lblNotiCount.Text = count.ToString();
        }

        private void btnNoti_Click(object sender, EventArgs e)
        {

        }

        public void HideDropDown()
        {
            pnlManageEmployeesDD.Visible = false;
            pnlManageMenuDD.Visible = false;
            pnlManageOrdersDD.Visible = false;
        }
    }
}
