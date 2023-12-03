using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KasenovAE.Sprint6.Task1.V20.Lib;

namespace Tyuiu.KasenovAE.Sprint6.Task1.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                FindResult();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FindResult()
        {
            var ds = new DataService();
            int start = Convert.ToInt32(textBoxStartValue.Text);
            int stop = Convert.ToInt32(textBoxStopValue.Text);
            double[] res = ds.GetMassFunction(start, stop);
            string line;
            textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            textBoxResult.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
            textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            int c = 0;
            for (int i = start; i <= stop; i++)
            {
                line = String.Format("|{0,-10:d}|{1,-10:f2}|", i, res[c]);
                textBoxResult.AppendText(line + Environment.NewLine);
                c++;
            }
            textBoxResult.AppendText("+----------+----------+");
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-23-2 Касенов Айдархан Есенаевич", "Сообщение");
        }
    }
}
