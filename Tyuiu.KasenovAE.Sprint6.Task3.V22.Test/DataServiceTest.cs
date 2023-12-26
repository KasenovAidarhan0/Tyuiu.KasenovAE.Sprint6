using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint6.Task3.V22.Lib;

namespace Tyuiu.KasenovAE.Sprint6.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            DataService ds = new DataService();
            int[,] input = { { 2, 0 }, { 2, 0 } };
            int[,] res = ds.Calculate(input);
            int[,] wait = { { 0, 0 }, { 2, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
