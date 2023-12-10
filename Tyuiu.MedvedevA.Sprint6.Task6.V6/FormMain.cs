﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.MedvedevA.Sprint6.Task6.V6.Lib;

namespace Tyuiu.MedvedevA.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService service1 = new DataService();
        string openFilePath;
        private void buttonDane_MA_Click(object sender, EventArgs e)
        {
            textBoxResult_MA.Text = service1.CollectTextFromFile(openFilePath);
        }

        private void buttonOpenFail_MA_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInput.Text = File.ReadAllText(openFilePath);
            groupBoxInput.Text += " " + openFilePath;
        }

        private void buttonHelp_MA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы АСОиУБ-23-3 Медведев Андрей Валерьевич", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
