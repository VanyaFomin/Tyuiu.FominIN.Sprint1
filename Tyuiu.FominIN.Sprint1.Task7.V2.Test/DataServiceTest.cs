using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FominIN.Sprint1.Task7.V2.Lib;

namespace Tyuiu.FominIN.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 30;
            double y = 60;
            double wait = 0.233858533120374;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
