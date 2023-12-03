using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MedvedevA.Sprint6.Task3.V28.Lib;

namespace Tyuiu.MedvedevA.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] { { -9, 8, 9, 16, -18,},
                                          {  -13, -11, -20, -15, 9,},
                                          {  18, 13, -12, -15, -11,},
                                          {   10, -2, 19, -4, -10,},
                                          {   6, -20, -4, 13, -14,}, };
        public FormMain()
        {
            InitializeComponent();

        }

        private void buttonHelp_MA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы АСОиУБ-23-3 Медведев Андрей Валерьевич", "Справка");
        }

        private void dataGridViewInput_MA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load_MA(object sender, EventArgs e)
        {

            dataGridViewInput_MA.RowCount = matrix.GetLength(0);
            dataGridViewInput_MA.ColumnCount = matrix.GetLength(1);
            for (int i = 0; i < dataGridViewInput_MA.ColumnCount; i++)
            {
                dataGridViewInput_MA.Columns[i].Width = 25;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewInput_MA.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

        }

        private void buttonStart_MA_Click(object sender, EventArgs e)
        {
            matrix = ds.Calculate(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewInput_MA.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void textBoxTwo_MA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
