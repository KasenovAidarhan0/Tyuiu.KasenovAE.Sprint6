
namespace Tyuiu.KasenovAE.Sprint6.Task7.V12
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelTask = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelButtons.SuspendLayout();
            this.panelTask.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonSaveFile);
            this.panelButtons.Controls.Add(this.buttonAbout);
            this.panelButtons.Controls.Add(this.buttonDone);
            this.panelButtons.Controls.Add(this.buttonOpenFile);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(784, 71);
            this.panelButtons.TabIndex = 0;
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.groupBoxTask);
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask.Location = new System.Drawing.Point(0, 71);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(784, 75);
            this.panelTask.TabIndex = 1;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.groupBoxInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput.Location = new System.Drawing.Point(0, 146);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(400, 265);
            this.panelInput.TabIndex = 2;
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.groupBoxOutput);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Location = new System.Drawing.Point(400, 146);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(384, 265);
            this.panelOutput.TabIndex = 3;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.Location = new System.Drawing.Point(3, 6);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(96, 62);
            this.buttonOpenFile.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonOpenFile, "Открыть файл\r\nОткрыть файл для обработки данных в формате CSV");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Enabled = false;
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.Location = new System.Drawing.Point(105, 6);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(96, 62);
            this.buttonDone.TabIndex = 1;
            this.toolTip.SetToolTip(this.buttonDone, "Выполнить\r\nВыплнить обработку данных");
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.Location = new System.Drawing.Point(685, 6);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(96, 62);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Enabled = false;
            this.buttonSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.Image")));
            this.buttonSaveFile.Location = new System.Drawing.Point(207, 6);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(96, 62);
            this.buttonSaveFile.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonSaveFile, "Сохранить в файл\r\nСохранить данные в формате CSV");
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(784, 75);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(778, 56);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxInput.Controls.Add(this.dataGridViewInput);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(400, 265);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод:";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.dataGridViewOutput);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(384, 265);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод:";
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.Size = new System.Drawing.Size(394, 246);
            this.dataGridViewInput.TabIndex = 0;
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.Size = new System.Drawing.Size(378, 246);
            this.dataGridViewOutput.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.panelButtons);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 12 | Касенов А. Е.";
            this.panelButtons.ResumeLayout(false);
            this.panelTask.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelOutput.ResumeLayout(false);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.DataGridView dataGridViewInput;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

