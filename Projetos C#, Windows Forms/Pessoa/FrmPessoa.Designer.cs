
namespace Pessoa
{
    partial class FrmPessoa
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
            this.label5 = new System.Windows.Forms.Label();
            this.BtnMostrarDataCompleta = new System.Windows.Forms.Button();
            this.BtnMostrarData = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.txtQI = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mês Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "QI";
            // 
            // BtnMostrarDataCompleta
            // 
            this.BtnMostrarDataCompleta.Location = new System.Drawing.Point(145, 93);
            this.BtnMostrarDataCompleta.Name = "BtnMostrarDataCompleta";
            this.BtnMostrarDataCompleta.Size = new System.Drawing.Size(240, 38);
            this.BtnMostrarDataCompleta.TabIndex = 5;
            this.BtnMostrarDataCompleta.Text = "Mostrar Data Completa";
            this.BtnMostrarDataCompleta.UseVisualStyleBackColor = true;
            this.BtnMostrarDataCompleta.Click += new System.EventHandler(this.BtnMostrarDataCompleta_Click);
            // 
            // BtnMostrarData
            // 
            this.BtnMostrarData.Location = new System.Drawing.Point(145, 137);
            this.BtnMostrarData.Name = "BtnMostrarData";
            this.BtnMostrarData.Size = new System.Drawing.Size(240, 36);
            this.BtnMostrarData.TabIndex = 6;
            this.BtnMostrarData.Text = "Mostar Data";
            this.BtnMostrarData.UseVisualStyleBackColor = true;
            this.BtnMostrarData.Click += new System.EventHandler(this.BtnMostrarData_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(58, 6);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(329, 26);
            this.TxtNome.TabIndex = 7;
            // 
            // txtQI
            // 
            this.txtQI.Location = new System.Drawing.Point(14, 118);
            this.txtQI.Name = "txtQI";
            this.txtQI.Size = new System.Drawing.Size(116, 26);
            this.txtQI.TabIndex = 8;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(14, 65);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(116, 26);
            this.txtDia.TabIndex = 9;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(145, 65);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(116, 26);
            this.txtMes.TabIndex = 10;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(272, 65);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(116, 26);
            this.txtAno.TabIndex = 11;
            // 
            // LblResultado
            // 
            this.LblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResultado.Location = new System.Drawing.Point(14, 193);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(371, 123);
            this.LblResultado.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 325);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtQI);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.BtnMostrarData);
            this.Controls.Add(this.BtnMostrarDataCompleta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnMostrarDataCompleta;
        private System.Windows.Forms.Button BtnMostrarData;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox txtQI;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label LblResultado;
    }
}

