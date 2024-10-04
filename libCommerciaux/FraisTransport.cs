using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public class FraisTransport:NoteFrais
    {

        //private string fraisTransports;
        private Commercial c;
        private DateTime dateNoteFrais;
        private int nbKm;


        public FraisTransport() 
        {
            
        }
        public FraisTransport(DateTime dateNoteFrais,Commercial c, int nbKm)
        {
           
            this.c = c;

            dateNoteFrais = new DateTime(2023, 1, 1);
            this.nbKm = nbKm;
        }

    }
}
