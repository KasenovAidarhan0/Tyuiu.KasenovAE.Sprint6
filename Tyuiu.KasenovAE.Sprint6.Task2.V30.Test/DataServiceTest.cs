using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint6.Task2.V30.Lib;

namespace Tyuiu.KasenovAE.Sprint6.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-2, 2);
            double[] w = { -8, -2.62, 1.83, 4.49, 6.78 };
            CollectionAssert.AreEqual(w, res);
        }
    }
}
