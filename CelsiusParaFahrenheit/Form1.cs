using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusParaFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valorf = float.Parse(textBox1faherenheit.Text);
            float subf = (valorf - 32);
            double divisaof = (subf / 1.8);

                        
            
        try
            {
                valorf = float.Parse(textBox1faherenheit.Text);
                subf = (valorf - 32);
                divisaof = (subf / 1.8);

                MessageBox.Show("O valor de " + valorf + " graus Fahrenheit para graus Celsius é de: " + divisaof + "° C");

                
            }
        catch
            {
                MessageBox.Show("Valor invalido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valorcampo = (0);
            double valordigitado = (valorcampo);
            double subc = (valordigitado * 1.8);
            double somac = (subc + 32);
            double resultado = (somac);

            try
            {
                valordigitado = float.Parse(textBox1celsius.Text);
                subc = (valordigitado * 1.8);
                somac = (subc + 32);
                resultado = (somac);

                MessageBox.Show("O valor de " + valordigitado+ " ° C para F é de : " + resultado + "°F");
            }
            catch
            {
                MessageBox.Show("Valor invalido");
            }
        }
    }
}
