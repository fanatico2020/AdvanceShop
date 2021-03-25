namespace AdvanceShop.Views
{
    partial class PagamentoContaAPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagamentoContaAPagar));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbxFornecedor = new DevExpress.XtraEditors.LookUpEdit();
            this.txtReferentea = new DevExpress.XtraEditors.TextEdit();
            this.lblReferentea = new DevExpress.XtraEditors.LabelControl();
            this.cbxAbaterValorCaixaAtual = new DevExpress.XtraEditors.CheckEdit();
            this.txtPagamento = new DevExpress.XtraEditors.DateEdit();
            this.txtValorPago = new DevExpress.XtraEditors.TextEdit();
            this.lblVencimento = new DevExpress.XtraEditors.LabelControl();
            this.txtVencimento = new DevExpress.XtraEditors.DateEdit();
            this.lblPagamento = new DevExpress.XtraEditors.LabelControl();
            this.txtObservacao = new DevExpress.XtraEditors.TextEdit();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.txtDocumento = new DevExpress.XtraEditors.TextEdit();
            this.lblObservacao = new DevExpress.XtraEditors.LabelControl();
            this.lblValorPago = new DevExpress.XtraEditors.LabelControl();
            this.lblValor = new DevExpress.XtraEditors.LabelControl();
            this.lblDocumento = new DevExpress.XtraEditors.LabelControl();
            this.lblFavorecido = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferentea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAbaterValorCaixaAtual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagamento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbxFornecedor);
            this.panelControl1.Controls.Add(this.txtReferentea);
            this.panelControl1.Controls.Add(this.lblReferentea);
            this.panelControl1.Controls.Add(this.cbxAbaterValorCaixaAtual);
            this.panelControl1.Controls.Add(this.txtPagamento);
            this.panelControl1.Controls.Add(this.txtValorPago);
            this.panelControl1.Controls.Add(this.lblVencimento);
            this.panelControl1.Controls.Add(this.txtVencimento);
            this.panelControl1.Controls.Add(this.lblPagamento);
            this.panelControl1.Controls.Add(this.txtObservacao);
            this.panelControl1.Controls.Add(this.txtValor);
            this.panelControl1.Controls.Add(this.txtDocumento);
            this.panelControl1.Controls.Add(this.lblObservacao);
            this.panelControl1.Controls.Add(this.lblValorPago);
            this.panelControl1.Controls.Add(this.lblValor);
            this.panelControl1.Controls.Add(this.lblDocumento);
            this.panelControl1.Controls.Add(this.lblFavorecido);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(641, 286);
            this.panelControl1.TabIndex = 0;
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.Location = new System.Drawing.Point(92, 48);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFornecedor.Properties.Appearance.Options.UseFont = true;
            this.cbxFornecedor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.cbxFornecedor.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White;
            this.cbxFornecedor.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFornecedor.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.cbxFornecedor.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.cbxFornecedor.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cbxFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbxFornecedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idclientespessoas", "Código", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nome", "Nome", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cpf_cnpj", "CPF_CNPJ", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbxFornecedor.Properties.MaxLength = 60;
            this.cbxFornecedor.Properties.NullText = "";
            this.cbxFornecedor.Properties.ReadOnly = true;
            this.cbxFornecedor.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbxFornecedor_Properties_ButtonClick);
            this.cbxFornecedor.Size = new System.Drawing.Size(542, 26);
            this.cbxFornecedor.TabIndex = 2;
            // 
            // txtReferentea
            // 
            this.txtReferentea.Location = new System.Drawing.Point(92, 16);
            this.txtReferentea.Name = "txtReferentea";
            this.txtReferentea.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferentea.Properties.Appearance.Options.UseFont = true;
            this.txtReferentea.Properties.ReadOnly = true;
            this.txtReferentea.Properties.UseReadOnlyAppearance = false;
            this.txtReferentea.Size = new System.Drawing.Size(542, 26);
            this.txtReferentea.TabIndex = 1;
            // 
            // lblReferentea
            // 
            this.lblReferentea.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferentea.Appearance.Options.UseFont = true;
            this.lblReferentea.Location = new System.Drawing.Point(5, 19);
            this.lblReferentea.Name = "lblReferentea";
            this.lblReferentea.Size = new System.Drawing.Size(80, 19);
            this.lblReferentea.TabIndex = 13;
            this.lblReferentea.Text = "Referente a";
            // 
            // cbxAbaterValorCaixaAtual
            // 
            this.cbxAbaterValorCaixaAtual.Location = new System.Drawing.Point(259, 177);
            this.cbxAbaterValorCaixaAtual.Name = "cbxAbaterValorCaixaAtual";
            this.cbxAbaterValorCaixaAtual.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAbaterValorCaixaAtual.Properties.Appearance.Options.UseFont = true;
            this.cbxAbaterValorCaixaAtual.Properties.Caption = "Abarter valor no saldo do caixa atual?";
            this.cbxAbaterValorCaixaAtual.Size = new System.Drawing.Size(316, 23);
            this.cbxAbaterValorCaixaAtual.TabIndex = 9;
            this.cbxAbaterValorCaixaAtual.CheckedChanged += new System.EventHandler(this.cbxAbaterValorCaixaAtual_CheckedChanged);
            // 
            // txtPagamento
            // 
            this.txtPagamento.EditValue = null;
            this.txtPagamento.Location = new System.Drawing.Point(92, 208);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagamento.Properties.Appearance.Options.UseFont = true;
            this.txtPagamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPagamento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPagamento.Size = new System.Drawing.Size(161, 26);
            this.txtPagamento.TabIndex = 7;
            // 
            // txtValorPago
            // 
            this.txtValorPago.EditValue = "0";
            this.txtValorPago.Location = new System.Drawing.Point(92, 176);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Properties.Appearance.Options.UseFont = true;
            this.txtValorPago.Properties.DisplayFormat.FormatString = "c";
            this.txtValorPago.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorPago.Properties.Mask.EditMask = "c";
            this.txtValorPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorPago.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorPago.Properties.MaxLength = 12;
            this.txtValorPago.Size = new System.Drawing.Size(161, 26);
            this.txtValorPago.TabIndex = 6;
            // 
            // lblVencimento
            // 
            this.lblVencimento.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimento.Appearance.Options.UseFont = true;
            this.lblVencimento.Location = new System.Drawing.Point(5, 147);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(83, 19);
            this.lblVencimento.TabIndex = 12;
            this.lblVencimento.Text = "Vencimento";
            // 
            // txtVencimento
            // 
            this.txtVencimento.EditValue = null;
            this.txtVencimento.Location = new System.Drawing.Point(92, 144);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimento.Properties.Appearance.Options.UseFont = true;
            this.txtVencimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVencimento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVencimento.Properties.ReadOnly = true;
            this.txtVencimento.Properties.UseReadOnlyAppearance = false;
            this.txtVencimento.Size = new System.Drawing.Size(161, 26);
            this.txtVencimento.TabIndex = 5;
            // 
            // lblPagamento
            // 
            this.lblPagamento.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.Appearance.Options.UseFont = true;
            this.lblPagamento.Location = new System.Drawing.Point(5, 211);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(79, 19);
            this.lblPagamento.TabIndex = 10;
            this.lblPagamento.Text = "Pagamento";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(92, 240);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Properties.Appearance.Options.UseFont = true;
            this.txtObservacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Properties.MaxLength = 60;
            this.txtObservacao.Size = new System.Drawing.Size(542, 26);
            this.txtObservacao.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(92, 112);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Properties.Appearance.Options.UseFont = true;
            this.txtValor.Properties.DisplayFormat.FormatString = "c";
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.Mask.EditMask = "c";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.Properties.ReadOnly = true;
            this.txtValor.Properties.UseReadOnlyAppearance = false;
            this.txtValor.Size = new System.Drawing.Size(161, 26);
            this.txtValor.TabIndex = 4;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(92, 80);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Properties.Appearance.Options.UseFont = true;
            this.txtDocumento.Properties.ReadOnly = true;
            this.txtDocumento.Properties.UseReadOnlyAppearance = false;
            this.txtDocumento.Size = new System.Drawing.Size(542, 26);
            this.txtDocumento.TabIndex = 3;
            // 
            // lblObservacao
            // 
            this.lblObservacao.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Appearance.Options.UseFont = true;
            this.lblObservacao.Location = new System.Drawing.Point(5, 243);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(82, 19);
            this.lblObservacao.TabIndex = 6;
            this.lblObservacao.Text = "Observação";
            // 
            // lblValorPago
            // 
            this.lblValorPago.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.Appearance.Options.UseFont = true;
            this.lblValorPago.Location = new System.Drawing.Point(4, 179);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(77, 19);
            this.lblValorPago.TabIndex = 5;
            this.lblValorPago.Text = "Valor Pago";
            // 
            // lblValor
            // 
            this.lblValor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Appearance.Options.UseFont = true;
            this.lblValor.Location = new System.Drawing.Point(5, 115);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 19);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // lblDocumento
            // 
            this.lblDocumento.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Appearance.Options.UseFont = true;
            this.lblDocumento.Location = new System.Drawing.Point(5, 83);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(81, 19);
            this.lblDocumento.TabIndex = 3;
            this.lblDocumento.Text = "Documento";
            // 
            // lblFavorecido
            // 
            this.lblFavorecido.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavorecido.Appearance.Options.UseFont = true;
            this.lblFavorecido.Location = new System.Drawing.Point(5, 51);
            this.lblFavorecido.Name = "lblFavorecido";
            this.lblFavorecido.Size = new System.Drawing.Size(76, 19);
            this.lblFavorecido.TabIndex = 1;
            this.lblFavorecido.Text = "Favorecido";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(555, 314);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 29);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar (F2)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // PagamentoContaAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 359);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PagamentoContaAPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento Conta A Pagar";
            this.Load += new System.EventHandler(this.PagamentoContaAPagar_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PagamentoContaAPagar_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferentea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxAbaterValorCaixaAtual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagamento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.LabelControl lblFavorecido;
        private DevExpress.XtraEditors.TextEdit txtDocumento;
        private DevExpress.XtraEditors.LabelControl lblObservacao;
        private DevExpress.XtraEditors.LabelControl lblValorPago;
        private DevExpress.XtraEditors.LabelControl lblValor;
        private DevExpress.XtraEditors.LabelControl lblDocumento;
        private DevExpress.XtraEditors.LabelControl lblPagamento;
        private DevExpress.XtraEditors.TextEdit txtObservacao;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.DateEdit txtPagamento;
        private DevExpress.XtraEditors.TextEdit txtValorPago;
        private DevExpress.XtraEditors.LabelControl lblVencimento;
        private DevExpress.XtraEditors.DateEdit txtVencimento;
        private DevExpress.XtraEditors.CheckEdit cbxAbaterValorCaixaAtual;
        private DevExpress.XtraEditors.TextEdit txtReferentea;
        private DevExpress.XtraEditors.LabelControl lblReferentea;
        private DevExpress.XtraEditors.LookUpEdit cbxFornecedor;
    }
}