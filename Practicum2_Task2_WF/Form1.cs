using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum2_Task2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            int k = (int)numericUpDown.Value;

            if (k < 6 || k > 14)
            {
                MessageBox.Show("Достоинство карты должно находиться в диапазоне от 6 до 14!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (k)
            {
                case 6:
                    textBox.Text = "Шестерка";
                    break;
                case 7:
                    textBox.Text = "Семерка";
                    break;
                case 8:
                    textBox.Text = "Восьмерка";
                    break;
                case 9:
                    textBox.Text = "Девятка";
                    break;
                case 10:
                    textBox.Text = "Десятка";
                    break;
                case 11:
                    textBox.Text = "Валет";
                    break;
                case 12:
                    textBox.Text = "Дама";
                    break;
                case 13:
                    textBox.Text = "Король";
                    break;
                case 14:
                    textBox.Text = "Туз";
                    break;
            }
        }
    }
}
