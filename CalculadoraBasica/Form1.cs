using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxValorUm_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valorum = float.Parse(textBoxValorUm.Text);
            float valordois = float.Parse (textBoxValorDois.Text);

            float resultado = valorum + valordois;

            labelresposta.Text = resultado.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            float valorum = float.Parse (textBoxValorUm.Text);
            float valordois = float.Parse(textBoxValorDois.Text);

            float resultado = valorum - valordois;

            labelresposta.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float valorum = float.Parse(textBoxValorUm.Text);
            float valordois = float.Parse(textBoxValorDois.Text);

            float resultado = valorum / valordois;

            labelresposta.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float valorum = float.Parse(textBoxValorUm.Text);
            float valordois = float.Parse(textBoxValorDois.Text);

            float resultado = valorum * valordois;

            labelresposta.Text = resultado.ToString();
        }
    }
}
