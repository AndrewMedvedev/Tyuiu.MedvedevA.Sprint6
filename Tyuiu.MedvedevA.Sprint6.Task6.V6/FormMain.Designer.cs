
namespace Tyuiu.MedvedevA.Sprint6.Task6.V6
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
            this.buttonOpenFail_MA = new System.Windows.Forms.Button();
            this.buttonDane_MA = new System.Windows.Forms.Button();
            this.buttonHelp_MA = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxUslovie_MA = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MA = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_MA.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFail_MA
            // 
            this.buttonOpenFail_MA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFail_MA.Image")));
            this.buttonOpenFail_MA.Location = new System.Drawing.Point(10, 11);
            this.buttonOpenFail_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenFail_MA.Name = "buttonOpenFail_MA";
            this.buttonOpenFail_MA.Size = new System.Drawing.Size(56, 61);
            this.buttonOpenFail_MA.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonOpenFail_MA, "Нажми чтобы выбрать файл");
            this.buttonOpenFail_MA.UseVisualStyleBackColor = true;
            this.buttonOpenFail_MA.Click += new System.EventHandler(this.buttonOpenFail_MA_Click);
            // 
            // buttonDane_MA
            // 
            this.buttonDane_MA.Location = new System.Drawing.Point(70, 10);
            this.buttonDane_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDane_MA.Name = "buttonDane_MA";
            this.buttonDane_MA.Size = new System.Drawing.Size(56, 61);
            this.buttonDane_MA.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonDane_MA, "Запустить выполнение условия");
            this.buttonDane_MA.UseVisualStyleBackColor = true;
            this.buttonDane_MA.Click += new System.EventHandler(this.buttonDane_MA_Click);
            // 
            // buttonHelp_MA
            // 
            this.buttonHelp_MA.Location = new System.Drawing.Point(535, 10);
            this.buttonHelp_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp_MA.Name = "buttonHelp_MA";
            this.buttonHelp_MA.Size = new System.Drawing.Size(56, 61);
            this.buttonHelp_MA.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonHelp_MA, "Информация о производителе");
            this.buttonHelp_MA.UseVisualStyleBackColor = true;
            this.buttonHelp_MA.Click += new System.EventHandler(this.buttonHelp_MA_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // groupBoxUslovie_MA
            // 
            this.groupBoxUslovie_MA.Controls.Add(this.label1);
            this.groupBoxUslovie_MA.Location = new System.Drawing.Point(10, 77);
            this.groupBoxUslovie_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUslovie_MA.Name = "groupBoxUslovie_MA";
            this.groupBoxUslovie_MA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUslovie_MA.Size = new System.Drawing.Size(581, 64);
            this.groupBoxUslovie_MA.TabIndex = 1;
            this.groupBoxUslovie_MA.TabStop = false;
            this.groupBoxUslovie_MA.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxInput);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 146);
            this.groupBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInput.Size = new System.Drawing.Size(289, 210);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(5, 18);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(284, 192);
            this.textBoxInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxResult_MA);
            this.groupBox2.Location = new System.Drawing.Point(305, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(286, 210);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод";
            // 
            // textBoxResult_MA
            // 
            this.textBoxResult_MA.Location = new System.Drawing.Point(0, 18);
            this.textBoxResult_MA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult_MA.Multiline = true;
            this.textBoxResult_MA.Name = "textBoxResult_MA";
            this.textBoxResult_MA.ReadOnly = true;
            this.textBoxResult_MA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_MA.Size = new System.Drawing.Size(287, 192);
            this.textBoxResult_MA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxUslovie_MA);
            this.Controls.Add(this.buttonHelp_MA);
            this.Controls.Add(this.buttonDane_MA);
            this.Controls.Add(this.buttonOpenFail_MA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 6 | Медведев А. В.";
            this.groupBoxUslovie_MA.ResumeLayout(false);
            this.groupBoxUslovie_MA.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFail_MA;
        private System.Windows.Forms.Button buttonDane_MA;
        private System.Windows.Forms.Button buttonHelp_MA;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.GroupBox groupBoxUslovie_MA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxResult_MA;
    }
}

