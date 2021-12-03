using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telop_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += -trackBar1.Value;
            if (label1.Right < 0)
            {

                label1.Left = this.ClientSize.Width - label1.Right;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "現在の速度:"+trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
    
}
