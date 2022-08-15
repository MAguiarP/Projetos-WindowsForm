namespace DataAniversário
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
            this.TxtAniA = new System.Windows.Forms.TextBox();
            this.TxtAniB = new System.Windows.Forms.TextBox();
            this.TxtAniC = new System.Windows.Forms.TextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.LblMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aniversáriante A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aniversáriante B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aniversáriante C";
            // 
            // TxtAniA
            // 
            this.TxtAniA.Location = new System.Drawing.Point(15, 28);
            this.TxtAniA.Name = "TxtAniA";
            this.TxtAniA.Size = new System.Drawing.Size(107, 22);
            this.TxtAniA.TabIndex = 3;
            // 
            // TxtAniB
            // 
            this.TxtAniB.Location = new System.Drawing.Point(179, 28);
            this.TxtAniB.Name = "TxtAniB";
            this.TxtAniB.Size = new System.Drawing.Size(106, 22);
            this.TxtAniB.TabIndex = 4;
            // 
            // TxtAniC
            // 
            this.TxtAniC.Location = new System.Drawing.Point(338, 28);
            this.TxtAniC.Name = "TxtAniC";
            this.TxtAniC.Size = new System.Drawing.Size(102, 22);
            this.TxtAniC.TabIndex = 5;
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(81, 56);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(305, 41);
            this.BtnVerificar.TabIndex = 6;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // LblMostrar
            // 
            this.LblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMostrar.Location = new System.Drawing.Point(15, 125);
            this.LblMostrar.Name = "LblMostrar";
            this.LblMostrar.Size = new System.Drawing.Size(423, 138);
            this.LblMostrar.TabIndex = 7;
            this.LblMostrar.Text = "LblMostrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 272);
            this.Controls.Add(this.LblMostrar);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.TxtAniC);
            this.Controls.Add(this.TxtAniB);
            this.Controls.Add(this.TxtAniA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aniversáriante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAniA;
        private System.Windows.Forms.TextBox TxtAniB;
        private System.Windows.Forms.TextBox TxtAniC;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Label LblMostrar;
    }
}

