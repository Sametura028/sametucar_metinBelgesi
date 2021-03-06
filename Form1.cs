using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            String[] kelime = richTextBox1.Text.Split();
            int ksayisi = richTextBox1.Text.Trim().Split().Length;
            toolStripStatusLabel2.Text = ksayisi.ToString();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog yeniDosya = new OpenFileDialog();
            yeniDosya.Filter = "Tüm dosyalar| * *";
            if (yeniDosya.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(yeniDosya.FileName);
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(yeniDosya.FileName);
                }
                else 
                {
                    MessageBox.Show("HATA");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Directory.CreateDirectory("C: yeni dosya");
        }

        private void yeniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
