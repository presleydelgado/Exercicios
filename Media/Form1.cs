using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valorum = float.Parse(textBox1numero1.Text);
            float valordois = float.Parse(textBox2numero2.Text);
            float valortres = float.Parse(textBox3numero3.Text);
            float valorquatro = float.Parse(textBox4numero4.Text);
            float resultado = (valorum + valordois + valortres + valorquatro);
            float media = (resultado / 4);

            try
            {
                
                
                MessageBox.Show("A soma dos números é igual a  " + resultado + " e a sua média é de : " + media);
            }
            catch
            {
                MessageBox.Show("Valor invalido");
            }
        }
    }
}
