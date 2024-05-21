using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scale
{
    public class DbConnection
    {
        private static SqlConnection Conn;


        public static SqlConnection getConnection()
        {
            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.connString);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return Conn;
        }
    }
}
