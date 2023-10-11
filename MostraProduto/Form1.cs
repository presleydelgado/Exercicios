using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostraProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = textBox1codigoproduto.Text;

            switch (codigo)
            {
                case "100": MessageBox.Show("Valor R$ 1000");
                    break;
                case "101": MessageBox.Show("valor R$ 500");
                    break;
                case "102": MessageBox.Show("Valor R$ 600");
                    break;
                case "103": MessageBox.Show("Valor R$ 1600");
                    break;
                case "104": MessageBox.Show("Valor R$ 10000");
                    break;
            }
        }
    }
}
