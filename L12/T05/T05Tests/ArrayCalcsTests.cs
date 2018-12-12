using Microsoft.VisualStudio.TestTools.UnitTesting;
using T05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            ArrayCalcs laskuri = new ArrayCalcs();
            double[] luvut = { 1.0, 2.1, 3.2 };
            double expected = 6.3;


            double actual = ArrayCalcs.Sum(luvut);
            string expectedToString = String.Format("{0:0.0###########}", expected);
            string actualToString = String.Format("{0:0.0###########}", actual);
            Assert.AreEqual(expectedToString, actualToString);
        }
        [TestMethod()]
        public void AverageTest()
        {
            ArrayCalcs laskuri = new ArrayCalcs();
            double[] luvut = { 1.0, 2.1, 3.2 };
            double expected = 2.1;


            double actual = ArrayCalcs.Average(luvut);
            string expectedToString = String.Format("{0:0.0###########}", expected);
            string actualToString = String.Format("{0:0.0###########}", actual);
            Assert.AreEqual(expectedToString, actualToString);
        }

        [TestMethod()]
        public void MinTest()
        {
            ArrayCalcs laskuri = new ArrayCalcs();
            double[] luvut = { 4.0, 0.9, 3.2 };
            double expected = 0.9;


            double actual = ArrayCalcs.Min(luvut);
            string expectedToString = String.Format("{0:0.0###########}", expected);
            string actualToString = String.Format("{0:0.0###########}", actual);
            Assert.AreEqual(expectedToString, actualToString);
        }

        [TestMethod()]
        public void MaxTest()
        {
            ArrayCalcs laskuri = new ArrayCalcs();
            double[] luvut = { 4.0, 0.9, 3.2 };
            double expected = 4.0;


            double actual = ArrayCalcs.Max(luvut);
            string expectedToString = String.Format("{0:0.0###########}", expected);
            string actualToString = String.Format("{0:0.0###########}", actual);
            Assert.AreEqual(expectedToString, actualToString);
        }
    }
}