namespace AdvanceShop.Views
{
    partial class AlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarSenha));
            this.lblSenhaAtual = new DevExpress.XtraEditors.LabelControl();
            this.txtSenhaAcessoAtual = new DevExpress.XtraEditors.TextEdit();
            this.lblNovaSenha = new DevExpress.XtraEditors.LabelControl();
            this.txtNovaSenhaAcesso = new DevExpress.XtraEditors.TextEdit();
            this.lblConfirmarSenha = new DevExpress.XtraEditors.LabelControl();
            this.txtConfimarNovaSenha = new DevExpress.XtraEditors.TextEdit();
            this.lblTamanhoMaximoSenha = new DevExpress.XtraEditors.LabelControl();
            this.pbcForcaSenha = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblForcaSenha = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaAcessoAtual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNovaSenhaAcesso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfimarNovaSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcForcaSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtual.Appearance.Options.UseFont = true;
            this.lblSenhaAtual.Location = new System.Drawing.Point(12, 12);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(82, 19);
            this.lblSenhaAtual.TabIndex = 1;
            this.lblSenhaAtual.Text = "Senha atual";
            // 
            // txtSenhaAcessoAtual
            // 
            this.txtSenhaAcessoAtual.EditValue = "";
            this.txtSenhaAcessoAtual.Location = new System.Drawing.Point(135, 9);
            this.txtSenhaAcessoAtual.Name = "txtSenhaAcessoAtual";
            this.txtSenhaAcessoAtual.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAcessoAtual.Properties.Appearance.Options.UseFont = true;
            this.txtSenhaAcessoAtual.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSenhaAcessoAtual.Properties.ContextImageOptions.Image")));
            this.txtSenhaAcessoAtual.Properties.MaxLength = 35;
            this.txtSenhaAcessoAtual.Properties.UseSystemPasswordChar = true;
            this.txtSenhaAcessoAtual.Size = new System.Drawing.Size(396, 26);
            this.txtSenhaAcessoAtual.TabIndex = 1;
            this.txtSenhaAcessoAtual.Leave += new System.EventHandler(this.txtSenhaAcessoAtual_Leave);
            this.txtSenhaAcessoAtual.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSenhaAcessoAtual_MouseDoubleClick);
            this.txtSenhaAcessoAtual.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtSenhaAcessoAtual_MouseMove);
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.Appearance.Options.UseFont = true;
            this.lblNovaSenha.Location = new System.Drawing.Point(12, 44);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(82, 19);
            this.lblNovaSenha.TabIndex = 4;
            this.lblNovaSenha.Text = "Nova senha";
            // 
            // txtNovaSenhaAcesso
            // 
            this.txtNovaSenhaAcesso.EditValue = "";
            this.txtNovaSenhaAcesso.Location = new System.Drawing.Point(135, 41);
            this.txtNovaSenhaAcesso.Name = "txtNovaSenhaAcesso";
            this.txtNovaSenhaAcesso.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenhaAcesso.Properties.Appearance.Options.UseFont = true;
            this.txtNovaSenhaAcesso.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtNovaSenhaAcesso.Properties.ContextImageOptions.Image")));
            this.txtNovaSenhaAcesso.Properties.MaxLength = 35;
            this.txtNovaSenhaAcesso.Properties.UseSystemPasswordChar = true;
            this.txtNovaSenhaAcesso.Size = new System.Drawing.Size(396, 26);
            this.txtNovaSenhaAcesso.TabIndex = 2;
            this.txtNovaSenhaAcesso.TextChanged += new System.EventHandler(this.txtNovaSenhaAcesso_TextChanged);
            this.txtNovaSenhaAcesso.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtNovaSenhaAcesso_MouseDoubleClick);
            this.txtNovaSenhaAcesso.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtNovaSenhaAcesso_MouseMove);
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Appearance.Options.UseFont = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(12, 76);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(117, 19);
            this.lblConfirmarSenha.TabIndex = 6;
            this.lblConfirmarSenha.Text = "Confirmar senha";
            // 
            // txtConfimarNovaSenha
            // 
            this.txtConfimarNovaSenha.EditValue = "";
            this.txtConfimarNovaSenha.Location = new System.Drawing.Point(135, 73);
            this.txtConfimarNovaSenha.Name = "txtConfimarNovaSenha";
            this.txtConfimarNovaSenha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfimarNovaSenha.Properties.Appearance.Options.UseFont = true;
            this.txtConfimarNovaSenha.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtConfimarNovaSenha.Properties.ContextImageOptions.Image")));
            this.txtConfimarNovaSenha.Properties.MaxLength = 35;
            this.txtConfimarNovaSenha.Properties.UseSystemPasswordChar = true;
            this.txtConfimarNovaSenha.Size = new System.Drawing.Size(396, 26);
            this.txtConfimarNovaSenha.TabIndex = 3;
            this.txtConfimarNovaSenha.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtConfimarNovaSenha_MouseDoubleClick);
            this.txtConfimarNovaSenha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtConfimarNovaSenha_MouseMove);
            // 
            // lblTamanhoMaximoSenha
            // 
            this.lblTamanhoMaximoSenha.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanhoMaximoSenha.Appearance.Options.UseFont = true;
            this.lblTamanhoMaximoSenha.Location = new System.Drawing.Point(12, 184);
            this.lblTamanhoMaximoSenha.Name = "lblTamanhoMaximoSenha";
            this.lblTamanhoMaximoSenha.Size = new System.Drawing.Size(299, 19);
            this.lblTamanhoMaximoSenha.TabIndex = 8;
            this.lblTamanhoMaximoSenha.Text = "Tamanho máximo da senha 35 caracteres!";
            // 
            // pbcForcaSenha
            // 
            this.pbcForcaSenha.Location = new System.Drawing.Point(135, 105);
            this.pbcForcaSenha.Name = "pbcForcaSenha";
            this.pbcForcaSenha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbcForcaSenha.Size = new System.Drawing.Size(396, 26);
            this.pbcForcaSenha.TabIndex = 0;
            // 
            // lblForcaSenha
            // 
            this.lblForcaSenha.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForcaSenha.Appearance.Options.UseFont = true;
            this.lblForcaSenha.Location = new System.Drawing.Point(12, 109);
            this.lblForcaSenha.Name = "lblForcaSenha";
            this.lblForcaSenha.Size = new System.Drawing.Size(84, 19);
            this.lblForcaSenha.TabIndex = 10;
            this.lblForcaSenha.Text = "Força senha";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(393, 181);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 29);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Alterar Senha (F2)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 236);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblForcaSenha);
            this.Controls.Add(this.pbcForcaSenha);
            this.Controls.Add(this.lblTamanhoMaximoSenha);
            this.Controls.Add(this.txtConfimarNovaSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.txtNovaSenhaAcesso);
            this.Controls.Add(this.lblNovaSenha);
            this.Controls.Add(this.txtSenhaAcessoAtual);
            this.Controls.Add(this.lblSenhaAtual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar senha";
            this.Load += new System.EventHandler(this.AlterarSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaAcessoAtual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNovaSenhaAcesso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfimarNovaSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcForcaSenha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblSenhaAtual;
        private DevExpress.XtraEditors.TextEdit txtSenhaAcessoAtual;
        private DevExpress.XtraEditors.LabelControl lblNovaSenha;
        private DevExpress.XtraEditors.TextEdit txtNovaSenhaAcesso;
        private DevExpress.XtraEditors.LabelControl lblConfirmarSenha;
        private DevExpress.XtraEditors.TextEdit txtConfimarNovaSenha;
        private DevExpress.XtraEditors.LabelControl lblTamanhoMaximoSenha;
        private DevExpress.XtraEditors.ProgressBarControl pbcForcaSenha;
        private DevExpress.XtraEditors.LabelControl lblForcaSenha;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
    }
}