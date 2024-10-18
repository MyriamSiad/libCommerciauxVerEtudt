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
            /*   ServiceCommercial sc = new ServiceCommercial();
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
               Assert.AreEqual(2,sc.nbFraisNonRembourses());*/

            // Test transport 

            //Arranger

            /*
                Commercial c;
                NoteFrais f0;
                 FraisTransport T0;
                c = new Commercial("Jean", "Dupond", 8, 'A');
                //Agir
                T0 = new FraisTransport(new DateTime(2022, 11, 12), c, 250);
                //Auditer
                Assert.AreEqual(50, T0.getMontantARembourser());
            */

            // Test Repas Midi calculMontantARembourserMidi1Test
            /* Commercial c;
             NoteFrais f0;
             RepasMidi R0;
             c = new Commercial("Jean", "Dupond", 8, 'A');
             //Agir
             R0 = new RepasMidi(new DateTime(2022, 11, 12), c, 15);
             //Auditer
             Assert.AreEqual(15, R0.getMontantARembourser());
            */

            // Test Nuités 
            /* Commercial c;
             NoteFrais f0;
             Nuite N0;
             c = new Commercial("Jean", "Dupond", 8, 'A');
             //Agir
             N0 = new Nuite(new DateTime(2022, 11, 12), c, 46, '2');
             //Auditer
             Assert.AreEqual(46, N0.getMontantARembourser());*/

            /*  Commercial c;
              NoteFrais f0;
              Nuite N0;
              c = new Commercial("Jean", "Dupond", 8, 'A');
              //Agir
              N0 = new Nuite(new DateTime(2022, 11, 12), c, 80, '3');
              //Auditer
              Assert.AreEqual(74.75, N0.getMontantARembourser());*
            /*/



            // Test Cumul de frais remboursé ServiceCommercial sc; 
          /*  Commercial c1;
            ServiceCommercial sc;

            sc = new ServiceCommercial();
            c1 = new Commercial("Dupond", "Jean", 7, 'B');
            sc.ajouterCommercial(c1);
            sc.ajouterNote(c1, new DateTime(2013, 11, 15), 100);      // ajoute un frais de transport 
            sc.ajouterNote(c1, new DateTime(2013, 11, 21), 15.5);     // ajoute une note de repas 
            sc.ajouterNote(c1, new DateTime(2013, 11, 25), 105, '2');  // ajoute une nuité 
            Console.WriteLine($"il y a {sc.nbFraisNonRembourses()} frais non remboursés");
          */





        }
    }
}