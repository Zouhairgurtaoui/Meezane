using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scale.models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        //static string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public DataTable Select()
        {
            //SqlConnection conn = new SqlConnection(myConnstring);
            SqlConnection conn = DbConnection.getConnection();
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable Select(string username,string password)
        {
            //SqlConnection conn = new SqlConnection(myConnstring);
            SqlConnection conn = DbConnection.getConnection();
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Users where username=@username AND user_password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
               
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
