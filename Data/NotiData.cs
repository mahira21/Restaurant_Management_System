using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResManaged3.Data
{
    class NotiData
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Edu\Programs\C#\Practice\ResManaged3\Data\ResM.mdf;Integrated Security=True";
        public int GetNotiCount()
        {
            int count;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM notification where notified = 0", con);

                cmd.CommandType = CommandType.Text;

                count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

            }
            return count;
        }
    }
}
