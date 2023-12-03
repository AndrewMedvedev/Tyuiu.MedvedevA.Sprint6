using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MedvedevA.Sprint6.Task2.V5.Lib;

namespace Tyuiu.MedvedevA.Sprint6.Task2.V5
{
    public partial class FormMain_MA : Form
    {
        DataService ds = new DataService();
        public FormMain_MA()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_MA_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_MA.Text);
                int stop = Convert.ToInt32(textBoxStop_MA.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueA = new double[len];
                valueA = ds.GetMassFunction(start, stop);
                this.chartResult_MA.Titles.Add("График функции (2х-3/Cos(x)-2x)+5x-6");
                this.chartResult_MA.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult_MA.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewXY_MA.Rows.Add(Convert.ToString(start), Convert.ToString(valueA[i]));
                    this.chartResult_MA.Series[0].Points.AddXY(start, valueA[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_MA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-23-3 Медведев Андрей Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_MA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStart_MA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_MA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_MA.BackColor = Color.Red;
        }

        private void buttonDone_MA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_MA.BackColor = Color.Green;
        }

        private void buttonDone_MA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_MA.BackColor = Color.Blue;
        }
    }
}
