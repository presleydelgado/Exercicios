using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParImparZero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float valor = float.Parse(textBoxValor.Text);
                int resto = (int)valor % 2;
                if(valor == 0)
                {
                    MessageBox.Show("Valor digitado é zero");
                    resultado.Text = ("Valor digitado é Zero");
                } else if (resto > 0 )
                {
                    resultado.Text = "Valor digitado é impar";
                }
                else
                {
                    resultado.Text = "Valor digitado é par";
                }
            }
            catch
            {
                MessageBox.Show("Valor digitado é invalido");
            }
        }
    }
}
