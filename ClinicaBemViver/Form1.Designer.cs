namespace ClinicaBemViver
{
    partial class formulario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1nome = new System.Windows.Forms.TextBox();
            this.textBox2telefone = new System.Windows.Forms.TextBox();
            this.textBox3email = new System.Windows.Forms.TextBox();
            this.textBox4idade = new System.Windows.Forms.TextBox();
            this.textBox5cpf = new System.Windows.Forms.TextBox();
            this.button1salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Idade :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF :";
            // 
            // textBox1nome
            // 
            this.textBox1nome.Location = new System.Drawing.Point(55, 33);
            this.textBox1nome.Name = "textBox1nome";
            this.textBox1nome.Size = new System.Drawing.Size(188, 26);
            this.textBox1nome.TabIndex = 5;
            // 
            // textBox2telefone
            // 
            this.textBox2telefone.Location = new System.Drawing.Point(55, 91);
            this.textBox2telefone.Name = "textBox2telefone";
            this.textBox2telefone.Size = new System.Drawing.Size(188, 26);
            this.textBox2telefone.TabIndex = 6;
            // 
            // textBox3email
            // 
            this.textBox3email.Location = new System.Drawing.Point(55, 154);
            this.textBox3email.Name = "textBox3email";
            this.textBox3email.Size = new System.Drawing.Size(188, 26);
            this.textBox3email.TabIndex = 7;
            // 
            // textBox4idade
            // 
            this.textBox4idade.Location = new System.Drawing.Point(55, 215);
            this.textBox4idade.Name = "textBox4idade";
            this.textBox4idade.Size = new System.Drawing.Size(188, 26);
            this.textBox4idade.TabIndex = 8;
            // 
            // textBox5cpf
            // 
            this.textBox5cpf.Location = new System.Drawing.Point(55, 274);
            this.textBox5cpf.Name = "textBox5cpf";
            this.textBox5cpf.Size = new System.Drawing.Size(188, 26);
            this.textBox5cpf.TabIndex = 9;
            // 
            // button1salvar
            // 
            this.button1salvar.Location = new System.Drawing.Point(97, 323);
            this.button1salvar.Name = "button1salvar";
            this.button1salvar.Size = new System.Drawing.Size(102, 33);
            this.button1salvar.TabIndex = 10;
            this.button1salvar.Text = "Salvar";
            this.button1salvar.UseVisualStyleBackColor = true;
            this.button1salvar.Click += new System.EventHandler(this.button1salvar_Click);
            // 
            // formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 388);
            this.Controls.Add(this.button1salvar);
            this.Controls.Add(this.textBox5cpf);
            this.Controls.Add(this.textBox4idade);
            this.Controls.Add(this.textBox3email);
            this.Controls.Add(this.textBox2telefone);
            this.Controls.Add(this.textBox1nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formulario";
            this.Text = "Formulário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1nome;
        private System.Windows.Forms.TextBox textBox2telefone;
        private System.Windows.Forms.TextBox textBox3email;
        private System.Windows.Forms.TextBox textBox4idade;
        private System.Windows.Forms.TextBox textBox5cpf;
        private System.Windows.Forms.Button button1salvar;
    }
}

