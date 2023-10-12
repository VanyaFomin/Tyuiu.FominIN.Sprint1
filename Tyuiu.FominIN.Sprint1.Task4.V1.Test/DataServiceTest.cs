using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FominIN.Sprint1.Task4.V1.Lib;

namespace Tyuiu.FominIN.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 0.0625;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
