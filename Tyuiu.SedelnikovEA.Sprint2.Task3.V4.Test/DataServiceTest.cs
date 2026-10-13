using Tyuiu.SedelnikovEA.Sprint2.Task3.V4.Lib;

namespace Tyuiu.SedelnikovEA.Sprint2.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.Calculate(x);
            Assert.AreEqual(11, res);
        }
    }
}
