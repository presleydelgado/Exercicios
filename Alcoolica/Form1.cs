using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alcoolica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void button1_Click_1(object sender, EventArgs e)
        {
            float valoralcool = 0;

            try
            {
                if (valoralcool <= 0.25)
                    MessageBox.Show("Liberado");
            }
            catch
            {
                MessageBox.Show("Valor invalido");
            }
        }
    }
    }
}
