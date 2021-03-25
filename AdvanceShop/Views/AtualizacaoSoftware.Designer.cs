
namespace AdvanceShop.Views
{
    partial class AtualizacaoSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizacaoSoftware));
            this.lblVersaoAtualServidor = new DevExpress.XtraEditors.LabelControl();
            this.btnVerificar = new DevExpress.XtraEditors.SimpleButton();
            this.lblProgresso = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblVersaoAtualServidor
            // 
            this.lblVersaoAtualServidor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersaoAtualServidor.Appearance.Options.UseFont = true;
            this.lblVersaoAtualServidor.Appearance.Options.UseTextOptions = true;
            this.lblVersaoAtualServidor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblVersaoAtualServidor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVersaoAtualServidor.Location = new System.Drawing.Point(12, 12);
            this.lblVersaoAtualServidor.Name = "lblVersaoAtualServidor";
            this.lblVersaoAtualServidor.Size = new System.Drawing.Size(385, 19);
            this.lblVersaoAtualServidor.TabIndex = 0;
            this.lblVersaoAtualServidor.Text = "Versão atual 1.0.0.0 | Versão servidor 1.0.0.0";
            // 
            // btnVerificar
            // 
            this.btnVerificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVerificar.ImageOptions.SvgImage")));
            this.btnVerificar.Location = new System.Drawing.Point(308, 109);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(89, 36);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblProgresso
            // 
            this.lblProgresso.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgresso.Appearance.Options.UseFont = true;
            this.lblProgresso.Appearance.Options.UseTextOptions = true;
            this.lblProgresso.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblProgresso.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblProgresso.Location = new System.Drawing.Point(12, 59);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(385, 25);
            this.lblProgresso.TabIndex = 3;
            this.lblProgresso.Text = "%";
            // 
            // AtualizacaoSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 157);
            this.Controls.Add(this.lblProgresso);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblVersaoAtualServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AtualizacaoSoftware.IconOptions.SvgImage")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AtualizacaoSoftware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização de Software";
            this.Load += new System.EventHandler(this.AtualizacaoSoftware_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AtualizacaoSoftware_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblVersaoAtualServidor;
        private DevExpress.XtraEditors.SimpleButton btnVerificar;
        private DevExpress.XtraEditors.LabelControl lblProgresso;
    }
}