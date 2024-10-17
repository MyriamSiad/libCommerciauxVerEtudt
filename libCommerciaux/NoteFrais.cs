using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public class NoteFrais
    {

        private DateTime dateNoteFrais = new DateTime(2023,1,1);
        private Commercial leCommercial = new Commercial();
        private string NoteFraisType;
      
        private bool estRembourse = false;
        private double montantARembourser = 0;
        private int numero = 0 ;
  


        public NoteFrais() {

         

        }

       public NoteFrais(DateTime date, Commercial c)
        {
            this.leCommercial = c;
            this.dateNoteFrais = date;
         
            c.ajouterNoteFrais(this);

            


        }

        public NoteFrais(DateTime date, Commercial c, double montant)
        {
            this.leCommercial = c;
            this.dateNoteFrais = date;

            c.ajouterNoteFrais(this);

            this.montantARembourser = montant;
           



        }

       public NoteFrais(DateTime date,double montant )
        {

            this.dateNoteFrais = date;
            leCommercial = new Commercial();
          


        }

        public NoteFrais(DateTime date, Commercial c, string NoteFaisType)
        {
            this.leCommercial = c;
            this.dateNoteFrais = date;
            this.NoteFraisType = NoteFaisType;
         
        }

        public DateTime GetDate() { return dateNoteFrais = new DateTime(); }

        public Commercial getLeCommercial() { return leCommercial; }

        public string getNoteFraisType() { return NoteFraisType; }

        public int getNumero() { return numero; }

        public void setRembourse() { this.estRembourse = true; }

        public double getMontantARembourser()
        { return montantARembourser; }

        public void setMontantARembourser( )
        {
           this.montantARembourser = calculMontantARembourser();
        }


        public bool getEstRembourse() 
        { return estRembourse;
        }

      



        public virtual double calculMontantARembourser() { return 0; }

        /*public virtual void setMontantARembourser(double montantARembourser)
        {
            this.montantARembourser = montantARembourser;
        }
        */
        

        public virtual string ToString()
        {
            string flag = "Non remboursé";

            if(getEstRembourse() == true)
            {
                flag = "Est remboursé";
            }
         
            
            string str = $"Numéro : {numero} - Date : {dateNoteFrais} - Montant à rembourser: {montantARembourser} euros - {flag}";
            return str;
        }

    }
}
