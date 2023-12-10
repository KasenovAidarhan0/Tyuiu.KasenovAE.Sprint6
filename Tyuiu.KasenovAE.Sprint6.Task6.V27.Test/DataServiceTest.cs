using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint6.Task6.V27.Lib;
using System.IO;

namespace Tyuiu.KasenovAE.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void test()
        {
            string path = $@"C:\Users\kasen\source\repos\Tyuiu.KasenovAE.Sprint6\Tyuiu.KasenovAE.Sprint6.Task6.V27\bin\Debug\InPutFileTask6V27.txt";
            bool a = File.Exists(path);
            bool w = true;
            Assert.AreEqual(w, a);
        }
    }
}
