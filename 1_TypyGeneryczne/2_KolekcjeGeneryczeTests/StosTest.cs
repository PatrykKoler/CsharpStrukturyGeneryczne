﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczeTests
{
    [TestClass]
    public class StosTest
    {
        [TestMethod]
        public void testPeek()
        {
            var stos = new Stack<int>();

            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);

            Assert.AreEqual(4, stos.Peek());
        }
        [TestMethod]
        public void testContains()
        {
            var stos = new Stack<int>();

            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);

            Assert.IsTrue(stos.Contains(3));
        }
        [TestMethod]
        public void testToArray()
        {
            var stos = new Stack<int>();

            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);


            var tablica = stos.ToArray();
            stos.Pop();

            Assert.AreEqual(4, tablica[0]);
            Assert.AreEqual(3, stos.Count);
        }
        [TestMethod]
        public void testClear()
        {
            var stos = new Stack<int>();

            stos.Push(1);
            stos.Push(2);
            stos.Push(3);
            stos.Push(4);


            stos.Clear();

            Assert.AreEqual(0, stos.Count);
        }
    }
}
