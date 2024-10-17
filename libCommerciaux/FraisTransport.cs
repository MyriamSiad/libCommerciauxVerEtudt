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
        
        private int nbKm;
        private DateTime dateNoteFrais;
        private int  numero = 0;


        public FraisTransport() 
        {
            //dateNoteFrais = DateTime.Now;
        }

        public override double calculMontantARembourser()
        {
            double montant = this.getMontantARembourser();
            double remboursement = 0.0;
            if (this.getLeCommercial().getPuissanceVoiture() < 5) 
            {
               
                remboursement = (0.1 * this.nbKm) - montant;
                    
            }

            else if (this.getLeCommercial().getPuissanceVoiture() >= 5 && this.getLeCommercial().getPuissanceVoiture() <= 10)
            {
                remboursement = (0.2 * this.nbKm) - montant;
            }

            else
            {
                remboursement = (0.3* this.nbKm) - montant;
            }

            
            return remboursement;
        }

        public FraisTransport(DateTime dateNoteFrais, int nbKm) : base(dateNoteFrais, nbKm)
        {
            this.dateNoteFrais = dateNoteFrais;
            this.nbKm = nbKm;
            numero++;
            



        }
        /*  public FraisTransport(DateTime dateNoteFrais,Commercial c, int nbKm, double montant) : base (dateNoteFrais,c, montant)
            {
                this.dateNoteFrais= dateNoteFrais;

                this.c = c;


                this.nbKm = nbKm;
            }
        */
        public FraisTransport(DateTime dateNoteFrais, Commercial leCommercial, int nbKm)
           : base(dateNoteFrais, leCommercial) // Appel au constructeur de la classe de base
        {
            this.dateNoteFrais = dateNoteFrais ;
            this.nbKm = nbKm;
            this.numero++;
            this.setMontantARembourser(); // Si 'setMontantARembourser' est une méthode à appeler dans le constructeur
        }

        public override string ToString()
        {
            string flag = "Non remboursé";

            if (getEstRembourse() == true)
            {
                flag = "Est remboursé";
            }


            string str = $"Transport - Numéro : {this.numero} - Date : {this.dateNoteFrais} - Montant à rembourser: {this.getMontantARembourser()} euros - {flag} - {nbKm} km-";
            return str;
        }

    }
}
