using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace scale.models
{
    internal class Fournisseur
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        

        static string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM Fournisseur";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex) { 
                Console.Write(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public DataTable Select(string fr_name)
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            string query;
            SqlCommand cmd;

            try
            {
                query = "SELECT * FROM Fournisseur WHERE fr_name=@fr_name";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fr_name", fr_name);
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

        public bool Insert()
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnstring);
            try
            {
                string sql = "INSERT INTO Fournisseur(fr_name,fr_code) VALUES(@fr_name,@fr_code)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fr_name", Name);
                cmd.Parameters.AddWithValue("@fr_code", Code);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0) isSuccess = true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
