using scale.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scale
{
    public partial class MainForm : Form
    {
        private Timer timer;
        private static readonly string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private static string buttonClicked ;
        public MainForm()
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
        private void Clear()
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
        void display()
        {
            if (typePesee.Text.Equals("ENTREE"))
            {
                label10.Visible = true;
                pes_id.Visible = true;
            }
            label12.Visible = true;
            nbreCaisse.Visible = true;
            caisseNormale.Visible = true;
            Plateaux.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            PoidCaisse.Visible = true;
            dechets.Visible = true;
            Ecart.Visible = true;
            nonUsinable.Visible = true;
            tareAvecCaisse.Visible = true;
            tareSansCaisse.Visible = true;
            groupBox1.Visible = true;
            label11.Visible = true;
            label22.Visible = true;
            pGlace.Visible = true;
            nbrPalettes.Visible = true;
        }
        void hide()
        {
            label10.Visible = false;
            pes_id.Visible = false;
            label12.Visible = false;
            nbreCaisse.Visible = false;
            caisseNormale.Visible = false;
            Plateaux.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            PoidCaisse.Visible = false;
            dechets.Visible = false;
            Ecart.Visible = false;
            nonUsinable.Visible = false;
            groupBox1.Visible = false;
            tareAvecCaisse.Visible = false;
            tareSansCaisse.Visible= false;
            label11.Visible = false;
            label22.Visible = false;
            pGlace.Visible = false;
            nbrPalettes.Visible = false;
            
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

        private void tare_Click(object sender, EventArgs e)
        {
            tareBox.Text = pesee.Text.Trim();
            display();

            valider.Visible = true;
            buttonClicked = "tare";

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
                string query = "SELECT p.p_id,p.matricule,p.type_pesee,pr.pr_name,fr.fr_name,p.ddebut,p.dfin,p.hdebut,p.hfin FROM Pesee p,Produit pr,Fournisseur fr where p.pr_id=pr.pr_id AND p.fr_id=fr.fr_id ORDER BY p.p_id DESC";
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
            Clear();
            
        }

        private void destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void brut_Click(object sender, EventArgs e)
        {
            hide();
            if (typePesee.Text.Equals("SORTIE") || typePesee.Text.Equals("TRANSFER"))
            {
                label10.Visible = true;
                pes_id.Visible = true;
                display();
            }
            brutBox.Text = pesee.Text.Trim();
            valider.Visible = true;
            buttonClicked = "brut";
            

        }
        void setEnabled(bool enabled)
        {
                camion.Enabled = enabled;
                destination.Enabled = enabled;
                provenance.Enabled = enabled;
            fournisseurBox.Enabled = enabled;
            categorie.Enabled = enabled;
            produit1.Enabled = enabled;

        }
        private void valider_Click(object sender, EventArgs e)
        {
            if (buttonClicked.Equals("brut") )
            {
                if (typePesee.Text.Equals("ENTREE"))
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
                    int brutVal = 0;
                    try
                    {
                        brutVal = int.Parse(brutBox.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Clicker Sur le button Brut !!" + ex.Message);
                    }

                    string ddebut = date.Text;
                    string hdebut = hour.Text;


                    DataTable dt;
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
                        dt = fr.Select(fr_name);
                        data["fr_id"] = (int)dt.Rows[0]["fr_id"];
                    }
                    else
                    {
                        data["fr_id"] = (int)dt.Rows[0]["fr_id"];
                    }




                    //acceuil

                    dt = acceuill.Select(acc);
                    if (dt.Rows.Count == 0)
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
                    if (dt.Rows.Count == 0)
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
                    if (dt.Rows.Count == 0)
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
                    if (dt.Rows.Count == 0)
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
                    ++id;
                    string prefix = $"{char.ToUpper(acc[0])}{char.ToUpper(type_pes[0])}{char.ToUpper(cat_pr[0])}";
                    string p_id = $"{prefix}-{id}";



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
                    p.Tare = 0;
                    p.PoidGlace = 0;
                    p.PoidCaisse = 0;
                    p.NbrCaisse = 0;
                    p.CaisseNormale = caisseNormale.Checked;
                    p.Plateaux = Plateaux.Checked;
                    p.Dechets = 0;
                    p.NbrPalette = 0;
                    p.Ecart = 0;
                    p.HFin = null;
                    p.DFin = null;
                    p.IsFinished = false;
                    p.NonUsinable = 0;
                    p.Net = (p.Brut - (p.Tare +p.Dechets+ p.PoidGlace + p.PoidCaisse + p.Ecart+(p.NbrPalette * 26)));
                    p.Insert();
                    Clear();
                }
                else
                {
                    Pesee p = new Pesee();
                    int bru = int.Parse(brutBox.Text.Trim());
                    int pglace = int.Parse(pGlace.Text.Trim());
                    int pcaisse = int.Parse(PoidCaisse.Text.Trim());
                    int nbrcaisse = int.Parse(nbreCaisse.Text.Trim());
                    int dech = int.Parse(dechets.Text.Trim());
                    int ecar = int.Parse(Ecart.Text.Trim());
                    int nusinable = int.Parse(nonUsinable.Text.Trim());
                    int nPalettes = int.Parse(nbrPalettes.Text.Trim());

                    DataTable dt = p.Select(pes_id.Text);
                    p.Id = pes_id.Text;
                    int tare = (int)dt.Rows[0]["tare"];
                    p.Tare = tare;
                    p.Brut = bru;
                    p.PoidGlace = pglace;
                    p.PoidCaisse = pcaisse;
                    p.NbrCaisse = nbrcaisse;
                    p.Dechets = dech;
                    p.CaisseNormale = caisseNormale.Checked;

                    p.Plateaux = Plateaux.Checked;
                    p.NbrPalette = nPalettes;

                    p.Ecart = ecar;
                    p.HFin = hour.Text;
                    p.DFin = date.Text;
                    p.IsFinished = true;
                    p.NonUsinable = nusinable;
                    p.Net = (p.Brut - (p.Tare + p.Dechets + p.PoidGlace + p.PoidCaisse + p.Ecart + (p.NbrPalette * 26)));
                    brut1.Text= p.Brut.ToString();
                    tare1.Text = p.Tare.ToString();
                    netMp.Text = p.Net.ToString();
                    p.Update("tare");

                    Clear();


                }

            }
            else
            {
                if (typePesee.Text.Equals("SORTIE") || typePesee.Text.Equals("TRANSFER"))
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
                    int tareVal = 0;
                    try
                    {
                        tareVal = int.Parse(tareBox.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Clicker Sur le button Tare !!" + ex.Message);
                    }

                    string ddebut = date.Text;
                    string hdebut = hour.Text;


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
                        dt = fr.Select(fr_name);
                        data["fr_id"] = (int)dt.Rows[0]["fr_id"];
                    }
                    else
                    {
                        data["fr_id"] = (int)dt.Rows[0]["fr_id"];
                    }




                    //acceuil

                    dt = acceuill.Select(acc);
                    if (dt.Rows.Count == 0)
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
                    if (dt.Rows.Count == 0)
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
                    if (dt.Rows.Count == 0)
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
                    if (dt.Rows.Count == 0)
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
                    ++id;
                    string prefix = $"{char.ToUpper(acc[0])}{char.ToUpper(type_pes[0])}{char.ToUpper(cat_pr[0])}";
                    string p_id = $"{prefix}-{id}";

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
                    p.Tare = tareVal;
                    p.Brut = 0;
                    p.PoidGlace = 0;
                    p.PoidCaisse = 0;
                    p.NbrCaisse = 0;
                    p.CaisseNormale = false;
                    p.Plateaux = false;
                    p.NbrPalette = 0;
                    p.Ecart = 0;
                    p.HFin = null;
                    p.DFin = null;
                    p.IsFinished = false;
                    p.NonUsinable = 0;
                    p.Net = (p.Brut != 0)?(p.Brut - (p.Tare + p.PoidGlace + p.PoidCaisse + p.Ecart + (p.NbrPalette * 26))):0;
                    p.Insert();
                    Clear();

                }
                else
                {
                    
                    Pesee p = new Pesee();
                    int tar = int.Parse(tareBox.Text.Trim());
                    int pglace = int.Parse(pGlace.Text.Trim());
                    int pcaisse = int.Parse(PoidCaisse.Text.Trim());
                    int nbrcaisse = int.Parse(nbreCaisse.Text.Trim());
                    int dech = int.Parse(dechets.Text.Trim());
                    int ecar = int.Parse(Ecart.Text.Trim());
                    int nusinable = int.Parse(nonUsinable.Text.Trim());
                    int nPalettes = int.Parse(nbrPalettes.Text.Trim());

                    DataTable dt = p.Select(pes_id.Text);
                    p.Id = pes_id.Text;
                    int brut = (int)dt.Rows[0]["brut"];
                    p.Brut = brut;
                    p.Tare = tar;
                    p.PoidGlace = pglace;
                    p.PoidCaisse = pcaisse;
                    p.NbrCaisse = nbrcaisse;
                    p.Dechets = dech;
                    p.CaisseNormale = caisseNormale.Checked;

                    p.Plateaux = Plateaux.Checked;
                    p.NbrPalette = nPalettes;

                    p.Ecart = ecar;
                    p.HFin = hour.Text;
                    p.DFin = date.Text;
                    p.IsFinished = true;
                    p.NonUsinable = nusinable;
                    p.Net = (p.Brut - (p.Tare + p.Dechets + p.PoidGlace + p.PoidCaisse + p.Ecart + (p.NbrPalette * 26)));
                    brut1.Text = p.Brut.ToString();
                    tare1.Text = p.Tare.ToString();
                    netMp.Text = p.Net.ToString();
                    p.Update("brut");
                    Clear();
                }
            }
            Clear();
            lst_load();
            tbl_inf_load();
            
        }

      
       

        private void pes_id_DropDown(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT TOP 10 * FROM Pesee ORDER BY hdebut DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                pes_id.DataSource = dt;
                pes_id.DisplayMember = "p_id";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }





        // Assuming pes_id is a ComboBox or similar control
        private void pes_id_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string p_id = pes_id.Text;

                string query = "SELECT matricule,prov_id,fr_id,pr_id,dest_id FROM Pesee WHERE p_id=@p_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@p_id", p_id); // Corrected parameter name
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string mat = (string)dt.Rows[0]["matricule"];
                    int prov = (int)dt.Rows[0]["prov_id"];
                    int fr = (int)dt.Rows[0]["fr_id"];
                    int dest = (int)dt.Rows[0]["dest_id"];
                    int pr = (int)dt.Rows[0]["pr_id"];

                    // Retrieve provenance name
                    query = "SELECT prov_name FROM Provenance WHERE prov_id=@prov_id";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@prov_id", prov);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dtProv = new DataTable();
                    adapter.Fill(dtProv);
                    if (dtProv.Rows.Count > 0)
                    {
                        string prov_name = (string)dtProv.Rows[0]["prov_name"];
                        provenance.Text = prov_name;
                    }

                    // Retrieve fournisseur name
                    query = "SELECT fr_name FROM Fournisseur WHERE fr_id=@fr_id";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fr_id", fr);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dtFr = new DataTable();
                    adapter.Fill(dtFr);
                    if (dtFr.Rows.Count > 0)
                    {
                        string fr_name = (string)dtFr.Rows[0]["fr_name"];
                        fournisseurBox.Text = fr_name;
                    }

                    // Retrieve product name and category name
                    query = "SELECT p.pr_name,c.cat_name FROM Produit AS p,Categorie AS c WHERE c.cat_id=p.cat_id AND p.pr_id=@pr_id"; // Added missing AND keyword
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@pr_id", pr);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dtProd = new DataTable();
                    adapter.Fill(dtProd);
                    if (dtProd.Rows.Count > 0)
                    {
                        string pr_name = (string)dtProd.Rows[0]["pr_name"];
                        string cat_name = (string)dtProd.Rows[0]["cat_name"];
                        produit1.Text = pr_name;
                        categorie.Text = cat_name;
                    }

                    // Retrieve destination name
                    query = "SELECT dest_name FROM Destination WHERE dest_id=@dest_id";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@dest_id", dest);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dtDest = new DataTable();
                    adapter.Fill(dtDest);
                    if (dtDest.Rows.Count > 0)
                    {
                        string dest_name = (string)dtDest.Rows[0]["dest_name"];
                        destination.Text = dest_name;
                    }

                    // Set other controls
                    setEnabled(false);
                    camion.Text = mat;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        
    }
}
