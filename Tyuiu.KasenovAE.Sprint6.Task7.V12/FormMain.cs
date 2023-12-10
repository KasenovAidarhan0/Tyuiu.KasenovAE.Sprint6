using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KasenovAE.Sprint6.Task7.V12.Lib;
using System.IO;
using System.Diagnostics;

namespace Tyuiu.KasenovAE.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        string path;

        private int[,] LoadData(string path)
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
                    res[i, j] = digit;
                }
                Debug.WriteLine('\n');
            }

            Debug.Write("END");

            return res;
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            path = openFileDialogTask.FileName;
            var arr = LoadData(path);
            int rows = arr.GetLength(0);
            int colums = arr.GetLength(1);
            dataGridViewInput.RowCount = rows;
            dataGridViewInput.ColumnCount = colums;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewInput.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewInput.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            var arr = ds.GetMatrix(path);
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            dataGridViewOutput.RowCount = rows;
            dataGridViewOutput.ColumnCount = columns;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutput.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
            buttonSaveFile.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "OutPutFileTask7.csv";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();

            string savePath = saveFileDialog.FileName;
            string str = "";

            int rows = dataGridViewOutput.RowCount;
            int columns = dataGridViewOutput.ColumnCount;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput.Rows[i].Cells[j].Value + ';';
                    }
                    else
                    {
                        str = str + dataGridViewOutput.Rows[i].Cells[j].Value;
                    }
                }
                str += '\n';
            }

            File.WriteAllText(savePath, str);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
