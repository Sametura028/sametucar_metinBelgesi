using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25ekim2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog renk = new ColorDialog();
            renk.ShowDialog();
            richTextBox1.ForeColor = renk.Color;
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FontDialog yztip = new FontDialog();
            yztip.ShowDialog(); 
            richTextBox1.Font=yztip.Font;
        }
    }
}
