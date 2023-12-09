using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KasenovAE.Sprint6.Task4.V11.Lib
{
    public class DataService : ISprint6Task4V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            var res = new double[stopValue - startValue + 1];
            double a;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (2-2*x == 0)
                {
                    res[c] = 0;
                    c++;
                    continue;
                }
                a = Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x;
                res[c] = Math.Round(a, 2);
                c++;
            }
            return res;
        }
    }
}
