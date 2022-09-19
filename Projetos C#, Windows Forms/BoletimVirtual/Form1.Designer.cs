namespace BoletimVirtual
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt4 = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1° Bimestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2° Bimestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3° Bimestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "4° Bimestre";
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(12, 25);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 4;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(130, 25);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 5;
            // 
            // Txt3
            // 
            this.Txt3.Location = new System.Drawing.Point(249, 25);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(100, 20);
            this.Txt3.TabIndex = 6;
            // 
            // Txt4
            // 
            this.Txt4.Location = new System.Drawing.Point(368, 25);
            this.Txt4.Name = "Txt4";
            this.Txt4.Size = new System.Drawing.Size(100, 20);
            this.Txt4.TabIndex = 7;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(24, 72);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(100, 41);
            this.BtnCalcular.TabIndex = 8;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // LblResultado
            // 
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResultado.Location = new System.Drawing.Point(12, 132);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(456, 198);
            this.LblResultado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 339);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.Txt4);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Boletim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt4;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LblResultado;
    }
}

