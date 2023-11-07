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
                string nomecompleto = textBoxnome.Text;
                string telefone = textBoxtelefone.Text;
                string email = textBoxemail.Text;
                int idade = int.Parse(textBoxidade.Text);
                string cpf = textBoxcpf.Text;

                
                this.richTextBoxresultado.Text = "Dados: " + "\nNome Completo: " + nomecompleto + "\nTelefone: " + telefone + "\nEmail: " + email + "\nIdade: " + idade + "\nCPF: " + cpf; 

                //MessageBox.Show($"Dados \nNome Completo: {nomecompleto} \nTelefone: {telefone} \nEmail: {email} \nIdade: {idade} \nCPF: {cpf}.");
            }
            catch
            {
                MessageBox.Show("ERRO \nValor valido \nVerifique se preencheu corretamente os campos");
            }

            textBoxnome.Text = "";
            textBoxtelefone.Text = "";
            textBoxemail.Text = "";
            textBoxidade.Text = "";
            textBoxcpf.Text = "";
            
           
            
         
            
        }
    }
}
