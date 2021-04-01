namespace AdvanceShop.Views
{
    partial class DescontoPDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescontoPDV));
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.lblDesconto = new DevExpress.XtraEditors.LabelControl();
            this.txtDescontoValor = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalAPagar = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalAPagar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescontoPorcentagem = new DevExpress.XtraEditors.TextEdit();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescontoValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAPagar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescontoPorcentagem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 19);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(112, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.DisplayFormat.FormatString = "c";
            this.txtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotal.Properties.Mask.EditMask = "c";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Properties.UseReadOnlyAppearance = false;
            this.txtTotal.Size = new System.Drawing.Size(148, 26);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TabStop = false;
            // 
            // lblDesconto
            // 
            this.lblDesconto.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Appearance.Options.UseFont = true;
            this.lblDesconto.Location = new System.Drawing.Point(12, 40);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(65, 19);
            this.lblDesconto.TabIndex = 2;
            this.lblDesconto.Text = "Desconto";
            // 
            // txtDescontoValor
            // 
            this.txtDescontoValor.EditValue = "0";
            this.txtDescontoValor.Location = new System.Drawing.Point(112, 37);
            this.txtDescontoValor.Name = "txtDescontoValor";
            this.txtDescontoValor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoValor.Properties.Appearance.Options.UseFont = true;
            this.txtDescontoValor.Properties.DisplayFormat.FormatString = "c";
            this.txtDescontoValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDescontoValor.Properties.Mask.EditMask = "c";
            this.txtDescontoValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDescontoValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDescontoValor.Properties.MaxLength = 12;
            this.txtDescontoValor.Size = new System.Drawing.Size(148, 26);
            this.txtDescontoValor.TabIndex = 1;
            this.txtDescontoValor.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.txtDescontoValor_Spin);
            this.txtDescontoValor.EditValueChanged += new System.EventHandler(this.txtDescontoValor_EditValueChanged);
            this.txtDescontoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontoValor_KeyPress);
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Appearance.Options.UseFont = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(12, 72);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(94, 19);
            this.lblTotalAPagar.TabIndex = 4;
            this.lblTotalAPagar.Text = "Total a Pagar";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Location = new System.Drawing.Point(112, 69);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAPagar.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalAPagar.Properties.Appearance.Options.UseFont = true;
            this.txtTotalAPagar.Properties.Appearance.Options.UseForeColor = true;
            this.txtTotalAPagar.Properties.DisplayFormat.FormatString = "c";
            this.txtTotalAPagar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalAPagar.Properties.Mask.EditMask = "c";
            this.txtTotalAPagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAPagar.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalAPagar.Properties.ReadOnly = true;
            this.txtTotalAPagar.Properties.UseReadOnlyAppearance = false;
            this.txtTotalAPagar.Size = new System.Drawing.Size(148, 26);
            this.txtTotalAPagar.TabIndex = 0;
            this.txtTotalAPagar.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(266, 40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(16, 19);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "%";
            // 
            // txtDescontoPorcentagem
            // 
            this.txtDescontoPorcentagem.EditValue = "0";
            this.txtDescontoPorcentagem.Location = new System.Drawing.Point(288, 37);
            this.txtDescontoPorcentagem.Name = "txtDescontoPorcentagem";
            this.txtDescontoPorcentagem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoPorcentagem.Properties.Appearance.Options.UseFont = true;
            this.txtDescontoPorcentagem.Properties.DisplayFormat.FormatString = "P2";
            this.txtDescontoPorcentagem.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDescontoPorcentagem.Properties.Mask.EditMask = "P2";
            this.txtDescontoPorcentagem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDescontoPorcentagem.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDescontoPorcentagem.Properties.MaxLength = 6;
            this.txtDescontoPorcentagem.Size = new System.Drawing.Size(94, 26);
            this.txtDescontoPorcentagem.TabIndex = 2;
            this.txtDescontoPorcentagem.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.txtDescontoPorcentagem_Spin);
            this.txtDescontoPorcentagem.EditValueChanged += new System.EventHandler(this.txtDescontoPorcentagem_EditValueChanged);
            this.txtDescontoPorcentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescontoPorcentagem_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(288, 129);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 29);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar (F2)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // DescontoPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 183);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescontoPorcentagem);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.txtDescontoValor);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DescontoPDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desconto";
            this.Load += new System.EventHandler(this.DescontoPDV_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescontoPDV_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescontoPDV_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescontoValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAPagar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescontoPorcentagem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl lblDesconto;
        private DevExpress.XtraEditors.TextEdit txtDescontoValor;
        private DevExpress.XtraEditors.LabelControl lblTotalAPagar;
        private DevExpress.XtraEditors.TextEdit txtTotalAPagar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDescontoPorcentagem;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
    }
}