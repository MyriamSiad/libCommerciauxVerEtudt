using libCommerciaux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestlibCommerciaux
{
    [TestClass]
    public class TestCalculRemboursementNuite
    {
        [TestMethod]
        public void calculMontantARembourserNuite()
        {
            // Test Nuités 
            Commercial c;
             NoteFrais f0;
             Nuite N0;
             c = new Commercial("Jean", "Dupond", 8, 'A');
             //Agir
             N0 = new Nuite(new DateTime(2022, 11, 12), c, 46, '2');
             //Auditer
             Assert.AreEqual(46, N0.getMontantARembourser());


        }


        [TestMethod]
        public void calculMontantARembourserNuite2()
        {
            // Test Nuités 
            Commercial c;
            NoteFrais f0;
            Nuite N0;
            c = new Commercial("Jean", "Dupond", 8, 'A');
            //Agir
            N0 = new Nuite(new DateTime(2022, 11, 12), c, 80, '3');
            //Auditer
            Assert.AreEqual(74.75, N0.getMontantARembourser());


        }






    }
}
