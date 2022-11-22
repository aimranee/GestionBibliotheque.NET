using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.models
{
    internal class Ouvrage
    {
        private int id;
        private int stock;
        private string cote;
        private string titre;
        private string type;

        public Ouvrage(int stock, string cote, string titre, string type)
        {
            this.type = type;
            this.stock = stock;
            this.cote = cote;
            this.titre = titre;
        }

        public int Id { get => id; set => id = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Cote { get => cote; set => cote = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Type { get => type; set => type = value; }
    }
}
