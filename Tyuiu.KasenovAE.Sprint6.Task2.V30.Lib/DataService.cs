using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KasenovAE.Sprint6.Task2.V30.Lib
{
    public class DataService : ISprint6Task2V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[(stopValue - startValue) + 1];

            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = (5 * x + 2.5) / (Math.Sin(x) + 3.0) + 2 * x + Math.Cos(x);
                res[c] = Math.Round(y, 2);
                c++;
            }

            return res;
        }
    }
}
