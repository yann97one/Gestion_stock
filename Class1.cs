using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionStock
{
    internal class Fournisseur
    {
        public string label { get; set; }
        public string identifiant { get; set; }

        public Fournisseur(string label, string id)
        {
            this.label = label;
            this.identifiant = id; 
        }
    }
}
