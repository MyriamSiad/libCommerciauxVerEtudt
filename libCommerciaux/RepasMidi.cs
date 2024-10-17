using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public  class RepasMidi:NoteFrais
    {
        private DateTime dateNoteFrais;
        private double montantFacture;
        private int numero = 0;

        public RepasMidi()
        {
           
            //dateNoteFrais = new DateTime();
        }


       public RepasMidi(DateTime date, double montantFacture)
        {
            this.dateNoteFrais = date;
           
            this.montantFacture = montantFacture;
            this.numero++;
        }
        public override double calculMontantARembourser()
        {
            double montant = this.getMontantARembourser();
            double remboursement = 0.0;
            if (this.getLeCommercial().getCategorie() == 'A' )
            {

                remboursement = 25;

            }

            else if (this.getLeCommercial().getCategorie() == 'B')
            {
                remboursement =  22 ;
            }

            else
            {
                if (this.getLeCommercial().getCategorie() == 'C')
                remboursement = 20;
            }


            return remboursement;
        }

        public RepasMidi(DateTime dateNoteFrais, Commercial leCommercial, double montantFacture) : base(dateNoteFrais, leCommercial) // Appel au constructeur de la classe de base
        {
           this.dateNoteFrais = dateNoteFrais;
            this.numero++;
           this.montantFacture=montantFacture;
           this.setMontantARembourser(); // Si 'setMontantARembourser' est une méthode à appeler dans le constructeur
        }


        public override string ToString()
        {
            string flag = "Non remboursé";

            if (getEstRembourse() == true)
            {
                flag = "Est remboursé";
            }


            string str = $"Repas - Numéro : {this.numero} - Date : {this.dateNoteFrais} - Montant à rembourser: {this.calculMontantARembourser()} euros - {flag} - payé : {montantFacture} €";
            return str;
        }



        //<Repas - Numéro : 1 - Date : 01/01/2023 00:00:00 - Montant à rembourser: 25 euros - Non remboursé - payé : 25,5 €>
    }
}
