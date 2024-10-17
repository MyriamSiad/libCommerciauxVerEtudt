using libCommerciaux;
using System.Numerics;
namespace _1er_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Commercial c;
            c = new Commercial("Jean", "Dupond", 25, 'A');
            NoteFrais f0;
            f0 = new NoteFrais(new DateTime(2022, 11, 12), c);


            //Arranger
            string  attendu = "Nom : Jean Prénom : Dupond Puissance voiture : 25 Categorie : A";
           

            // Agir 

            string actuel = c.ToString();


           
            //Assert
           Assert.AreEqual(attendu, actuel, "Ils sont pas égaux !");

        }
    }
}