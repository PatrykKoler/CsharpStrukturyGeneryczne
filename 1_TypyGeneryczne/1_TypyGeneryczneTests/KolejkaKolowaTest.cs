using System;
using _1_TypyGeneryczne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_TypyGeneryczneTests
{
    [TestClass]
    public class KolejkaKolowaTest
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var kolejka = new KolejkaKolowa<double>();

            Assert.IsTrue(kolejka.JestPusty);
        }
        [TestMethod]
        public void KolejkaTrzyElementowaPoTrzechZapisach()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc : 3);
            kolejka.Zapisz(3.8);
            kolejka.Zapisz(5.8);
            kolejka.Zapisz(6.2);
            Assert.IsTrue(kolejka.JestPelny);
        }
        [TestMethod]
        public void PierwszyWchodziPierwszyWychodzi()
        {
            var kolejka = new KolejkaKolowa<string>(pojemnosc : 3);

            var wartosc = "4.6";
            var wartosc2 = "3.7";
            kolejka.Zapisz(wartosc);
            kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc, kolejka.Czytaj());
            Assert.AreEqual(wartosc2, kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }
        [TestMethod]
        public void NadpisywanieElementow()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            var wartosc = new[] { 1.2, 2.3, 3, 4, 5.2, 6.7 };

            foreach (var item in wartosc)
            {
                kolejka.Zapisz(item); 
            }
            
            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(wartosc[3], kolejka.Czytaj());
            Assert.AreEqual(wartosc[4], kolejka.Czytaj());
            Assert.AreEqual(wartosc[5], kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }
    }
}
