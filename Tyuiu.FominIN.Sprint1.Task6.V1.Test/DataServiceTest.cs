using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FominIN.Sprint1.Task6.V1.Lib;

namespace Tyuiu.FominIN.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string value = "1";
            string res = ds.SymbolCode(value);
            string wait = "Символ: 1 Код: 49";
            Assert.AreEqual(wait, res);

        }
    }
}
