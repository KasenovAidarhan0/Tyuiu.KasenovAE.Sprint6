using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint6.Task4.V11.Lib;

namespace Tyuiu.KasenovAE.Sprint6.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction_Test()
        {
            int start = -5;
            int stop = 5;
            var ds = new DataService();
            var res = ds.GetMassFunction(start, stop);
            var wait = new double[] { 20.36, 15.42, 10.99, 7.43, 4.33, 1.00, 0.00, -8.87, -13.03, -16.53, -19.60 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
