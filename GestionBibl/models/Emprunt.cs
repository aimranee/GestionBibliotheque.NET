using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.Model
{
    internal class Emprunt
    {
        private int ouvrageId;
        private int clientId;
        private string? dateEmprunt;
        private string? dateRendre;

        public string DateEmprunt { get => dateEmprunt; set => dateEmprunt = value; }
        public string DateRendre { get => dateRendre; set => dateRendre = value; }
        internal int OuvrageId { get => ouvrageId; set => ouvrageId = value; }
        internal int ClientId { get => clientId; set => clientId = value; }
    }
}
