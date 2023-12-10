using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KasenovAE.Sprint6.Task5.V4.Lib;

namespace Tyuiu.KasenovAE.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = $@"C:\Users\kasen\source\repos\Tyuiu.KasenovAE.Sprint6\Tyuiu.KasenovAE.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width = 20;
            dataGridViewNums.Columns[1].Width = 50;

            chartData.ChartAreas[0].AxisX.Title = "Ось X";
            chartData.ChartAreas[0].AxisY.Title = "Ось Y";

            chartData.Series[0].Points.Clear();

            var arr = ds.LoadFromDataFile(path);

            for (int i = 0; i < arr.Length; i++)
            {
                dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(arr[i]));
                chartData.Series[0].Points.AddXY(i, arr[i]);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-2 Касенов Айдархан Есенаевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
