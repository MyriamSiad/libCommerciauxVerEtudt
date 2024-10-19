using libCommerciaux;

namespace TestlibCommerciaux
{
    [TestClass]
    public class MesTests
    {
        [TestMethod]
        public void TestGetmesNoteFrais()
        {

            Commercial c;
            NoteFrais f0, f1;
            c = new Commercial("Jean", "Dupond", 25, 'A');
            //Agir:

            f0 = new NoteFrais(new DateTime(2022, 11, 12), c);
            f1 = new NoteFrais(new DateTime(2022, 11, 15), c);


            //Auditer:

            Assert.AreEqual(2, c.getMesNoteFrais().Count);


        }

        [TestMethod]
        public void NbFraisNonRembourses()
        {

            // Arranger 
            ServiceCommercial sc = new ServiceCommercial();
            Commercial c0, c1;
            NoteFrais f0, f1, f2, f3, f4;
            c0 = new Commercial("Dupond", "Jean", 8, 'A');
            c1 = new Commercial("Duval", "René", 6, 'A');

            sc.ajouterCommercial(c0);
            sc.ajouterCommercial(c1);

            f0 = new NoteFrais(new DateTime(2022, 10, 12), c0);
            f1 = new NoteFrais(new DateTime(2022, 10, 15), c0);
            f2 = new NoteFrais(new DateTime(2022, 10, 18), c1);
            f3 = new NoteFrais(new DateTime(2022, 10, 21), c1);

            f4 = new NoteFrais(new DateTime(2022, 10, 25), c1);

            //Agir 

            f1.setRembourse();
            f2.setRembourse();
            f3.setRembourse();



            //Auditer
            Assert.AreEqual(2, sc.nbFraisNonRembourses());



        }

        [TestMethod]
        public void AjoutNoteRepasMidi()
        {

         
            Commercial c1;
            c1 = new Commercial("Dupond", "Jean", 7, 'B');
            c1.ajouterNote(new DateTime(2013, 11, 15), 20);
            c1.ajouterNote(new DateTime(2013, 11, 15), 10);

            Assert.AreEqual(2, c1.getMesNoteFrais().Count());

        }


        [TestMethod]
        public void AjoutNoteTransport()
        {


            Commercial c1;
            c1 = new Commercial("Dupond", "Jean", 7, 'B');
            c1.ajouterNote(new DateTime(2013, 11, 15), 100);
            c1.ajouterNote(new DateTime(2013, 11, 15), 252);

            Assert.AreEqual(2, c1.getMesNoteFrais().Count());



        }


        [TestMethod]

        public void AjoutNoteNuite()
        {

            Commercial c1;
            c1 = new Commercial("Dupond", "Jean", 7, 'B');
            c1.ajouterNote(new DateTime(2013, 11, 25), 105, '2');
            c1.ajouterNote(new DateTime(2013, 11, 25), 205, '1');

            Assert.AreEqual(2, c1.getMesNoteFrais().Count());


        }



        [TestMethod]
        public void NbFraisNonRembourses2()
        {

            // Test Cumul de frais remboursé ServiceCommercial sc; 
            Commercial c1;
            ServiceCommercial sc;

            sc = new ServiceCommercial();
            c1 = new Commercial("Dupond", "Jean", 7, 'B');
            sc.ajouterCommercial(c1);
            sc.ajouterNote(c1, new DateTime(2013, 11, 15), 100);      // ajoute un frais de transport 
            sc.ajouterNote(c1, new DateTime(2013, 11, 21), 15.5);     // ajoute une note de repas 
            sc.ajouterNote(c1, new DateTime(2013, 11, 25), 105, '2');  // ajoute une nuité 
            Console.WriteLine($"il y a {sc.nbFraisNonRembourses()} frais non remboursés");


        }

    }
}
