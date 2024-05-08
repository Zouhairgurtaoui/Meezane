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
    internal class Produit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CatId { get; set; }
        virtual public Categorie Categories { get; set; }

        static string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Produit";
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
        public DataTable Select(string pr_name)
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Produit where pr_name=@pr_name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pr_name", pr_name);
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
        public bool Insert()
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnstring);
            try
            {
                string sql = "INSERT INTO Produit(pr_name,cat_id) VALUES(@pr_name,@cat_id)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pr_name", Name);
                cmd.Parameters.AddWithValue("@cat_id", CatId);
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
