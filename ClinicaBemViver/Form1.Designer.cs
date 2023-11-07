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
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.textBoxtelefone = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxidade = new System.Windows.Forms.TextBox();
            this.textBoxcpf = new System.Windows.Forms.TextBox();
            this.buttonsalvar = new System.Windows.Forms.Button();
            this.richTextBoxresultado = new System.Windows.Forms.RichTextBox();
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
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(55, 33);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(188, 26);
            this.textBoxnome.TabIndex = 5;
            // 
            // textBoxtelefone
            // 
            this.textBoxtelefone.Location = new System.Drawing.Point(55, 91);
            this.textBoxtelefone.Name = "textBoxtelefone";
            this.textBoxtelefone.Size = new System.Drawing.Size(188, 26);
            this.textBoxtelefone.TabIndex = 6;
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(55, 154);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(188, 26);
            this.textBoxemail.TabIndex = 7;
            // 
            // textBoxidade
            // 
            this.textBoxidade.Location = new System.Drawing.Point(55, 215);
            this.textBoxidade.Name = "textBoxidade";
            this.textBoxidade.Size = new System.Drawing.Size(188, 26);
            this.textBoxidade.TabIndex = 8;
            // 
            // textBoxcpf
            // 
            this.textBoxcpf.Location = new System.Drawing.Point(55, 274);
            this.textBoxcpf.Name = "textBoxcpf";
            this.textBoxcpf.Size = new System.Drawing.Size(188, 26);
            this.textBoxcpf.TabIndex = 9;
            // 
            // buttonsalvar
            // 
            this.buttonsalvar.Location = new System.Drawing.Point(97, 323);
            this.buttonsalvar.Name = "buttonsalvar";
            this.buttonsalvar.Size = new System.Drawing.Size(102, 33);
            this.buttonsalvar.TabIndex = 10;
            this.buttonsalvar.Text = "Salvar";
            this.buttonsalvar.UseVisualStyleBackColor = true;
            this.buttonsalvar.Click += new System.EventHandler(this.button1salvar_Click);
            // 
            // richTextBoxresultado
            // 
            this.richTextBoxresultado.Location = new System.Drawing.Point(270, 33);
            this.richTextBoxresultado.Name = "richTextBoxresultado";
            this.richTextBoxresultado.Size = new System.Drawing.Size(321, 267);
            this.richTextBoxresultado.TabIndex = 11;
            this.richTextBoxresultado.Text = "";
            // 
            // formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 388);
            this.Controls.Add(this.richTextBoxresultado);
            this.Controls.Add(this.buttonsalvar);
            this.Controls.Add(this.textBoxcpf);
            this.Controls.Add(this.textBoxidade);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxtelefone);
            this.Controls.Add(this.textBoxnome);
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
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.TextBox textBoxtelefone;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxidade;
        private System.Windows.Forms.TextBox textBoxcpf;
        private System.Windows.Forms.Button buttonsalvar;
        private System.Windows.Forms.RichTextBox richTextBoxresultado;
    }
}

