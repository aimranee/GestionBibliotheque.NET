using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.models
{
    internal abstract class Bibliotheque
    {
        public abstract Boolean ajouter(Ouvrage ouvrage);

        public abstract Boolean supprimer(Ouvrage ouvrage);

        public abstract Boolean modifier(Ouvrage ouvrage);

        public abstract String toString();

    }
}
