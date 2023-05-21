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
    internal class Db
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
        

        public static void AddProd(Produit prod)
        {
            string sql = "INSERT INTO  produit  VALUES (NULL,@label_produit,@Produitfournisseur,@Produitprix,@quantite)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Produitfournisseur", MySqlDbType.VarChar).Value = prod.fournisseur;
            cmd.Parameters.Add("@Produitprix", MySqlDbType.VarChar).Value = prod.prix;
            cmd.Parameters.Add("@label_produit", MySqlDbType.VarChar).Value = prod.labelProduit;
            cmd.Parameters.Add("@quantite", MySqlDbType.VarChar).Value = prod.quantite;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouté avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du produit ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            conn.Close();

        }




        public static void UpdateProd(Produit prod,string id)
        {
            string sql = "UPDATE produit SET label_produit=@lbl_produit,prix_produit=@prix,quantite=@quantite,fou_produit=@fou_produit  WHERE id_produit=@idProd";
            //string sql = "UPDATE produit SET label_produit=latest,fou_produit = yannis,prix_produit=145 WHERE id_produit=8";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@prix", MySqlDbType.VarChar).Value = prod.prix;
            cmd.Parameters.Add("@idProd", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@lbl_produit", MySqlDbType.VarChar).Value = prod.labelProduit;
            cmd.Parameters.Add("@quantite", MySqlDbType.VarChar).Value = prod.quantite;
            cmd.Parameters.Add("@fou_produit", MySqlDbType.VarChar).Value = prod.fournisseur;
            string query = cmd.CommandText;
            foreach (MySqlParameter parameter in cmd.Parameters)
            {
                query = query.Replace(parameter.ParameterName, parameter.Value.ToString());
            }

            //MessageBox.Show("Requête : " + query);



            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produit mis à jour  avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour  du produit ! \n fournisseur: "+prod.fournisseur+"prix :"+prod.prix+"label +"+prod.labelProduit  + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            conn.Close();

        }

        public static string[] getFourOfProduct(int id)
        {
            string sql = "SELECT fou_produit FROM produit WHERE id_produit=@idProduit";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = null;
            cmd.Parameters.AddWithValue("@idProduit", id);
            List<string> result = new List<string>();


            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la récupération des résultats de la requête ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Voici la requete : \n" + sql, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            /*
             
             Le bloc finally est toujours exécuté, que l'exception soit levée ou non, sauf dans certains cas exceptionnels tels que la fermeture forcée de l'application ou l'arrêt du système.
             */
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                conn.Close();

            }

            return result.ToArray();
        }

        public static void DeleteProd(int id)
        {
            string sql = "DELETE FROM produit WHERE id_produit = @prod_id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@prod_id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produit Supprimé avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la suppression  du produit ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            conn.Close();

        }

        /// <summary>
        /// Fonction qui vérifie si un fournisseur existe dans la base de données 
        /// </summary>
        /// <param name="four">Correspond au nom du fournisseur</param>
        /// <returns>Le résultat de la requete sous forme de tableau</returns>

        public static string[] VerifFou(string four)
        {
            string sql = "SELECT * FROM fournisseurs WHERE label_fou=@four";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader= null;
            cmd.Parameters.AddWithValue("@four", four);
            List<string> result = new List<string>();
           
              
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                }
            }catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la récupération des résultats de la requête ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Voici la requete : \n" + sql, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            /*
             
             Le bloc finally est toujours exécuté, que l'exception soit levée ou non, sauf dans certains cas exceptionnels tels que la fermeture forcée de l'application ou l'arrêt du système.
             */
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
                conn.Close();

            }

            return result.ToArray();



        }

        public static void displayProduit(string query, DataGridView dgv)
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
