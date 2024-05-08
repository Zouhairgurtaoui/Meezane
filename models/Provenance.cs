using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace scale.models
{
    internal class Provenance
    {
        public int Id
        {
            get; set;
        }
        public string Name { get; set; }

        static string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Provenance";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable Select(string prv)
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            string query;
            SqlCommand cmd;
           
            try
            {
                query = "SELECT * FROM Provenance WHERE prov_name=@prov_name";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@prov_name", prv);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool insert()
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            
            string query;
            SqlCommand cmd;
            bool isSuccess = false;
            try
            {
                query = "INSERT INTO Provenance(prov_name) VALUES(@prov_name)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@prov_name", Name);
               
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0) isSuccess = true;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

    }
}
