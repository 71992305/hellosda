using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8._6._3_StatusStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Minimum = 0;
            this.toolStripProgressBar1.Maximum = 5000;
            this.toolStripProgressBar1.Step = 2;
            for (int i = 0; i <=4999; i++)
            {
                this.toolStripProgressBar1.PerformStep();
            }
        }
    }
}
