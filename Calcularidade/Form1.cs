using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcularidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anoReferencia = 2040;
            int anoNascimento = 0;
            try
            {
                anoNascimento = int.Parse(textBoxanonascimento.Text);
            }
            catch
            {
                MessageBox.Show("Valor invalido");
            }

            int idade = anoReferencia - anoNascimento;

            label2resultado.Text = "A idade é " + idade + " no ano de " + anoReferencia;
        }
    }
}
