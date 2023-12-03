
namespace Tyuiu.KasenovAE.Sprint6.Task1.V20
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelStopValue = new System.Windows.Forms.Label();
            this.labelStartValue = new System.Windows.Forms.Label();
            this.textBoxStopValue = new System.Windows.Forms.TextBox();
            this.textBoxStartValue = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(476, 217);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(463, 191);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в виде т" +
    "аблицы.";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(496, 13);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(212, 291);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(7, 19);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult.Location = new System.Drawing.Point(7, 38);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(199, 247);
            this.textBoxResult.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.labelStopValue);
            this.groupBoxInput.Controls.Add(this.labelStartValue);
            this.groupBoxInput.Controls.Add(this.textBoxStopValue);
            this.groupBoxInput.Controls.Add(this.textBoxStartValue);
            this.groupBoxInput.Location = new System.Drawing.Point(13, 237);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(264, 67);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // labelStopValue
            // 
            this.labelStopValue.AutoSize = true;
            this.labelStopValue.Location = new System.Drawing.Point(132, 22);
            this.labelStopValue.Name = "labelStopValue";
            this.labelStopValue.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue.TabIndex = 3;
            this.labelStopValue.Text = "Конец шага:";
            // 
            // labelStartValue
            // 
            this.labelStartValue.AutoSize = true;
            this.labelStartValue.Location = new System.Drawing.Point(7, 22);
            this.labelStartValue.Name = "labelStartValue";
            this.labelStartValue.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue.TabIndex = 2;
            this.labelStartValue.Text = "Старт шага:";
            // 
            // textBoxStopValue
            // 
            this.textBoxStopValue.Location = new System.Drawing.Point(132, 41);
            this.textBoxStopValue.Name = "textBoxStopValue";
            this.textBoxStopValue.Size = new System.Drawing.Size(126, 20);
            this.textBoxStopValue.TabIndex = 1;
            // 
            // textBoxStartValue
            // 
            this.textBoxStartValue.Location = new System.Drawing.Point(7, 41);
            this.textBoxStartValue.Name = "textBoxStartValue";
            this.textBoxStartValue.Size = new System.Drawing.Size(119, 20);
            this.textBoxStartValue.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonHelp.Location = new System.Drawing.Point(284, 237);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(87, 67);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone.Location = new System.Drawing.Point(377, 237);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(112, 67);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 316);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 20 | Касенов А. Е.";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxStopValue;
        private System.Windows.Forms.TextBox textBoxStartValue;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelStopValue;
        private System.Windows.Forms.Label labelStartValue;
    }
}

