
namespace Tyuiu.KasenovAE.Sprint6.Task5.V4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums = new System.Windows.Forms.DataGridView();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTask.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.groupBoxTask);
            this.panelTask.Controls.Add(this.buttonOpenFile);
            this.panelTask.Controls.Add(this.buttonHelp);
            this.panelTask.Controls.Add(this.buttonDone);
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask.Location = new System.Drawing.Point(0, 0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(699, 80);
            this.panelTask.TabIndex = 0;
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.groupBoxResult);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult.Location = new System.Drawing.Point(0, 80);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(194, 381);
            this.panelResult.TabIndex = 1;
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.chartData);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(194, 80);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(505, 381);
            this.panelChart.TabIndex = 2;
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone.Location = new System.Drawing.Point(450, 12);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 56);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Location = new System.Drawing.Point(612, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 56);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile.Location = new System.Drawing.Point(531, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 56);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(431, 56);
            this.groupBoxTask.TabIndex = 3;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(425, 37);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести в DataGridView. Вывести в" +
    "се целые числа.. Построить диаграмму по этим значениям.\r\n\r\n";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.dataGridViewNums);
            this.groupBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(194, 381);
            this.groupBoxResult.TabIndex = 0;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных:";
            // 
            // dataGridViewNums
            // 
            this.dataGridViewNums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNums.Name = "dataGridViewNums";
            this.dataGridViewNums.Size = new System.Drawing.Size(188, 362);
            this.dataGridViewNums.TabIndex = 0;
            // 
            // chartData
            // 
            chartArea4.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea4);
            this.chartData.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartData.Legends.Add(legend4);
            this.chartData.Location = new System.Drawing.Point(0, 0);
            this.chartData.Name = "chartData";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartData.Series.Add(series4);
            this.chartData.Size = new System.Drawing.Size(505, 381);
            this.chartData.TabIndex = 0;
            this.chartData.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 461);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelTask);
            this.MinimumSize = new System.Drawing.Size(715, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 4 | Касенов А. Е.";
            this.panelTask.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.DataGridView dataGridViewNums;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
    }
}

