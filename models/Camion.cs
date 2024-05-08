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
    internal class Camion
    {
        public string Matricule { get; set; }
        static string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Camion";
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
        public DataTable Select(string matricule)
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            string query;
            SqlCommand cmd;

            try
            {
                query = "SELECT * FROM Camion WHERE matricule=@matricule";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricule", matricule);
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
            
            string query;
            SqlCommand cmd;
            bool isSuccess = false;
            try
            {
                query = "INSERT INTO Camion VALUES(@matricule)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricule", Matricule);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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
