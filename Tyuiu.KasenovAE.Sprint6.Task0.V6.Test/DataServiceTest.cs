using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint6.Task0.V6.Lib;

namespace Tyuiu.KasenovAE.Sprint6.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 0.866;
            Assert.AreEqual(wait, res);
        }
    }
}
