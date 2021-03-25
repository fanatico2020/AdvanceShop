
namespace AdvShopGeradorKey
{
    partial class FormPrincipal
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
            this.lblPalavraChave = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtDescriptografada = new System.Windows.Forms.TextBox();
            this.lblDescriptografada = new System.Windows.Forms.Label();
            this.txtCriptografada = new System.Windows.Forms.TextBox();
            this.lblCriptografada = new System.Windows.Forms.Label();
            this.txtPalavraChave = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPalavraChave
            // 
            this.lblPalavraChave.AutoSize = true;
            this.lblPalavraChave.Location = new System.Drawing.Point(6, 29);
            this.lblPalavraChave.Name = "lblPalavraChave";
            this.lblPalavraChave.Size = new System.Drawing.Size(77, 13);
            this.lblPalavraChave.TabIndex = 0;
            this.lblPalavraChave.Text = "Palavra Chave";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVencimento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGerar);
            this.groupBox1.Controls.Add(this.txtDescriptografada);
            this.groupBox1.Controls.Add(this.lblDescriptografada);
            this.groupBox1.Controls.Add(this.txtCriptografada);
            this.groupBox1.Controls.Add(this.lblCriptografada);
            this.groupBox1.Controls.Add(this.txtPalavraChave);
            this.groupBox1.Controls.Add(this.lblPalavraChave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerador de chave para uso do sistema";
            // 
            // txtVencimento
            // 
            this.txtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtVencimento.Location = new System.Drawing.Point(9, 162);
            this.txtVencimento.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.txtVencimento.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(110, 20);
            this.txtVencimento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vencimento";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(393, 159);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(113, 23);
            this.btnGerar.TabIndex = 5;
            this.btnGerar.Text = "Gerar (F2)";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtDescriptografada
            // 
            this.txtDescriptografada.Location = new System.Drawing.Point(9, 123);
            this.txtDescriptografada.Name = "txtDescriptografada";
            this.txtDescriptografada.ReadOnly = true;
            this.txtDescriptografada.Size = new System.Drawing.Size(497, 20);
            this.txtDescriptografada.TabIndex = 3;
            this.txtDescriptografada.Text = "************************************************";
            this.txtDescriptografada.UseSystemPasswordChar = true;
            this.txtDescriptografada.Click += new System.EventHandler(this.txtDescriptografada_Click);
            // 
            // lblDescriptografada
            // 
            this.lblDescriptografada.AutoSize = true;
            this.lblDescriptografada.Location = new System.Drawing.Point(6, 107);
            this.lblDescriptografada.Name = "lblDescriptografada";
            this.lblDescriptografada.Size = new System.Drawing.Size(88, 13);
            this.lblDescriptografada.TabIndex = 4;
            this.lblDescriptografada.Text = "Descriptografada";
            // 
            // txtCriptografada
            // 
            this.txtCriptografada.Location = new System.Drawing.Point(9, 84);
            this.txtCriptografada.Name = "txtCriptografada";
            this.txtCriptografada.ReadOnly = true;
            this.txtCriptografada.Size = new System.Drawing.Size(497, 20);
            this.txtCriptografada.TabIndex = 2;
            this.txtCriptografada.TextChanged += new System.EventHandler(this.txtCriptografada_TextChanged);
            // 
            // lblCriptografada
            // 
            this.lblCriptografada.AutoSize = true;
            this.lblCriptografada.Location = new System.Drawing.Point(6, 68);
            this.lblCriptografada.Name = "lblCriptografada";
            this.lblCriptografada.Size = new System.Drawing.Size(70, 13);
            this.lblCriptografada.TabIndex = 2;
            this.lblCriptografada.Text = "Criptografada";
            // 
            // txtPalavraChave
            // 
            this.txtPalavraChave.Location = new System.Drawing.Point(9, 45);
            this.txtPalavraChave.Name = "txtPalavraChave";
            this.txtPalavraChave.ReadOnly = true;
            this.txtPalavraChave.Size = new System.Drawing.Size(497, 20);
            this.txtPalavraChave.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 219);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "advanceshopsistema.com.br";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPalavraChave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescriptografada;
        private System.Windows.Forms.Label lblDescriptografada;
        private System.Windows.Forms.TextBox txtCriptografada;
        private System.Windows.Forms.Label lblCriptografada;
        private System.Windows.Forms.TextBox txtPalavraChave;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DateTimePicker txtVencimento;
        private System.Windows.Forms.Label label1;
    }
}

