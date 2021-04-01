namespace AdvanceShop.Views
{
    partial class NovaContaAPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaContaAPagar));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tsRepetirLancamento = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblMeses = new DevExpress.XtraEditors.LabelControl();
            this.txtQtdMesesRepetir = new DevExpress.XtraEditors.SpinEdit();
            this.cbxCategoria = new DevExpress.XtraEditors.LookUpEdit();
            this.lblReferenteA = new DevExpress.XtraEditors.LabelControl();
            this.txtReferentea = new DevExpress.XtraEditors.TextEdit();
            this.cbxFornecedor = new DevExpress.XtraEditors.LookUpEdit();
            this.lblVencimento = new DevExpress.XtraEditors.LabelControl();
            this.txtVencimento = new DevExpress.XtraEditors.DateEdit();
            this.txtObservacao = new DevExpress.XtraEditors.TextEdit();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.txtDocumento = new DevExpress.XtraEditors.TextEdit();
            this.lblObservacao = new DevExpress.XtraEditors.LabelControl();
            this.lblValor = new DevExpress.XtraEditors.LabelControl();
            this.lblCategoria = new DevExpress.XtraEditors.LabelControl();
            this.lblDocumento = new DevExpress.XtraEditors.LabelControl();
            this.lblFornecedor = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsRepetirLancamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdMesesRepetir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferentea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tsRepetirLancamento);
            this.panelControl1.Controls.Add(this.lblMeses);
            this.panelControl1.Controls.Add(this.txtQtdMesesRepetir);
            this.panelControl1.Controls.Add(this.cbxCategoria);
            this.panelControl1.Controls.Add(this.lblReferenteA);
            this.panelControl1.Controls.Add(this.txtReferentea);
            this.panelControl1.Controls.Add(this.cbxFornecedor);
            this.panelControl1.Controls.Add(this.lblVencimento);
            this.panelControl1.Controls.Add(this.txtVencimento);
            this.panelControl1.Controls.Add(this.txtObservacao);
            this.panelControl1.Controls.Add(this.txtValor);
            this.panelControl1.Controls.Add(this.txtDocumento);
            this.panelControl1.Controls.Add(this.lblObservacao);
            this.panelControl1.Controls.Add(this.lblValor);
            this.panelControl1.Controls.Add(this.lblCategoria);
            this.panelControl1.Controls.Add(this.lblDocumento);
            this.panelControl1.Controls.Add(this.lblFornecedor);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(641, 259);
            this.panelControl1.TabIndex = 1;
            // 
            // tsRepetirLancamento
            // 
            this.tsRepetirLancamento.Location = new System.Drawing.Point(5, 229);
            this.tsRepetirLancamento.Name = "tsRepetirLancamento";
            this.tsRepetirLancamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsRepetirLancamento.Properties.Appearance.Options.UseFont = true;
            this.tsRepetirLancamento.Properties.OffText = "Repetir esse lançamento por";
            this.tsRepetirLancamento.Properties.OnText = "Repetir esse lançamento por";
            this.tsRepetirLancamento.Size = new System.Drawing.Size(265, 23);
            this.tsRepetirLancamento.TabIndex = 0;
            this.tsRepetirLancamento.Toggled += new System.EventHandler(this.tsRepetirLancamento_Toggled);
            // 
            // lblMeses
            // 
            this.lblMeses.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeses.Appearance.Options.UseFont = true;
            this.lblMeses.Location = new System.Drawing.Point(382, 230);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(48, 18);
            this.lblMeses.TabIndex = 21;
            this.lblMeses.Text = "meses.";
            // 
            // txtQtdMesesRepetir
            // 
            this.txtQtdMesesRepetir.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQtdMesesRepetir.Location = new System.Drawing.Point(276, 227);
            this.txtQtdMesesRepetir.Name = "txtQtdMesesRepetir";
            this.txtQtdMesesRepetir.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdMesesRepetir.Properties.Appearance.Options.UseFont = true;
            this.txtQtdMesesRepetir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQtdMesesRepetir.Properties.Mask.EditMask = "d";
            this.txtQtdMesesRepetir.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQtdMesesRepetir.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtQtdMesesRepetir.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQtdMesesRepetir.Size = new System.Drawing.Size(100, 26);
            this.txtQtdMesesRepetir.TabIndex = 8;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Location = new System.Drawing.Point(94, 101);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.Properties.Appearance.Options.UseFont = true;
            this.cbxCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.cbxCategoria.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idcategoriascontasapagar", "Código", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descricaocategoria", "Descrição")});
            this.cbxCategoria.Properties.MaxLength = 60;
            this.cbxCategoria.Properties.NullText = "";
            this.cbxCategoria.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbxCategoria_Properties_ButtonClick);
            this.cbxCategoria.Size = new System.Drawing.Size(542, 26);
            this.cbxCategoria.TabIndex = 4;
            // 
            // lblReferenteA
            // 
            this.lblReferenteA.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferenteA.Appearance.Options.UseFont = true;
            this.lblReferenteA.Location = new System.Drawing.Point(5, 8);
            this.lblReferenteA.Name = "lblReferenteA";
            this.lblReferenteA.Size = new System.Drawing.Size(80, 19);
            this.lblReferenteA.TabIndex = 18;
            this.lblReferenteA.Text = "Referente a";
            // 
            // txtReferentea
            // 
            this.txtReferentea.Location = new System.Drawing.Point(94, 5);
            this.txtReferentea.Name = "txtReferentea";
            this.txtReferentea.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferentea.Properties.Appearance.Options.UseFont = true;
            this.txtReferentea.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferentea.Properties.MaxLength = 60;
            this.txtReferentea.Size = new System.Drawing.Size(542, 26);
            this.txtReferentea.TabIndex = 1;
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.Location = new System.Drawing.Point(94, 37);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFornecedor.Properties.Appearance.Options.UseFont = true;
            this.cbxFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbxFornecedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idclientespessoas", "Código", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nome", "Nome", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cpf_cnpj", "CPF_CNPJ", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbxFornecedor.Properties.MaxLength = 60;
            this.cbxFornecedor.Properties.NullText = "";
            this.cbxFornecedor.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cbxFornecedor_Properties_ButtonClick);
            this.cbxFornecedor.Size = new System.Drawing.Size(542, 26);
            this.cbxFornecedor.TabIndex = 2;
            this.cbxFornecedor.DoubleClick += new System.EventHandler(this.cbxFornecedor_DoubleClick);
            // 
            // lblVencimento
            // 
            this.lblVencimento.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimento.Appearance.Options.UseFont = true;
            this.lblVencimento.Location = new System.Drawing.Point(5, 168);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(83, 19);
            this.lblVencimento.TabIndex = 12;
            this.lblVencimento.Text = "Vencimento";
            // 
            // txtVencimento
            // 
            this.txtVencimento.EditValue = null;
            this.txtVencimento.Location = new System.Drawing.Point(94, 165);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimento.Properties.Appearance.Options.UseFont = true;
            this.txtVencimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVencimento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVencimento.Size = new System.Drawing.Size(161, 26);
            this.txtVencimento.TabIndex = 6;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(94, 197);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Properties.Appearance.Options.UseFont = true;
            this.txtObservacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Properties.MaxLength = 60;
            this.txtObservacao.Size = new System.Drawing.Size(542, 26);
            this.txtObservacao.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.EditValue = "0";
            this.txtValor.Location = new System.Drawing.Point(94, 133);
            this.txtValor.Name = "txtValor";
            this.txtValor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Properties.Appearance.Options.UseFont = true;
            this.txtValor.Properties.DisplayFormat.FormatString = "c";
            this.txtValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValor.Properties.Mask.EditMask = "c";
            this.txtValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValor.Properties.MaxLength = 12;
            this.txtValor.Size = new System.Drawing.Size(161, 26);
            this.txtValor.TabIndex = 5;
            this.txtValor.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.txtValor_Spin);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(94, 69);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Properties.Appearance.Options.UseFont = true;
            this.txtDocumento.Properties.MaxLength = 60;
            this.txtDocumento.Size = new System.Drawing.Size(542, 26);
            this.txtDocumento.TabIndex = 3;
            // 
            // lblObservacao
            // 
            this.lblObservacao.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Appearance.Options.UseFont = true;
            this.lblObservacao.Location = new System.Drawing.Point(5, 200);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(82, 19);
            this.lblObservacao.TabIndex = 6;
            this.lblObservacao.Text = "Observação";
            // 
            // lblValor
            // 
            this.lblValor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Appearance.Options.UseFont = true;
            this.lblValor.Location = new System.Drawing.Point(5, 136);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 19);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Valor";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Appearance.Options.UseFont = true;
            this.lblCategoria.Location = new System.Drawing.Point(5, 104);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 19);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblDocumento
            // 
            this.lblDocumento.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Appearance.Options.UseFont = true;
            this.lblDocumento.Location = new System.Drawing.Point(5, 72);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(81, 19);
            this.lblDocumento.TabIndex = 3;
            this.lblDocumento.Text = "Documento";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Appearance.Options.UseFont = true;
            this.lblFornecedor.Location = new System.Drawing.Point(5, 40);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(79, 19);
            this.lblFornecedor.TabIndex = 1;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(555, 290);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 29);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar (F2)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // NovaContaAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 347);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "NovaContaAPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Conta a Pagar";
            this.Load += new System.EventHandler(this.NovaContaAPagar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NovaContaAPagar_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NovaContaAPagar_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsRepetirLancamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdMesesRepetir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReferentea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblVencimento;
        private DevExpress.XtraEditors.DateEdit txtVencimento;
        private DevExpress.XtraEditors.TextEdit txtObservacao;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.TextEdit txtDocumento;
        private DevExpress.XtraEditors.LabelControl lblObservacao;
        private DevExpress.XtraEditors.LabelControl lblValor;
        private DevExpress.XtraEditors.LabelControl lblCategoria;
        private DevExpress.XtraEditors.LabelControl lblDocumento;
        private DevExpress.XtraEditors.LabelControl lblFornecedor;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.LookUpEdit cbxFornecedor;
        private DevExpress.XtraEditors.LookUpEdit cbxCategoria;
        private DevExpress.XtraEditors.LabelControl lblReferenteA;
        private DevExpress.XtraEditors.TextEdit txtReferentea;
        private DevExpress.XtraEditors.LabelControl lblMeses;
        private DevExpress.XtraEditors.SpinEdit txtQtdMesesRepetir;
        private DevExpress.XtraEditors.ToggleSwitch tsRepetirLancamento;
    }
}