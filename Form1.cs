using scale.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace scale
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;
        //private static readonly string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private static string buttonClicked;
        private Pesee p = new Pesee();
        private delegate void SetTextDeleg(string message);
       

        private StringBuilder dataBuffer = new StringBuilder();




        public MainForm()
        {
            InitializeComponent();
            InitializeFullscreenForm();
            this.date.Text = DateTime.Now.ToShortDateString();
            InitializeTimer();
            lst_load();
            tbl_inf_load();
            

            serialPort.PortName = "COM4";
            serialPort.RtsEnable = true;

            serialPort.ReceivedBytesThreshold = 1;
            serialPort.DtrEnable = true;
           
            serialPort.Handshake = Handshake.RequestToSend;
            try
            {
                serialPort.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                serialPort.Close();

                serialPort.Dispose();
            }


        }
        /*private void timer_Tick(object sender, EventArgs e)
        {
            string dataFromScale = serial.ReadLine().ToString();
        }*/
        public  void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {



            /* try
             {
                 string data = serialPort.ReadExisting();
                 // Ensure the UI update is done on the UI thread
                 this.Invoke(new Action(() =>
                 {
                     pesee.Text = data;
                 }));
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/

            try
            {
                
                string data = serialPort.ReadExisting();
                dataBuffer.Append(data);

                // Check if the buffer contains a complete message (assuming newline as the delimiter)
                while (dataBuffer.ToString().Contains("\n"))
                {
                    string completeData = dataBuffer.ToString();
                    int newlineIndex = completeData.IndexOf('\n');

                    // Extract the message up to the newline
                    string message = completeData.Substring(0, newlineIndex).Trim();

                    // Remove the processed message from the buffer
                    dataBuffer.Remove(0, newlineIndex + 1);

                    // Update the UI on the main thread
                    this.Invoke(new Action(() =>
                    {
                        // Filter out '+' and '-' if they are not part of the numeric data
                        if (message == "+" || message == "-")
                        {
                            message = "0";
                        }

                        if (string.IsNullOrEmpty(message))
                        {
                            pesee.Text = "0";
                        }
                        else
                        {
                            pesee.Text = message;
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //private void si_DataReceived(string data) { pesee.Text = data; MessageBox.Show(data); }


        /*private void serialPort_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            string message;
            
            try
            {
                
                message = serialPort.ReadLine().ToString();
                this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { message });
                
             
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }*/

        private void InitializeFullscreenForm()
        {

            //this.FormBorderStyle = FormBorderStyle.None; // Remove borders
            this.WindowState = FormWindowState.Maximized;
        }

        public void SetUser(User user)
        {
            p.Users = user;
        }

        private void InitializeTimer()
        {

            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };


            timer.Tick += Timer_Tick;


            timer.Start();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                serialPort.Dispose();
            }
        }


        private void Timer_Tick(object sender, EventArgs e)
        {

            hour.Text = DateTime.Now.ToString("H:mm:ss");
            timer.Stop();

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
            nbreCaisse.Text = "0";
            nbrPalettes.Text = "0";
            PoidCaisse.Text = "0";
            tareAvecCaisse.Checked = false;
            tareSansCaisse.Checked = false;
            pes_id.Text = string.Empty;
            caisseNormale.Checked = false;
            dechets.Text = "0";
            nonUsinable.Text = "0";
            Ecart.Text = "0";

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
            if (frCode.Text == string.Empty)
            {
                fournisseurBox.DataSource = fr.Select();
                
            }
            else
            {
                fournisseurBox.DataSource = fr.select(frCode.Text);
               
            }
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
            tareSansCaisse.Visible = false;
            label11.Visible = false;
            label22.Visible = false;
            pGlace.Visible = false;
            nbrPalettes.Visible = false;

        }


        
        

        private void produit1_DropDown(object sender, EventArgs e)
        {
            string cat = categorie.Text;
            //SqlConnection conn = new SqlConnection(myConnstring);
            SqlConnection conn = DbConnection.getConnection();
            DataTable dt = new DataTable();
            string query;
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
                cmd.Parameters.AddWithValue("@catName", cat);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
            }

            produit1.DataSource = dt;
            produit1.DisplayMember = "pr_name";



        }

        private void tare_Click(object sender, EventArgs e)
        {
            hide();
            tareBox.Text = pesee.Text.Trim();
            if (typePesee.Text.Equals("ENTREE"))
            {
                display();
            }

            valider.Visible = true;
            buttonClicked = "tare";

        }
        public void lst_load()
        {

            DataTable dt = p.Select();
            lstPesee.DataSource = dt;
            lstPesee.DisplayMember = "p_id";
        }
        public void tbl_inf_load()
        {
            //SqlConnection conn = new SqlConnection(myConnstring);
            SqlConnection conn = DbConnection.getConnection();
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT p.p_id, p.matricule, p.type_pesee, pr.pr_name, fr.fr_name, p.ddebut, p.dfin, p.hdebut, p.hfin FROM Pesee p JOIN Produit pr ON p.pr_id = pr.pr_id JOIN Fournisseur fr ON p.fr_id = fr.fr_id WHERE p.dfin >= DATEADD(DAY, -3, GETDATE()) OR p.ddebut >= DATEADD(DAY, -3, GETDATE()) ORDER BY p.p_id DESC;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
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
            tbl_inf.Columns["p_id"].Visible = false;
            tbl_inf.Columns["matricule"].Visible = false;
            tbl_inf.Columns["fr_name"].Visible = false;
            tbl_inf.Columns["type_pesee"].Visible = false;
            tbl_inf.Columns["pr_name"].Visible = false;
            tbl_inf.Columns["ddebut"].Visible = false;
            tbl_inf.Columns["dfin"].Visible = false;
            tbl_inf.Columns["hdebut"].Visible = false;
            tbl_inf.Columns["hfin"].Visible = false;


        }
        private void search_TextUpdated(object sender, EventArgs e)
        {
            string keyword = search.Text;
            if (keyword == string.Empty)
            {
                lst_load();
            }
            //SqlConnection conn = new SqlConnection(myConnstring);
            SqlConnection conn = DbConnection.getConnection();
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

        private void destination_TextUpdated(object sender, EventArgs e)
        {
            string keyword = destination.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                destination_DropDown(sender, e);

            }

            //using (SqlConnection conn = new SqlConnection(myConnstring))
            using (SqlConnection conn = DbConnection.getConnection())
            {
                string query = "SELECT * FROM Destination WHERE dest_name LIKE @dest_name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dest_name", "%" + keyword + "%");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    sda.Fill(dt);

                    if (dt != null && dt.Rows.Count > 0)
                    {

                        destination.DataSource = dt;
                        destination.DisplayMember = "dest_name";
                        destination.DroppedDown = true;
                        destination.Text = keyword;
                        destination.SelectionStart = destination.Text.Length;
                    }
                    else
                    {
                        destination.DroppedDown = false;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {

                    conn.Close();
                }
            }
        }

        private void brut_Click(object sender, EventArgs e)
        {
            brutBox.Text = pesee.Text.Trim();
            hide();

            if (typePesee.Text.Equals("SORTIE") || typePesee.Text.Equals("TRANSFER"))
            {
                label10.Visible = true;
                pes_id.Visible = true;
                display();
            }

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
        private void ChangeTextObject(ReportDocument reportDocument, string textObjectName, string newText)
        {
            // Find the text object in the report
            TextObject textObject = reportDocument.ReportDefinition.ReportObjects[textObjectName] as TextObject;
            if (textObject != null)
            {
                // Change the text
                textObject.Text = newText;
            }
        }
        void Print(ReportDetail rp,string type)
        {
            if (type.Equals("brut")) {
                rptFirstOp.SetParameterValue("PeseeN", rp.PeseeN);
                rptFirstOp.SetParameterValue("typeOperation", rp.TypeOperation);
                rptFirstOp.SetParameterValue("destination", rp.Destination);
                rptFirstOp.SetParameterValue("provenance", rp.Provenance);
                rptFirstOp.SetParameterValue("matricule", rp.Matricule);
                rptFirstOp.SetParameterValue("produit", rp.Produit);
                rptFirstOp.SetParameterValue("fournisseur", rp.Fournisseur);
                rptFirstOp.SetParameterValue("BRUT", rp.Brut);
                rptFirstOp.SetParameterValue("operateur", rp.Operateur);
                ChangeTextObject(rptFirstOp, "tareBrut", "Brut");
                string savePath = $"C:\\Users\\Hp\\Desktop\\{rp.PeseeN}.doc";
                rptFirstOp.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, savePath);
            }
            else if(type.Equals("tare")){

                rptFirstOp.SetParameterValue("PeseeN", rp.PeseeN);
                rptFirstOp.SetParameterValue("typeOperation", rp.TypeOperation);
                rptFirstOp.SetParameterValue("destination", rp.Destination);
                rptFirstOp.SetParameterValue("provenance", rp.Provenance);
                rptFirstOp.SetParameterValue("matricule", rp.Matricule);
                rptFirstOp.SetParameterValue("produit", rp.Produit);
                rptFirstOp.SetParameterValue("fournisseur", rp.Fournisseur);
                rptFirstOp.SetParameterValue("BRUT", rp.Tare);
                rptFirstOp.SetParameterValue("operateur", rp.Operateur);
                ChangeTextObject(rptFirstOp, "tareBrut", "Tare");
                string savePath = $"C:\\Users\\Hp\\Desktop\\{rp.PeseeN}.doc";
                rptFirstOp.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, savePath);
            }
            else
            {
                rptPesee.SetParameterValue("PeseeN", rp.PeseeN);
                rptPesee.SetParameterValue("typeOperation", rp.TypeOperation);
                rptPesee.SetParameterValue("destination", rp.Destination);
                rptPesee.SetParameterValue("provenance", rp.Provenance);
                rptPesee.SetParameterValue("matricule", rp.Matricule);
                rptPesee.SetParameterValue("produit", rp.Produit);
                rptPesee.SetParameterValue("fournisseur", rp.Fournisseur);
                rptPesee.SetParameterValue("debut", rp.Debut);
                rptPesee.SetParameterValue("fin", rp.Fin);
                rptPesee.SetParameterValue("BRUT", rp.Brut);
                rptPesee.SetParameterValue("TARE", rp.Tare);
                rptPesee.SetParameterValue("POIDCAIPAL", rp.PoidCaisPal);
                rptPesee.SetParameterValue("ECART", rp.Ecart);
                rptPesee.SetParameterValue("NONUSINABLE", rp.NonUsinable);
                rptPesee.SetParameterValue("DECHETS", rp.Dechets);
                rptPesee.SetParameterValue("NETMP", rp.Net);
                rptPesee.SetParameterValue("typeTare", rp.TypeTare);
                rptPesee.SetParameterValue("operateur", rp.Operateur);
                //rptPesee.SaveAs(rp.PeseeN);
                string savePath = $"C:\\Users\\Hp\\Desktop\\{rp.PeseeN}.doc";
                rptPesee.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, savePath);

                //rptPesee.PrintToPrinter(1,false,1,1);
            }
            
            
        }
        private void valider_Click(object sender, EventArgs e)
        {
            if (buttonClicked.Equals("brut"))
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
                        if (prv != string.Empty)
                        {
                            prov.Name = prv;
                            prov.insert();
                            dt = prov.Select(prv);
                            data["prov_id"] = (int)dt.Rows[0]["prov_id"];
                        }
                        else
                        {
                            MessageBox.Show("provenance is empty");
                            return;
                        }
                    }
                    else
                    {
                        data["prov_id"] = (int)dt.Rows[0]["prov_id"];
                    }



                    //camion

                    dt = cam.Select(matricule);
                    if (dt.Rows.Count == 0)
                    {
                        if (matricule != string.Empty)
                        {
                            cam.Matricule = matricule;
                            cam.Insert();
                        }
                        else
                        {
                            MessageBox.Show("matricule is empty");
                            return;
                        }
                    }



                    // Fr_code

                    dt = for_code.Select(fr_code);
                    if (dt.Rows.Count == 0)
                    {
                        if (fr_code != string.Empty)
                        {
                            for_code.Code = fr_code;
                            for_code.Insert();
                        }
                        else
                        {
                            MessageBox.Show("Fournisseur code is empty");
                            return;
                        }
                    }



                    //fournisseur 

                    dt = fr.Select(fr_name);
                    if (dt.Rows.Count == 0)
                    {
                        if (fr_name != string.Empty && fr_code != string.Empty)
                        {
                            fr.Code = fr_code;
                            fr.Name = fr_name;
                            fr.Insert();
                            dt = fr.Select(fr_name);
                            data["fr_id"] = (int)dt.Rows[0]["fr_id"];
                        }
                        else
                        {
                            MessageBox.Show((fr_code == string.Empty) ? "Check Fournisseur Code!" : "Check Fournisseur Name!");
                            return;
                        }
                    }
                    else
                    {
                        data["fr_id"] = (int)dt.Rows[0]["fr_id"];
                    }






                    //acceuil

                    dt = acceuill.Select(acc);
                    if (dt.Rows.Count == 0)
                    {
                        if (acc != string.Empty)
                        {
                            acceuill.Name = acc;
                            acceuill.Insert();
                            dt = acceuill.Select(acc);
                            data["acc_id"] = (int)dt.Rows[0]["acc_id"];
                        }
                        else
                        {
                            MessageBox.Show("Acceuil is empty");
                            return;
                        }
                    }
                    else
                    {
                        data["acc_id"] = (int)dt.Rows[0]["acc_id"];
                    }


                    //destination

                    dt = desti.Select(dest);
                    if (dt.Rows.Count == 0)
                    {
                        if (dest != string.Empty)
                        {
                            desti.Name = dest;
                            desti.Insert();
                            dt = desti.Select(dest);
                            data["dest_id"] = (int)dt.Rows[0]["dest_id"];
                        }

                        else
                        {
                            MessageBox.Show("destination is empty");
                            return;
                        }
                    }
                    else
                    {
                        data["dest_id"] = (int)dt.Rows[0]["dest_id"];
                    }


                    //categorie

                    dt = cat.Select(cat_pr);
                    if (dt.Rows.Count == 0)
                    {
                        if (cat_pr != string.Empty)
                        {
                            cat.Name = cat_pr;
                            cat.Insert();
                            dt = cat.Select(cat_pr);
                            data["cat_id"] = (int)dt.Rows[0]["cat_id"];
                        }
                        else
                        {
                            MessageBox.Show("product categorie is empty");
                            return;
                        }
                    }
                    else
                    {
                        data["cat_id"] = (int)dt.Rows[0]["cat_id"];
                    }



                    //produit
                    if (pr1 != string.Empty)
                    {
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
                    }
                    else
                    {
                        MessageBox.Show("produit is empty");
                        return;
                    }




                    string prefix = $"{char.ToUpper(acc[0])}{char.ToUpper(type_pes[0])}{char.ToUpper(cat_pr[0])}";
                    //pesee


                    dt = p.Select_last(char.ToUpper(acc[0]));
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
                    p.TareAvecCaisse = tareAvecCaisse.Checked;
                    p.TareSansCaisse = tareSansCaisse.Checked;
                    p.Net = (p.Brut - (p.Tare + p.Dechets + p.PoidGlace + p.PoidCaisse + p.Ecart + (p.NbrPalette * 26)));
                    p.Insert();
                    int poid = (p.PoidCaisse * p.NbrCaisse) + (p.NbrPalette * 26);

                    ReportDetail rp = new ReportDetail()
                    {
                        PeseeN = p.Id,
                        TypeOperation = p.Type,
                        Operateur = p.Users.UserName,
                        Destination = destination.Text,
                        Provenance = prv,
                        Matricule = p.Matricule,
                        Produit = produit1.Text.ToUpper(),
                        Fournisseur = fr_name.ToUpper(),
                        Debut = p.DDebut + " " + p.HDebut,
                        Fin = p.DFin + " " + p.HFin,
                        Brut = p.Brut.ToString(),
                        Tare = p.Tare.ToString(),
                        PoidCaisPal = $"{poid}",
                        Ecart = p.Ecart.ToString(),
                        NonUsinable = p.NonUsinable.ToString(),
                        Dechets = p.Dechets.ToString(),
                        Net = p.Net.ToString(),
                        TypeTare = (tareAvecCaisse.Checked) ? " " : " "
                    };
                    Print(rp,"brut");
                    Clear();
                }
                else
                {

                    int bru = int.Parse(brutBox.Text.Trim());
                    int pglace = int.Parse(pGlace.Text.Trim());
                    int pcaisse = int.Parse(PoidCaisse.Text.Trim());
                    int nbrcaisse = int.Parse(nbreCaisse.Text.Trim());
                    int dech = int.Parse(dechets.Text.Trim());
                    int ecar = int.Parse(Ecart.Text.Trim());
                    int nusinable = int.Parse(nonUsinable.Text.Trim());
                    int nPalettes = int.Parse(nbrPalettes.Text.Trim());
                    string prov = provenance.Text;
                    string fr_name = fournisseurBox.Text;

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
                    p.TareAvecCaisse = tareAvecCaisse.Checked;
                    p.TareSansCaisse = tareSansCaisse.Checked;
                    p.Net = (p.Brut - (p.Tare + p.Dechets + p.PoidGlace + (p.PoidCaisse * p.PoidCaisse) + p.Ecart + (p.NbrPalette * 26)));

                    p.Update("tare");
                    int poid = (p.PoidCaisse * p.NbrCaisse) + (p.NbrPalette * 26);
                    ReportDetail rp = new ReportDetail()
                    {
                        PeseeN = p.Id.ToString(),
                        TypeOperation = dt.Rows[0]["type_pesee"].ToString(),
                        Operateur = p.Users.UserName,
                        Destination = destination.Text.Trim(),
                        Provenance = prov.ToString(),
                        Matricule = camion.Text,
                        Produit = produit1.Text.ToUpper(),
                        Fournisseur = fr_name,
                        Debut = Convert.ToDateTime(dt.Rows[0]["ddebut"]).ToString("dd/MM/yyyy") + " " + ((TimeSpan)dt.Rows[0]["hdebut"]).ToString(@"hh\:mm\:ss").ToString(),
                        Fin = p.DFin.ToString() + " " + p.HFin.ToString(),
                        Brut = p.Brut.ToString(),
                        Tare = p.Tare.ToString(),
                        PoidCaisPal = poid.ToString(),
                        Ecart = p.Ecart.ToString(),
                        NonUsinable = p.NonUsinable.ToString(),
                        Dechets = p.Dechets.ToString(),
                        Net = p.Net.ToString(),
                        TypeTare = tareAvecCaisse.Checked ? "Tare Avec Caisse" : "Tare Sans Caisse"
                    };
                    Print(rp,"");
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
                        if (prv != string.Empty)
                        {
                            prov.Name = prv;
                            prov.insert();
                            dt = prov.Select(prv);
                            data["prov_id"] = (int)dt.Rows[0]["prov_id"];
                        }
                        else
                        {
                            MessageBox.Show("provenance is empty");
                            return;
                        }
                    }
                    else
                    {
                        data["prov_id"] = (int)dt.Rows[0]["prov_id"];
                    }



                    //camion

                    dt = cam.Select(matricule);
                    if (dt.Rows.Count == 0)
                    {
                        if (matricule != string.Empty)
                        {
                            cam.Matricule = matricule;
                            cam.Insert();
                        }
                        else
                        {
                            MessageBox.Show("matricule is empty");
                            return;
                        }
                    }



                    // Fr_code

                    dt = for_code.Select(fr_code);
                    if (dt.Rows.Count == 0)
                    {
                        if (fr_code != string.Empty)
                        {
                            for_code.Code = fr_code;
                            for_code.Insert();
                        }
                        else
                        {
                            MessageBox.Show("Fournisseur code is empty");
                            return;
                        }
                    }



                    //fournisseur 

                    dt = fr.Select(fr_name);
                    if (dt.Rows.Count == 0)
                    {
                        if (fr_name != string.Empty && fr_code != string.Empty)
                        {
                            fr.Code = fr_code;
                            fr.Name = fr_name;
                            fr.Insert();
                            dt = fr.Select(fr_name);
                            data["fr_id"] = (int)dt.Rows[0]["fr_id"];
                        }
                        else
                        {
                            MessageBox.Show((fr_code == string.Empty) ? "Check Fournisseur Code!" : "Check Fournisseur Name!");
                            return;
                        }
                    }
                    else
                    {
                        data["fr_id"] = (int)dt.Rows[0]["fr_id"];
                    }






                    //acceuil

                    dt = acceuill.Select(acc);
                    if (dt.Rows.Count == 0)
                    {
                        if (acc != string.Empty)
                        {
                            acceuill.Name = acc;
                            acceuill.Insert();
                            dt = acceuill.Select(acc);
                            data["acc_id"] = (int)dt.Rows[0]["acc_id"];
                        }
                        else
                        {
                            MessageBox.Show("Acceuil is empty");
                            return;
                        }
                    }
                    else
                    {
                        data["acc_id"] = (int)dt.Rows[0]["acc_id"];
                    }


                    //destination

                    dt = desti.Select(dest);
                    if (dt.Rows.Count == 0)
                    {
                        if (dest != string.Empty)
                        {
                            desti.Name = dest;
                            desti.Insert();
                            dt = desti.Select(dest);
                            data["dest_id"] = (int)dt.Rows[0]["dest_id"];
                        }

                        else
                        {
                            MessageBox.Show("destination is empty");
                            return;
                        }
                    }
                    else
                    {
                        data["dest_id"] = (int)dt.Rows[0]["dest_id"];
                    }


                    //categorie

                    dt = cat.Select(cat_pr);
                    if (dt.Rows.Count == 0)
                    {
                        if (cat_pr != string.Empty)
                        {
                            cat.Name = cat_pr;
                            cat.Insert();
                            dt = cat.Select(cat_pr);
                            data["cat_id"] = (int)dt.Rows[0]["cat_id"];
                        }
                        else
                        {
                            MessageBox.Show("product categorie is empty");
                            return;
                        }
                    }
                    else
                    {
                        data["cat_id"] = (int)dt.Rows[0]["cat_id"];
                    }



                    //produit
                    if (pr1 != string.Empty)
                    {
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
                    }
                    else
                    {
                        MessageBox.Show("produit is empty");
                        return;
                    }





                    //pesee
                    string prefix = $"{char.ToUpper(acc[0])}{char.ToUpper(type_pes[0])}{char.ToUpper(cat_pr[0])}";
                    dt = p.Select_last(char.ToUpper(acc[0]));
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
                    p.TareAvecCaisse = tareAvecCaisse.Checked;
                    p.TareSansCaisse = tareSansCaisse.Checked;
                    p.Net = (p.Brut != 0) ? (p.Brut - (p.Tare + p.PoidGlace + (p.PoidCaisse * p.NbrCaisse) + p.Ecart + (p.NbrPalette * 26))) : 0;
                    p.Insert();
                    int poid = (p.PoidCaisse * p.NbrCaisse) + (p.NbrPalette * 26);

                    ReportDetail rp = new ReportDetail()
                    {
                        PeseeN = p.Id,
                        TypeOperation = p.Type,
                        Operateur = p.Users.UserName,
                        Destination = destination.Text,
                        Provenance = prv,
                        Matricule = p.Matricule,
                        Produit = produit1.Text.ToUpper(),
                        Fournisseur = fr_name.ToUpper(),
                        Debut = p.DDebut + " " + p.HDebut,
                        Fin = p.DFin + " " + p.HFin,
                        Brut = p.Brut.ToString(),
                        Tare = p.Tare.ToString(),
                        PoidCaisPal = $"{poid}",
                        Ecart = p.Ecart.ToString(),
                        NonUsinable = p.NonUsinable.ToString(),
                        Dechets = p.Dechets.ToString(),
                        Net = p.Net.ToString(),
                        TypeTare = (tareAvecCaisse.Checked) ? " " : " "
                    };
                    Print(rp,"tare");
                    Clear();

                }
                else
                {


                    int tar = int.Parse(tareBox.Text.Trim());
                    int pglace = int.Parse(pGlace.Text.Trim());
                    int pcaisse = int.Parse(PoidCaisse.Text.Trim());
                    int nbrcaisse = int.Parse(nbreCaisse.Text.Trim());
                    int dech = int.Parse(dechets.Text.Trim());
                    int ecar = int.Parse(Ecart.Text.Trim());
                    int nusinable = int.Parse(nonUsinable.Text.Trim());
                    int nPalettes = int.Parse(nbrPalettes.Text.Trim());
                    string prv = provenance.Text;
                    string fr_name = fournisseurBox.Text;


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
                    p.TareAvecCaisse = tareAvecCaisse.Checked;
                    p.TareSansCaisse = tareSansCaisse.Checked;
                    p.Net = (p.Brut - (p.Tare + p.Dechets + p.PoidGlace + (p.PoidCaisse * p.NbrCaisse) + p.Ecart + (p.NbrPalette * 26)));

                    p.Update("brut");

                    int poid = (p.PoidCaisse * p.NbrCaisse) + (p.NbrPalette * 26);
                    try
                    {
                        ReportDetail rp = new ReportDetail()
                        {
                            PeseeN = p.Id.ToString(),
                            TypeOperation = dt.Rows[0]["type_pesee"].ToString(),
                            Operateur = p.Users.UserName,
                            Destination = destination.Text.Trim(),
                            Provenance = prv.ToString(),
                            Matricule = camion.Text,
                            Produit = produit1.Text.ToUpper(),
                            Fournisseur = fr_name,
                            Debut = Convert.ToDateTime(dt.Rows[0]["ddebut"]).ToString("dd/MM/yyyy") + " " + ((TimeSpan)dt.Rows[0]["hdebut"]).ToString(@"hh\:mm\:ss").ToString(),
                            Fin = p.DFin.ToString() + " " + p.HFin.ToString(),
                            Brut = p.Brut.ToString(),
                            Tare = p.Tare.ToString(),
                            PoidCaisPal = poid.ToString(),
                            Ecart = p.Ecart.ToString(),
                            NonUsinable = p.NonUsinable.ToString(),
                            Dechets = p.Dechets.ToString(),
                            Net = p.Net.ToString(),
                            TypeTare = tareAvecCaisse.Checked ? "Tare Avec Caisse" : "Tare Sans Caisse"
                        };

                        Print(rp,"");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Clear();
                }
            }
            setEnabled(true);
            Clear();
            lst_load();
            tbl_inf_load();

        }




        private void pes_id_DropDown(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(myConnstring);
            SqlConnection conn = DbConnection.getConnection();
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT TOP 10 * FROM Pesee ORDER BY   CAST(    SUBSTRING( p_id,     CHARINDEX('-', p_id) + 1,     LEN(p_id) - CHARINDEX('-', p_id)   ) AS INT  ) DESC;";
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






        private void pes_id_SelectedValueChanged(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(myConnstring);
            SqlConnection conn = DbConnection.getConnection();
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

        private void annulerPesee_Click(object sender, EventArgs e)
        {
            if (tbl_inf.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int index = tbl_inf.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = tbl_inf.Rows[index];
            p.Id = selectedRow.Cells["NPesee"].Value.ToString();
            User user = new User();
            string password = PasswordInputBox.Show("Enter password:", "Password Prompt");
            if (password != null)
            {
                DataTable dt = user.Select();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (password.Equals((string)dt.Rows[i]["user_password"]))
                        {

                            p.Delete();
                            MessageBox.Show($"Pesee {p.Id} Deleted successfully");
                            tbl_inf_load();
                            break;
                        }
                        else
                        {

                            MessageBox.Show("Incorrect password" + dt.Rows[i]["password"]);
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No User Found.");
                }
            }

        }

        private void synthese_Click(object sender, EventArgs e)
        {
            SyntheseForm sf = new SyntheseForm();
            sf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tbl_inf_load();
            lst_load();
        }

        private void impremer_Click(object sender, EventArgs e)
        {

            try
            {
                DataRowView drv = lstPesee.SelectedItem as DataRowView;
                string p_id = drv["p_id"].ToString();
                //SqlConnection conn = new SqlConnection(myConnstring);
                SqlConnection conn = DbConnection.getConnection();
                DataTable dt = new DataTable();
                try
                {

                    string query = "SELECT p.*,d.dest_name,f.fr_name,pr.pr_name,prv.prov_name,usr.username FROM Pesee p JOIN Destination AS d ON d.dest_id=p.dest_id JOIN Fournisseur AS f ON f.fr_id=p.fr_id JOIN Produit AS pr ON pr.pr_id=p.pr_id JOIN Provenance AS prv ON prv.prov_id=p.prov_id JOIN Users AS usr ON usr.id=p.id_user WHERE p.p_id =@p_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@p_id", p_id);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);


                    int caipoi = ((int)dt.Rows[0]["nbr_caisse"]) * ((int)dt.Rows[0]["poid_caisse"]);
                    int poid = caipoi + ((int)dt.Rows[0]["nbr_palettes"]) * 26;
                    ReportDetail rp = new ReportDetail()
                    {
                        PeseeN = dt.Rows[0]["p_id"].ToString(),
                        Operateur = dt.Rows[0]["username"].ToString(),
                        TypeOperation = dt.Rows[0]["type_pesee"].ToString(),
                        Destination = dt.Rows[0]["dest_name"].ToString(),
                        Provenance = dt.Rows[0]["prov_name"].ToString(),
                        Produit = dt.Rows[0]["pr_name"].ToString(),
                        Matricule = dt.Rows[0]["matricule"].ToString(),
                        Fournisseur = dt.Rows[0]["fr_name"].ToString(),
                        Brut = dt.Rows[0]["brut"].ToString(),
                        Tare = dt.Rows[0]["tare"].ToString(),
                        Ecart = dt.Rows[0]["ecart"].ToString(),
                        NonUsinable = dt.Rows[0]["non_usinable"].ToString(),
                        Dechets = dt.Rows[0]["dechets"].ToString(),
                        Debut = dt.Rows[0]["ddebut"].ToString() + " " + dt.Rows[0]["hdebut"].ToString(),
                        Fin = dt.Rows[0]["dfin"].ToString() + " " + dt.Rows[0]["hfin"].ToString(),
                        TypeTare = ((bool)dt.Rows[0]["tare_avec_caisse"]) ? "Tare Avec Caisse" :((bool)dt.Rows[0]["tare_sans_caisse"]) ? "Tare Sans Caisse" :"",
                        PoidCaisPal = poid.ToString(),
                        Net = dt.Rows[0]["net"].ToString(),
                    };
                    Print(rp,"");

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No Item Selected");
            }

            
        }

        

        private void pes_id_TextUpdated(object sender, EventArgs e)
        {
            

            string keyword = pes_id.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                pes_id_DropDown(sender, e);
           
            }

            //using (SqlConnection conn = new SqlConnection(myConnstring))
            using (SqlConnection conn = DbConnection.getConnection())
            {
                string query = "SELECT * FROM Pesee WHERE p_id LIKE @p_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@p_id", "%" + keyword + "%");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    sda.Fill(dt);

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        pes_id.DataSource = dt;
                        pes_id.DisplayMember = "p_id";
                        pes_id.DroppedDown = true;
                        pes_id.Text = keyword;
                        pes_id.SelectionStart = pes_id.Text.Length;
                    }
                    else
                    {
                        pes_id.DroppedDown = false;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {

                    conn.Close();
                }
            }
        }


        

        private void camion_TextUpdated(object sender, EventArgs e)
        {
            

            string keyword = camion.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                camion_DropDown(sender, e);
             
            }

            //using (SqlConnection conn = new SqlConnection(myConnstring))
            using (SqlConnection conn = DbConnection.getConnection())
            {
                string query = "SELECT * FROM Camion WHERE matricule LIKE @matricule";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@matricule", "%" + keyword + "%");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    sda.Fill(dt);

                    if (dt != null && dt.Rows.Count > 0)
                    {

                        camion.DataSource = dt;
                        camion.DisplayMember = "matricule";
                        camion.DroppedDown = true;
                        camion.Text = keyword;
                        camion.SelectionStart = camion.Text.Length;
                    }
                    else
                    {
                        camion.DroppedDown = false;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: cam " + ex.Message);
                }
                finally
                {

                    conn.Close();
                }
            }
        }



        private void provenance_TextUpdated(object sender, EventArgs e)
        {
            

            string keyword = provenance.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                provenance_DropDown(sender, e);
               
            }

            //using (SqlConnection conn = new SqlConnection(myConnstring))
            using (SqlConnection conn = DbConnection.getConnection())
            {
                string query = "SELECT * FROM Provenance WHERE prov_name LIKE @prov_name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@prov_name", "%" + keyword + "%");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    sda.Fill(dt);

                    if (dt != null && dt.Rows.Count > 0)
                    {

                        provenance.DataSource = dt;
                        provenance.DisplayMember = "prov_name";
                        provenance.DroppedDown = true;
                        provenance.Text = keyword;
                        provenance.SelectionStart = provenance.Text.Length;
                    }
                    else
                    {
                        provenance.DroppedDown = false;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {

                    conn.Close();
                }
            }
        }


       

        private void fournisseurBox_TextUpdated(object sender, EventArgs e)
        {
            

            string keyword = fournisseurBox.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                fournisseurBox_DropDown(sender, e);
               
            }

            //using (SqlConnection conn = new SqlConnection(myConnstring))
            using (SqlConnection conn = DbConnection.getConnection())
            {
                string query = "SELECT * FROM Fournisseur WHERE fr_name LIKE @fr_name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fr_name", "%" + keyword + "%");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    sda.Fill(dt);

                    if (dt != null && dt.Rows.Count > 0)
                    {

                        fournisseurBox.DataSource = dt;
                        fournisseurBox.DisplayMember = "fr_name";
                        fournisseurBox.DroppedDown = true;
                        fournisseurBox.Text = keyword;
                        fournisseurBox.SelectionStart = fournisseurBox.Text.Length;
                    }
                    else
                    {
                        fournisseurBox.DroppedDown = false;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {

                    conn.Close();
                }
            }
        }


        private void produit1_TextUpdated(object sender, EventArgs e)
        {
            string cat = categorie.Text;

            string keyword = produit1.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                produit1_DropDown(sender, e);
               
            }
            string query;

            //using (SqlConnection conn = new SqlConnection(myConnstring))
            using (SqlConnection conn = DbConnection.getConnection())
            {
                if (cat == string.Empty)
                {
                    query = "SELECT * FROM Produit WHERE pr_name LIKE @pr_name";
                }
                else
                {
                    query = $"SELECT * FROM Produit WHERE pr_name LIKE @pr_name AND cat_id=(SELECT cat_id FROM Categorie WHERE cat_name=@cat_name)";
                }
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pr_name", "%" + keyword + "%");
                if (cat != string.Empty) cmd.Parameters.AddWithValue("@cat_name", cat);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    sda.Fill(dt);

                    if (dt != null && dt.Rows.Count > 0)
                    {

                        produit1.DataSource = dt;
                        produit1.DisplayMember = "pr_name";
                        produit1.DroppedDown = true;
                        produit1.Text = keyword; // Keep the current text
                        produit1.SelectionStart = produit1.Text.Length; // Move cursor to the end
                    }
                    else
                    {
                        produit1.DroppedDown = false;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {

                    conn.Close();
                }
            }
        }

       
    }
}
   

