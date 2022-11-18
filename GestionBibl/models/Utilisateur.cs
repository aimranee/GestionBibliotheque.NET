using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.Model
{
    internal class Utilisateur
    {
        private int id;
        private string nom;
        private string prenom;
        private string cin;
        private string password;
        private static int count;
        private string[] row;

        public Utilisateur(string nom, string prenom, string cin, string password)
        {
            this.id = count++;
            this.nom = nom;
            this.prenom = prenom;
            this.cin = cin;
            this.password = password;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Cin { get => cin; set => cin = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
        public string[] Row { get => row; set => row = value; }
    }
}
