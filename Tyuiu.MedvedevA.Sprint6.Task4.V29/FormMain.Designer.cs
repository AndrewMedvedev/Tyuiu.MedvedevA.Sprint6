
namespace Tyuiu.MedvedevA.Sprint6.Task4.V29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxUslovie_MA = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2Uslovie_MA = new System.Windows.Forms.Label();
            this.label1Uslovie_MA = new System.Windows.Forms.Label();
            this.labelUslovie_MA = new System.Windows.Forms.Label();
            this.groupBoxEnterDano_MA = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStopValue_MA = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_MA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSave_MA = new System.Windows.Forms.Button();
            this.buttonDane_MA = new System.Windows.Forms.Button();
            this.buttonHelp_MA = new System.Windows.Forms.Button();
            this.groupBoxOutResult_MA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MA = new System.Windows.Forms.TextBox();
            this.chartFunction_MA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxUslovie_MA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxEnterDano_MA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxOutResult_MA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_MA
            // 
            this.groupBoxUslovie_MA.Controls.Add(this.pictureBox1);
            this.groupBoxUslovie_MA.Controls.Add(this.label2Uslovie_MA);
            this.groupBoxUslovie_MA.Controls.Add(this.label1Uslovie_MA);
            this.groupBoxUslovie_MA.Controls.Add(this.labelUslovie_MA);
            this.groupBoxUslovie_MA.Location = new System.Drawing.Point(10, 11);
            this.groupBoxUslovie_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUslovie_MA.Name = "groupBoxUslovie_MA";
            this.groupBoxUslovie_MA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUslovie_MA.Size = new System.Drawing.Size(399, 115);
            this.groupBoxUslovie_MA.TabIndex = 0;
            this.groupBoxUslovie_MA.TabStop = false;
            this.groupBoxUslovie_MA.Text = "Условие";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2Uslovie_MA
            // 
            this.label2Uslovie_MA.AutoSize = true;
            this.label2Uslovie_MA.Location = new System.Drawing.Point(0, 44);
            this.label2Uslovie_MA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2Uslovie_MA.Name = "label2Uslovie_MA";
            this.label2Uslovie_MA.Size = new System.Drawing.Size(216, 13);
            this.label2Uslovie_MA.TabIndex = 1;
            this.label2Uslovie_MA.Text = "OutPutFileTak4V29.txt по нажатию кнопки";
            // 
            // label1Uslovie_MA
            // 
            this.label1Uslovie_MA.AutoSize = true;
            this.label1Uslovie_MA.Location = new System.Drawing.Point(0, 32);
            this.label1Uslovie_MA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1Uslovie_MA.Name = "label1Uslovie_MA";
            this.label1Uslovie_MA.Size = new System.Drawing.Size(400, 13);
            this.label1Uslovie_MA.TabIndex = 1;
            this.label1Uslovie_MA.Text = "Результат вывести в textBox, Построить график функции и сохранить файл в";
            // 
            // labelUslovie_MA
            // 
            this.labelUslovie_MA.AutoSize = true;
            this.labelUslovie_MA.Location = new System.Drawing.Point(0, 18);
            this.labelUslovie_MA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUslovie_MA.Name = "labelUslovie_MA";
            this.labelUslovie_MA.Size = new System.Drawing.Size(322, 13);
            this.labelUslovie_MA.TabIndex = 0;
            this.labelUslovie_MA.Text = "Протабулировать функцию на заданном диапазоне: от -5 до 5";
            // 
            // groupBoxEnterDano_MA
            // 
            this.groupBoxEnterDano_MA.Controls.Add(this.label2);
            this.groupBoxEnterDano_MA.Controls.Add(this.label1);
            this.groupBoxEnterDano_MA.Controls.Add(this.textBoxStopValue_MA);
            this.groupBoxEnterDano_MA.Controls.Add(this.textBoxStartValue_MA);
            this.groupBoxEnterDano_MA.Location = new System.Drawing.Point(413, 11);
            this.groupBoxEnterDano_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxEnterDano_MA.Name = "groupBoxEnterDano_MA";
            this.groupBoxEnterDano_MA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxEnterDano_MA.Size = new System.Drawing.Size(168, 96);
            this.groupBoxEnterDano_MA.TabIndex = 1;
            this.groupBoxEnterDano_MA.TabStop = false;
            this.groupBoxEnterDano_MA.Text = "Ввод данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конец шага";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Старт шага";
            // 
            // textBoxStopValue_MA
            // 
            this.textBoxStopValue_MA.Location = new System.Drawing.Point(85, 44);
            this.textBoxStopValue_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStopValue_MA.Name = "textBoxStopValue_MA";
            this.textBoxStopValue_MA.Size = new System.Drawing.Size(76, 20);
            this.textBoxStopValue_MA.TabIndex = 0;
            // 
            // textBoxStartValue_MA
            // 
            this.textBoxStartValue_MA.Location = new System.Drawing.Point(5, 44);
            this.textBoxStartValue_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStartValue_MA.Name = "textBoxStartValue_MA";
            this.textBoxStartValue_MA.Size = new System.Drawing.Size(76, 20);
            this.textBoxStartValue_MA.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSave_MA);
            this.groupBox1.Controls.Add(this.buttonDane_MA);
            this.groupBox1.Location = new System.Drawing.Point(586, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(157, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // buttonSave_MA
            // 
            this.buttonSave_MA.Location = new System.Drawing.Point(80, 11);
            this.buttonSave_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave_MA.Name = "buttonSave_MA";
            this.buttonSave_MA.Size = new System.Drawing.Size(70, 79);
            this.buttonSave_MA.TabIndex = 0;
            this.buttonSave_MA.Text = "Сохранить";
            this.buttonSave_MA.UseVisualStyleBackColor = true;
            this.buttonSave_MA.Click += new System.EventHandler(this.buttonSave_MA_Click);
            // 
            // buttonDane_MA
            // 
            this.buttonDane_MA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDane_MA.Location = new System.Drawing.Point(4, 11);
            this.buttonDane_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDane_MA.Name = "buttonDane_MA";
            this.buttonDane_MA.Size = new System.Drawing.Size(70, 79);
            this.buttonDane_MA.TabIndex = 0;
            this.buttonDane_MA.Text = "Выполнить";
            this.buttonDane_MA.UseVisualStyleBackColor = true;
            this.buttonDane_MA.Click += new System.EventHandler(this.buttonDane_MA_Click);
            // 
            // buttonHelp_MA
            // 
            this.buttonHelp_MA.Location = new System.Drawing.Point(747, 24);
            this.buttonHelp_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp_MA.Name = "buttonHelp_MA";
            this.buttonHelp_MA.Size = new System.Drawing.Size(77, 79);
            this.buttonHelp_MA.TabIndex = 3;
            this.buttonHelp_MA.Text = "Справка";
            this.buttonHelp_MA.UseVisualStyleBackColor = true;
            this.buttonHelp_MA.Click += new System.EventHandler(this.buttonHelp_MA_Click);
            // 
            // groupBoxOutResult_MA
            // 
            this.groupBoxOutResult_MA.Controls.Add(this.textBoxResult_MA);
            this.groupBoxOutResult_MA.Location = new System.Drawing.Point(12, 112);
            this.groupBoxOutResult_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutResult_MA.Name = "groupBoxOutResult_MA";
            this.groupBoxOutResult_MA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutResult_MA.Size = new System.Drawing.Size(160, 343);
            this.groupBoxOutResult_MA.TabIndex = 4;
            this.groupBoxOutResult_MA.TabStop = false;
            this.groupBoxOutResult_MA.Text = "Вывод данных:";
            // 
            // textBoxResult_MA
            // 
            this.textBoxResult_MA.Location = new System.Drawing.Point(5, 18);
            this.textBoxResult_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult_MA.Multiline = true;
            this.textBoxResult_MA.Name = "textBoxResult_MA";
            this.textBoxResult_MA.ReadOnly = true;
            this.textBoxResult_MA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_MA.Size = new System.Drawing.Size(152, 321);
            this.textBoxResult_MA.TabIndex = 0;
            // 
            // chartFunction_MA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_MA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_MA.Legends.Add(legend1);
            this.chartFunction_MA.Location = new System.Drawing.Point(178, 115);
            this.chartFunction_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartFunction_MA.Name = "chartFunction_MA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_MA.Series.Add(series1);
            this.chartFunction_MA.Size = new System.Drawing.Size(646, 340);
            this.chartFunction_MA.TabIndex = 5;
            this.chartFunction_MA.Text = "chartf";
            title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            title1.BackImageTransparentColor = System.Drawing.Color.Blue;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title";
            title1.Text = "График функции";
            this.chartFunction_MA.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 474);
            this.Controls.Add(this.chartFunction_MA);
            this.Controls.Add(this.groupBoxOutResult_MA);
            this.Controls.Add(this.buttonHelp_MA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEnterDano_MA);
            this.Controls.Add(this.groupBoxUslovie_MA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант29 | Медведев А. В.";
            this.groupBoxUslovie_MA.ResumeLayout(false);
            this.groupBoxUslovie_MA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxEnterDano_MA.ResumeLayout(false);
            this.groupBoxEnterDano_MA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxOutResult_MA.ResumeLayout(false);
            this.groupBoxOutResult_MA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_MA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2Uslovie_MA;
        private System.Windows.Forms.Label label1Uslovie_MA;
        private System.Windows.Forms.Label labelUslovie_MA;
        private System.Windows.Forms.GroupBox groupBoxEnterDano_MA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStopValue_MA;
        private System.Windows.Forms.TextBox textBoxStartValue_MA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave_MA;
        private System.Windows.Forms.Button buttonDane_MA;
        private System.Windows.Forms.Button buttonHelp_MA;
        private System.Windows.Forms.GroupBox groupBoxOutResult_MA;
        private System.Windows.Forms.TextBox textBoxResult_MA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MA;
    }
}

