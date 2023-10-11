namespace Media
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
            this.textBox1numero1 = new System.Windows.Forms.TextBox();
            this.textBox2numero2 = new System.Windows.Forms.TextBox();
            this.textBox3numero3 = new System.Windows.Forms.TextBox();
            this.textBox4numero4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1numero1
            // 
            this.textBox1numero1.Location = new System.Drawing.Point(113, 36);
            this.textBox1numero1.Name = "textBox1numero1";
            this.textBox1numero1.Size = new System.Drawing.Size(100, 26);
            this.textBox1numero1.TabIndex = 0;
            // 
            // textBox2numero2
            // 
            this.textBox2numero2.Location = new System.Drawing.Point(113, 94);
            this.textBox2numero2.Name = "textBox2numero2";
            this.textBox2numero2.Size = new System.Drawing.Size(100, 26);
            this.textBox2numero2.TabIndex = 1;
            // 
            // textBox3numero3
            // 
            this.textBox3numero3.Location = new System.Drawing.Point(113, 160);
            this.textBox3numero3.Name = "textBox3numero3";
            this.textBox3numero3.Size = new System.Drawing.Size(100, 26);
            this.textBox3numero3.TabIndex = 2;
            // 
            // textBox4numero4
            // 
            this.textBox4numero4.Location = new System.Drawing.Point(113, 216);
            this.textBox4numero4.Name = "textBox4numero4";
            this.textBox4numero4.Size = new System.Drawing.Size(100, 26);
            this.textBox4numero4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular media";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite os valores ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4numero4);
            this.Controls.Add(this.textBox3numero3);
            this.Controls.Add(this.textBox2numero2);
            this.Controls.Add(this.textBox1numero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1numero1;
        private System.Windows.Forms.TextBox textBox2numero2;
        private System.Windows.Forms.TextBox textBox3numero3;
        private System.Windows.Forms.TextBox textBox4numero4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

