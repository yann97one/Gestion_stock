using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionStock
{
    public partial class Form2 : Form
    {
        FormProduit form;
        FormFournisseur formF;
        
        public Form2()
        {
            InitializeComponent();
            form = new FormProduit(this,formF);
            formF = new FormFournisseur(this);
            //productData.Columns["delete"].DisplayIndex = 101;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        /// <summary>
        ///Fonction qui permet d'afficher les produit et fournisseurs dans les DataGridViews
        /// </summary>
        public void Display()
        {
            Db.displayProduit("SELECT id_produit,label_produit,prix_produit,quantite FROM PRODUIT", productData);
            DbFour.displayFournisseur("SELECT id_fou,label_fou,reference_fou FROM fournisseurs", four_data);
        }
        
       

       
        private void button6_Click(object sender, EventArgs e)
        {
            formF.Clear();
            formF.ShowDialog();


        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            Display();
            
        }

       

        

        private void productData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Modifier
                form.Clear();
                System.Diagnostics.Debug.WriteLine(e.RowIndex);
                form.id = productData.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.product_name = productData.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.price = productData.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.quantite_product = productData.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                form.ModifyButton("Enregistrer");

                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Supprimmer
                if(MessageBox.Show("Voulez vous supprimer un produit ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes) {                     
                    Db.DeleteProd(int.Parse(productData.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    Display();
                }
                return;
            }
        }

       
        /// <summary>
        /// C'est une fonction qui s'active à l'évenement Cellclick on vérifie d'abord grâce au <paramref name="e"/> 'index' des column puis on agis en conséquence
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void four_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                
                //Modifier
                formF.Clear();
                formF.id_fou = four_data.Rows[e.RowIndex].Cells[2].Value.ToString();
                formF.label_fou = four_data.Rows[e.RowIndex].Cells[3].Value.ToString();
                formF.ref_fou = four_data.Rows[e.RowIndex ].Cells[4].Value.ToString();

                formF.UpdateInfo();
                formF.ShowDialog();

                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Supprimmer
                if (MessageBox.Show("Voulez vous supprimer un fournisseur ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    
                    //Db.DeleteProd(int.Parse(productData.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    DbFour.DeleteFou(int.Parse(four_data.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    Display();
                }
                return;
            }

        }

       

        private void AddProduct_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            formF.Clear();
            formF.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rd_price.Checked)
            {
                Db.displayProduit("SELECT id_produit,label_produit,prix_produit,quantite FROM PRODUIT WHERE prix_produit LIKE'%" + textBox1.Text + "%' ",productData);
            }else if (rd_qantite.Checked)
            {
                Db.displayProduit("SELECT id_produit,label_produit,prix_produit,quantite FROM PRODUIT WHERE quantite LIKE'%" + textBox1.Text + "%' ", productData);

            }
            else if(rd_nom.Checked)
            {
                Db.displayProduit("SELECT id_produit,label_produit,prix_produit,quantite FROM PRODUIT WHERE label_produit LIKE'%" + textBox1.Text + "%' ", productData);

            }

        }
    }
}
