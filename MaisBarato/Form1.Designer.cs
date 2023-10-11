namespace MaisBarato
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
            this.textBox1valor1 = new System.Windows.Forms.TextBox();
            this.textBox2valor2 = new System.Windows.Forms.TextBox();
            this.textBox3valor3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1valor1
            // 
            this.textBox1valor1.Location = new System.Drawing.Point(160, 47);
            this.textBox1valor1.Name = "textBox1valor1";
            this.textBox1valor1.Size = new System.Drawing.Size(100, 26);
            this.textBox1valor1.TabIndex = 0;
            // 
            // textBox2valor2
            // 
            this.textBox2valor2.Location = new System.Drawing.Point(160, 120);
            this.textBox2valor2.Name = "textBox2valor2";
            this.textBox2valor2.Size = new System.Drawing.Size(100, 26);
            this.textBox2valor2.TabIndex = 1;
            // 
            // textBox3valor3
            // 
            this.textBox3valor3.Location = new System.Drawing.Point(160, 202);
            this.textBox3valor3.Name = "textBox3valor3";
            this.textBox3valor3.Size = new System.Drawing.Size(100, 26);
            this.textBox3valor3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor 3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mostrar Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3valor3);
            this.Controls.Add(this.textBox2valor2);
            this.Controls.Add(this.textBox1valor1);
            this.Name = "Form1";
            this.Text = "Mais Barato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1valor1;
        private System.Windows.Forms.TextBox textBox2valor2;
        private System.Windows.Forms.TextBox textBox3valor3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

