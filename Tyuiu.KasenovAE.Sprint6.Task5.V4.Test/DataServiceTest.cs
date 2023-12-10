using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint6.Task5.V4.Lib;

namespace Tyuiu.KasenovAE.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_Test()
        {
            double[] w = new double[] { -1, 3, -1, -3, 0, -5, 6, 7, -7, 8, -8, -9, 10, -10, 0 };
            var ds = new DataService();
            string path = $@"C:\Users\kasen\source\repos\Tyuiu.KasenovAE.Sprint6\Tyuiu.KasenovAE.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";
            var r = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(w, r);
        }
    }
}
