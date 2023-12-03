using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint6.Task1.V20.Lib;

namespace Tyuiu.KasenovAE.Sprint6.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction_Test()
        {
            var ds = new DataService();
            var res = ds.GetMassFunction(-5, 5);
            var wait = new double[] { -27.22,
                                      -22.25,
                                      -16.66,
                                      -11.04,
                                       -6.13,
                                       -3.00,
                                        4.84,
                                        8.86,
                                       14.43,
                                       20.18,
                                       25.24};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
