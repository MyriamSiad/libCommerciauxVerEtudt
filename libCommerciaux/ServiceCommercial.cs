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
