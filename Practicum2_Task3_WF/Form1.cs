using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum2_Task3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            richTextBox.Clear();
            richTextBox.Text += "Цикл for\n";
            richTextBox.Text += "-----------------------------------------\n";
            for (; i < 11; i++)
            {
                richTextBox.Text += $"{i} lb. equals {i * 453} gram\n";
            }
            richTextBox.Text += "\n";

            i = 1;
            richTextBox.Text += "Цикл while\n";
            richTextBox.Text += "-----------------------------------------\n";
            while (i < 11)
            {
                richTextBox.Text += $"{i} lb. equals {i * 453} gram\n";
                i++;
            }
            richTextBox.Text += "\n";

            i = 1;
            richTextBox.Text += "Цикл do...while\n";
            richTextBox.Text += "-----------------------------------------\n";
            do
            {
                richTextBox.Text += $"{i} lb. equals {i * 453} gram\n";
                i++;
            }
            while (i < 11);
        }
    }
}
