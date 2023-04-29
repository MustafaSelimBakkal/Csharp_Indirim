using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat;
            double ind;
            fiyat = Convert.ToInt16(textBox1.Text);
            ind= fiyat - fiyat*0.10;
           label1.Text=ind.ToString();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fiyat;
            double ind;
            fiyat = Convert.ToInt16(textBox1.Text);
            ind = fiyat - fiyat * 0.25;
            label1.Text = ind.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fiyat;
            double ind;
            fiyat = Convert.ToInt16(textBox1.Text);
            ind = fiyat - fiyat * 0.50;
           label1.Text = ind.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fiyat;
            double ind;
            fiyat = Convert.ToInt16(textBox1.Text);
            ind = fiyat - fiyat * 0.75;
            label1.Text = ind.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
