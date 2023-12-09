using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KasenovAE.Sprint6.Task4.V11.Lib;
using System.IO;

namespace Tyuiu.KasenovAE.Sprint6.Task4.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            chartFunction.Titles.Add("График функции cos(x) + sin(x)/(2-2x) - 4x");
        }

        DataService ds = new DataService();
        private double[] Massive(int start, int stop)
        {
            var res = new double[stop - start + 1];
            res = ds.GetMassFunction(start, stop);
            return res;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                ReturnInTextBox();
                MakeGraph();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnInTextBox()
        {
            textBoxResult.Text = "";
            int start = Convert.ToInt32(textBoxStartValue.Text);
            int stop = Convert.ToInt32(textBoxStopValue.Text);
            var tab = Massive(start, stop);
            foreach (double a in tab)
            {
                string line = Convert.ToString(a);
                textBoxResult.Text += line + Environment.NewLine;
            }
        }

        private void MakeGraph()
        {
            int start = Convert.ToInt32(textBoxStartValue.Text);
            int stop = Convert.ToInt32(textBoxStopValue.Text);
            var tab = Massive(start, stop);
            
            chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
            chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction.Series[0].Points.Clear();
            foreach (double a in tab)
            {
                chartFunction.Series[0].Points.AddXY(start, a);
                start++;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask.txt";
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dialogReesult = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogReesult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 подготовил студент группы ПКТб-23-2 Касенов Айдархан Есенаевич", "Сообщение");
        }
    }
}
