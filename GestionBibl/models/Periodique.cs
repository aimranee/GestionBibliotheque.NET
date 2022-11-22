using GestionBibl.models;
using Org.BouncyCastle.Asn1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.models
{
    internal class Periodique:Ouvrage
    {
       int nump;
       int periodicite;

        public Periodique(int numeroP, int periodicite, int stock, string cote, string titre, string type):base(stock, cote, titre, type)
        {
            this.nump = numeroP;
            this.Periodicite = periodicite;
        }

        public int Nump { get => nump; set => nump = value; }
        public int Periodicite { get => periodicite; set => periodicite = value; }

    }
}
