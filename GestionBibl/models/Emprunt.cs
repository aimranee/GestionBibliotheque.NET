using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.models
{
    internal class Emprunt
    {
        private string ouvrageId;
        private string clientId;
        private string dateEmprunt;
        private string dateRendre;

        public string DateEmprunt { get => dateEmprunt; set => dateEmprunt = value; }
        public string DateRendre { get => dateRendre; set => dateRendre = value; }
        internal string OuvrageId { get => ouvrageId; set => ouvrageId = value; }
        internal string ClientId { get => clientId; set => clientId = value; }

        public Emprunt(string ouvrageId, string clientId, string dateEmprunt, string dateRendre)
        {
            this.ouvrageId = ouvrageId;
            this.clientId = clientId;
            this.dateEmprunt = dateEmprunt;
            this.dateRendre = dateRendre;
        }
    }
}
