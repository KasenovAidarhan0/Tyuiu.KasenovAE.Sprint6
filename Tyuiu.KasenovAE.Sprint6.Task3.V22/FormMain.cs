using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KasenovAE.Sprint6.Task3.V22.Lib;

namespace Tyuiu.KasenovAE.Sprint6.Task3.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            int[,] mtrx =
            {
                { 17 ,  0  ,19 , -8 , -1},
                {9  , 4 , -5 , 7 , 15 },
                {11 ,13 ,4,  -4 ,-14 },
                { 11 , 14 , 5, -15 , 16},
                { 2, -14 , -2 , 11  ,11}
            };
            DataService ds = new DataService();
            int[,] res = ds.Calculate(mtrx);

            dataGridViewInput.ColumnCount = mtrx.GetLength(1);
            dataGridViewInput.RowCount = mtrx.GetLength(0);

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    dataGridViewInput.Columns[i].Width = 25;
                    dataGridViewInput.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

            dataGridViewOutput.ColumnCount = res.GetLength(1);
            dataGridViewOutput.RowCount = res.GetLength(0);

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    dataGridViewOutput.Columns[i].Width = 25;
                    dataGridViewOutput.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
