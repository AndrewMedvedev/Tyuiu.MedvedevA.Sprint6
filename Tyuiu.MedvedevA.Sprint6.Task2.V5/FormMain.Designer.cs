
namespace Tyuiu.MedvedevA.Sprint6.Task2.V5
{
    partial class FormMain_MA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_MA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_MA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_MA = new System.Windows.Forms.TextBox();
            this.textBoxStart_MA = new System.Windows.Forms.TextBox();
            this.labelStop_MA = new System.Windows.Forms.Label();
            this.labelStart_MA = new System.Windows.Forms.Label();
            this.buttonHelp_MA = new System.Windows.Forms.Button();
            this.buttonDone_MA = new System.Windows.Forms.Button();
            this.groupBoxResult_MA = new System.Windows.Forms.GroupBox();
            this.labelResult_MA = new System.Windows.Forms.Label();
            this.chartResult_MA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewXY_MA = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_MA.SuspendLayout();
            this.groupBoxInPut_MA.SuspendLayout();
            this.groupBoxResult_MA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_MA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXY_MA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_MA
            // 
            this.groupBoxTask_MA.Controls.Add(this.textBoxTask_MA);
            this.groupBoxTask_MA.Location = new System.Drawing.Point(14, 12);
            this.groupBoxTask_MA.Name = "groupBoxTask_MA";
            this.groupBoxTask_MA.Size = new System.Drawing.Size(636, 300);
            this.groupBoxTask_MA.TabIndex = 0;
            this.groupBoxTask_MA.TabStop = false;
            this.groupBoxTask_MA.Text = "Условие";
            this.groupBoxTask_MA.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxTask_MA
            // 
            this.textBoxTask_MA.Location = new System.Drawing.Point(10, 27);
            this.textBoxTask_MA.Multiline = true;
            this.textBoxTask_MA.Name = "textBoxTask_MA";
            this.textBoxTask_MA.ReadOnly = true;
            this.textBoxTask_MA.Size = new System.Drawing.Size(620, 258);
            this.textBoxTask_MA.TabIndex = 0;
            this.textBoxTask_MA.Text = "Протабулировать функцию ( (2х-3) / (cos(x)-2x) ) + 5x - 6 \r\nна заданном диапазоне" +
    " [-5;5].\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInPut_MA
            // 
            this.groupBoxInPut_MA.Controls.Add(this.textBoxStop_MA);
            this.groupBoxInPut_MA.Controls.Add(this.textBoxStart_MA);
            this.groupBoxInPut_MA.Controls.Add(this.labelStop_MA);
            this.groupBoxInPut_MA.Controls.Add(this.labelStart_MA);
            this.groupBoxInPut_MA.Location = new System.Drawing.Point(13, 320);
            this.groupBoxInPut_MA.Name = "groupBoxInPut_MA";
            this.groupBoxInPut_MA.Size = new System.Drawing.Size(304, 100);
            this.groupBoxInPut_MA.TabIndex = 1;
            this.groupBoxInPut_MA.TabStop = false;
            this.groupBoxInPut_MA.Text = "Ввод данных";
            // 
            // textBoxStop_MA
            // 
            this.textBoxStop_MA.Location = new System.Drawing.Point(162, 49);
            this.textBoxStop_MA.Name = "textBoxStop_MA";
            this.textBoxStop_MA.Size = new System.Drawing.Size(100, 26);
            this.textBoxStop_MA.TabIndex = 3;
            this.textBoxStop_MA.Text = "5";
            this.textBoxStop_MA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_MA_KeyPress);
            // 
            // textBoxStart_MA
            // 
            this.textBoxStart_MA.Location = new System.Drawing.Point(9, 49);
            this.textBoxStart_MA.Name = "textBoxStart_MA";
            this.textBoxStart_MA.Size = new System.Drawing.Size(100, 26);
            this.textBoxStart_MA.TabIndex = 2;
            this.textBoxStart_MA.Text = "-5";
            this.textBoxStart_MA.TextChanged += new System.EventHandler(this.textBoxStart_MA_TextChanged);
            this.textBoxStart_MA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_MA_KeyPress);
            // 
            // labelStop_MA
            // 
            this.labelStop_MA.AutoSize = true;
            this.labelStop_MA.Location = new System.Drawing.Point(161, 26);
            this.labelStop_MA.Name = "labelStop_MA";
            this.labelStop_MA.Size = new System.Drawing.Size(101, 20);
            this.labelStop_MA.TabIndex = 1;
            this.labelStop_MA.Text = "Конец шага:";
            // 
            // labelStart_MA
            // 
            this.labelStart_MA.AutoSize = true;
            this.labelStart_MA.Location = new System.Drawing.Point(7, 26);
            this.labelStart_MA.Name = "labelStart_MA";
            this.labelStart_MA.Size = new System.Drawing.Size(102, 20);
            this.labelStart_MA.TabIndex = 0;
            this.labelStart_MA.Text = "Старт шага:";
            // 
            // buttonHelp_MA
            // 
            this.buttonHelp_MA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_MA.Location = new System.Drawing.Point(324, 330);
            this.buttonHelp_MA.Name = "buttonHelp_MA";
            this.buttonHelp_MA.Size = new System.Drawing.Size(125, 90);
            this.buttonHelp_MA.TabIndex = 2;
            this.buttonHelp_MA.Text = "Справка";
            this.buttonHelp_MA.UseVisualStyleBackColor = false;
            this.buttonHelp_MA.Click += new System.EventHandler(this.buttonHelp_MA_Click);
            // 
            // buttonDone_MA
            // 
            this.buttonDone_MA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_MA.Location = new System.Drawing.Point(456, 330);
            this.buttonDone_MA.Name = "buttonDone_MA";
            this.buttonDone_MA.Size = new System.Drawing.Size(193, 90);
            this.buttonDone_MA.TabIndex = 3;
            this.buttonDone_MA.Text = "Выполнить";
            this.buttonDone_MA.UseVisualStyleBackColor = false;
            this.buttonDone_MA.Click += new System.EventHandler(this.buttonDone_MA_Click);
            this.buttonDone_MA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MA_MouseDown);
            this.buttonDone_MA.MouseEnter += new System.EventHandler(this.buttonDone_MA_MouseEnter);
            this.buttonDone_MA.MouseLeave += new System.EventHandler(this.buttonDone_MA_MouseLeave);
            // 
            // groupBoxResult_MA
            // 
            this.groupBoxResult_MA.Controls.Add(this.labelResult_MA);
            this.groupBoxResult_MA.Controls.Add(this.chartResult_MA);
            this.groupBoxResult_MA.Controls.Add(this.dataGridViewXY_MA);
            this.groupBoxResult_MA.Location = new System.Drawing.Point(656, 13);
            this.groupBoxResult_MA.Name = "groupBoxResult_MA";
            this.groupBoxResult_MA.Size = new System.Drawing.Size(968, 407);
            this.groupBoxResult_MA.TabIndex = 4;
            this.groupBoxResult_MA.TabStop = false;
            this.groupBoxResult_MA.Text = "Вывод данных";
            // 
            // labelResult_MA
            // 
            this.labelResult_MA.AutoSize = true;
            this.labelResult_MA.Location = new System.Drawing.Point(7, 26);
            this.labelResult_MA.Name = "labelResult_MA";
            this.labelResult_MA.Size = new System.Drawing.Size(93, 20);
            this.labelResult_MA.TabIndex = 2;
            this.labelResult_MA.Text = "Результат:";
            // 
            // chartResult_MA
            // 
            chartArea5.Name = "ChartArea1";
            this.chartResult_MA.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartResult_MA.Legends.Add(legend5);
            this.chartResult_MA.Location = new System.Drawing.Point(191, 50);
            this.chartResult_MA.Name = "chartResult_MA";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartResult_MA.Series.Add(series5);
            this.chartResult_MA.Size = new System.Drawing.Size(609, 351);
            this.chartResult_MA.TabIndex = 1;
            this.chartResult_MA.Text = "chart1";
            // 
            // dataGridViewXY_MA
            // 
            this.dataGridViewXY_MA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXY_MA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.dataGridViewXY_MA.Location = new System.Drawing.Point(7, 50);
            this.dataGridViewXY_MA.Name = "dataGridViewXY_MA";
            this.dataGridViewXY_MA.RowHeadersVisible = false;
            this.dataGridViewXY_MA.RowHeadersWidth = 62;
            this.dataGridViewXY_MA.RowTemplate.Height = 28;
            this.dataGridViewXY_MA.Size = new System.Drawing.Size(178, 351);
            this.dataGridViewXY_MA.TabIndex = 0;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.MinimumWidth = 8;
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 50;
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "F(X)";
            this.ColumnY.MinimumWidth = 8;
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.ReadOnly = true;
            this.ColumnY.Width = 50;
            // 
            // FormMain_MA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 450);
            this.Controls.Add(this.groupBoxResult_MA);
            this.Controls.Add(this.buttonDone_MA);
            this.Controls.Add(this.buttonHelp_MA);
            this.Controls.Add(this.groupBoxInPut_MA);
            this.Controls.Add(this.groupBoxTask_MA);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_MA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант  5 | Медведев А.В.";
            this.groupBoxTask_MA.ResumeLayout(false);
            this.groupBoxTask_MA.PerformLayout();
            this.groupBoxInPut_MA.ResumeLayout(false);
            this.groupBoxInPut_MA.PerformLayout();
            this.groupBoxResult_MA.ResumeLayout(false);
            this.groupBoxResult_MA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_MA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXY_MA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MA;
        private System.Windows.Forms.GroupBox groupBoxInPut_MA;
        private System.Windows.Forms.Button buttonHelp_MA;
        private System.Windows.Forms.Button buttonDone_MA;
        private System.Windows.Forms.GroupBox groupBoxResult_MA;
        private System.Windows.Forms.TextBox textBoxTask_MA;
        private System.Windows.Forms.TextBox textBoxStop_MA;
        private System.Windows.Forms.TextBox textBoxStart_MA;
        private System.Windows.Forms.Label labelStop_MA;
        private System.Windows.Forms.Label labelStart_MA;
        private System.Windows.Forms.Label labelResult_MA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_MA;
        private System.Windows.Forms.DataGridView dataGridViewXY_MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
    }
}

