using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.models
{
    internal class Livre : Ouvrage
    {
        private string auteur;
        private string editeur;

        public Livre(int stock, string cote, string auteur, string titre, string editeur, string type) : base(stock, cote, titre, type)
        {
            this.auteur = auteur;
            this.editeur = editeur;
        }

        public string Auteur { get => auteur; set => auteur = value; }
        public string Editeur { get => editeur; set => editeur = value; }
    }
}
