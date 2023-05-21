using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionStock
{
    internal class DbFour
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;username=root;password=;database=gestion_stock";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mysql Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }


        public static void AddFour(fournisseur four)
        {
            string sql = "INSERT INTO  fournisseurs(reference_fou,label_fou)  VALUES (@ref_fou,@label_fou)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ref_fou", MySqlDbType.VarChar).Value = four.four_ref;
            cmd.Parameters.Add("@label_fou", MySqlDbType.VarChar).Value = four.four_name;

            string query = cmd.CommandText;
            foreach (MySqlParameter parameter in cmd.Parameters)
            {
                query = query.Replace(parameter.ParameterName, parameter.Value.ToString());
            }



            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouté avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du fournisseur ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            conn.Close();

        }




        public static void UpdateFou(fournisseur four, string id)
        {
            string sql = "UPDATE fournisseurs SET reference_fou=@ref,label_fou = @label WHERE id_fou=@ActualId";
            
            //string sql = "UPDATE produit SET label_produit=latest,fou_produit = yannis,prix_produit=145 WHERE id_produit=8";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@label", MySqlDbType.VarChar).Value = four.four_name;
            cmd.Parameters.Add("@ref", MySqlDbType.VarChar).Value = four.four_ref;
            cmd.Parameters.Add("@ActualId", MySqlDbType.VarChar).Value = id;

            string query = cmd.CommandText;
            foreach (MySqlParameter parameter in cmd.Parameters)
            {
                query = query.Replace(parameter.ParameterName, parameter.Value.ToString());
            }

            //MessageBox.Show("Requête : " + query);




            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Les informations du fourniseur ont bien été mises à jour !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour  des informations du fournisseur !" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            conn.Close();

        }


        public static void DeleteFou(int idfou)
        {
            string sql = "DELETE FROM fournisseurs WHERE id_fou = @id_fou";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id_fou", MySqlDbType.VarChar).Value = idfou;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fournisseur Supprimé avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la suppression  du fournisseurs ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            conn.Close();

        }

        public static void DeleteProdWithFour(int idfour)
        {
            string sql = "DELETE FROM produit WHERE fou_produit = @id_fou";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id_fou", MySqlDbType.VarChar).Value = idfour;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produit liés au fournisseur supprimés", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la suppression  des produits liés au fournisseur ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            conn.Close();
        }

        public static void displayFournisseur(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();

        }

    }
}
