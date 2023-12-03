
namespace Tyuiu.MedvedevA.Sprint6.Task3.V28
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
            this.groupBoxOne_MA = new System.Windows.Forms.GroupBox();
            this.textBoxOne_MA = new System.Windows.Forms.TextBox();
            this.dataGridViewInput_MA = new System.Windows.Forms.DataGridView();
            this.groupBoxTwo_MA = new System.Windows.Forms.GroupBox();
            this.textBoxTwo_MA = new System.Windows.Forms.TextBox();
            this.buttonHelp_MA = new System.Windows.Forms.Button();
            this.buttonStart_MA = new System.Windows.Forms.Button();
            this.groupBoxOne_MA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_MA)).BeginInit();
            this.groupBoxTwo_MA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOne_MA
            // 
            this.groupBoxOne_MA.Controls.Add(this.textBoxOne_MA);
            this.groupBoxOne_MA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxOne_MA.Name = "groupBoxOne_MA";
            this.groupBoxOne_MA.Size = new System.Drawing.Size(235, 304);
            this.groupBoxOne_MA.TabIndex = 0;
            this.groupBoxOne_MA.TabStop = false;
            this.groupBoxOne_MA.Text = "Условия";
            // 
            // textBoxOne_MA
            // 
            this.textBoxOne_MA.Location = new System.Drawing.Point(7, 20);
            this.textBoxOne_MA.Multiline = true;
            this.textBoxOne_MA.Name = "textBoxOne_MA";
            this.textBoxOne_MA.ReadOnly = true;
            this.textBoxOne_MA.Size = new System.Drawing.Size(218, 235);
            this.textBoxOne_MA.TabIndex = 0;
            this.textBoxOne_MA.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в четвертой строке на 0.";
            // 
            // dataGridViewInput_MA
            // 
            this.dataGridViewInput_MA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_MA.Location = new System.Drawing.Point(6, 45);
            this.dataGridViewInput_MA.Name = "dataGridViewInput_MA";
            this.dataGridViewInput_MA.Size = new System.Drawing.Size(274, 245);
            this.dataGridViewInput_MA.TabIndex = 1;
            this.dataGridViewInput_MA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInput_MA_CellContentClick);
            // 
            // groupBoxTwo_MA
            // 
            this.groupBoxTwo_MA.Controls.Add(this.textBoxTwo_MA);
            this.groupBoxTwo_MA.Controls.Add(this.dataGridViewInput_MA);
            this.groupBoxTwo_MA.Location = new System.Drawing.Point(254, 13);
            this.groupBoxTwo_MA.Name = "groupBoxTwo_MA";
            this.groupBoxTwo_MA.Size = new System.Drawing.Size(286, 304);
            this.groupBoxTwo_MA.TabIndex = 1;
            this.groupBoxTwo_MA.TabStop = false;
            this.groupBoxTwo_MA.Text = "Вывод данных";
            // 
            // textBoxTwo_MA
            // 
            this.textBoxTwo_MA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTwo_MA.Name = "textBoxTwo_MA";
            this.textBoxTwo_MA.ReadOnly = true;
            this.textBoxTwo_MA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTwo_MA.TabIndex = 0;
            this.textBoxTwo_MA.Text = "Результат:";
            this.textBoxTwo_MA.TextChanged += new System.EventHandler(this.textBoxTwo_MA_TextChanged);
            // 
            // buttonHelp_MA
            // 
            this.buttonHelp_MA.Location = new System.Drawing.Point(559, 249);
            this.buttonHelp_MA.Name = "buttonHelp_MA";
            this.buttonHelp_MA.Size = new System.Drawing.Size(229, 55);
            this.buttonHelp_MA.TabIndex = 2;
            this.buttonHelp_MA.Text = "СПРАВКА";
            this.buttonHelp_MA.UseVisualStyleBackColor = true;
            this.buttonHelp_MA.Click += new System.EventHandler(this.buttonHelp_MA_Click);
            // 
            // buttonStart_MA
            // 
            this.buttonStart_MA.Location = new System.Drawing.Point(559, 187);
            this.buttonStart_MA.Name = "buttonStart_MA";
            this.buttonStart_MA.Size = new System.Drawing.Size(229, 56);
            this.buttonStart_MA.TabIndex = 3;
            this.buttonStart_MA.Text = "ВЫПОЛНИТЬ";
            this.buttonStart_MA.UseVisualStyleBackColor = true;
            this.buttonStart_MA.Click += new System.EventHandler(this.buttonStart_MA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.buttonStart_MA);
            this.Controls.Add(this.buttonHelp_MA);
            this.Controls.Add(this.groupBoxTwo_MA);
            this.Controls.Add(this.groupBoxOne_MA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "| Спринт 6 | Таск 3 | Вариант 28 | Медведев А. В. ";
            this.Load += new System.EventHandler(this.FormMain_Load_MA);
            this.groupBoxOne_MA.ResumeLayout(false);
            this.groupBoxOne_MA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_MA)).EndInit();
            this.groupBoxTwo_MA.ResumeLayout(false);
            this.groupBoxTwo_MA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_MA;
        private System.Windows.Forms.DataGridView dataGridViewInput_MA;
        private System.Windows.Forms.TextBox textBoxOne_MA;
        private System.Windows.Forms.GroupBox groupBoxTwo_MA;
        private System.Windows.Forms.TextBox textBoxTwo_MA;
        private System.Windows.Forms.Button buttonHelp_MA;
        private System.Windows.Forms.Button buttonStart_MA;
    }
}

