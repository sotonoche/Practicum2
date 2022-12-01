using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum2_Task1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGetRes_Click(object sender, EventArgs e)
        {
            var x = (double)numericUpDownX.Value;
            var y = (double)numericUpDownY.Value;

            if ((x * x + y * y > Math.Pow(3, 2)) && (x * x + y * y < Math.Pow(7, 2)))
            {
                ResArea.Text = "Да";
            }
            else if ((x * x + y * y == Math.Pow(3, 2)) || (x * x + y * y == Math.Pow(7, 2)))
            {
                ResArea.Text = "На границе";
            }
            else ResArea.Text = "Нет";
        }
    }
}
