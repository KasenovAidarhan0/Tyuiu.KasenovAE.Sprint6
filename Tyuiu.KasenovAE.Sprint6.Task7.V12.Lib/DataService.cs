using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
using System.Diagnostics;

namespace Tyuiu.KasenovAE.Sprint6.Task7.V12.Lib
{
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            lines = lines.Where(val => (!string.IsNullOrEmpty(val))).ToArray();
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] res = new int[rows, columns];
            string[] line = new string[columns];
            Debug.WriteLine("Строки: {0}   Столбцы: {1}", rows, columns);

            for (int i = 0; i < rows; i++)
            {
                line = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    Debug.Write(line[j] + '\t');
                    int digit = Convert.ToInt32(line[j]);
                    if (j == 8 && digit != 10)
                        res[i, j] = 0;
                    else
                        res[i, j] = digit;
                }
                Debug.WriteLine('\n');
            }

            Debug.Write("END");

            return res;
        }
    }
}
