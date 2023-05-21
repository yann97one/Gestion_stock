using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionStock
{
   
    internal class fournisseur
    {
        public string four_name { get; set; }
        public string four_ref { get; set; }
        public int four_id { get; set; }

      
       public fournisseur(string label_four,string four_ref)
        {
            this.four_ref = four_ref;
            this.four_name = label_four;    
        }
    }
}

/*
 *       internal class Produit
    {
        public string fournisseur { get; set; }
        public int prix { get; set; }

        public string labelProduit { get; set; }
        public int id { get; set; }

        public Produit(string fournisseur, int prix,  string labelProduit, int id = 0)
        {
            this.fournisseur = fournisseur;
            this.prix = prix;
            this.id = id;
            this.labelProduit = labelProduit;
        }
    }
 
 
 
 
 */
