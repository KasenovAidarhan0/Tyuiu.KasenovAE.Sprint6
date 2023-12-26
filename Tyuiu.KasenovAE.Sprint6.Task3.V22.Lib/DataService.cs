using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KasenovAE.Sprint6.Task3.V22.Lib
{
    public class DataService : ISprint6Task3V22
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] res = matrix;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (res[0, i] % 2 == 0)
                {
                    res[0, i] = 0;
                }
            }

            return res;
        }
    }
}
