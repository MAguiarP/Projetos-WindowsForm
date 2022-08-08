namespace Calculadora
{
    partial class Calculadora
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
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.TxtExpressao = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptAdicao = new System.Windows.Forms.RadioButton();
            this.OptSubtracao = new System.Windows.Forms.RadioButton();
            this.OptMultiplicacao = new System.Windows.Forms.RadioButton();
            this.OptDivisao = new System.Windows.Forms.RadioButton();
            this.OptRestoDivisao = new System.Windows.Forms.RadioButton();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expressão";
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Location = new System.Drawing.Point(15, 28);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(100, 22);
            this.TxtNumero1.TabIndex = 4;
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.Location = new System.Drawing.Point(196, 28);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(100, 22);
            this.TxtNumero2.TabIndex = 5;
            // 
            // TxtExpressao
            // 
            this.TxtExpressao.Location = new System.Drawing.Point(12, 274);
            this.TxtExpressao.Name = "TxtExpressao";
            this.TxtExpressao.Size = new System.Drawing.Size(100, 22);
            this.TxtExpressao.TabIndex = 6;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(12, 318);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(100, 22);
            this.TxtResultado.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OptRestoDivisao);
            this.groupBox1.Controls.Add(this.OptDivisao);
            this.groupBox1.Controls.Add(this.OptMultiplicacao);
            this.groupBox1.Controls.Add(this.OptSubtracao);
            this.groupBox1.Controls.Add(this.OptAdicao);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 196);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operação";
            // 
            // OptAdicao
            // 
            this.OptAdicao.AutoSize = true;
            this.OptAdicao.Location = new System.Drawing.Point(0, 21);
            this.OptAdicao.Name = "OptAdicao";
            this.OptAdicao.Size = new System.Drawing.Size(89, 20);
            this.OptAdicao.TabIndex = 0;
            this.OptAdicao.TabStop = true;
            this.OptAdicao.Text = "Adição (+)";
            this.OptAdicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OptAdicao.UseVisualStyleBackColor = true;
            // 
            // OptSubtracao
            // 
            this.OptSubtracao.AutoSize = true;
            this.OptSubtracao.Location = new System.Drawing.Point(0, 57);
            this.OptSubtracao.Name = "OptSubtracao";
            this.OptSubtracao.Size = new System.Drawing.Size(102, 20);
            this.OptSubtracao.TabIndex = 1;
            this.OptSubtracao.TabStop = true;
            this.OptSubtracao.Text = "Subtração(-)";
            this.OptSubtracao.UseVisualStyleBackColor = true;
            // 
            // OptMultiplicacao
            // 
            this.OptMultiplicacao.AutoSize = true;
            this.OptMultiplicacao.Location = new System.Drawing.Point(0, 94);
            this.OptMultiplicacao.Name = "OptMultiplicacao";
            this.OptMultiplicacao.Size = new System.Drawing.Size(120, 20);
            this.OptMultiplicacao.TabIndex = 2;
            this.OptMultiplicacao.TabStop = true;
            this.OptMultiplicacao.Text = "Multiplicação(*)";
            this.OptMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // OptDivisao
            // 
            this.OptDivisao.AutoSize = true;
            this.OptDivisao.Location = new System.Drawing.Point(0, 133);
            this.OptDivisao.Name = "OptDivisao";
            this.OptDivisao.Size = new System.Drawing.Size(86, 20);
            this.OptDivisao.TabIndex = 3;
            this.OptDivisao.TabStop = true;
            this.OptDivisao.Text = "Divisão(/)";
            this.OptDivisao.UseVisualStyleBackColor = true;
            // 
            // OptRestoDivisao
            // 
            this.OptRestoDivisao.AutoSize = true;
            this.OptRestoDivisao.Location = new System.Drawing.Point(0, 170);
            this.OptRestoDivisao.Name = "OptRestoDivisao";
            this.OptRestoDivisao.Size = new System.Drawing.Size(152, 20);
            this.OptRestoDivisao.TabIndex = 4;
            this.OptRestoDivisao.TabStop = true;
            this.OptRestoDivisao.Text = "Resto da Divisão(%)";
            this.OptRestoDivisao.UseVisualStyleBackColor = true;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(200, 258);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(96, 139);
            this.BtnCalcular.TabIndex = 9;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(15, 359);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(90, 35);
            this.BtnLimpar.TabIndex = 10;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click_1);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(118, 343);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(61, 51);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 406);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtExpressao);
            this.Controls.Add(this.TxtNumero2);
            this.Controls.Add(this.TxtNumero1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.TextBox TxtExpressao;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OptRestoDivisao;
        private System.Windows.Forms.RadioButton OptDivisao;
        private System.Windows.Forms.RadioButton OptMultiplicacao;
        private System.Windows.Forms.RadioButton OptSubtracao;
        private System.Windows.Forms.RadioButton OptAdicao;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
    }
}

