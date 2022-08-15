namespace Estrutura_de_Repetição
{
    partial class FrmEstruturaRepeticao
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
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.groupBoxEstrutura = new System.Windows.Forms.GroupBox();
            this.OptFor = new System.Windows.Forms.RadioButton();
            this.OptWhile = new System.Windows.Forms.RadioButton();
            this.OptDo = new System.Windows.Forms.RadioButton();
            this.groupBoxEstrutura.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(15, 55);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(272, 24);
            this.TxtNumero.TabIndex = 0;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(293, 180);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(148, 90);
            this.BtnCalcular.TabIndex = 1;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um número para ser validado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado Operação";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(15, 139);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtResultado.Size = new System.Drawing.Size(272, 131);
            this.TxtResultado.TabIndex = 4;
            // 
            // groupBoxEstrutura
            // 
            this.groupBoxEstrutura.Controls.Add(this.OptDo);
            this.groupBoxEstrutura.Controls.Add(this.OptFor);
            this.groupBoxEstrutura.Controls.Add(this.OptWhile);
            this.groupBoxEstrutura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBoxEstrutura.Location = new System.Drawing.Point(293, 22);
            this.groupBoxEstrutura.Name = "groupBoxEstrutura";
            this.groupBoxEstrutura.Size = new System.Drawing.Size(156, 152);
            this.groupBoxEstrutura.TabIndex = 5;
            this.groupBoxEstrutura.TabStop = false;
            this.groupBoxEstrutura.Text = "Estrutura";
            // 
            // OptFor
            // 
            this.OptFor.AutoSize = true;
            this.OptFor.Location = new System.Drawing.Point(6, 51);
            this.OptFor.Name = "OptFor";
            this.OptFor.Size = new System.Drawing.Size(55, 22);
            this.OptFor.TabIndex = 1;
            this.OptFor.TabStop = true;
            this.OptFor.Text = "For";
            this.OptFor.UseVisualStyleBackColor = true;
            // 
            // OptWhile
            // 
            this.OptWhile.AutoSize = true;
            this.OptWhile.Location = new System.Drawing.Point(6, 23);
            this.OptWhile.Name = "OptWhile";
            this.OptWhile.Size = new System.Drawing.Size(71, 22);
            this.OptWhile.TabIndex = 0;
            this.OptWhile.TabStop = true;
            this.OptWhile.Text = "While";
            this.OptWhile.UseVisualStyleBackColor = true;
            // 
            // OptDo
            // 
            this.OptDo.AutoSize = true;
            this.OptDo.Location = new System.Drawing.Point(6, 78);
            this.OptDo.Name = "OptDo";
            this.OptDo.Size = new System.Drawing.Size(51, 22);
            this.OptDo.TabIndex = 2;
            this.OptDo.TabStop = true;
            this.OptDo.Text = "Do";
            this.OptDo.UseVisualStyleBackColor = true;
            // 
            // FrmEstruturaRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 282);
            this.Controls.Add(this.groupBoxEstrutura);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtNumero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmEstruturaRepeticao";
            this.Text = "Estrutura Repetição";
            this.groupBoxEstrutura.ResumeLayout(false);
            this.groupBoxEstrutura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.GroupBox groupBoxEstrutura;
        private System.Windows.Forms.RadioButton OptWhile;
        private System.Windows.Forms.RadioButton OptFor;
        private System.Windows.Forms.RadioButton OptDo;
    }
}

