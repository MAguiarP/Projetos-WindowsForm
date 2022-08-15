namespace Sobrescrita
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptFuncionario = new System.Windows.Forms.RadioButton();
            this.OptSupervisor = new System.Windows.Forms.RadioButton();
            this.OptGerente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEmpresa = new System.Windows.Forms.TextBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.OptFuncionario);
            this.groupBox1.Controls.Add(this.OptSupervisor);
            this.groupBox1.Controls.Add(this.OptGerente);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(242, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Defina seu Cargo";
            // 
            // OptFuncionario
            // 
            this.OptFuncionario.AutoSize = true;
            this.OptFuncionario.Location = new System.Drawing.Point(6, 72);
            this.OptFuncionario.Name = "OptFuncionario";
            this.OptFuncionario.Size = new System.Drawing.Size(88, 19);
            this.OptFuncionario.TabIndex = 2;
            this.OptFuncionario.TabStop = true;
            this.OptFuncionario.Text = "Funcionário";
            this.OptFuncionario.UseVisualStyleBackColor = true;
            // 
            // OptSupervisor
            // 
            this.OptSupervisor.AutoSize = true;
            this.OptSupervisor.Location = new System.Drawing.Point(6, 22);
            this.OptSupervisor.Name = "OptSupervisor";
            this.OptSupervisor.Size = new System.Drawing.Size(80, 19);
            this.OptSupervisor.TabIndex = 1;
            this.OptSupervisor.TabStop = true;
            this.OptSupervisor.Text = "Supervisor";
            this.OptSupervisor.UseVisualStyleBackColor = true;
            // 
            // OptGerente
            // 
            this.OptGerente.AutoSize = true;
            this.OptGerente.Location = new System.Drawing.Point(6, 47);
            this.OptGerente.Name = "OptGerente";
            this.OptGerente.Size = new System.Drawing.Size(66, 19);
            this.OptGerente.TabIndex = 0;
            this.OptGerente.TabStop = true;
            this.OptGerente.Text = "Gerente";
            this.OptGerente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(6, 26);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(398, 23);
            this.TxtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Empresa";
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.Location = new System.Drawing.Point(6, 73);
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(216, 23);
            this.TxtEmpresa.TabIndex = 4;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(6, 127);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(216, 28);
            this.BtnConsultar.TabIndex = 5;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(417, 174);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.TxtEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Consulta Dados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton OptFuncionario;
        private RadioButton OptSupervisor;
        private RadioButton OptGerente;
        private Label label1;
        private TextBox TxtNome;
        private Label label2;
        private TextBox TxtEmpresa;
        private Button BtnConsultar;
    }
}