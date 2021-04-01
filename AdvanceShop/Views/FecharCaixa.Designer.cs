namespace AdvanceShop.Views
{
    partial class FecharCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FecharCaixa));
            this.lblFecharOCaixa = new DevExpress.XtraEditors.LabelControl();
            this.txtSaldoFinal = new DevExpress.XtraEditors.TextEdit();
            this.lblSaldoFinal = new DevExpress.XtraEditors.LabelControl();
            this.lblSaldoFinalSistema = new DevExpress.XtraEditors.LabelControl();
            this.txtSaldoFinalSistema = new DevExpress.XtraEditors.TextEdit();
            this.lblQubraDeCaixa = new DevExpress.XtraEditors.LabelControl();
            this.txtQuebraCaixa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacao = new DevExpress.XtraEditors.TextEdit();
            this.btnFecharCaixa = new DevExpress.XtraEditors.SimpleButton();
            this.btnContadorDinheiro = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoFinalSistema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuebraCaixa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecharOCaixa
            // 
            this.lblFecharOCaixa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecharOCaixa.Appearance.Options.UseFont = true;
            this.lblFecharOCaixa.Location = new System.Drawing.Point(12, 12);
            this.lblFecharOCaixa.Name = "lblFecharOCaixa";
            this.lblFecharOCaixa.Size = new System.Drawing.Size(120, 19);
            this.lblFecharOCaixa.TabIndex = 1;
            this.lblFecharOCaixa.Text = "Fechar o Caixa";
            // 
            // txtSaldoFinal
            // 
            this.txtSaldoFinal.EditValue = "0";
            this.txtSaldoFinal.Location = new System.Drawing.Point(12, 62);
            this.txtSaldoFinal.Name = "txtSaldoFinal";
            this.txtSaldoFinal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoFinal.Properties.Appearance.Options.UseFont = true;
            this.txtSaldoFinal.Properties.DisplayFormat.FormatString = "c";
            this.txtSaldoFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldoFinal.Properties.Mask.EditMask = "c";
            this.txtSaldoFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaldoFinal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSaldoFinal.Properties.MaxLength = 12;
            this.txtSaldoFinal.Size = new System.Drawing.Size(205, 26);
            this.txtSaldoFinal.TabIndex = 1;
            this.txtSaldoFinal.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.txtSaldoFinal_Spin);
            this.txtSaldoFinal.EditValueChanged += new System.EventHandler(this.txtSaldoFinal_EditValueChanged);
            this.txtSaldoFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoFinal_KeyPress);
            // 
            // lblSaldoFinal
            // 
            this.lblSaldoFinal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoFinal.Appearance.Options.UseFont = true;
            this.lblSaldoFinal.Location = new System.Drawing.Point(12, 37);
            this.lblSaldoFinal.Name = "lblSaldoFinal";
            this.lblSaldoFinal.Size = new System.Drawing.Size(74, 19);
            this.lblSaldoFinal.TabIndex = 3;
            this.lblSaldoFinal.Text = "Saldo final";
            // 
            // lblSaldoFinalSistema
            // 
            this.lblSaldoFinalSistema.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoFinalSistema.Appearance.Options.UseFont = true;
            this.lblSaldoFinalSistema.Location = new System.Drawing.Point(12, 94);
            this.lblSaldoFinalSistema.Name = "lblSaldoFinalSistema";
            this.lblSaldoFinalSistema.Size = new System.Drawing.Size(240, 19);
            this.lblSaldoFinalSistema.TabIndex = 4;
            this.lblSaldoFinalSistema.Text = "Saldo final totalizado pelo sistema";
            // 
            // txtSaldoFinalSistema
            // 
            this.txtSaldoFinalSistema.EditValue = "0";
            this.txtSaldoFinalSistema.Location = new System.Drawing.Point(12, 119);
            this.txtSaldoFinalSistema.Name = "txtSaldoFinalSistema";
            this.txtSaldoFinalSistema.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoFinalSistema.Properties.Appearance.Options.UseFont = true;
            this.txtSaldoFinalSistema.Properties.DisplayFormat.FormatString = "c";
            this.txtSaldoFinalSistema.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSaldoFinalSistema.Properties.Mask.EditMask = "c";
            this.txtSaldoFinalSistema.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaldoFinalSistema.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSaldoFinalSistema.Properties.MaxLength = 12;
            this.txtSaldoFinalSistema.Properties.ReadOnly = true;
            this.txtSaldoFinalSistema.Properties.UseReadOnlyAppearance = false;
            this.txtSaldoFinalSistema.Size = new System.Drawing.Size(205, 26);
            this.txtSaldoFinalSistema.TabIndex = 2;
            this.txtSaldoFinalSistema.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.txtSaldoFinalSistema_Spin);
            this.txtSaldoFinalSistema.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoFinalSistema_KeyPress);
            // 
            // lblQubraDeCaixa
            // 
            this.lblQubraDeCaixa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQubraDeCaixa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblQubraDeCaixa.Appearance.Options.UseFont = true;
            this.lblQubraDeCaixa.Appearance.Options.UseForeColor = true;
            this.lblQubraDeCaixa.Location = new System.Drawing.Point(12, 151);
            this.lblQubraDeCaixa.Name = "lblQubraDeCaixa";
            this.lblQubraDeCaixa.Size = new System.Drawing.Size(92, 19);
            this.lblQubraDeCaixa.TabIndex = 6;
            this.lblQubraDeCaixa.Text = "Quebra caixa";
            // 
            // txtQuebraCaixa
            // 
            this.txtQuebraCaixa.EditValue = "0";
            this.txtQuebraCaixa.Location = new System.Drawing.Point(12, 176);
            this.txtQuebraCaixa.Name = "txtQuebraCaixa";
            this.txtQuebraCaixa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuebraCaixa.Properties.Appearance.Options.UseFont = true;
            this.txtQuebraCaixa.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtQuebraCaixa.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtQuebraCaixa.Properties.DisplayFormat.FormatString = "c";
            this.txtQuebraCaixa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQuebraCaixa.Properties.Mask.EditMask = "c";
            this.txtQuebraCaixa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuebraCaixa.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuebraCaixa.Properties.MaxLength = 12;
            this.txtQuebraCaixa.Properties.ReadOnly = true;
            this.txtQuebraCaixa.Size = new System.Drawing.Size(205, 26);
            this.txtQuebraCaixa.TabIndex = 3;
            this.txtQuebraCaixa.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.txtQuebraCaixa_Spin);
            this.txtQuebraCaixa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuebraCaixa_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 208);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 19);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 233);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Properties.Appearance.Options.UseFont = true;
            this.txtObservacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Properties.MaxLength = 45;
            this.txtObservacao.Size = new System.Drawing.Size(417, 26);
            this.txtObservacao.TabIndex = 4;
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFecharCaixa.ImageOptions.SvgImage")));
            this.btnFecharCaixa.Location = new System.Drawing.Point(292, 281);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(137, 47);
            this.btnFecharCaixa.TabIndex = 6;
            this.btnFecharCaixa.Text = "Fechar o Caixa (F2)";
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // btnContadorDinheiro
            // 
            this.btnContadorDinheiro.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnContadorDinheiro.ImageOptions.SvgImage")));
            this.btnContadorDinheiro.Location = new System.Drawing.Point(12, 281);
            this.btnContadorDinheiro.Name = "btnContadorDinheiro";
            this.btnContadorDinheiro.Size = new System.Drawing.Size(131, 47);
            this.btnContadorDinheiro.TabIndex = 5;
            this.btnContadorDinheiro.Text = "Contador Dinheiro";
            this.btnContadorDinheiro.Click += new System.EventHandler(this.btnContadorDinheiro_Click);
            // 
            // FecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 340);
            this.Controls.Add(this.btnContadorDinheiro);
            this.Controls.Add(this.btnFecharCaixa);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtQuebraCaixa);
            this.Controls.Add(this.lblQubraDeCaixa);
            this.Controls.Add(this.txtSaldoFinalSistema);
            this.Controls.Add(this.lblSaldoFinalSistema);
            this.Controls.Add(this.txtSaldoFinal);
            this.Controls.Add(this.lblSaldoFinal);
            this.Controls.Add(this.lblFecharOCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FecharCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechar Caixa";
            this.Load += new System.EventHandler(this.FecharCaixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FecharCaixa_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FecharCaixa_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoFinalSistema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuebraCaixa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblFecharOCaixa;
        private DevExpress.XtraEditors.TextEdit txtSaldoFinal;
        private DevExpress.XtraEditors.LabelControl lblSaldoFinal;
        private DevExpress.XtraEditors.LabelControl lblSaldoFinalSistema;
        private DevExpress.XtraEditors.TextEdit txtSaldoFinalSistema;
        private DevExpress.XtraEditors.LabelControl lblQubraDeCaixa;
        private DevExpress.XtraEditors.TextEdit txtQuebraCaixa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtObservacao;
        private DevExpress.XtraEditors.SimpleButton btnFecharCaixa;
        private DevExpress.XtraEditors.SimpleButton btnContadorDinheiro;
    }
}