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
    class AuthData
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";

        string username, password;
        public AuthData(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User GetProfile()
        {
            int status = CheckUser();
            if (status > -1)
            {
                User user = GetUser();
                if (user != null)
                {
                    user.UserName = username;
                    user.Password = password;
                    user.UserType = status;

                    return user;
                }
                else
                    return null;
            }
            else
                return null;
        }

        private int CheckUser()
        {
            int status = -1;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from authTable where username = @username and password = @password", con);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    status = (Convert.ToInt32(reader[2]));
                }

                reader.Close();
                con.Close();

                return status;
            }
        }

        public User GetUser()
        {
            User user;
            try
            {
                
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from userTable where username = @username", con);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@username", username);


                    SqlDataReader reader = cmd.ExecuteReader();
                    user = new User();

                    while (reader.Read())
                    {
                        user.Name = reader[1].ToString();
                        user.Date = (DateTime)reader[2];
                        user.Gender = Convert.ToInt32(reader[3]);
                        user.Email = reader[4].ToString();
                        user.Mobile = reader[5].ToString();
                        user.Address = reader[6].ToString();
                    }

                    reader.Close();
                    con.Close();

                    return user;
                }
            }
            catch(Exception ex)
            {
                user = null;
                return user;
            }
        }
    }
}
