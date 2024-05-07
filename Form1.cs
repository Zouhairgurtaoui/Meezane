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
    public partial class Form1 : Form
    {
        private Timer timer;
        private static readonly string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            InitializeFullscreenForm();
            this.date.Text = DateTime.Now.ToShortDateString();
            InitializeTimer();
            lst_load();
            tbl_inf_load();
        }
        private void InitializeFullscreenForm()
        {
            
            //this.FormBorderStyle = FormBorderStyle.None; // Remove borders
            this.WindowState = FormWindowState.Maximized; 
        }

        private void InitializeTimer()
        {

            timer = new Timer
            {
                Interval = 1000
            };


            timer.Tick += Timer_Tick;

            
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            hour.Text = DateTime.Now.ToString("H:mm:ss");
        }
        private void clear()
        {
            camion.Text = string.Empty;
            fournisseurBox.Text = string.Empty;
            produit1.Text = string.Empty;
            provenance.Text = string.Empty;
            destination.Text = string.Empty;
            typePesee.Text = string.Empty;
            acceuil.Text = string.Empty;
            categorie.Text = string.Empty;
            frCode.Text = string.Empty;
            brutBox.Text = string.Empty;
            tareBox.Text = string.Empty;
        }

        private void acceuil_DropDown(object sender, EventArgs e)
        {
            
            Acceuil acceuilVar = new Acceuil();
            acceuil.DataSource = acceuilVar.Select();
            acceuil.DisplayMember = "acc_name";

        }

        private void camion_DropDown(object sender, EventArgs e)
        {
            Camion matricule = new Camion();
            camion.DataSource = matricule.Select();
            camion.DisplayMember = "matricule";

        }

        private void categorie_DropDown(object sender, EventArgs e)
        {
            Categorie type = new Categorie();
            categorie.DataSource = type.Select();
            categorie.DisplayMember = "cat_name";
        }

        private void provenance_DropDown(object sender, EventArgs e)
        {
            Provenance prv = new Provenance();
            provenance.DataSource = prv.Select();
            provenance.DisplayMember = "prov_name";
        }

        private void destination_DropDown(object sender, EventArgs e)
        {
            Destination dest = new Destination();
            destination.DataSource = dest.Select();
            destination.DisplayMember = "dest_name";
        }

        private void fournisseurBox_DropDown(object sender, EventArgs e)
        {
            Fournisseur fr = new Fournisseur();
            fournisseurBox.DataSource = fr.Select();
            fournisseurBox.DisplayMember = "fr_name";
        }

        private void tare_Click(object sender, EventArgs e)
        {

        }

        private void frCode_TextChanged(object sender, EventArgs e)
        {
            string keyword = frCode.Text;
            if (keyword == string.Empty)
            {
                fournisseurBox_DropDown(sender,e);
            }
            SqlConnection conn = new SqlConnection(myConnstring);
            string query = "SELECT * FROM Fournisseur WHERE fr_code LIKE @frCode";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@frCode", "%" + keyword + "%");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                fournisseurBox.DataSource = dt;
                fournisseurBox.DisplayMember = "fr_name";
                fournisseurBox.DroppedDown = false;
            }
            else
            {
                fournisseurBox.DroppedDown = false;
            }
            

        }

        private void produit1_DropDown(object sender, EventArgs e)
        {
            string cat = categorie.Text;
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            string query ;
            if (cat == string.Empty)
            {
                query = "SELECT * FROM Produit";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            else
            {
                query = "SELECT * FROM Produit WHERE cat_id=(SELECT cat_id FROM Categorie WHERE cat_name = @catName)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@catName",  cat);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                
                sda.Fill(dt);
            }

            produit1.DataSource = dt;
            produit1.DisplayMember = "pr_name";
            
            

        }

      
        public void lst_load()
        {
            Pesee p = new Pesee();
            DataTable dt = p.Select();
            lstPesee.DataSource = dt;
            lstPesee.DisplayMember = "p_id";
        }
        public void tbl_inf_load()
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT p.p_id,p.ddebut,p.dfin,p.hdebut,p.hfin,p.matricule,p.type_pesee,pr.pr_name,fr.fr_name FROM Pesee p,Produit pr,Fournisseur fr where p.pr_id=pr.pr_id AND p.fr_id=fr.fr_id";
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
            tbl_inf.DataSource = dt;
            tbl_inf.Columns["NPesee"].DataPropertyName = "p_id";
            tbl_inf.Columns["Matricule"].DataPropertyName = "matricule";
            tbl_inf.Columns["Type"].DataPropertyName = "type_pesee";
            tbl_inf.Columns["Fournisseur"].DataPropertyName = "fr_name";
            tbl_inf.Columns["Produit"].DataPropertyName = "pr_name";
            tbl_inf.Columns["DDebut"].DataPropertyName = "ddebut";
            tbl_inf.Columns["DFin"].DataPropertyName = "dfin";
            tbl_inf.Columns["HDebut"].DataPropertyName = "hdebut";
            tbl_inf.Columns["HFin"].DataPropertyName = "hfin";


        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            string keyword = search.Text;
            if (keyword == string.Empty)
            {
                lst_load();
            }
            SqlConnection conn = new SqlConnection(myConnstring);
            string query = "SELECT * FROM Pesee WHERE P_id like @PId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PId", "%" + keyword + "%");
            

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lstPesee.DataSource = dt;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void brut_Click(object sender, EventArgs e)
        {
            brutBox.Text = pesee.Text.Trim();
            valider.Visible = true;

        }

        private void valider_Click(object sender, EventArgs e)
        {
           
            string matricule = camion.Text;
            string prv = provenance.Text;
            string fr_code = frCode.Text;
            string fr_name = fournisseurBox.Text;
            string dest = destination.Text;
            string cat_pr = categorie.Text;
            string pr1 = produit1.Text;
           
            string acc = acceuil.Text;
            string type_pes = typePesee.Text;
            int brutVal = int.Parse(brutBox.Text.Trim());

            string ddebut = date.Text;
            string hdebut = hour.Text;
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            Dictionary<string, int> data = new Dictionary<string, int>();
            Provenance prov = new Provenance();
            Camion cam = new Camion();
            Fournisseur fr = new Fournisseur();
            Acceuil acceuill = new Acceuil();
            Destination desti = new Destination();
            Produit pro1 = new Produit();
            FournisseurCode for_code = new FournisseurCode();
            Categorie cat = new Categorie();

            //provenance
            
                dt = prov.Select(prv);
                if (dt.Rows.Count == 0)
                {
                    prov.Name = prv;
                    prov.insert();
                    dt = prov.Select(prv);
                    data["prov_id"] = (int)dt.Rows[0]["prov_id"];
                }
                else
                {
                    data["prov_id"] = (int)dt.Rows[0]["prov_id"];
                }
            
            //camion
            
                dt = cam.Select(matricule);
                if (dt.Rows.Count == 0)
                {
                    cam.Matricule = matricule;
                    cam.Insert();
                }

                // Fr_code
                dt = for_code.Select(fr_code);
                if (dt.Rows.Count == 0)
                {
                    for_code.Code = fr_code;
                    for_code.Insert();
                }

            //fournisseur 
                
                dt = fr.Select(fr_name);
            if (dt.Rows.Count == 0)
            {
                fr.Code = fr_code;
                fr.Name = fr_name;
                fr.Insert();
                dt=fr.Select(fr_name);
                data["fr_id"] = (int)dt.Rows[0]["fr_id"];
            }
            else
            {
                data["fr_id"] = (int)dt.Rows[0]["fr_id"];
            }
                
                

            
            //acceuil
            
                dt = acceuill.Select(acc);
                if(dt.Rows.Count == 0)
                {
                    acceuill.Name = acc;
                    acceuill.Insert();
                    dt = acceuill.Select(acc);
                    data["acc_id"] = (int)dt.Rows[0]["acc_id"];
            }
                else
                {
                    data["acc_id"] = (int)dt.Rows[0]["acc_id"];
                }
            
            //destination
            
                dt = desti.Select(dest);
                if(dt.Rows.Count == 0)
                {
                    desti.Name = dest;
                    desti.Insert();
                dt = desti.Select(dest);
                data["dest_id"] = (int)dt.Rows[0]["dest_id"];
            }
                else
                {
                    data["dest_id"] = (int)dt.Rows[0]["dest_id"];
                }
            
            //categorie
            
                dt = cat.Select(cat_pr);
                if(dt.Rows.Count == 0)
                {
                    cat.Name = cat_pr;
                    cat.Insert();
                    dt = cat.Select(cat_pr);
                    data["cat_id"] = (int)dt.Rows[0]["cat_id"];
                }
                else
                {
                    data["cat_id"] = (int)dt.Rows[0]["cat_id"];
                }
            
            //produit
            
                dt = pro1.Select(pr1);
                if(dt.Rows.Count == 0)
                {
                    pro1.CatId = data["cat_id"];
                    pro1.Name = pr1;
                    pro1.Insert();
                    dt = pro1.Select(pr1);
                    data["pr_id"] = (int)dt.Rows[0]["pr_id"];
                }
                else
                {
                    data["pr_id"] = (int)dt.Rows[0]["pr_id"];
                }
            
            
            
               
            
            //pesee
            Pesee p = new Pesee();
            dt = p.Select_last();
            string[] mp = null;
            if (dt.Rows.Count > 0)
            {
                mp = dt.Rows[0]["p_id"].ToString().Split('-');
                data["p_id"] = Convert.ToInt32(mp[1]);
            }
            else
            {
                data["p_id"] = 0;
            }

            int id = data["p_id"];
            id++;
            string prefix = $"{char.ToUpper(acc[0])}{char.ToUpper(type_pes[0])}{char.ToUpper(cat_pr[0])}";
            string p_id = $"{prefix}-{id}";

            MessageBox.Show(p_id);
       
            p.Id = p_id;
            p.Type = type_pes;
            p.AcceuilId = data["acc_id"];
            p.FournisseurID = data["fr_id"];
            p.Matricule = matricule;
            p.ProduitId = data["pr_id"];
            p.ProvenanceId = data["prov_id"];
            p.DestinationId = data["dest_id"];
            p.HDebut = hdebut;
            p.DDebut = ddebut;
            p.Brut = brutVal;
            p.Insert();



            lst_load();
            tbl_inf_load();
            clear();
        }

        
    }
}
