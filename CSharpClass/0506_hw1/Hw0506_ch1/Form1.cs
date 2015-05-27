using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw0506_ch1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "visual C# 2013";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "基礎必修課程";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }


    }
}
