namespace Polimorfismo
{
    partial class FrmPrincipal
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
            this.LblMostrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptQuadrado = new System.Windows.Forms.RadioButton();
            this.OptTriangulo = new System.Windows.Forms.RadioButton();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMostrar
            // 
            this.LblMostrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMostrar.Location = new System.Drawing.Point(17, 136);
            this.LblMostrar.Name = "LblMostrar";
            this.LblMostrar.Size = new System.Drawing.Size(428, 87);
            this.LblMostrar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 12);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o tamanho do Lado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OptQuadrado);
            this.groupBox1.Controls.Add(this.OptTriangulo);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a opção desejada";
            // 
            // OptQuadrado
            // 
            this.OptQuadrado.AutoSize = true;
            this.OptQuadrado.Location = new System.Drawing.Point(6, 22);
            this.OptQuadrado.Name = "OptQuadrado";
            this.OptQuadrado.Size = new System.Drawing.Size(84, 20);
            this.OptQuadrado.TabIndex = 3;
            this.OptQuadrado.TabStop = true;
            this.OptQuadrado.Text = "Quadrado";
            this.OptQuadrado.UseVisualStyleBackColor = true;
            // 
            // OptTriangulo
            // 
            this.OptTriangulo.AutoSize = true;
            this.OptTriangulo.Location = new System.Drawing.Point(6, 66);
            this.OptTriangulo.Name = "OptTriangulo";
            this.OptTriangulo.Size = new System.Drawing.Size(143, 20);
            this.OptTriangulo.TabIndex = 4;
            this.OptTriangulo.TabStop = true;
            this.OptTriangulo.Text = "Triangulo Equilátero";
            this.OptTriangulo.UseVisualStyleBackColor = true;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(229, 31);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(161, 23);
            this.TxtNumero.TabIndex = 5;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(226, 64);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(219, 48);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(461, 238);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblMostrar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Polimorfismo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OptQuadrado;
        private System.Windows.Forms.RadioButton OptTriangulo;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

