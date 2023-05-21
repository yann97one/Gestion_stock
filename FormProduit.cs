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
    public partial class FormProduit : Form
    {
        private readonly Form2 _parent;
        FormFournisseur _fouForm;
        public string id, product_name, product_price,product_four,price, quantite_product;

        public FormProduit(Form2 parent,FormFournisseur fouForm)
        {
            InitializeComponent();
            _parent = parent;
            _fouForm = fouForm;
        }

      

        private void FormProduit_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Methode qui modifie le texte du bouton d'enregistrement elle servait à modifier le 
        /// Texte du bouton du formulaire des produit via la page principale 
        /// </summary>
        /// <param name="text">Correspond au texte du bouton</param>
        public void ModifyButton(string text)
        {
            btn_save.Text = text;
        }
        
        /// <summary>
        /// C'est une fonction qui vide tout les champs du formulaire
        /// </summary>
        public void Clear()
        {
            Product_Name.Clear();
            Four_Product.Clear();
            //Price_Product.Dispose();
            Price_Product.Clear();
            

        }
        /// <summary>
        /// C'est une fonction qui permet d'assigner les valeurs du fournisseur courant aux TextBox du formulaire 
        /// elle est utilisée que dans le cas d'une mise à jour !
        /// </summary>
        public void UpdateInfo()
        {
           
            
            btn_save.Text = "Mettre à jour";
            Product_Name.Text = product_name;
            Price_Product.Text =price;
            quantite_produit.Text = quantite_product;
            Product_id.Text = id;
            string[] fournisseur =  Db.getFourOfProduct(int.Parse(id));
            string fournisseursText = string.Join(", ",fournisseur );
            Four_Product.Text = fournisseursText ;



        }
        /// <summary>
        /// Ceci est une fonction qui vérifie si le texte mis en paramètre est un entier 
        /// </summary>
        /// <param name="input">Texte à vérifier</param>
        /// <returns>Retourne True si c'est un entier et False si ce n'est pas le cas</returns>
        public bool VerifyString(string input)
        {
            if(int.TryParse(input, out int value))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        /// <summary>
        /// Fonction qui s'active à l'évènement du bouton pour valider le formulaire
        /// </summary>
        /// <param name="sender">Emmetteur de l'evenement</param>
        /// <param name="e">arguments de l'evenement</param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            /*
             Ici on vérifie que tout les champs du formulaires soient correctement remplis
             */
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
            }else if(Price_Product.Text.Trim().Length < 2)
            {
                MessageBox.Show("Veuillez remplir le champ du prix du produit !");
                return;
            }
            
            string four = Four_Product.Text;
            string[] function = Db.VerifFou(four.ToUpper());

            if(function.Length == 0)
            {
                //MessageBox.Show("Voulez vous supprimer un produit ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                DialogResult result = MessageBox.Show("Ce fournisseur n'existe pas dans la base de données, voulez-vous l'ajouter ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    FormFournisseur formFour = new FormFournisseur(_parent);
                    formFour.ShowDialog();
                }
                else
                {
                    return;
                }
                

            }

            
            /*
             Ici nous vérifions d'abord si c'est une modification ou un ajout que l'utilisateur veut effectuer grâce au texte du bouton
            qui varie selon l'opération voulue...
             */
            if(btn_save.Text == "Enregistrer")
            {
                int price = int.Parse(Price_Product.Text);
               Produit prod = new Produit(Four_Product.Text.Trim(), price, Product_Name.Text.Trim(),quantite_produit.Text.Trim());
                Db.AddProd(prod);
                Clear();
                Close();
                _parent.Display();
                return;
            }
            if(btn_save.Text == "Mettre à jour")
            {
                Produit produit = new Produit(Four_Product.Text.Trim(), int.Parse(Price_Product.Text), Product_Name.Text, quantite_produit.Text);
                Db.UpdateProd(produit,id);
                _parent.Display();
            }
            btn_save.Text = "Enregistrer";
            //_parent.Display();
        }


    }
}
