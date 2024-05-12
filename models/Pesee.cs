using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace scale.models
{
    internal class Pesee
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public int FournisseurID { get; set; }
        virtual public Fournisseur Fournisseurs { get; set; }
        public int ProduitId { get; set; }
        virtual public Produit Produits { get; set; }
        public string Matricule { get; set; }
        virtual public Camion Camions { get; set; }

        public int AcceuilId { get; set; }
        virtual public Acceuil Acceuils { get; set; }
        public int ProvenanceId { get; set; }
        virtual public Provenance Provenances { get; set; }
        public int DestinationId { get; set; }

        virtual public Destination Destinations { get; set; }
        public int Brut { get; set; }
        public int Tare { get; set; }
        public int Dechets { get; set; }
        public int Net { get; set; }
        public int NbrCaisse { get; set; }
        public bool CaisseNormale { get; set; }
        public bool Plateaux { get; set; }
        public User Users { get; set; }
        public string DDebut { get; set; }
        public string HDebut { get; set; }
        public string DFin { get; set; }
        public string HFin { get; set; }
        public int NbrPalette { get; set; }
        public int PoidCaisse { get; set; }
        public int PoidGlace { get; set; }
        public int Ecart { get; set; }
        public int NonUsinable { get; set; }
        public bool IsFinished { get; set; }
        public bool TareAvecCaisse { get; set; }
        public bool TareSansCaisse { get; set; }

        static string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Pesee ORDER BY p_id DESC";
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
        public DataTable Select(string p_id)
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Pesee where p_id =@p_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@p_id", p_id);
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
            return dt;
        }
        public DataTable Select_last()
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT TOP 1 * FROM Pesee ORDER BY p_id DESC";
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
        public bool Insert()
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnstring);
            try
            {
               string query = "INSERT INTO Pesee(p_id,type_pesee,fr_id,pr_id,matricule,acc_id,prov_id,dest_id,brut,ddebut,hdebut,is_finished,tare,dechets,dfin,hfin,net,nbr_caisse,caisses_normales,plateaux,poid_caisse,nbr_palettes,poid_glace,ecart,non_usinable,id_user,tare_avec_caisse,tare_sans_caisse) VALUES(@p_id,@type_pesee,@fr_id,@pr_id,@matricule,@acc_id,@prov_id,@dest_id,@brut,@ddebut,@hdebut,@is_finished,@tare,@dechets,@dfin,@hfin,@net,@nbr_caisse,@caisses_normales,@plateaux,@poid_caisse,@nbr_palettes,@poid_glace,@ecart,@non_usinable,@id_user,@tare_avec_caisse,@tare_sans_caisse)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@p_id",Id);
                cmd.Parameters.AddWithValue("@type_pesee", Type);
                cmd.Parameters.AddWithValue("@fr_id",FournisseurID);
                cmd.Parameters.AddWithValue("@pr_id", ProduitId);
                cmd.Parameters.AddWithValue("@matricule", Matricule);
                cmd.Parameters.AddWithValue("@acc_id", AcceuilId);
                cmd.Parameters.AddWithValue("@prov_id", ProvenanceId);
                cmd.Parameters.AddWithValue("@dest_id", DestinationId);
                cmd.Parameters.AddWithValue("@brut", Brut);
                cmd.Parameters.AddWithValue("@ddebut", DDebut);
                cmd.Parameters.AddWithValue("@hdebut", HDebut);
                cmd.Parameters.AddWithValue("@tare", Tare);
                cmd.Parameters.AddWithValue("@is_finished", IsFinished);
                cmd.Parameters.AddWithValue("@dechets", Dechets);
                cmd.Parameters.AddWithValue("@dfin", (object)DFin ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@hfin", (object)HFin ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@net", Net);
                cmd.Parameters.AddWithValue("@nbr_caisse", NbrCaisse);
                cmd.Parameters.AddWithValue("@caisses_normales", CaisseNormale);
                cmd.Parameters.AddWithValue("@plateaux", Plateaux);
                cmd.Parameters.AddWithValue("@poid_caisse", PoidCaisse);
                cmd.Parameters.AddWithValue("@nbr_palettes", NbrPalette);
                cmd.Parameters.AddWithValue("@poid_glace", PoidGlace);
                cmd.Parameters.AddWithValue("@ecart", Ecart);
                cmd.Parameters.AddWithValue("@non_usinable", NonUsinable);
                cmd.Parameters.AddWithValue("@id_user", Users.Id);
                cmd.Parameters.AddWithValue("@tare_avec_caisse", TareAvecCaisse);
                cmd.Parameters.AddWithValue("@tare_sans_caisse", TareSansCaisse);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0) isSuccess = true;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Update(string type)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnstring);
            if (type.Equals("brut"))
            {

                try
                {
                    string query = "UPDATE Pesee SET tare=@tare,is_finished=@is_finished,dechets=@dechets,dfin=@dfin,hfin=@hfin,net=@net,nbr_caisse=@nbr_caisse,caisses_normales=@caisses_normales,plateaux=@plateaux,poid_caisse=@poid_caisse,nbr_palettes=@nbr_palettes,poid_glace=@poid_glace,ecart=@ecart,non_usinable=@non_usinable WHERE p_id=@p_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@p_id", Id);
                    cmd.Parameters.AddWithValue("@tare", Tare);
                    cmd.Parameters.AddWithValue("@is_finished", IsFinished);
                    cmd.Parameters.AddWithValue("@dechets", Dechets);
                    cmd.Parameters.AddWithValue("@dfin", DFin);
                    cmd.Parameters.AddWithValue("@hfin", HFin);
                    cmd.Parameters.AddWithValue("@net", Net);
                    cmd.Parameters.AddWithValue("@nbr_caisse", NbrCaisse);
                    cmd.Parameters.AddWithValue("@caisses_normales", CaisseNormale);
                    cmd.Parameters.AddWithValue("@plateaux", Plateaux);
                    cmd.Parameters.AddWithValue("@poid_caisse", PoidCaisse);
                    cmd.Parameters.AddWithValue("@nbr_palettes", NbrPalette);
                    cmd.Parameters.AddWithValue("@poid_glace", PoidGlace);
                    cmd.Parameters.AddWithValue("@ecart", Ecart);
                    cmd.Parameters.AddWithValue("@non_usinable", NonUsinable);
                    cmd.Parameters.AddWithValue("@tare_avec_caisse", TareAvecCaisse);
                    cmd.Parameters.AddWithValue("@tare_sans_caisse", TareSansCaisse);
                    conn.Open();
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0) isSuccess = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }else if (type.Equals("tare"))
            {
                try
                {
                    string query = "UPDATE Pesee SET brut=@brut,is_finished=@is_finished,dechets=@dechets,dfin=@dfin,hfin=@hfin,net=@net,nbr_caisse=@nbr_caisse,caisses_normales=@caisses_normales,plateaux=@plateaux,poid_caisse=@poid_caisse,nbr_palettes=@nbr_palettes,poid_glace=@poid_glace,ecart=@ecart,non_usinable=@non_usinable WHERE p_id=@p_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@p_id", Id);
                    cmd.Parameters.AddWithValue("@brut", Brut);
                    cmd.Parameters.AddWithValue("@is_finished", IsFinished);
                    cmd.Parameters.AddWithValue("@dechets", Dechets);
                    cmd.Parameters.AddWithValue("@dfin", DFin);
                    cmd.Parameters.AddWithValue("@hfin", HFin);
                    cmd.Parameters.AddWithValue("@net", Net);
                    cmd.Parameters.AddWithValue("@nbr_caisse", NbrCaisse);
                    cmd.Parameters.AddWithValue("@caisses_normales", CaisseNormale);
                    cmd.Parameters.AddWithValue("@plateaux", Plateaux);
                    cmd.Parameters.AddWithValue("@poid_caisse", PoidCaisse);
                    cmd.Parameters.AddWithValue("@nbr_palettes", NbrPalette);
                    cmd.Parameters.AddWithValue("@poid_glace", PoidGlace);
                    cmd.Parameters.AddWithValue("@ecart", Ecart);
                    cmd.Parameters.AddWithValue("@non_usinable", NonUsinable);
                   
                    conn.Open();
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0) isSuccess = true;
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
            return isSuccess;
        }

        public bool Delete()
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnstring);

            try
            {
                string query = "DELETE FROM Pesee WHERE p_id=@p_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@p_id", Id);
                conn.Open();
                if (cmd.ExecuteNonQuery()>0)
                {
                    isSuccess = true;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }finally { conn.Close(); }
            return isSuccess;
        }





    }
}
