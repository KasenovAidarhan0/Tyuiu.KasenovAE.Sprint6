using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KasenovAE.Sprint6.Task6.V27.Lib
{
    public class DataService : ISprint6Task6V27
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            string[] arr = File.ReadAllText(path).Split(' ', '\n');
            foreach (string c in arr)
            {
                if (c.Contains('H'))
                {
                    res += c + ' ';
                }
            }
            res = res.Remove(res.Length - 1);
            return res;
        }
    }
}
