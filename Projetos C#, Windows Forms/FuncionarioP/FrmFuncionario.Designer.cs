namespace FuncionarioP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmpresa = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.box = new System.Windows.Forms.ListBox();
            this.OptGerente = new System.Windows.Forms.RadioButton();
            this.OptSupervisor = new System.Windows.Forms.RadioButton();
            this.OptFuncionario = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.Location = new System.Drawing.Point(12, 27);
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(291, 23);
            this.TxtEmpresa.TabIndex = 3;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(12, 84);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(291, 23);
            this.TxtNome.TabIndex = 4;
            // 
            // box
            // 
            this.box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box.FormattingEnabled = true;
            this.box.ItemHeight = 15;
            this.box.Location = new System.Drawing.Point(12, 166);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(128, 92);
            this.box.TabIndex = 5;
            // 
            // OptGerente
            // 
            this.OptGerente.AutoSize = true;
            this.OptGerente.Location = new System.Drawing.Point(20, 182);
            this.OptGerente.Name = "OptGerente";
            this.OptGerente.Size = new System.Drawing.Size(66, 19);
            this.OptGerente.TabIndex = 6;
            this.OptGerente.TabStop = true;
            this.OptGerente.Text = "Gerente";
            this.OptGerente.UseVisualStyleBackColor = true;
            // 
            // OptSupervisor
            // 
            this.OptSupervisor.AutoSize = true;
            this.OptSupervisor.Location = new System.Drawing.Point(20, 207);
            this.OptSupervisor.Name = "OptSupervisor";
            this.OptSupervisor.Size = new System.Drawing.Size(80, 19);
            this.OptSupervisor.TabIndex = 7;
            this.OptSupervisor.TabStop = true;
            this.OptSupervisor.Text = "Supervisor";
            this.OptSupervisor.UseVisualStyleBackColor = true;
            // 
            // OptFuncionario
            // 
            this.OptFuncionario.AutoSize = true;
            this.OptFuncionario.Location = new System.Drawing.Point(20, 232);
            this.OptFuncionario.Name = "OptFuncionario";
            this.OptFuncionario.Size = new System.Drawing.Size(88, 19);
            this.OptFuncionario.TabIndex = 8;
            this.OptFuncionario.TabStop = true;
            this.OptFuncionario.Text = "Funcionário";
            this.OptFuncionario.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Defina seu Cargo";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(202, 166);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(87, 92);
            this.BtnCalcular.TabIndex = 10;
            this.BtnCalcular.Text = "Calcular Salário";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 312);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OptFuncionario);
            this.Controls.Add(this.OptSupervisor);
            this.Controls.Add(this.OptGerente);
            this.Controls.Add(this.box);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Verifique seu Salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox TxtEmpresa;
        private TextBox TxtNome;
        private ListBox box;
        private RadioButton OptGerente;
        private RadioButton OptSupervisor;
        private RadioButton OptFuncionario;
        private Label label4;
        private Button BtnCalcular;
    }
}