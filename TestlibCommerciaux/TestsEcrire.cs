using libCommerciaux;

namespace TestlibCommerciaux
{
    [TestClass]
    public class TestsEcrire
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*
            Commercial c;
            NoteFrais f0, f1;
            c = new Commercial("Jean", "Dupond", 25, 'A');
        //Agir:

            f0 = new NoteFrais(new DateTime(2022, 11, 12), c);
            f1 = new NoteFrais(new DateTime(2022, 11, 15), c);

           
        //Auditer:

            Assert.AreEqual(2,c.getMesNoteFrais().Count);
        

        */

            // Arranger 
            ServiceCommercial sc = new ServiceCommercial();
            Commercial c0, c1;
            NoteFrais f0, f1, f2, f3, f4;
            c0 = new Commercial("Dupond","Jean",8,'A');
            c1 = new Commercial("Duval", "René", 6, 'A');

            sc.ajouterCommercial(c0);
            sc.ajouterCommercial(c1);

            f0 = new NoteFrais (new DateTime(2022,10,12),c0);
            f1 = new NoteFrais(new DateTime(2022, 10, 15), c0);
            f2 = new NoteFrais(new DateTime(2022, 10, 18), c1);
            f3 = new NoteFrais(new DateTime(2022, 10, 21), c1);

            f4 = new NoteFrais(new DateTime(2022, 10, 25), c1);

            //Agir 

            f1.setRembourse();
            f2.setRembourse();
            f3.setRembourse();

            

            //Auditer
            Assert.AreEqual(2,sc.nbFraisNonRembourses());
        
        }
    }
}