using libCommerciaux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestlibCommerciaux
{
    [TestClass]
    public  class TestCalculRemboursementTranport
    {
        [TestMethod]
        public void calculMontantARembourserTransportTest()
        {

            Commercial c;
            NoteFrais f0;
            FraisTransport T0;
            c = new Commercial("Jean", "Dupond", 8, 'A');
            //Agir
            T0 = new FraisTransport(new DateTime(2022, 11, 12), c, 250);
            //Auditer
            Assert.AreEqual(50, T0.getMontantARembourser());
        }



    }
}
