
namespace AdvanceShop.Views
{
    partial class LinkPagamentoCompartilha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkPagamentoCompartilha));
            this.txtLinkURL = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalAPagar = new DevExpress.XtraEditors.LabelControl();
            this.btnConcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopiarLink = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtLinkURL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLinkURL
            // 
            this.txtLinkURL.EditValue = "";
            this.txtLinkURL.Location = new System.Drawing.Point(12, 94);
            this.txtLinkURL.Name = "txtLinkURL";
            this.txtLinkURL.Properties.AllowMouseWheel = false;
            this.txtLinkURL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkURL.Properties.Appearance.Options.UseFont = true;
            this.txtLinkURL.Properties.Appearance.Options.UseTextOptions = true;
            this.txtLinkURL.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtLinkURL.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtLinkURL.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkURL.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtLinkURL.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtLinkURL.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtLinkURL.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtLinkURL.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtLinkURI.Properties.ContextImageOptions.SvgImage")));
            this.txtLinkURL.Properties.ReadOnly = true;
            this.txtLinkURL.Size = new System.Drawing.Size(506, 36);
            this.txtLinkURL.TabIndex = 1;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAPagar.Appearance.Options.UseFont = true;
            this.lblTotalAPagar.Appearance.Options.UseForeColor = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(117, 33);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(298, 19);
            this.lblTotalAPagar.TabIndex = 6;
            this.lblTotalAPagar.Text = "Link pagamento gerado com sucesso";
            // 
            // btnConcluir
            // 
            this.btnConcluir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnConcluir.ImageOptions.SvgImage")));
            this.btnConcluir.Location = new System.Drawing.Point(408, 160);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(110, 41);
            this.btnConcluir.TabIndex = 3;
            this.btnConcluir.Text = "Concluir (F2)";
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnCopiarLink
            // 
            this.btnCopiarLink.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCopiarLink.ImageOptions.SvgImage")));
            this.btnCopiarLink.Location = new System.Drawing.Point(291, 160);
            this.btnCopiarLink.Name = "btnCopiarLink";
            this.btnCopiarLink.Size = new System.Drawing.Size(110, 41);
            this.btnCopiarLink.TabIndex = 2;
            this.btnCopiarLink.Text = "Copiar (F4)";
            this.btnCopiarLink.Click += new System.EventHandler(this.btnCopiarLink_Click);
            // 
            // LinkPagamentoCompartilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 238);
            this.Controls.Add(this.btnCopiarLink);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.txtLinkURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LinkPagamentoCompartilha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LinkPagamentoCompartilha_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LinkPagamentoCompartilha_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LinkPagamentoCompartilha_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtLinkURL.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtLinkURL;
        private DevExpress.XtraEditors.LabelControl lblTotalAPagar;
        private DevExpress.XtraEditors.SimpleButton btnConcluir;
        private DevExpress.XtraEditors.SimpleButton btnCopiarLink;
    }
}