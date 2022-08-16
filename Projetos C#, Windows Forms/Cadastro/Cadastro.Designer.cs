namespace Cadastro
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtSobrenome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptSolteiro = new System.Windows.Forms.RadioButton();
            this.OptCasado = new System.Windows.Forms.RadioButton();
            this.OptDivorciado = new System.Windows.Forms.RadioButton();
            this.OptViuvo = new System.Windows.Forms.RadioButton();
            this.BtnExibir = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            resources.ApplyResources(this.TxtNome, "TxtNome");
            this.TxtNome.Name = "TxtNome";
            // 
            // TxtSobrenome
            // 
            resources.ApplyResources(this.TxtSobrenome, "TxtSobrenome");
            this.TxtSobrenome.Name = "TxtSobrenome";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OptSolteiro);
            this.groupBox1.Controls.Add(this.OptCasado);
            this.groupBox1.Controls.Add(this.OptDivorciado);
            this.groupBox1.Controls.Add(this.OptViuvo);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // OptSolteiro
            // 
            resources.ApplyResources(this.OptSolteiro, "OptSolteiro");
            this.OptSolteiro.Name = "OptSolteiro";
            this.OptSolteiro.TabStop = true;
            this.OptSolteiro.UseVisualStyleBackColor = true;
            // 
            // OptCasado
            // 
            resources.ApplyResources(this.OptCasado, "OptCasado");
            this.OptCasado.Name = "OptCasado";
            this.OptCasado.TabStop = true;
            this.OptCasado.UseVisualStyleBackColor = true;
            // 
            // OptDivorciado
            // 
            resources.ApplyResources(this.OptDivorciado, "OptDivorciado");
            this.OptDivorciado.Name = "OptDivorciado";
            this.OptDivorciado.TabStop = true;
            this.OptDivorciado.UseVisualStyleBackColor = true;
            // 
            // OptViuvo
            // 
            resources.ApplyResources(this.OptViuvo, "OptViuvo");
            this.OptViuvo.Name = "OptViuvo";
            this.OptViuvo.TabStop = true;
            this.OptViuvo.UseVisualStyleBackColor = true;
            // 
            // BtnExibir
            // 
            resources.ApplyResources(this.BtnExibir, "BtnExibir");
            this.BtnExibir.Name = "BtnExibir";
            this.BtnExibir.UseVisualStyleBackColor = true;
            this.BtnExibir.Click += new System.EventHandler(this.BtnExibir_Click);
            // 
            // BtnLimpar
            // 
            resources.ApplyResources(this.BtnLimpar, "BtnLimpar");
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnFechar
            // 
            resources.ApplyResources(this.BtnFechar, "BtnFechar");
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // Cadastro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnExibir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSobrenome);
            this.Controls.Add(this.TxtNome);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtSobrenome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OptSolteiro;
        private System.Windows.Forms.RadioButton OptCasado;
        private System.Windows.Forms.RadioButton OptDivorciado;
        private System.Windows.Forms.RadioButton OptViuvo;
        private System.Windows.Forms.Button BtnExibir;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnFechar;
    }
}

