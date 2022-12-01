using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum2_Task4_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            richTextBox.Clear();

            for (int j = 0; j < 5; j++)
            {
                richTextBox.Text += str += "5 ";
                richTextBox.Text += "\n";
            }
        }
    }
}
