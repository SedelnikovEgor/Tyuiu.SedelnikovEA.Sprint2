using System;
using Tyuiu.Sedelnikovea.Sprint2.Task6.V5.Lib;

namespace Tyuiu.Sedelnikovea.Sprint2.Task6.V5.Test
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
