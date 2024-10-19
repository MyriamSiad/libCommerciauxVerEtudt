using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public Nuite(DateTime date, char region)
        {
            this.dateNoteFrais = date;
            this.region = region;
            this.setMontantARembourser();
            this.setFactureRembourser();
        }

        public Nuite(DateTime dateNoteFrais, double montantFacture) : base(dateNoteFrais, montantFacture)
        {
            this.montantFacture = montantFacture;
            this.dateNoteFrais = dateNoteFrais;


            this.setMontantARembourser();
            this.setFactureRembourser();
            numero++;
        }

        public Nuite(DateTime dateNoteFrais, double montantFacture, char region) : base(dateNoteFrais, montantFacture)
        {
            this.montantFacture = montantFacture;
            this.dateNoteFrais = dateNoteFrais;
            this.region = region;

            this.setMontantARembourser();
            this.setFactureRembourser();
            numero++;
        }

        public override double calculMontantARembourser()
        {
            double remboursement = 0.0;

            char categorie = this.getLeCommercial().getCategorie();
            char region = this.region;
            double plafond = 0.0;

            /////////////Catégorie A///////////////////
            ///

            //Catégorie A région 1 

            if (categorie == 'A' && region == '1')
            {
                plafond = 65 * 0.90;


                if (this.montantFacture < plafond)
                {
                    remboursement = this.montantFacture;

                }

                else
                {
                    
                    remboursement = plafond;
                }


            }



            //Catégorie A région 2 
            if (categorie == 'A' && region == '2'  || (categorie == 'A'))
            {
                plafond = 65;
                if (this.montantFacture >= plafond)
                {
                    remboursement = 65; // Région 2, coefficient 1 (pas de changement)
                }
                else
                {
                   

                    remboursement = this.montantFacture;
                }
            }



            //Catégorie A région 3 

            if (categorie == 'A' && region == '3')
            {
                plafond = 65 * 1.15;

                if ((this.montantFacture >= plafond))
                {
                    remboursement = plafond; // Région 3, coefficient 1.15
                }

                else
                {
                   
                    remboursement = this.montantFacture;
                }
            }





            ////////////// Catégorie B///////////////
            ///

            /// Catégorie B région 1


            if (categorie == 'B' && (region == '1'))
            {
                plafond = 55 * 0.90;


                if ((this.montantFacture >= plafond))
                {
                    remboursement = plafond;
                }

                else
                {
                    
                    remboursement = this.montantFacture;

                }


            }


            /// Catégorie B région 2

            if (categorie == 'B' && region == '2')
            {
                plafond = 55;
                if (this.montantFacture >= plafond)
                {

                    remboursement = plafond;
                }
                else
                {
                  
                    remboursement = this.montantFacture;
                }
            }


            /// Catégorie B région 3

            if (categorie == 'B' && region == '3')
            {
                plafond = 55 * 1.15;

                if (this.montantFacture >= plafond)
                {

                    remboursement = plafond;
                }
                else
                {
                    
                    remboursement = this.montantFacture;
                }
            }




        //////////////// // Catégorie C //////////////
           

            ////// Catégorie C region 1
            if (categorie == 'C' && region == '1')
            {
                plafond = 50 * 0.90;
                if (this.montantFacture >= plafond)
                {

                    remboursement = plafond;
                }
                else
                {
                    
                    remboursement = this.montantFacture;
                }


            }


            // Categorie C region 2 

            if (categorie == 'C' && region == '2')
            {
                plafond = 50;
                if (this.montantFacture >= plafond)
                {

                    remboursement = plafond;
                }
                else
                {
                  
                    remboursement = this.montantFacture;
                }


            }

            // Categorie C region 3

            if (categorie == 'C' && region == '3')
            {

                plafond = 50 * 1.15;
                if (this.montantFacture >= plafond)
                {

                    remboursement = plafond;
                }
                else
                {
                   
                    remboursement = this.montantFacture;
                }

            }

            return remboursement;
        }



        /// <summary>
        /// //Facture remboursé si le montant de la facture est totalement remboursé 
        /// </summary>

       

        /// Construscteur 

        public Nuite(DateTime date, Commercial C, double montantFacture, char region) : base(date, C)
        {
            this.montantFacture = montantFacture;
            this.region = region;

            this.dateNoteFrais = date;
            this.numero++;
           this.setMontantARembourser();
            this.setFactureRembourser();
        }


        public void setFactureRembourser()
        {
            if (calculMontantARembourser() == montantFacture)
            {
                this.setRembourse();
            }
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
