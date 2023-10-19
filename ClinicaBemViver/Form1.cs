using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaBemViver
{
    public partial class formulario : Form
    {
        public formulario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomecompleto = textBox1nome.Text;
                string telefone = textBox2telefone.Text;
                string email = textBox3email.Text;
                string idade = textBox4idade.Text;
                string cpf = textBox5cpf.Text;

                this.richTextBox1resultado.Text = "Dados: " + "\nNome Completo: " + nomecompleto + "\nTelefone: " + telefone + "\nEmail: " + email + "\nIdade: " + idade + "\nCPF: " + cpf; 

                //MessageBox.Show($"Dados \nNome Completo: {nomecompleto} \nTelefone: {telefone} \nEmail: {email} \nIdade: {idade} \nCPF: {cpf}.");
            }
            catch
            {
                MessageBox.Show("Valor invalido");
            }

            textBox1nome.Text = "";
            textBox2telefone.Text = "";
            textBox3email.Text = "";
            textBox4idade.Text = "";
            textBox5cpf.Text = "";
            
           
            
         
            
        }
    }
}
