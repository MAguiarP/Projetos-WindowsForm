namespace CadastrarProfessor
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.TxtDisciplina = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Disciplina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Matrícula";
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(14, 83);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(244, 22);
            this.TxtMatricula.TabIndex = 23;
            // 
            // TxtDisciplina
            // 
            this.TxtDisciplina.Location = new System.Drawing.Point(277, 83);
            this.TxtDisciplina.Name = "TxtDisciplina";
            this.TxtDisciplina.Size = new System.Drawing.Size(164, 22);
            this.TxtDisciplina.TabIndex = 22;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(14, 26);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(427, 22);
            this.TxtNome.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nome";
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(251, 126);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(190, 36);
            this.BtnConsulta.TabIndex = 19;
            this.BtnConsulta.Text = "Consultar Professor(a)";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Location = new System.Drawing.Point(14, 128);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(187, 34);
            this.BtnCadastro.TabIndex = 18;
            this.BtnCadastro.Text = "Cadastrar Professor(a)";
            this.BtnCadastro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 174);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.TxtDisciplina);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.BtnCadastro);
            this.Name = "Form1";
            this.Text = "Cadastrar Professor(a)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.TextBox TxtDisciplina;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnCadastro;
    }
}

