namespace CelsiusParaFahrenheit
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1faherenheit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1celsius = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor em Faherenheit";
            // 
            // textBox1faherenheit
            // 
            this.textBox1faherenheit.Location = new System.Drawing.Point(257, 68);
            this.textBox1faherenheit.Name = "textBox1faherenheit";
            this.textBox1faherenheit.Size = new System.Drawing.Size(100, 26);
            this.textBox1faherenheit.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular F para C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1celsius
            // 
            this.textBox1celsius.Location = new System.Drawing.Point(502, 68);
            this.textBox1celsius.Name = "textBox1celsius";
            this.textBox1celsius.Size = new System.Drawing.Size(100, 26);
            this.textBox1celsius.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Calcular C para F";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor em Celsius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1celsius);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1faherenheit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1faherenheit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1celsius;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

