using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisBarato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valorum = 0;
            float valordois = 0;
            float valortres = 0;

            try
            {
                valorum = float.Parse(textBox1valor1.Text);
                valordois = float.Parse(textBox2valor2.Text);
                valortres = float.Parse(textBox3valor3.Text);
            }
            catch
            {
                MessageBox.Show("Um dos valores é invalido !");
            }
            if (valorum < valordois)
            {
                if(valorum < valortres)
                {
                    MessageBox.Show("Valor 1 é o mais barato!");
                }else
                {
                    MessageBox.Show("O valor 3 é o mais barato!");
                }

            }else
            {
               if (valordois < valortres)
                {
                    MessageBox.Show("O valor 2 é o mais barato!");
                }
                else
                {
                    MessageBox.Show("O valor 3 é o mais barato!");
                }

                    
            }
        }
    }
}
