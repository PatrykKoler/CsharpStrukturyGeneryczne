using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczeTests
{
    [TestClass]
    public class ListaTests
    {
        [TestMethod]
        public void ListaMozemyDodawacNaKoniec()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            listaLiczb.Add(4);

            Assert.AreEqual(4, listaLiczb[3]);
        }
        [TestMethod]
        public void ListaMozemyDodacNaPozycji()
        {
            List<int> listaLiccz = new List<int> { 1, 2, 3 };

            listaLiccz.Insert(1, 8);

            Assert.AreEqual(8, listaLiccz[1]);
        }
        [TestMethod]
        public void ListaMozemyUsuwac()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            listaLiczb.Remove(2);

            Assert.IsTrue(listaLiczb.SequenceEqual(new[] { 1,3}));
        }
        [TestMethod]
        public void ListaMozemyUsuwacNaPozycji()
        {
            List<int> listaLiccz = new List<int> { 1, 2, 3 };

            listaLiccz.RemoveAt(2);

            Assert.IsTrue(listaLiccz.SequenceEqual(new[] { 1, 2 }));
        }
        [TestMethod]
        public void ListaMozemyWyszukiwacIndex()
        {
            List<int> listaLiccz = new List<int> { 1, 2, 3 };

            Assert.AreEqual(listaLiccz.IndexOf(3), 2);
        }
        public void ListaMozemyWyszukiwacCzyZawiera()
        {
            List<int> listaLiccz = new List<int> { 1, 2, 3 };

            Assert.IsTrue(listaLiccz.Contains(3));
        }
        [TestMethod]
        public void ListaMozemyDodawacNaKoniecZakresliczb()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            var zakres = new List<int> { 4, 5, 6 };
            listaLiczb.AddRange(zakres);

            Assert.AreEqual(6, listaLiczb[5]);
        }
    }
}
