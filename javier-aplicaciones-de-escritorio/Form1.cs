using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace javier_aplicaciones_de_escritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dia.Text = DateTime.Now.ToString("dd");
            label2.Text = DateTime.Now.ToString("MM");
            label3.Text = DateTime.Now.ToString("yy");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dia_click(object sender, EventArgs e)
        {
            

        }

        private void dia_Click(object sender, EventArgs e)
        {

        }

        private void cmbCOLORES_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cmbCOLORES.Text == "ROJO")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;

            }
           if(cmbCOLORES.Text == "AZUL")
            {
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
            }
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
