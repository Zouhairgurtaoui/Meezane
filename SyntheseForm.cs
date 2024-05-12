using scale.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scale
{
    public partial class SyntheseForm : Form
    {
        private static readonly string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public SyntheseForm()
        {
            InitializeComponent();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            string start_time = date.Value.ToString("M/d/yyyy");
            Fournisseur fr = new Fournisseur();

            DataTable dt = fr.Select(fournisseur.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                try
                {
                    
                    string query = "SELECT pr.pr_name AS produit , SUM(p.net) AS quantity, SUM(p.dechets) AS dechets,SUM(p.ecart) AS Ecart,SUM(non_usinable) AS 'Non usinable' FROM Pesee p INNER JOIN   Produit pr ON p.pr_id = pr.pr_id WHERE  p.fr_id = @fr_id  AND p.ddebut >= @start_time  AND p.ddebut <= DATEADD(MONTH, DATEDIFF(MONTH, 0, @start_time) + 1, -1) GROUP BY pr.pr_name";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fr_id", (int)dt.Rows[0]["fr_id"]);
                    cmd.Parameters.AddWithValue("@start_time", start_time);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
            else
            {
                MessageBox.Show("Fournisseur n'exist pas");
            }
        }

        private void fournisseur_DropDown(object sender, EventArgs e)
        {
            Fournisseur fr = new Fournisseur();
            fournisseur.DataSource = fr.Select();
            fournisseur.DisplayMember = "fr_name";
        }
    }
}
