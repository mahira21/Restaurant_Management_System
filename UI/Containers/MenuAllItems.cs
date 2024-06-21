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
using ResManaged3.UI.Elements;


namespace ResManaged3.UI.Containers
{
    public partial class MenuAllItems : Form
    {
        public MenuAllItems()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            PopulateFlow();
        }

        
        private async void PopulateFlow()
        {
            MenuAllItemsApp menuAllItemsApp = new MenuAllItemsApp();

            Task<List<ItemApp>> task = new Task<List<ItemApp>>(menuAllItemsApp.GetItems);
            task.Start();
            
            List<ItemApp> itemAppList = await task;

            foreach (ItemApp itemApp in itemAppList)
            {
                Item item = new Item();
                item.FoodPic = itemApp.ImageFile;
                item.ItemID = itemApp.ItemID.ToString();
                item.Title = itemApp.Title;
                item.Description = itemApp.Description;
                item.PriceTag = itemApp.PriceTag.ToString();

                flowLayoutPanel1.Controls.Add(item);
            }
        }

        
    }
}
