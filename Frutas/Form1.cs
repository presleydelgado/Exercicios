using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frutas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float custo = 0;
            float frete = 0;
            
            try
            {
                custo = float.Parse(textBox1custo.Text);
                frete = float.Parse(textBox1frete.Text);
                string fruta = comboBox1.SelectedItem.ToString();

                float valortotal = (custo + frete);

                

                switch (fruta)
                {
                    case "Mamão":
                        MessageBox.Show("O valor do Mamão é de R$ " + valortotal * 1.25);
                        break;
                    case "Manga":
                        MessageBox.Show("O valor da Manga é de R$ " + valortotal * 1.25);
                        break;
                    case "Uva":
                        MessageBox.Show("O valor da Uva é de R$ " + valortotal * 1.25);
                        break;
                    case "Maça":
                        MessageBox.Show("O valor da Maça é de R$ " + valortotal * 1.25);
                        break;
                }
                    

            }
            catch
            {
                MessageBox.Show("Valor invalido");
            }
        }
    }
}
