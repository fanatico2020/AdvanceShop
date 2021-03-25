namespace AdvanceShop.Views
{
    partial class AbrirCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbrirCaixa));
            this.lblAbrirOCaixa = new DevExpress.XtraEditors.LabelControl();
            this.lblSaldoInicial = new DevExpress.XtraEditors.LabelControl();
            this.txtSaldoInicial = new DevExpress.XtraEditors.TextEdit();
            this.btnAbrirCaixa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbrirOCaixa
            // 
            this.lblAbrirOCaixa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrirOCaixa.Appearance.Options.UseFont = true;
            this.lblAbrirOCaixa.Location = new System.Drawing.Point(12, 26);
            this.lblAbrirOCaixa.Name = "lblAbrirOCaixa";
            this.lblAbrirOCaixa.Size = new System.Drawing.Size(107, 19);
            this.lblAbrirOCaixa.TabIndex = 0;
            this.lblAbrirOCaixa.Text = "Abrir o Caixa";
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoInicial.Appearance.Options.UseFont = true;
            this.lblSaldoInicial.Location = new System.Drawing.Point(12, 110);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(86, 19);
            this.lblSaldoInicial.TabIndex = 1;
            this.lblSaldoInicial.Text = "Saldo Inicial";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.EditValue = "0";
            this.txtSaldoInicial.Location = new System.Drawing.Point(12, 135);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoInicial.Properties.Appearance.Options.UseFont = true;
            this.txtSaldoInicial.Properties.DisplayFormat.FormatString = "c";
            this.txtSaldoInicial.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldoInicial.Properties.Mask.EditMask = "c";
            this.txtSaldoInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaldoInicial.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSaldoInicial.Properties.MaxLength = 12;
            this.txtSaldoInicial.Size = new System.Drawing.Size(205, 26);
            this.txtSaldoInicial.TabIndex = 1;
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAbrirCaixa.ImageOptions.SvgImage")));
            this.btnAbrirCaixa.Location = new System.Drawing.Point(292, 245);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(137, 47);
            this.btnAbrirCaixa.TabIndex = 2;
            this.btnAbrirCaixa.Text = "Abrir o Caixa (F2)";
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // AbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 304);
            this.Controls.Add(this.btnAbrirCaixa);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.lblSaldoInicial);
            this.Controls.Add(this.lblAbrirOCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AbrirCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Caixa";
            this.Load += new System.EventHandler(this.AbrirCaixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AbrirCaixa_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AbrirCaixa_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoInicial.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAbrirOCaixa;
        private DevExpress.XtraEditors.LabelControl lblSaldoInicial;
        private DevExpress.XtraEditors.TextEdit txtSaldoInicial;
        private DevExpress.XtraEditors.SimpleButton btnAbrirCaixa;
    }
}