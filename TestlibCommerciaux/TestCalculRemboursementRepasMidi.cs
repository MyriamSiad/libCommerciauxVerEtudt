using libCommerciaux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestlibCommerciaux
{
    [TestClass]
    public class TestCalculRemboursementRepasMidi
    {
        [TestMethod]
        public void calculMontantARembourserRepasMidiTest()
        {

            // Test Repas Midi calculMontantARembourserMidi1Test
             Commercial c;
             NoteFrais f0;
             RepasMidi R0;
             c = new Commercial("Jean", "Dupond", 8, 'A');
             //Agir
             R0 = new RepasMidi(new DateTime(2022, 11, 12), c, 15);
             //Auditer
             Assert.AreEqual(15, R0.getMontantARembourser());
            

        }


        [TestMethod]
        public void calculMontantARembourserRepasMidiTest2()
        {

            // Test Repas Midi calculMontantARembourserMidi1Test
            Commercial c;
            NoteFrais f0;
            RepasMidi R0;
            c = new Commercial("Jean", "Dupond", 8, 'A');
            //Agir
            R0 = new RepasMidi(new DateTime(2022, 11, 12), c, 35);
            //Auditer
            Assert.AreEqual(25, R0.getMontantARembourser());


        }



    }
}
