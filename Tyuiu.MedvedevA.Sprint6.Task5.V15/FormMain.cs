using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MedvedevA.Sprint6.Task5.V15.Lib;

namespace Tyuiu.MedvedevA.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V15.txt";

        private void dataGridViewRes_MA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpenF_MA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonStart_MA_Click(object sender, EventArgs e)
        {
            dataGridViewRes_MA.ColumnCount = 2;
            dataGridViewRes_MA.Columns[0].Width = 20;
            dataGridViewRes_MA.Columns[1].Width = 50;

            this.chartRes_MA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartRes_MA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartRes_MA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewRes_MA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartRes_MA.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }

        private void chartRes_MA_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_MA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-3 Медведев Андрей Валерьевич ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
