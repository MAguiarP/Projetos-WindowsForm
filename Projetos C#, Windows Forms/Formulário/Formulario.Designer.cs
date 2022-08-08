namespace Formulário
{
    partial class Formulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.Label();
            this.TxtIdade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.textIdade = new System.Windows.Forms.TextBox();
            this.textEstCiv = new System.Windows.Forms.TextBox();
            this.confirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(57, 22);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Nome";
            // 
            // TxtIdade
            // 
            this.TxtIdade.AutoSize = true;
            this.TxtIdade.BackColor = System.Drawing.Color.Transparent;
            this.TxtIdade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TxtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdade.Location = new System.Drawing.Point(12, 76);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(54, 22);
            this.TxtIdade.TabIndex = 1;
            this.TxtIdade.Text = "Idade";
            this.TxtIdade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado Civil";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textoNome
            // 
            this.textoNome.BackColor = System.Drawing.Color.White;
            this.textoNome.Location = new System.Drawing.Point(12, 34);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(405, 22);
            this.textoNome.TabIndex = 3;
            // 
            // textIdade
            // 
            this.textIdade.BackColor = System.Drawing.Color.White;
            this.textIdade.Location = new System.Drawing.Point(12, 113);
            this.textIdade.Name = "textIdade";
            this.textIdade.Size = new System.Drawing.Size(54, 22);
            this.textIdade.TabIndex = 4;
            // 
            // textEstCiv
            // 
            this.textEstCiv.BackColor = System.Drawing.Color.White;
            this.textEstCiv.Location = new System.Drawing.Point(16, 181);
            this.textEstCiv.Name = "textEstCiv";
            this.textEstCiv.Size = new System.Drawing.Size(113, 22);
            this.textEstCiv.TabIndex = 5;
            // 
            // confirmar
            // 
            this.confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirmar.Location = new System.Drawing.Point(302, 160);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(115, 43);
            this.confirmar.TabIndex = 6;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(16, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 211);
            this.label2.TabIndex = 7;
            this.label2.Text = "labeldados";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.textEstCiv);
            this.Controls.Add(this.textIdade);
            this.Controls.Add(this.textoNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIdade);
            this.Controls.Add(this.txtName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label TxtIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.TextBox textIdade;
        private System.Windows.Forms.TextBox textEstCiv;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Label label2;
    }
}

