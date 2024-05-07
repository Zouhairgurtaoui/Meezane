﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

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

        static string myConnstring = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnstring);
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM Pesee";
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
               string query = "INSERT INTO Pesee(p_id,type_pesee,fr_id,pr_id,matricule,acc_id,prov_id,dest_id,brut,ddebut,hdebut,is_finished) VALUES(@p_id,@type_pesee,@fr_id,@pr_id,@matricule,@acc_id,@prov_id,@dest_id,@brut,@ddebut,@hdebut,@is_finished)";
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
                cmd.Parameters.AddWithValue("@is_finished", false);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0) isSuccess = true;
            }
            catch(Exception ex) { }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }





    }
}
