using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionStock
{
    internal class Produit
    {
        public string fournisseur { get; set; }
        public int prix { get; set; }
        public string quantite { get; set; }
        public string labelProduit { get; set; }
        public int id { get; set; }

        //constructeur de la classe 
        public Produit(string fournisseur, int prix,  string labelProduit,string quantite="",int id=0)
        {
            this.fournisseur = fournisseur;
            this.prix = prix;
            this.id = id;
            this.labelProduit = labelProduit;
            this.quantite = quantite;
        }
    }
}
