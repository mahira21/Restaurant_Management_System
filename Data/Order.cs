using ResManaged3.App;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManaged3.Data
{
    class Order
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";

        public static void InserOrdersDb(User user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into orderTable values ( @userID, @bill, @status, @address, @mobile);", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@userID", user.UserName);
                cmd.Parameters.AddWithValue("@bill", (float)CheckOutApp.CalculateTotalPrice());
                cmd.Parameters.AddWithValue("@status", 0);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@mobile", user.Mobile);



                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("SELECT IDENT_CURRENT('orderTable')", con);
                int id = Convert.ToInt32(cmd2.ExecuteScalar());


                cmd2 = new SqlCommand("Insert into notification values (@userID, @message, @notified);", con);
                cmd2.CommandType = CommandType.Text;

                cmd2.Parameters.AddWithValue("@userID", user.UserName);
                cmd2.Parameters.AddWithValue("@message", user.UserName + " has placed an order ["+id+"]");
                cmd2.Parameters.AddWithValue("@notified", 0);

                cmd2.ExecuteNonQuery();






                foreach (CartItemApp cartItemApp in CheckOutApp.itemApps)
                {
                    
                    SqlCommand cmd3 = new SqlCommand("Insert into orderExtension values ( @orderID, @itemCode, @quantity);", con);

                    cmd3.CommandType = CommandType.Text;

                    cmd3.Parameters.AddWithValue("@orderID", id);
                    cmd3.Parameters.AddWithValue("@itemCode", Convert.ToInt32(cartItemApp.ItemCode));
                    cmd3.Parameters.AddWithValue("@quantity", cartItemApp.Quantity);
                  



                    cmd3.ExecuteNonQuery();
                }
                con.Close();


                Console.WriteLine("inserted orders");
            }
        }

        #region PendingOrderOperations

        public List<OrderPaletteApp> GetOrderPalettes (string query)
        {
            List<OrderPaletteApp> orderPaletteApps = new List<OrderPaletteApp>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("select * from orderTable where status = @status", con);
                SqlCommand cmd = new SqlCommand(query, con);


                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@status", );


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    OrderPaletteApp orderPalette = new OrderPaletteApp();
                    orderPalette.OrderID = Convert.ToInt32(reader[0]);
                    //orderPalette.UserName = reader[1].ToString();
                    orderPalette.Bill = (double)reader[2];
                    orderPalette.Status = Convert.ToInt32(reader[3]);
                    orderPalette.AddPhn = reader[4].ToString() + ", " + reader[5].ToString();
                    orderPalette.itemnames = GetItemInfo(orderPalette.OrderID);


                    orderPaletteApps.Add(orderPalette);

                }

                reader.Close();
                con.Close();

            }

            return orderPaletteApps;


        }
        public List<string> GetItemInfo(int id)
        {
            List<string> names = new List<string>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                Console.WriteLine(id + ":\n");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from orderExtension where orderID = @orderID", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@orderID", id);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string str = "";
                    //str = reader[1].ToString() 
                    int itemID = (int)reader[1];
                    string inem = GetItemName(itemID);
                    
                    str = inem + " ( " + reader[2].ToString() + " )";
                    //Console.WriteLine("#" + label.Text + "\n");

                    //str = str + inem + "  [ " + reader[2].ToString() + " ],  ";
                    names.Add(str);

                }

                reader.Close();
                con.Close();

            }
            return names;
        }

        public string GetItemName(int id)
        {
            string str = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from itemTable where itemcode = @itemcode", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@itemcode", id);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    str = reader[2].ToString();
                }

                reader.Close();
                con.Close();

            }
            return str;
        }

        #endregion
    }

}

