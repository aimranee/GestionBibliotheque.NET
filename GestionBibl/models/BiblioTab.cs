using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibl.models
{
    internal class BiblioTab : Bibliotheque
    {
        private Ouvrage[] ouvrage;
        private static int count;

        public BiblioTab(int cap)
        {
            this.ouvrage = new Ouvrage [cap];
        }

        public override bool ajouter(Ouvrage ouvrage)
        {
            try
            {
               this.ouvrage[count] = ouvrage;
               count++;
               return true;
            }
            catch
            {
                return false;
            }
        }

        public override bool supprimer(Ouvrage ouvrage)
        {
            try
            {
                for (int i=0; i<count; i++)
                {
                    if (this.ouvrage[i].Id == ouvrage.Id)
                    {
                        for (int j=i; j<count; j++)
                        {
                            this.ouvrage[j] = this.ouvrage[j++];
                            count--;
                            return true;
                        }
                        
                    }
                    
                }
                return false;
                
            }
            catch
            {
                return false;
            }
        }

        public override bool modifier(Ouvrage ouvrage)
        {
            try
            {
                for (int i=0; i<count; i++)
                {
                    if (this.ouvrage[i].Id == ouvrage.Id)
                    {
                        this.ouvrage[i].Stock = ouvrage.Stock;
                        this.ouvrage[i].Cote = ouvrage.Cote;
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public override string toString()
        {
            return "Nombre d'ouvrage est : "+count;
        }
    }
}
