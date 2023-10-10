using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FominIN.Sprint1.Task2.V4.Lib;

namespace Tyuiu.FominIN.Sprint1.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            // Длина стороны квадрата 4
            DataService ds = new DataService();
            int x = 4;
            var res = ds.CalculateSquare(x);
            Assert.AreEqual(16, res);
        }
    }
}
