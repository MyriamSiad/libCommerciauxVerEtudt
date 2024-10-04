using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public class NoteFrais
    {
        private DateTime dateNoteFrais;
        private Commercial leCommercial;
        private string NoteFraisType;
        private bool estRembourse = false ;
        private double montantARembourse = 0;
        private int numero = 0 ;
  


        public NoteFrais() { }

        public NoteFrais(DateTime date, Commercial c)
        {
            leCommercial = new Commercial();
            date = new DateTime(2023, 1, 1);


        }

        public NoteFrais(DateTime date,double montant )
        {
            //c = new Commercial();
            this.dateNoteFrais = date;


        }

        public NoteFrais(DateTime date, Commercial c, string NoteFaisType)
        {
            c = new Commercial();
            date = new DateTime();
            this.NoteFraisType = NoteFaisType;
        }

        public DateTime GetDate() { return dateNoteFrais; }

        public Commercial getLeCommercial() { return leCommercial; }

        public string getNoteFraisType() { return NoteFraisType; }

        public int getNumero() { return numero; }

        public void setRembourse(bool rembourse) { this.estRembourse = rembourse; }

        public double getMontantARembourser()
        { return montantARembourse; }

        public bool getEstRembourse() { return estRembourse = true; }

        public double calculMontantARembourser(double rembourser)
        {
            return rembourser - getMontantARembourser();

        }

        public void setMontantARembourser(double montantARembourser)
        {
            this.montantARembourse = montantARembourser;
        }

        

        public override string ToString()
        {
            string flag = "Non remboursé";
            if(getEstRembourse() == true)
            {
                flag = "Est remboursé";
            }
         
            
            string str = $"Numéro : {numero} - Date : {dateNoteFrais} - Montant à remboruser: {montantARembourse} euros -{flag}";
            return str;
        }

    }
}
