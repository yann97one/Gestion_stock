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
    public partial class FormFournisseur : Form
    {
        private readonly Form2 _parent;
        public string id_fou, label_fou,ref_fou;
        
             
        public FormFournisseur(Form2 parent)
        {
            InitializeComponent();
            _parent = parent;
           
        }

       public void Clear()
        {
            four_name.Clear();
            four_ref.Clear();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(four_name.Text.Trim().Length < 3)
            {
                MessageBox.Show("Veuillez remplir le champs concernant le nom du fournisseur");
                return;
            }else if(four_ref.Text.Trim().Length < 3)
            {
                MessageBox.Show("Veuillez remplir le champs concernant l'identifiant du fournisseur");
                return;
            }else if(Db.VerifFou(four_name.Text.ToUpper()).Length != 0)
            {
                MessageBox.Show("Ce fournisseur existe déja dans la Base !");
                return;
            }
            if (submit.Text == "Enregistrer")
            {
                fournisseur four = new fournisseur(four_name.Text.Trim().ToUpper(), four_ref.Text.Trim());
                DbFour.AddFour(four);
                Clear();
                Close();
            }else if(submit.Text == "Mettre à jour")
            {
                fournisseur four = new fournisseur(four_name.Text.Trim().ToUpper(),four_ref.Text.Trim());  
                DbFour.UpdateFou(four, id_fou);
                
            }
            submit.Text = "Enregistrer";
            _parent.Display();

        }

        public void UpdateInfo()
        {
            lbl_formF.Text = "Changer les informations d'un fournisseur";
            submit.Text = "Mettre à jour";
            four_id.Text = "Fournisseur n° "+id_fou;
            four_ref.Text = ref_fou;
            four_name.Text = label_fou;
            

        }


        /*
         private void btn_save_Click(object sender, EventArgs e)
        {
            if (Product_Name.Text.Trim().Length < 3)
            {
                MessageBox.Show("Veuillez remplir le champs concernant le nom du produit");
                return;
            }
            if (Four_Product.Text.Trim().Length < 1)
            {
                MessageBox.Show("Veuillez remplir le champs concernant le fournisseur du produit");
                return;
            }
            if (!VerifyString(Price_Product.Text))
            {
                MessageBox.Show("Veuillez Mettre un entier !");
                return;
            }else if(Price_Product.Text.Trim().Length < 3)
            {
                MessageBox.Show("Veuillez remplir le champ du prix du produit !");
            }

            if(btn_save.Text == "Enregistrer")
            {
                int price = int.Parse(Price_Product.Text);
        Produit prod = new Produit(Four_Product.Text.Trim(), price, Product_Name.Text.Trim());
        Db.AddProd(prod);
                Clear();
        Close();
    }
            if(btn_save.Text == "Mettre à jour")
            {
                Produit produit = new Produit(Four_Product.Text.Trim(), int.Parse(Price_Product.Text), Product_Name.Text);
    Console.WriteLine("TEST: " + Four_Product.Text+Price_Product.Text+ProductName);
                Db.UpdateProd(produit, id);
            }
_parent.Display();
        }
         
         
         */
    }
}
