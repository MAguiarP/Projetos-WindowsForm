namespace Divisão
{
    partial class FrmDivisao
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
            this.TxtDividendo = new System.Windows.Forms.TextBox();
            this.TxtDivisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtQuociente = new System.Windows.Forms.TextBox();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDividendo
            // 
            this.TxtDividendo.Location = new System.Drawing.Point(37, 49);
            this.TxtDividendo.Name = "TxtDividendo";
            this.TxtDividendo.Size = new System.Drawing.Size(100, 22);
            this.TxtDividendo.TabIndex = 0;
            // 
            // TxtDivisor
            // 
            this.TxtDivisor.Location = new System.Drawing.Point(231, 49);
            this.TxtDivisor.Name = "TxtDivisor";
            this.TxtDivisor.Size = new System.Drawing.Size(100, 22);
            this.TxtDivisor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dividendo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Divisor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quociente";
            // 
            // TxtQuociente
            // 
            this.TxtQuociente.Location = new System.Drawing.Point(37, 125);
            this.TxtQuociente.Name = "TxtQuociente";
            this.TxtQuociente.ReadOnly = true;
            this.TxtQuociente.Size = new System.Drawing.Size(100, 22);
            this.TxtQuociente.TabIndex = 5;
            // 
            // BtnDividir
            // 
            this.BtnDividir.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDividir.Location = new System.Drawing.Point(169, 104);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(162, 43);
            this.BtnDividir.TabIndex = 6;
            this.BtnDividir.Text = "Dividir";
            this.BtnDividir.UseVisualStyleBackColor = true;
            this.BtnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // FrmDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(373, 180);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.TxtQuociente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDivisor);
            this.Controls.Add(this.TxtDividendo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmDivisao";
            this.Opacity = 0.99D;
            this.Text = "Divisão";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDividendo;
        private System.Windows.Forms.TextBox TxtDivisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtQuociente;
        private System.Windows.Forms.Button BtnDividir;
    }
}

