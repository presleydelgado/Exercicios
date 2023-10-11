namespace Jogador
{
    partial class Form1
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
            this.textBox1idade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1idadejogador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1idade
            // 
            this.textBox1idade.Location = new System.Drawing.Point(174, 117);
            this.textBox1idade.Name = "textBox1idade";
            this.textBox1idade.Size = new System.Drawing.Size(100, 26);
            this.textBox1idade.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Categoria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1idadejogador
            // 
            this.label1idadejogador.AutoSize = true;
            this.label1idadejogador.Location = new System.Drawing.Point(170, 94);
            this.label1idadejogador.Name = "label1idadejogador";
            this.label1idadejogador.Size = new System.Drawing.Size(185, 20);
            this.label1idadejogador.TabIndex = 2;
            this.label1idadejogador.Text = "Digite a idade do jogador";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1idadejogador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1idade);
            this.Name = "Form1";
            this.Text = "Classificação do jogador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1idade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1idadejogador;
    }
}

