using GestionBibl.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.models
{
    internal class Cd :Ouvrage
    {
        string auteur;

        public Cd(string auteur, int stock, string cote, string titre, string type) :base(stock, titre, cote, type)
        {
            this.auteur = auteur;
        }

        public string Auteur { get => auteur; set => auteur = value; }

    }
}
