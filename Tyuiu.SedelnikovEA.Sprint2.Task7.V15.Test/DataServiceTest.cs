using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SedelnikovEA.Sprint2.Task7.V15.Lib;

namespace Tyuiu.SedelnikovEA.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точка (0, 1.5) находится строго внутри заштрихованной области
            double x = 0;
            double y = 1.5;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(true, res);
        }
    }
}
