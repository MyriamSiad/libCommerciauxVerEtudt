using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public class Nuite : NoteFrais
    {
        private double montantFacture;
        private char region;
        private DateTime dateNoteFrais;

        private int numero = 0;


        public Nuite() { }

        public Nuite (DateTime date,  char region)
        {
            this.dateNoteFrais = date;
            this.region = region;
        }

        public Nuite(DateTime dateNoteFrais, double montantFacture) : base(dateNoteFrais, montantFacture)
        {
            this.montantFacture = montantFacture;
            this.dateNoteFrais = dateNoteFrais;
           

            this.setMontantARembourser();
            numero++;
        }

        public Nuite(DateTime dateNoteFrais, double montantFacture, char region) : base(dateNoteFrais,montantFacture)
        {
            this.montantFacture = montantFacture;
            this.dateNoteFrais = dateNoteFrais;
            this.region=region;

            this.setMontantARembourser();
            numero++;
        }

        public override double calculMontantARembourser()
        {
            double remboursement = 0.0;

            char categorie = this.getLeCommercial().getCategorie();
            char region = this.region;

            // Catégorie A
            if (categorie == 'A' && region == '1')
            {

                remboursement = 65 * 0.90;
            }// Région 1, coefficient 0.90

            else if (categorie == 'A' && region =='2' || categorie == 'A')
            {
                if (this.montantFacture >= 65)
                {
                    remboursement = 65; // Région 2, coefficient 1 (pas de changement)
                }
                else
                {

                    remboursement = this.montantFacture;
                }
            }

            else
            {
                if (categorie == 'A' && region == '3')
                {
                    remboursement = 65 * 1.15; // Région 3, coefficient 1.15
                }

            }

                if (categorie == 'B' && (region == '1'))
                {

                    remboursement = 55 * 0.90;
                }

                else if (categorie == 'B' && region == '2')
                {
                    remboursement = 55;
                }
                else
                {
                    if (categorie == 'B' && region == '3')
                    {

                        remboursement = 55 * 1.15;
                    }
                }


                // Catégorie C
                if (categorie == 'C' && region == '1')
                {
                    remboursement = 50 * 0.90;

                }

                else if (categorie == 'C' && region == '2')
                {
                    remboursement = 50;
                }
                else
                {
                    if (categorie == 'C' && region == '3')
                    {
                        remboursement = 50 * 1.15;
                    }
                }
            

            return remboursement;
        }

        public Nuite(DateTime date, Commercial C, double montantFacture, char region) : base(date, C)
        {
            this.montantFacture = montantFacture;
            this.region = region;

            this.dateNoteFrais = date;
            this.numero++;
           this.setMontantARembourser();
        }

        public override string ToString()
        {
            string flag = "Non remboursé";

            if (getEstRembourse() == true)
            {
                flag = "Est remboursé";
            }

            string str = $"Nuité - Numéro : {this.numero} - Date : {this.dateNoteFrais} - Montant à rembourser: {this.calculMontantARembourser()} euros - {flag} - payé : {montantFacture} € - {this.getLeCommercial().getCategorie()} -";

            return str;

        }
    }
}
