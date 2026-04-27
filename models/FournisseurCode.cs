using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Linq;

namespace scale.models
{
    internal class FournisseurCode
    {
        public string Code { get; set; }
        //static string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public DataTable Select(string code)
        {
            //SqlConnection conn = new SqlConnection(myConnstring);
            SqlConnection conn = DbConnection.getConnection();
            DataTable dt = new DataTable();
            string query;
            SqlCommand cmd;

            try
            {
                query = "SELECT * FROM Fr_code WHERE fr_code=@fr_code";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fr_code", code);
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
            bool isSuccess = false;
            //SqlConnection conn = new SqlConnection(myConnstring);
            SqlConnection conn = DbConnection.getConnection();
            try
            {
                string sql = "INSERT INTO Fr_code VALUES(@fr_code)";
                SqlCommand cmd = new SqlCommand(sql, conn);
               
                cmd.Parameters.AddWithValue("@fr_code", Code);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0) isSuccess = true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
