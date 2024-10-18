using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public class ServiceCommercial: Commercial
    {
        private List<Commercial> lesCommerciaux = new List<Commercial>();
        private List<NoteFrais> mesNotes = new List<NoteFrais>();

        public ServiceCommercial() 
        {
           
        }
        public ServiceCommercial(List<Commercial> lesCommerciaux) 
        {
            this.lesCommerciaux = lesCommerciaux;
        }
       public  void ajouterCommercial(Commercial unCommercial)
        {
            
            lesCommerciaux.Add(unCommercial);
        }

        //Frais Transport 
        public virtual void ajouterNote(Commercial c,DateTime date, int nbklm)
        {

            this.getMesNoteFrais().Add(new FraisTransport(date,c, nbklm));
            //this.getMesNoteFrais().Add(new FraisTransport(date, nbklm));
        }

        //Repas Midi
        public virtual void ajouterNote(Commercial c, DateTime date, double montantfacture)
        {

           // mesRepasMidi.Add(new RepasMidi(date, montantfacture));

            this.getMesNoteFrais().Add(new RepasMidi(date, c,montantfacture));
        }

        // Nuités 
        public virtual void ajouterNote(Commercial c, DateTime date, double montantFacture, char region)
        {

            this.getMesNoteFrais().Add(new Nuite(date, c, montantFacture, region));
        }

        public int nbFraisNonRembourses()
        {

            int i = 0;


            foreach (Commercial c  in lesCommerciaux)
            {
              foreach (NoteFrais n in c.getMesNoteFrais())

                if (n.getEstRembourse()== false)               {
                    i++;
                }
            }
            return i;
        }

       




    }
}
