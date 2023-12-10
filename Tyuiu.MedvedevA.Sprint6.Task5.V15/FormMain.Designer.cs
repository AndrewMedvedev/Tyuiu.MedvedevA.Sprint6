
namespace Tyuiu.MedvedevA.Sprint6.Task5.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOne_MA = new System.Windows.Forms.GroupBox();
            this.textBoxOne_MA = new System.Windows.Forms.TextBox();
            this.buttonOpenF_MA = new System.Windows.Forms.Button();
            this.buttonHelp_MA = new System.Windows.Forms.Button();
            this.dataGridViewRes_MA = new System.Windows.Forms.DataGridView();
            this.groupBoxTwo_MA = new System.Windows.Forms.GroupBox();
            this.panelOneChart_MA = new System.Windows.Forms.Panel();
            this.chartRes_MA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart_MA = new System.Windows.Forms.Button();
            this.groupBoxOne_MA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MA)).BeginInit();
            this.groupBoxTwo_MA.SuspendLayout();
            this.panelOneChart_MA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_MA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOne_MA
            // 
            this.groupBoxOne_MA.Controls.Add(this.textBoxOne_MA);
            this.groupBoxOne_MA.Location = new System.Drawing.Point(6, 5);
            this.groupBoxOne_MA.Name = "groupBoxOne_MA";
            this.groupBoxOne_MA.Size = new System.Drawing.Size(553, 90);
            this.groupBoxOne_MA.TabIndex = 0;
            this.groupBoxOne_MA.TabStop = false;
            this.groupBoxOne_MA.Text = "Условие";
            // 
            // textBoxOne_MA
            // 
            this.textBoxOne_MA.Location = new System.Drawing.Point(7, 18);
            this.textBoxOne_MA.Multiline = true;
            this.textBoxOne_MA.Name = "textBoxOne_MA";
            this.textBoxOne_MA.ReadOnly = true;
            this.textBoxOne_MA.Size = new System.Drawing.Size(534, 66);
            this.textBoxOne_MA.TabIndex = 0;
            this.textBoxOne_MA.Text = "Вывести все числа от 2 до 7";
            // 
            // buttonOpenF_MA
            // 
            this.buttonOpenF_MA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenF_MA.Location = new System.Drawing.Point(648, 23);
            this.buttonOpenF_MA.Name = "buttonOpenF_MA";
            this.buttonOpenF_MA.Size = new System.Drawing.Size(65, 72);
            this.buttonOpenF_MA.TabIndex = 2;
            this.buttonOpenF_MA.Text = "Открыть файл";
            this.buttonOpenF_MA.UseVisualStyleBackColor = false;
            this.buttonOpenF_MA.Click += new System.EventHandler(this.buttonOpenF_MA_Click);
            // 
            // buttonHelp_MA
            // 
            this.buttonHelp_MA.BackColor = System.Drawing.Color.HotPink;
            this.buttonHelp_MA.Location = new System.Drawing.Point(719, 23);
            this.buttonHelp_MA.Name = "buttonHelp_MA";
            this.buttonHelp_MA.Size = new System.Drawing.Size(69, 72);
            this.buttonHelp_MA.TabIndex = 3;
            this.buttonHelp_MA.Text = "Справка";
            this.buttonHelp_MA.UseVisualStyleBackColor = false;
            this.buttonHelp_MA.Click += new System.EventHandler(this.buttonHelp_MA_Click);
            // 
            // dataGridViewRes_MA
            // 
            this.dataGridViewRes_MA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRes_MA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRes_MA.Name = "dataGridViewRes_MA";
            this.dataGridViewRes_MA.Size = new System.Drawing.Size(194, 317);
            this.dataGridViewRes_MA.TabIndex = 2;
            this.dataGridViewRes_MA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRes_MA_CellContentClick);
            // 
            // groupBoxTwo_MA
            // 
            this.groupBoxTwo_MA.Controls.Add(this.dataGridViewRes_MA);
            this.groupBoxTwo_MA.Location = new System.Drawing.Point(13, 102);
            this.groupBoxTwo_MA.Name = "groupBoxTwo_MA";
            this.groupBoxTwo_MA.Size = new System.Drawing.Size(200, 336);
            this.groupBoxTwo_MA.TabIndex = 5;
            this.groupBoxTwo_MA.TabStop = false;
            this.groupBoxTwo_MA.Text = "Вывод данных";
            // 
            // panelOneChart_MA
            // 
            this.panelOneChart_MA.Controls.Add(this.chartRes_MA);
            this.panelOneChart_MA.Location = new System.Drawing.Point(219, 102);
            this.panelOneChart_MA.Name = "panelOneChart_MA";
            this.panelOneChart_MA.Size = new System.Drawing.Size(569, 346);
            this.panelOneChart_MA.TabIndex = 6;
            // 
            // chartRes_MA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRes_MA.ChartAreas.Add(chartArea1);
            this.chartRes_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRes_MA.Legends.Add(legend1);
            this.chartRes_MA.Location = new System.Drawing.Point(0, 0);
            this.chartRes_MA.Name = "chartRes_MA";
            this.chartRes_MA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRes_MA.Series.Add(series1);
            this.chartRes_MA.Size = new System.Drawing.Size(569, 346);
            this.chartRes_MA.TabIndex = 0;
            this.chartRes_MA.Text = "chart1";
            this.chartRes_MA.Click += new System.EventHandler(this.chartRes_MA_Click);
            // 
            // buttonStart_MA
            // 
            this.buttonStart_MA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonStart_MA.Location = new System.Drawing.Point(566, 23);
            this.buttonStart_MA.Name = "buttonStart_MA";
            this.buttonStart_MA.Size = new System.Drawing.Size(75, 66);
            this.buttonStart_MA.TabIndex = 7;
            this.buttonStart_MA.Text = "Выполнить";
            this.buttonStart_MA.UseVisualStyleBackColor = false;
            this.buttonStart_MA.Click += new System.EventHandler(this.buttonStart_MA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 454);
            this.Controls.Add(this.buttonStart_MA);
            this.Controls.Add(this.panelOneChart_MA);
            this.Controls.Add(this.groupBoxTwo_MA);
            this.Controls.Add(this.buttonHelp_MA);
            this.Controls.Add(this.buttonOpenF_MA);
            this.Controls.Add(this.groupBoxOne_MA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "| Спринт 6 | Таск 5 | Вариант 15| Медведев А. В. ";
            this.groupBoxOne_MA.ResumeLayout(false);
            this.groupBoxOne_MA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MA)).EndInit();
            this.groupBoxTwo_MA.ResumeLayout(false);
            this.panelOneChart_MA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_MA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_MA;
        private System.Windows.Forms.Button buttonOpenF_MA;
        private System.Windows.Forms.Button buttonHelp_MA;
        private System.Windows.Forms.DataGridView dataGridViewRes_MA;
        private System.Windows.Forms.GroupBox groupBoxTwo_MA;
        private System.Windows.Forms.TextBox textBoxOne_MA;
        private System.Windows.Forms.Panel panelOneChart_MA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_MA;
        private System.Windows.Forms.Button buttonStart_MA;
    }
}

