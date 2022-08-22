namespace CadastroVeiculo
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
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtAno = new System.Windows.Forms.TextBox();
            this.BtnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.BtnConsultarVeiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(12, 38);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(345, 22);
            this.TxtMarca.TabIndex = 3;
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(12, 100);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(209, 22);
            this.TxtModelo.TabIndex = 4;
            // 
            // TxtAno
            // 
            this.TxtAno.Location = new System.Drawing.Point(240, 100);
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtAno.Size = new System.Drawing.Size(117, 22);
            this.TxtAno.TabIndex = 5;
            // 
            // BtnCadastrarVeiculo
            // 
            this.BtnCadastrarVeiculo.Location = new System.Drawing.Point(12, 145);
            this.BtnCadastrarVeiculo.Name = "BtnCadastrarVeiculo";
            this.BtnCadastrarVeiculo.Size = new System.Drawing.Size(164, 39);
            this.BtnCadastrarVeiculo.TabIndex = 6;
            this.BtnCadastrarVeiculo.Text = "Cadastrar Veículo";
            this.BtnCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.BtnCadastrarVeiculo.Click += new System.EventHandler(this.BtnCadastrarVeiculo_Click);
            // 
            // BtnConsultarVeiculo
            // 
            this.BtnConsultarVeiculo.Location = new System.Drawing.Point(193, 144);
            this.BtnConsultarVeiculo.Name = "BtnConsultarVeiculo";
            this.BtnConsultarVeiculo.Size = new System.Drawing.Size(164, 40);
            this.BtnConsultarVeiculo.TabIndex = 7;
            this.BtnConsultarVeiculo.Text = "Consultar Veículo";
            this.BtnConsultarVeiculo.UseVisualStyleBackColor = true;
            this.BtnConsultarVeiculo.Click += new System.EventHandler(this.BtnConsultarVeiculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 211);
            this.Controls.Add(this.BtnConsultarVeiculo);
            this.Controls.Add(this.BtnCadastrarVeiculo);
            this.Controls.Add(this.TxtAno);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastrar Veículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtAno;
        private System.Windows.Forms.Button BtnCadastrarVeiculo;
        private System.Windows.Forms.Button BtnConsultarVeiculo;
    }
}

