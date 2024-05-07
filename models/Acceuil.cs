using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scale.models
{
    internal class Acceuil
    {
        public int Id { get; set; }
        public string Name { get; set; }

        static string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
       

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Acceuil";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable Select(string acc)
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            string query;
            SqlCommand cmd;

            try
            {
                query = "SELECT * FROM Acceuil WHERE acc_name=@acc";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@acc", acc);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex) { }
            return dt;
        }
        public bool Insert()
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            string query;
            SqlCommand cmd;
            bool isSuccess = false;
            try
            {
                query = "INSERT INTO Acceuil(acc_name) VALUES(@acc_name)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@acc_name", Name);
               
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0) isSuccess = true;
            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
