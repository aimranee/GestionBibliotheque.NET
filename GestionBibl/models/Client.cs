using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.models
{
    internal class Client
    {
        private int id;
        private string name;
        private string prenom;
        private string cin;
        private static int count;
        private string[] row;

        public string Name { get => name; set => name = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string CIN { get => cin; set => cin = value; }
        public int Id { get => id; set => id = value; }
        public string[] Row { get => row; set => row = value; }

        public Client(string name, string prenom, string cin)
        {
            this.name = name;
            this.prenom = prenom;
            this.cin = cin;
            id = count++;
            row = new string[] { id.ToString(), this.name, this.prenom, this.cin };
        }

    }
}
