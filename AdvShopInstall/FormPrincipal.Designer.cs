
namespace AdvShopInstall
{
    partial class FormPrincipal
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
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTipoInstall = new System.Windows.Forms.Panel();
            this.rbtInstalacaoRede = new System.Windows.Forms.RadioButton();
            this.rbtInstalacaoLocal = new System.Windows.Forms.RadioButton();
            this.txtIPServidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtPastaDestino = new System.Windows.Forms.TextBox();
            this.lblPastaDestino = new System.Windows.Forms.Label();
            this.rbtNaoAceitaLicenca = new System.Windows.Forms.RadioButton();
            this.rbtAceitaLicenca = new System.Windows.Forms.RadioButton();
            this.rtxtLicenca = new System.Windows.Forms.RichTextBox();
            this.panelBemVindo = new System.Windows.Forms.Panel();
            this.btnSeguinte = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTipoInstall.SuspendLayout();
            this.panelBemVindo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBemVindo.Location = new System.Drawing.Point(108, 38);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(433, 25);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem-Vindo ao instalador do sistema advanceshop";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtNaoAceitaLicenca);
            this.panel1.Controls.Add(this.rbtAceitaLicenca);
            this.panel1.Controls.Add(this.rtxtLicenca);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 325);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelTipoInstall);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnProcurar);
            this.panel2.Controls.Add(this.txtPastaDestino);
            this.panel2.Controls.Add(this.lblPastaDestino);
            this.panel2.Location = new System.Drawing.Point(1, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 325);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            // 
            // panelTipoInstall
            // 
            this.panelTipoInstall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTipoInstall.Controls.Add(this.rbtInstalacaoRede);
            this.panelTipoInstall.Controls.Add(this.rbtInstalacaoLocal);
            this.panelTipoInstall.Controls.Add(this.txtIPServidor);
            this.panelTipoInstall.Controls.Add(this.label2);
            this.panelTipoInstall.Controls.Add(this.label1);
            this.panelTipoInstall.Enabled = false;
            this.panelTipoInstall.Location = new System.Drawing.Point(12, 94);
            this.panelTipoInstall.Name = "panelTipoInstall";
            this.panelTipoInstall.Size = new System.Drawing.Size(619, 214);
            this.panelTipoInstall.TabIndex = 3;
            // 
            // rbtInstalacaoRede
            // 
            this.rbtInstalacaoRede.AutoSize = true;
            this.rbtInstalacaoRede.Location = new System.Drawing.Point(15, 60);
            this.rbtInstalacaoRede.Name = "rbtInstalacaoRede";
            this.rbtInstalacaoRede.Size = new System.Drawing.Size(374, 19);
            this.rbtInstalacaoRede.TabIndex = 6;
            this.rbtInstalacaoRede.TabStop = true;
            this.rbtInstalacaoRede.Text = "Instalação em rede (já existe um servidor, forneça o ip do servidor)";
            this.rbtInstalacaoRede.UseVisualStyleBackColor = true;
            // 
            // rbtInstalacaoLocal
            // 
            this.rbtInstalacaoLocal.AutoSize = true;
            this.rbtInstalacaoLocal.Location = new System.Drawing.Point(15, 35);
            this.rbtInstalacaoLocal.Name = "rbtInstalacaoLocal";
            this.rbtInstalacaoLocal.Size = new System.Drawing.Size(325, 19);
            this.rbtInstalacaoLocal.TabIndex = 3;
            this.rbtInstalacaoLocal.Text = "Instalação local (quando a maquina atual sera o servidor)";
            this.rbtInstalacaoLocal.UseVisualStyleBackColor = true;
            // 
            // txtIPServidor
            // 
            this.txtIPServidor.Location = new System.Drawing.Point(41, 85);
            this.txtIPServidor.Name = "txtIPServidor";
            this.txtIPServidor.Size = new System.Drawing.Size(164, 23);
            this.txtIPServidor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleciona tipo de instalação:";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(556, 65);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtPastaDestino
            // 
            this.txtPastaDestino.Location = new System.Drawing.Point(12, 36);
            this.txtPastaDestino.Name = "txtPastaDestino";
            this.txtPastaDestino.Size = new System.Drawing.Size(619, 23);
            this.txtPastaDestino.TabIndex = 1;
            this.txtPastaDestino.TextChanged += new System.EventHandler(this.txtPastaDestino_TextChanged);
            // 
            // lblPastaDestino
            // 
            this.lblPastaDestino.AutoSize = true;
            this.lblPastaDestino.Location = new System.Drawing.Point(12, 15);
            this.lblPastaDestino.Name = "lblPastaDestino";
            this.lblPastaDestino.Size = new System.Drawing.Size(93, 15);
            this.lblPastaDestino.TabIndex = 0;
            this.lblPastaDestino.Text = "Pasta de destino";
            // 
            // rbtNaoAceitaLicenca
            // 
            this.rbtNaoAceitaLicenca.AutoSize = true;
            this.rbtNaoAceitaLicenca.Location = new System.Drawing.Point(11, 293);
            this.rbtNaoAceitaLicenca.Name = "rbtNaoAceitaLicenca";
            this.rbtNaoAceitaLicenca.Size = new System.Drawing.Size(258, 19);
            this.rbtNaoAceitaLicenca.TabIndex = 0;
            this.rbtNaoAceitaLicenca.Text = "Não aceito os termos do contrato de licença";
            this.rbtNaoAceitaLicenca.UseVisualStyleBackColor = true;
            this.rbtNaoAceitaLicenca.CheckedChanged += new System.EventHandler(this.rbtNaoAceitaLicenca_CheckedChanged);
            // 
            // rbtAceitaLicenca
            // 
            this.rbtAceitaLicenca.AutoSize = true;
            this.rbtAceitaLicenca.Location = new System.Drawing.Point(11, 268);
            this.rbtAceitaLicenca.Name = "rbtAceitaLicenca";
            this.rbtAceitaLicenca.Size = new System.Drawing.Size(234, 19);
            this.rbtAceitaLicenca.TabIndex = 0;
            this.rbtAceitaLicenca.Text = "Aceito os termos de contrato de licença";
            this.rbtAceitaLicenca.UseVisualStyleBackColor = true;
            this.rbtAceitaLicenca.CheckedChanged += new System.EventHandler(this.rbtAceitaLicenca_CheckedChanged);
            // 
            // rtxtLicenca
            // 
            this.rtxtLicenca.BackColor = System.Drawing.Color.White;
            this.rtxtLicenca.Location = new System.Drawing.Point(11, 15);
            this.rtxtLicenca.Name = "rtxtLicenca";
            this.rtxtLicenca.ReadOnly = true;
            this.rtxtLicenca.Size = new System.Drawing.Size(622, 247);
            this.rtxtLicenca.TabIndex = 0;
            this.rtxtLicenca.Text = "Contrato de linceça em breve...";
            // 
            // panelBemVindo
            // 
            this.panelBemVindo.BackColor = System.Drawing.Color.White;
            this.panelBemVindo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBemVindo.Controls.Add(this.lblBemVindo);
            this.panelBemVindo.Location = new System.Drawing.Point(1, 0);
            this.panelBemVindo.Name = "panelBemVindo";
            this.panelBemVindo.Size = new System.Drawing.Size(647, 100);
            this.panelBemVindo.TabIndex = 2;
            // 
            // btnSeguinte
            // 
            this.btnSeguinte.Enabled = false;
            this.btnSeguinte.Location = new System.Drawing.Point(93, 437);
            this.btnSeguinte.Name = "btnSeguinte";
            this.btnSeguinte.Size = new System.Drawing.Size(75, 23);
            this.btnSeguinte.TabIndex = 0;
            this.btnSeguinte.Text = "Seguinte >";
            this.btnSeguinte.UseVisualStyleBackColor = true;
            this.btnSeguinte.Click += new System.EventHandler(this.btnSeguinte_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(12, 437);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(559, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSeguinte);
            this.Controls.Add(this.panelBemVindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Setup AdvanceShop";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTipoInstall.ResumeLayout(false);
            this.panelTipoInstall.PerformLayout();
            this.panelBemVindo.ResumeLayout(false);
            this.panelBemVindo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxtLicenca;
        private System.Windows.Forms.Panel panelBemVindo;
        private System.Windows.Forms.RadioButton rbtNaoAceitaLicenca;
        private System.Windows.Forms.RadioButton rbtAceitaLicenca;
        private System.Windows.Forms.Button btnSeguinte;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPastaDestino;
        private System.Windows.Forms.TextBox txtPastaDestino;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panelTipoInstall;
        private System.Windows.Forms.RadioButton rbtInstalacaoRede;
        private System.Windows.Forms.RadioButton rbtInstalacaoLocal;
        private System.Windows.Forms.TextBox txtIPServidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

