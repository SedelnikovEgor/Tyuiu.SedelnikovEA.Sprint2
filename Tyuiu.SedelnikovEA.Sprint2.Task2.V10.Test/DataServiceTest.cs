using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SedelnikovEA.Sprint2.Task2.V10.Lib;

namespace Tyuiu.SedelnikovEA.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 14;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}