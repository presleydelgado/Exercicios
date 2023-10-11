using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaizQuadrada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorbase = 0;

            try
            {
                valorbase = double.Parse(ValorOriginal.Text);
                double raizQuadrada = Math.Sqrt(valorbase);
                Resultado.Text = "A raiz quadrada é " + raizQuadrada;
            }
            catch
            {
                MessageBox.Show("Valor invalido");
            }
            
            
        }
    }
}
