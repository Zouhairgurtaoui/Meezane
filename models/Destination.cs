using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace scale.models
{
    internal class Destination
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
                string query = "SELECT * FROM Destination";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex) {
                Console.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable Select(string dest_name)
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            string query;
            SqlCommand cmd;

            try
            {
                query = "SELECT * FROM Destination WHERE dest_name=@dest_name";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dest_name", dest_name);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex) {
                Console.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
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
                        query = "INSERT INTO Destination(dest_name) VALUES(@dest_name)";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@dest_name", Name);
                        
                        conn.Open();
                        int row = cmd.ExecuteNonQuery();
                        if (row > 0) isSuccess = true;
                    }
                    catch (Exception ex) {
                Console.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

    }
}
