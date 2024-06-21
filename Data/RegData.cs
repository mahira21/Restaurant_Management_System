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
    class RegData
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";

        User user;
        public RegData(User usr)
        {
            user = usr;
        }

        public string CreateProfile()
        {
            string msg = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                Console.WriteLine("1");
                try
                {
                    Console.WriteLine("2");
                    con.Open();

                    bool exists = false;

                    // create a command to check if the username exists
                    using (SqlCommand cmd = new SqlCommand("select count(*) from [userTable] where username = @UserName", con))
                    {
                        cmd.Parameters.AddWithValue("UserName", user.UserName);
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }
                    Console.WriteLine("hh");
                    if (!exists)
                    {
                        Console.WriteLine("here");
                        SqlCommand cmd = new SqlCommand("Insert into userTable values ( @username, @name, @dob, @gender, @email, @mobile, @address);" +
                            "Insert into authTable values ( @username, @password, @usertype);", con);

                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@username", user.UserName);
                        cmd.Parameters.AddWithValue("@name", user.Name);
                        cmd.Parameters.AddWithValue("@dob", user.Date);
                        cmd.Parameters.AddWithValue("@gender", user.Gender);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@mobile", user.Mobile);
                        cmd.Parameters.AddWithValue("@address", user.Address);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@usertype", user.UserType);





                        cmd.ExecuteNonQuery();



                        con.Close();
                        msg = "Profile Created Successfully";

                    }
                    else
                    {
                        msg = "Username is not availabe";
                        Console.WriteLine("duplicate user anme");
                    }


                    //Console.WriteLine("user Registred");
                }
                catch(Exception ex)
                {
                    msg = ex.Message;
                    Console.WriteLine(ex.Message);
                }
                return msg;
            }
        }

        public string UpdateProfile()
        {
            string msg = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                Console.WriteLine("1");
                try
                {
                    Console.WriteLine("2");
                    con.Open();

                    bool exists = false;

                    // create a command to check if the username exists
                    using (SqlCommand cmd = new SqlCommand("select count(*) from [userTable] where username = @UserName", con))
                    {
                        cmd.Parameters.AddWithValue("UserName", user.UserName);
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }
                    Console.WriteLine("hh");
                    if (exists)
                    {
                        Console.WriteLine("here");
                        SqlCommand cmd = new SqlCommand("Update userTable set name= @name, dob= @dob, gender = @gender, email = @email, mobile = @mobile, address = @address where username = @username;" +
                            "Update authTable set password = @password, usertype = @usertype where username = @username;", con);

                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@username", user.UserName);

                        cmd.Parameters.AddWithValue("@name", user.Name);
                        cmd.Parameters.AddWithValue("@dob", user.Date);
                        cmd.Parameters.AddWithValue("@gender", user.Gender);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@mobile", user.Mobile);
                        cmd.Parameters.AddWithValue("@address", user.Address);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@usertype", user.UserType);





                        cmd.ExecuteNonQuery();



                        con.Close();
                        msg = "Profile Updated Successfully";

                    }
                    else
                    {
                    }


                    //Console.WriteLine("user Registred");
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                    Console.WriteLine(ex.Message);
                }
                return msg;
            }
        }
    }
}
