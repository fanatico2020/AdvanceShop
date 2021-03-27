
namespace AdvanceShop.Views
{
    partial class EsqueceuSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueceuSenha));
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.btnNovaSenha = new DevExpress.XtraEditors.SimpleButton();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblInformacao = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Appearance.Options.UseFont = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 50);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 19);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnNovaSenha
            // 
            this.btnNovaSenha.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNovaSenha.ImageOptions.SvgImage")));
            this.btnNovaSenha.Location = new System.Drawing.Point(269, 176);
            this.btnNovaSenha.Name = "btnNovaSenha";
            this.btnNovaSenha.Size = new System.Drawing.Size(139, 37);
            this.btnNovaSenha.TabIndex = 3;
            this.btnNovaSenha.Text = "Nova senha (F2)";
            this.btnNovaSenha.Click += new System.EventHandler(this.btnNovaSenha_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtEmail.Properties.NullText = "Email cadastrado na conta do usuario";
            this.txtEmail.Size = new System.Drawing.Size(396, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // lblInformacao
            // 
            this.lblInformacao.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblInformacao.Appearance.Options.UseFont = true;
            this.lblInformacao.Appearance.Options.UseForeColor = true;
            this.lblInformacao.Location = new System.Drawing.Point(12, 12);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(369, 16);
            this.lblInformacao.TabIndex = 9;
            this.lblInformacao.Text = "Confirme o endereço de email para geração de uma nova senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.EditValue = "";
            this.txtUsuario.Location = new System.Drawing.Point(12, 75);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cbxUsuario.Properties.ContextImageOptions.Image")));
            this.txtUsuario.Properties.NullText = "Selecione seu usuário";
            this.txtUsuario.Properties.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(396, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // EsqueceuSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 225);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnNovaSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("EsqueceuSenha.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EsqueceuSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esqueceu sua senha";
            this.Load += new System.EventHandler(this.EsqueceuSenha_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EsqueceuSenha_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EsqueceuSenha_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.SimpleButton btnNovaSenha;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl lblInformacao;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
    }
}