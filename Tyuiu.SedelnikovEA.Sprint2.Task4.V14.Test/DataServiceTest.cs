using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SedelnikovEA.Sprint2.Task4.V14.Lib;

namespace Tyuiu.SedelnikovEA.Sprint2.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;

            var res = ds.Calculate(x, y);

            // Ожидаемый результат для x=2, y=3 равен 11.391
            Assert.AreEqual(11.391, res);
        }
    }
}