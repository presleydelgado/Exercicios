using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 0;

            try
            {
                idade = int.Parse(textBox1idade.Text);

                if (idade <= 15)
                {
                    MessageBox.Show("Juvenil");
                }
                else if (idade >= 16 & idade <= 20) 
                {
                    MessageBox.Show("Amador");
                }
                else
                {
                    MessageBox.Show("Profissional");
                }
            }
            catch 
            {
                MessageBox.Show("Idade invalida !");
            }
            
        }
    }
}
