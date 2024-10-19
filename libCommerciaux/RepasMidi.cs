using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public class RepasMidi : NoteFrais
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
            char categorie = this.getLeCommercial().getCategorie();
            double montant = this.montantFacture;
            double plafond = 0.0;
            double remboursement = 0.0;
            if (categorie == 'A')
            {
                plafond = 25;

                if (montant >= plafond)
                {
                    remboursement = plafond;
                }


                else
                {

                    remboursement = montant;

                }

            }

            if (categorie == 'B')
            {
                plafond = 22;
                if (montant >= plafond)
                {
                    remboursement = plafond;
                }


                else
                {

                    remboursement = montant;
                   

                }
            }



            if (categorie == 'C')
            {
                plafond = 20;
                if (montant >= plafond)
                {
                    remboursement = plafond;
                }


                else
                {
             
                    remboursement = montant;

                }

            }
           
            return remboursement;

        }

        public void setFactureRembourser()
        {
            if (calculMontantARembourser() == montantFacture)
            {
                this.setRembourse();
            }
        }

        public RepasMidi(DateTime dateNoteFrais, Commercial leCommercial, double montantFacture) : base(dateNoteFrais, leCommercial) // Appel au constructeur de la classe de base
        {
            this.dateNoteFrais = dateNoteFrais;
            this.numero++;
            this.montantFacture = montantFacture;
            this.setMontantARembourser(); // Si 'setMontantARembourser' est une méthode à appeler dans le constructeur
            this.setFactureRembourser();
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
