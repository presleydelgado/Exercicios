namespace SelecionarGenero
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
            this.radioButton1Masculino = new System.Windows.Forms.RadioButton();
            this.radioButton2Feminino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2Genero = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1Masculino
            // 
            this.radioButton1Masculino.AutoSize = true;
            this.radioButton1Masculino.Location = new System.Drawing.Point(17, 20);
            this.radioButton1Masculino.Name = "radioButton1Masculino";
            this.radioButton1Masculino.Size = new System.Drawing.Size(73, 17);
            this.radioButton1Masculino.TabIndex = 0;
            this.radioButton1Masculino.TabStop = true;
            this.radioButton1Masculino.Text = "Masculino";
            this.radioButton1Masculino.UseVisualStyleBackColor = true;
            this.radioButton1Masculino.CheckedChanged += new System.EventHandler(this.radioButton1Masculino_CheckedChanged);
            // 
            // radioButton2Feminino
            // 
            this.radioButton2Feminino.AutoSize = true;
            this.radioButton2Feminino.Location = new System.Drawing.Point(17, 43);
            this.radioButton2Feminino.Name = "radioButton2Feminino";
            this.radioButton2Feminino.Size = new System.Drawing.Size(67, 17);
            this.radioButton2Feminino.TabIndex = 1;
            this.radioButton2Feminino.TabStop = true;
            this.radioButton2Feminino.Text = "Feminino";
            this.radioButton2Feminino.UseVisualStyleBackColor = true;
            this.radioButton2Feminino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o Genero :";
            // 
            // label2Genero
            // 
            this.label2Genero.AutoSize = true;
            this.label2Genero.Location = new System.Drawing.Point(329, 36);
            this.label2Genero.Name = "label2Genero";
            this.label2Genero.Size = new System.Drawing.Size(0, 13);
            this.label2Genero.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1Masculino);
            this.groupBox1.Controls.Add(this.radioButton2Feminino);
            this.groupBox1.Location = new System.Drawing.Point(97, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2Genero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1Masculino;
        private System.Windows.Forms.RadioButton radioButton2Feminino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2Genero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

