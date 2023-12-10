
namespace Tyuiu.MedvedevA.Sprint6.Task7.V15
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
            this.panelTop_MA = new System.Windows.Forms.Panel();
            this.panelLeft_MA = new System.Windows.Forms.Panel();
            this.panelFill_MA = new System.Windows.Forms.Panel();
            this.splitterTask_MA = new System.Windows.Forms.Splitter();
            this.groupBoxButtons_MA = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_MA = new System.Windows.Forms.GroupBox();
            this.buttonOpen_MA = new System.Windows.Forms.Button();
            this.buttonDone_MA = new System.Windows.Forms.Button();
            this.buttonSave_MA = new System.Windows.Forms.Button();
            this.buttonHelp_MA = new System.Windows.Forms.Button();
            this.textBoxTask_MA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_MA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_MA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_MA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutPut_MA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_MA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_MA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_MA = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_MA.SuspendLayout();
            this.panelLeft_MA.SuspendLayout();
            this.panelFill_MA.SuspendLayout();
            this.groupBoxButtons_MA.SuspendLayout();
            this.groupBoxTask_MA.SuspendLayout();
            this.groupBoxInPut_MA.SuspendLayout();
            this.groupBoxOutPut_MA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_MA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_MA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_MA
            // 
            this.panelTop_MA.Controls.Add(this.groupBoxTask_MA);
            this.panelTop_MA.Controls.Add(this.groupBoxButtons_MA);
            this.panelTop_MA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MA.Name = "panelTop_MA";
            this.panelTop_MA.Size = new System.Drawing.Size(800, 154);
            this.panelTop_MA.TabIndex = 0;
            // 
            // panelLeft_MA
            // 
            this.panelLeft_MA.Controls.Add(this.groupBoxInPut_MA);
            this.panelLeft_MA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_MA.Location = new System.Drawing.Point(0, 154);
            this.panelLeft_MA.Name = "panelLeft_MA";
            this.panelLeft_MA.Size = new System.Drawing.Size(390, 296);
            this.panelLeft_MA.TabIndex = 1;
            // 
            // panelFill_MA
            // 
            this.panelFill_MA.Controls.Add(this.groupBoxOutPut_MA);
            this.panelFill_MA.Controls.Add(this.splitterTask_MA);
            this.panelFill_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_MA.Location = new System.Drawing.Point(390, 154);
            this.panelFill_MA.Name = "panelFill_MA";
            this.panelFill_MA.Size = new System.Drawing.Size(410, 296);
            this.panelFill_MA.TabIndex = 2;
            // 
            // splitterTask_MA
            // 
            this.splitterTask_MA.Location = new System.Drawing.Point(0, 0);
            this.splitterTask_MA.Name = "splitterTask_MA";
            this.splitterTask_MA.Size = new System.Drawing.Size(3, 296);
            this.splitterTask_MA.TabIndex = 0;
            this.splitterTask_MA.TabStop = false;
            // 
            // groupBoxButtons_MA
            // 
            this.groupBoxButtons_MA.Controls.Add(this.buttonHelp_MA);
            this.groupBoxButtons_MA.Controls.Add(this.buttonSave_MA);
            this.groupBoxButtons_MA.Controls.Add(this.buttonDone_MA);
            this.groupBoxButtons_MA.Controls.Add(this.buttonOpen_MA);
            this.groupBoxButtons_MA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxButtons_MA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons_MA.Name = "groupBoxButtons_MA";
            this.groupBoxButtons_MA.Size = new System.Drawing.Size(800, 68);
            this.groupBoxButtons_MA.TabIndex = 0;
            this.groupBoxButtons_MA.TabStop = false;
            // 
            // groupBoxTask_MA
            // 
            this.groupBoxTask_MA.Controls.Add(this.textBoxTask_MA);
            this.groupBoxTask_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_MA.Location = new System.Drawing.Point(0, 68);
            this.groupBoxTask_MA.Name = "groupBoxTask_MA";
            this.groupBoxTask_MA.Size = new System.Drawing.Size(800, 86);
            this.groupBoxTask_MA.TabIndex = 1;
            this.groupBoxTask_MA.TabStop = false;
            this.groupBoxTask_MA.Text = "Условие";
            // 
            // buttonOpen_MA
            // 
            this.buttonOpen_MA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_MA.Image")));
            this.buttonOpen_MA.Location = new System.Drawing.Point(6, 12);
            this.buttonOpen_MA.Name = "buttonOpen_MA";
            this.buttonOpen_MA.Size = new System.Drawing.Size(54, 50);
            this.buttonOpen_MA.TabIndex = 0;
            this.toolTipButton_MA.SetToolTip(this.buttonOpen_MA, "Открыть файл для обработки");
            this.buttonOpen_MA.UseVisualStyleBackColor = true;
            this.buttonOpen_MA.Click += new System.EventHandler(this.buttonOpen_MA_Click);
            this.buttonOpen_MA.MouseEnter += new System.EventHandler(this.buttonOpen_MA_MouseEnter);
            // 
            // buttonDone_MA
            // 
            this.buttonDone_MA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_MA.Image")));
            this.buttonDone_MA.Location = new System.Drawing.Point(66, 12);
            this.buttonDone_MA.Name = "buttonDone_MA";
            this.buttonDone_MA.Size = new System.Drawing.Size(54, 50);
            this.buttonDone_MA.TabIndex = 0;
            this.toolTipButton_MA.SetToolTip(this.buttonDone_MA, "Вывести данные");
            this.buttonDone_MA.UseVisualStyleBackColor = true;
            this.buttonDone_MA.Click += new System.EventHandler(this.buttonDone_MA_Click);
            this.buttonDone_MA.MouseEnter += new System.EventHandler(this.buttonDone_MA_MouseEnter);
            // 
            // buttonSave_MA
            // 
            this.buttonSave_MA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_MA.Image")));
            this.buttonSave_MA.Location = new System.Drawing.Point(126, 12);
            this.buttonSave_MA.Name = "buttonSave_MA";
            this.buttonSave_MA.Size = new System.Drawing.Size(54, 50);
            this.buttonSave_MA.TabIndex = 0;
            this.toolTipButton_MA.SetToolTip(this.buttonSave_MA, "Сохранить результат");
            this.buttonSave_MA.UseVisualStyleBackColor = true;
            this.buttonSave_MA.Click += new System.EventHandler(this.buttonSave_MA_Click);
            this.buttonSave_MA.MouseEnter += new System.EventHandler(this.buttonSave_MA_MouseEnter);
            // 
            // buttonHelp_MA
            // 
            this.buttonHelp_MA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_MA.Image")));
            this.buttonHelp_MA.Location = new System.Drawing.Point(740, 12);
            this.buttonHelp_MA.Name = "buttonHelp_MA";
            this.buttonHelp_MA.Size = new System.Drawing.Size(54, 50);
            this.buttonHelp_MA.TabIndex = 0;
            this.toolTipButton_MA.SetToolTip(this.buttonHelp_MA, "О программе");
            this.buttonHelp_MA.UseVisualStyleBackColor = true;
            this.buttonHelp_MA.Click += new System.EventHandler(this.buttonHelp_MA_Click);
            this.buttonHelp_MA.MouseEnter += new System.EventHandler(this.buttonHelp_MA_MouseEnter);
            // 
            // textBoxTask_MA
            // 
            this.textBoxTask_MA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_MA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_MA.Multiline = true;
            this.textBoxTask_MA.Name = "textBoxTask_MA";
            this.textBoxTask_MA.ReadOnly = true;
            this.textBoxTask_MA.Size = new System.Drawing.Size(794, 67);
            this.textBoxTask_MA.TabIndex = 0;
            this.textBoxTask_MA.Text = resources.GetString("textBoxTask_MA.Text");
            // 
            // groupBoxInPut_MA
            // 
            this.groupBoxInPut_MA.Controls.Add(this.dataGridViewInPut_MA);
            this.groupBoxInPut_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_MA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_MA.Name = "groupBoxInPut_MA";
            this.groupBoxInPut_MA.Size = new System.Drawing.Size(390, 296);
            this.groupBoxInPut_MA.TabIndex = 0;
            this.groupBoxInPut_MA.TabStop = false;
            this.groupBoxInPut_MA.Text = "Ввод";
            // 
            // groupBoxOutPut_MA
            // 
            this.groupBoxOutPut_MA.Controls.Add(this.dataGridViewOutPut_MA);
            this.groupBoxOutPut_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_MA.Location = new System.Drawing.Point(3, 0);
            this.groupBoxOutPut_MA.Name = "groupBoxOutPut_MA";
            this.groupBoxOutPut_MA.Size = new System.Drawing.Size(407, 296);
            this.groupBoxOutPut_MA.TabIndex = 1;
            this.groupBoxOutPut_MA.TabStop = false;
            this.groupBoxOutPut_MA.Text = "Вывод";
            // 
            // dataGridViewInPut_MA
            // 
            this.dataGridViewInPut_MA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_MA.ColumnHeadersVisible = false;
            this.dataGridViewInPut_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_MA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPut_MA.Name = "dataGridViewInPut_MA";
            this.dataGridViewInPut_MA.ReadOnly = true;
            this.dataGridViewInPut_MA.RowHeadersVisible = false;
            this.dataGridViewInPut_MA.Size = new System.Drawing.Size(384, 277);
            this.dataGridViewInPut_MA.TabIndex = 0;
            // 
            // dataGridViewOutPut_MA
            // 
            this.dataGridViewOutPut_MA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_MA.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_MA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_MA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_MA.Name = "dataGridViewOutPut_MA";
            this.dataGridViewOutPut_MA.ReadOnly = true;
            this.dataGridViewOutPut_MA.RowHeadersVisible = false;
            this.dataGridViewOutPut_MA.Size = new System.Drawing.Size(401, 277);
            this.dataGridViewOutPut_MA.TabIndex = 0;
            // 
            // openFileDialogTask_MA
            // 
            this.openFileDialogTask_MA.FileName = "openFileDialog1";
            // 
            // toolTipButton_MA
            // 
            this.toolTipButton_MA.IsBalloon = true;
            this.toolTipButton_MA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_MA.ToolTipTitle = "Информация";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFill_MA);
            this.Controls.Add(this.panelLeft_MA);
            this.Controls.Add(this.panelTop_MA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 15 | Медведев А. В. АСОиУБ-23-3 ";
            this.panelTop_MA.ResumeLayout(false);
            this.panelLeft_MA.ResumeLayout(false);
            this.panelFill_MA.ResumeLayout(false);
            this.groupBoxButtons_MA.ResumeLayout(false);
            this.groupBoxTask_MA.ResumeLayout(false);
            this.groupBoxTask_MA.PerformLayout();
            this.groupBoxInPut_MA.ResumeLayout(false);
            this.groupBoxOutPut_MA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_MA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_MA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_MA;
        private System.Windows.Forms.GroupBox groupBoxTask_MA;
        private System.Windows.Forms.TextBox textBoxTask_MA;
        private System.Windows.Forms.GroupBox groupBoxButtons_MA;
        private System.Windows.Forms.Button buttonHelp_MA;
        private System.Windows.Forms.Button buttonSave_MA;
        private System.Windows.Forms.Button buttonDone_MA;
        private System.Windows.Forms.Button buttonOpen_MA;
        private System.Windows.Forms.Panel panelLeft_MA;
        private System.Windows.Forms.GroupBox groupBoxInPut_MA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_MA;
        private System.Windows.Forms.Panel panelFill_MA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_MA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_MA;
        private System.Windows.Forms.Splitter splitterTask_MA;
        private System.Windows.Forms.ToolTip toolTipButton_MA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_MA;
    }
}

