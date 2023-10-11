using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senha
{
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senha = textBox1senha.Text;

            if (senha == "12345") 
            {
                MessageBox.Show ("Bem vindo!");
            }
            else

            {
                MessageBox.Show ("Acesso negado");
            }
        }
    }
}
