using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.Model
{
    internal class Emprunt
    {
        private Ouvrage ouvrageId;
        private Client clientId;
        private string dateEmprunt;
        private string dateRetoure;

        public string DateEmprunt { get => dateEmprunt; set => dateEmprunt = value; }
        public string DateRetoure { get => dateRetoure; set => dateRetoure = value; }
        internal Ouvrage OuvrageId { get => ouvrageId; set => ouvrageId = value; }
        internal Client ClientId { get => clientId; set => clientId = value; }
    }
}
