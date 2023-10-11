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
            float F = float.Parse(textBox1faherenheit.Text);
            float C = float.Parse(textBox1celsius.Text);
            
        try
            {
                F = float.Parse(textBox1faherenheit.Text);
                C = float.Parse(textBox1celsius.Text);

                MessageBox.Show("Valor em C" + C * 1.8);    
            }
        catch
            {
                MessageBox.Show("Valor invalido");
            }
        }
    }
}
