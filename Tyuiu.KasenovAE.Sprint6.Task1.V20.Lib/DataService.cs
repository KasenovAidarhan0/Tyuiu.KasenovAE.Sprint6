using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KasenovAE.Sprint6.Task1.V20.Lib
{
    public class DataService : ISprint6Task1V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - Math.Sin(x);
                res[c] = Math.Round(y, 2);
                c++;
            }
            return res;
        }
    }
}
