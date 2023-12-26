using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KasenovAE.Sprint6.Task2.V30.Lib;

namespace Tyuiu.KasenovAE.Sprint6.Task2.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxStop.Text);
                DataService ds = new DataService();
                double[] res = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction.Titles.Add("График функции");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                int c = 0;
                for (int i = startValue; i <= stopValue; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(i), Convert.ToString(res[c]));
                    this.chartFunction.Series[0].Points.AddXY(i, res[c]);
                    c++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo form = new FormInfo();
            form.Show();
        }
    }
}
