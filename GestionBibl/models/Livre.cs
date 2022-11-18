using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.Model
{
    internal class Livre : Ouvrage
    {
        private string auteur;
        private string titre;
        private string editeur;

        public Livre(int stock, int cote, string auteur, string titre, string editeur) : base(stock, cote)
        {
            this.auteur = auteur;
            this.titre = titre;
            this.editeur = editeur;
        }

        public string Auteur { get => auteur; set => auteur = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Editeur { get => editeur; set => editeur = value; }
    }
}
