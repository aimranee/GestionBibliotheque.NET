using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.Model
{
    internal class Ouvrage
    {
        private int id;
        private int stock;
        private int cote;
        private static int count;

        public Ouvrage(int id, int stock, int cote) : this(id, stock)
        {
            this.cote = cote;
        }

        public Ouvrage(int stock, int cote)
        {
            id = count++;
            this.stock = stock;
            this.cote = cote;
        }

        public int Stock { get => stock; set => stock = value; }
        public int Cote { get => cote; set => cote = value; }
        public int Id { get => id; set => id = value; }

        public string toString()
        {
            return "";
        }
    }
}
