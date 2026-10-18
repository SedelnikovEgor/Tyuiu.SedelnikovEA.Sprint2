using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SedelnikovEA.Sprint2.Task5.V5.Lib;

namespace Tyuiu.SedelnikovEA.Sprint2.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardValue()
        {
            DataService ds = new DataService();
            int k = 11;

            string res = ds.FindCardValue(k);

            Assert.AreEqual("валет", res);
        }
    }
}