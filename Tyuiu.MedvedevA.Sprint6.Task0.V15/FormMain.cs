using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MedvedevA.Sprint6.Task0.V15.Lib;

namespace Tyuiu.MedvedevA.Sprint6.Task0.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBox3.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox2.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task0 выполнил Студент Группы АСОиУБ-23-3 Медведев Андрей Валерьевич ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
