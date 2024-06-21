using ResManaged3.App;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManaged3.Data
{
    class ItemData
    {
        ItemClass itemClass;
        List<ItemApp> itemAppList;
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";

        public ItemData(ItemClass itemClass)
        {
            this.itemClass = itemClass;

            
        }

        public ItemData(List<ItemApp> itemAppList)
        {
            this.itemAppList = itemAppList;
        }

        public string AddItem()
        {
            string msg = "";

            Bitmap bmp = new Bitmap(this.itemClass.ImageLoc);
            FileStream fs = new FileStream(this.itemClass.ImageLoc, FileMode.Open, FileAccess.Read);
            byte[] bimage = new byte[fs.Length];
            fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
            fs.Close();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                Console.WriteLine("1");
                try
                {
                    Console.WriteLine("2");
                    con.Open();


                    Console.WriteLine("here");
                    SqlCommand cmd = new SqlCommand("Insert into itemTable values ( @image, @title, @description, @price);", con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@image", bimage);
                    cmd.Parameters.AddWithValue("@title", itemClass.Title);
                    cmd.Parameters.AddWithValue("@description", itemClass.Description);
                    cmd.Parameters.AddWithValue("@price", itemClass.Price);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    msg = "Item added Successfully";

                    

                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                    Console.WriteLine(ex.Message);
                }
                return msg;
            }
        }

        public List<ItemApp> GetItemApps()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from itemTable", con);

                cmd.CommandType = CommandType.Text;


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ItemApp itemApp = new ItemApp();

                    itemApp.ItemID = Convert.ToInt32(reader[0]);

                    byte[] myImage = new byte[0];
                    myImage = (byte[])reader[1];
                    MemoryStream stream = new MemoryStream(myImage);
                    itemApp.ImageFile = Image.FromStream(stream);

                    itemApp.Title = reader[2].ToString();
                    itemApp.Description = reader[3].ToString();
                    itemApp.PriceTag = Convert.ToDouble(reader[4]);

                    itemAppList.Add(itemApp);
                    
                }

                reader.Close();
                con.Close();

            }
            return itemAppList;
        }

    }
}
