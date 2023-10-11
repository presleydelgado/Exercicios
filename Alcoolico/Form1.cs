using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alcoolico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valoralcoolico = 0;

            try
            {
                valoralcoolico = float.Parse(textBox1valoralcoolico.Text);
                if (valoralcoolico < 0.25)
                {
                    MessageBox.Show("Liberado");
                }
                if(valoralcoolico >= 0.25 & valoralcoolico < 0.50)
                {
                    MessageBox.Show("Multado em R$100,00 ");
                }
                if (valoralcoolico >= 0.25 & valoralcoolico <= 1.0)
                {
                    MessageBox.Show("Multado em R$300,00");
                }
                else
                {
                    MessageBox.Show("Você está preso");
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Valor invalido");
            }
        }
    }
}
