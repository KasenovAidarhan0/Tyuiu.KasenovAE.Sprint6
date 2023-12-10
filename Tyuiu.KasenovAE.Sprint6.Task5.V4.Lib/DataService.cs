using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KasenovAE.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            double[] res = new double[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                res[i] = Convert.ToDouble(lines[i]);
            }
            res = res.Where(val => val % 1 == 0).ToArray();
            return res;
        }
    }
}
