using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelecionarGenero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Genero Masculino");
        }

        private void radioButton1Masculino_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Genero Masculino");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1Masculino.Checked)
            {
                MessageBox.Show("Masculino");
            }
            else if (radioButton2Feminino.Checked) 
            {
                MessageBox.Show("Feminino");
            }
        }
    }
}
