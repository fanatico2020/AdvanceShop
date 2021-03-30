namespace AdvanceShop.Views
{
    partial class ConfiguracoesGerais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracoesGerais));
            this.xtbpcConfigGerais = new DevExpress.XtraTab.XtraTabControl();
            this.xtbpVenda = new DevExpress.XtraTab.XtraTabPage();
            this.txtTrocoMaximo = new DevExpress.XtraEditors.TextEdit();
            this.tsAvisarClienteAniversariante = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsAvisarProdutoEstoqueBaixo = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsVendaCartaoPermitirDesconto = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsImprimirCPFCNPJCupomVenda = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsImprimirNomeVendedorFinalizarVenda = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsImprimirNotaFiscalFinalizarVenda = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsImprimirCupomFiscalFinalizarVenda = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsImprimirCupomFinalizarVenda = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsTrocoMaximo = new DevExpress.XtraEditors.ToggleSwitch();
            this.xtbpEmail = new DevExpress.XtraTab.XtraTabPage();
            this.txtEmailCopia2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmailCopia1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmailRecebimentoPrincipal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtbpFocusNFE = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblAmbiente = new DevExpress.XtraEditors.LabelControl();
            this.rgbAmbiente = new DevExpress.XtraEditors.RadioGroup();
            this.txtTokenProducao = new DevExpress.XtraEditors.TextEdit();
            this.lblTokenProducao = new DevExpress.XtraEditors.LabelControl();
            this.txtTokenHomologacao = new DevExpress.XtraEditors.TextEdit();
            this.lblTokenHomologacao = new DevExpress.XtraEditors.LabelControl();
            this.tsAtivaApiFocusNfe = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtbpcConfigGerais)).BeginInit();
            this.xtbpcConfigGerais.SuspendLayout();
            this.xtbpVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrocoMaximo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAvisarClienteAniversariante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAvisarProdutoEstoqueBaixo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsVendaCartaoPermitirDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsImprimirCPFCNPJCupomVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsImprimirNomeVendedorFinalizarVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsImprimirNotaFiscalFinalizarVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsImprimirCupomFiscalFinalizarVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsImprimirCupomFinalizarVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTrocoMaximo.Properties)).BeginInit();
            this.xtbpEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailCopia2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailCopia1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailRecebimentoPrincipal.Properties)).BeginInit();
            this.xtbpFocusNFE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbAmbiente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTokenProducao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTokenHomologacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAtivaApiFocusNfe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtbpcConfigGerais
            // 
            this.xtbpcConfigGerais.Location = new System.Drawing.Point(12, 12);
            this.xtbpcConfigGerais.Name = "xtbpcConfigGerais";
            this.xtbpcConfigGerais.SelectedTabPage = this.xtbpVenda;
            this.xtbpcConfigGerais.Size = new System.Drawing.Size(607, 410);
            this.xtbpcConfigGerais.TabIndex = 0;
            this.xtbpcConfigGerais.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtbpVenda,
            this.xtbpEmail,
            this.xtbpFocusNFE});
            // 
            // xtbpVenda
            // 
            this.xtbpVenda.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtbpVenda.Appearance.Header.Options.UseFont = true;
            this.xtbpVenda.Controls.Add(this.txtTrocoMaximo);
            this.xtbpVenda.Controls.Add(this.tsAvisarClienteAniversariante);
            this.xtbpVenda.Controls.Add(this.tsAvisarProdutoEstoqueBaixo);
            this.xtbpVenda.Controls.Add(this.tsVendaCartaoPermitirDesconto);
            this.xtbpVenda.Controls.Add(this.tsImprimirCPFCNPJCupomVenda);
            this.xtbpVenda.Controls.Add(this.tsImprimirNomeVendedorFinalizarVenda);
            this.xtbpVenda.Controls.Add(this.tsImprimirNotaFiscalFinalizarVenda);
            this.xtbpVenda.Controls.Add(this.tsImprimirCupomFiscalFinalizarVenda);
            this.xtbpVenda.Controls.Add(this.tsImprimirCupomFinalizarVenda);
            this.xtbpVenda.Controls.Add(this.tsTrocoMaximo);
            this.xtbpVenda.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtbpVenda.ImageOptions.SvgImage")));
            this.xtbpVenda.Name = "xtbpVenda";
            this.xtbpVenda.Size = new System.Drawing.Size(605, 366);
            this.xtbpVenda.Text = "Venda";
            // 
            // txtTrocoMaximo
            // 
            this.txtTrocoMaximo.EditValue = "0";
            this.txtTrocoMaximo.Location = new System.Drawing.Point(194, 3);
            this.txtTrocoMaximo.Name = "txtTrocoMaximo";
            this.txtTrocoMaximo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrocoMaximo.Properties.Appearance.Options.UseFont = true;
            this.txtTrocoMaximo.Properties.DisplayFormat.FormatString = "c";
            this.txtTrocoMaximo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTrocoMaximo.Properties.Mask.EditMask = "c";
            this.txtTrocoMaximo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTrocoMaximo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTrocoMaximo.Properties.MaxLength = 6;
            this.txtTrocoMaximo.Size = new System.Drawing.Size(100, 26);
            this.txtTrocoMaximo.TabIndex = 2;
            // 
            // tsAvisarClienteAniversariante
            // 
            this.tsAvisarClienteAniversariante.Location = new System.Drawing.Point(3, 243);
            this.tsAvisarClienteAniversariante.Name = "tsAvisarClienteAniversariante";
            this.tsAvisarClienteAniversariante.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAvisarClienteAniversariante.Properties.Appearance.Options.UseFont = true;
            this.tsAvisarClienteAniversariante.Properties.OffText = "Avisar cliente aniversariante";
            this.tsAvisarClienteAniversariante.Properties.OnText = "Avisar cliente aniversariante";
            this.tsAvisarClienteAniversariante.Size = new System.Drawing.Size(283, 24);
            this.tsAvisarClienteAniversariante.TabIndex = 10;
            // 
            // tsAvisarProdutoEstoqueBaixo
            // 
            this.tsAvisarProdutoEstoqueBaixo.Location = new System.Drawing.Point(3, 213);
            this.tsAvisarProdutoEstoqueBaixo.Name = "tsAvisarProdutoEstoqueBaixo";
            this.tsAvisarProdutoEstoqueBaixo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAvisarProdutoEstoqueBaixo.Properties.Appearance.Options.UseFont = true;
            this.tsAvisarProdutoEstoqueBaixo.Properties.OffText = "Avisar quando produto estiver com estoque baixo";
            this.tsAvisarProdutoEstoqueBaixo.Properties.OnText = "Avisar quando produto estiver com estoque baixo";
            this.tsAvisarProdutoEstoqueBaixo.Size = new System.Drawing.Size(439, 24);
            this.tsAvisarProdutoEstoqueBaixo.TabIndex = 9;
            // 
            // tsVendaCartaoPermitirDesconto
            // 
            this.tsVendaCartaoPermitirDesconto.Location = new System.Drawing.Point(3, 183);
            this.tsVendaCartaoPermitirDesconto.Name = "tsVendaCartaoPermitirDesconto";
            this.tsVendaCartaoPermitirDesconto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsVendaCartaoPermitirDesconto.Properties.Appearance.Options.UseFont = true;
            this.tsVendaCartaoPermitirDesconto.Properties.OffText = "Venda em cartão permitir desconto";
            this.tsVendaCartaoPermitirDesconto.Properties.OnText = "Venda em cartão permitir desconto";
            this.tsVendaCartaoPermitirDesconto.Size = new System.Drawing.Size(328, 24);
            this.tsVendaCartaoPermitirDesconto.TabIndex = 8;
            // 
            // tsImprimirCPFCNPJCupomVenda
            // 
            this.tsImprimirCPFCNPJCupomVenda.Enabled = false;
            this.tsImprimirCPFCNPJCupomVenda.Location = new System.Drawing.Point(3, 153);
            this.tsImprimirCPFCNPJCupomVenda.Name = "tsImprimirCPFCNPJCupomVenda";
            this.tsImprimirCPFCNPJCupomVenda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsImprimirCPFCNPJCupomVenda.Properties.Appearance.Options.UseFont = true;
            this.tsImprimirCPFCNPJCupomVenda.Properties.OffText = "Imprimir CPF/CNPJ da empresa no cupom";
            this.tsImprimirCPFCNPJCupomVenda.Properties.OnText = "Imprimir CPF/CNPJ da empresa no cupom";
            this.tsImprimirCPFCNPJCupomVenda.Size = new System.Drawing.Size(389, 24);
            this.tsImprimirCPFCNPJCupomVenda.TabIndex = 7;
            // 
            // tsImprimirNomeVendedorFinalizarVenda
            // 
            this.tsImprimirNomeVendedorFinalizarVenda.Location = new System.Drawing.Point(3, 123);
            this.tsImprimirNomeVendedorFinalizarVenda.Name = "tsImprimirNomeVendedorFinalizarVenda";
            this.tsImprimirNomeVendedorFinalizarVenda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsImprimirNomeVendedorFinalizarVenda.Properties.Appearance.Options.UseFont = true;
            this.tsImprimirNomeVendedorFinalizarVenda.Properties.OffText = "Imprimir nome do vendedor ao finalizar a venda";
            this.tsImprimirNomeVendedorFinalizarVenda.Properties.OnText = "Imprimir nome do vendedor ao finalizar a venda";
            this.tsImprimirNomeVendedorFinalizarVenda.Size = new System.Drawing.Size(439, 24);
            this.tsImprimirNomeVendedorFinalizarVenda.TabIndex = 6;
            // 
            // tsImprimirNotaFiscalFinalizarVenda
            // 
            this.tsImprimirNotaFiscalFinalizarVenda.Enabled = false;
            this.tsImprimirNotaFiscalFinalizarVenda.Location = new System.Drawing.Point(3, 93);
            this.tsImprimirNotaFiscalFinalizarVenda.Name = "tsImprimirNotaFiscalFinalizarVenda";
            this.tsImprimirNotaFiscalFinalizarVenda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsImprimirNotaFiscalFinalizarVenda.Properties.Appearance.Options.UseFont = true;
            this.tsImprimirNotaFiscalFinalizarVenda.Properties.OffText = "Imprimir nota fiscal(NF-e) ao finalizar a venda (Em Breve)";
            this.tsImprimirNotaFiscalFinalizarVenda.Properties.OnText = "Imprimir nota fiscal(NF-e) ao finalizar a venda";
            this.tsImprimirNotaFiscalFinalizarVenda.Size = new System.Drawing.Size(484, 24);
            this.tsImprimirNotaFiscalFinalizarVenda.TabIndex = 5;
            // 
            // tsImprimirCupomFiscalFinalizarVenda
            // 
            this.tsImprimirCupomFiscalFinalizarVenda.Location = new System.Drawing.Point(3, 63);
            this.tsImprimirCupomFiscalFinalizarVenda.Name = "tsImprimirCupomFiscalFinalizarVenda";
            this.tsImprimirCupomFiscalFinalizarVenda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsImprimirCupomFiscalFinalizarVenda.Properties.Appearance.Options.UseFont = true;
            this.tsImprimirCupomFiscalFinalizarVenda.Properties.OffText = "Imprimir cupom fiscal(NFC-e) ao finalizar a venda";
            this.tsImprimirCupomFiscalFinalizarVenda.Properties.OnText = "Imprimir cupom fiscal(NFC-e) ao finalizar a venda";
            this.tsImprimirCupomFiscalFinalizarVenda.Size = new System.Drawing.Size(439, 24);
            this.tsImprimirCupomFiscalFinalizarVenda.TabIndex = 4;
            // 
            // tsImprimirCupomFinalizarVenda
            // 
            this.tsImprimirCupomFinalizarVenda.Location = new System.Drawing.Point(3, 33);
            this.tsImprimirCupomFinalizarVenda.Name = "tsImprimirCupomFinalizarVenda";
            this.tsImprimirCupomFinalizarVenda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsImprimirCupomFinalizarVenda.Properties.Appearance.Options.UseFont = true;
            this.tsImprimirCupomFinalizarVenda.Properties.OffText = "Imprimir cupom ao finalizar a venda";
            this.tsImprimirCupomFinalizarVenda.Properties.OnText = "Imprimir cupom ao finalizar a venda";
            this.tsImprimirCupomFinalizarVenda.Size = new System.Drawing.Size(346, 24);
            this.tsImprimirCupomFinalizarVenda.TabIndex = 3;
            // 
            // tsTrocoMaximo
            // 
            this.tsTrocoMaximo.Location = new System.Drawing.Point(3, 3);
            this.tsTrocoMaximo.Name = "tsTrocoMaximo";
            this.tsTrocoMaximo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTrocoMaximo.Properties.Appearance.Options.UseFont = true;
            this.tsTrocoMaximo.Properties.OffText = "Troco máximo";
            this.tsTrocoMaximo.Properties.OnText = "Troco máximo";
            this.tsTrocoMaximo.Size = new System.Drawing.Size(185, 24);
            this.tsTrocoMaximo.TabIndex = 1;
            // 
            // xtbpEmail
            // 
            this.xtbpEmail.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtbpEmail.Appearance.Header.Options.UseFont = true;
            this.xtbpEmail.Controls.Add(this.txtEmailCopia2);
            this.xtbpEmail.Controls.Add(this.labelControl3);
            this.xtbpEmail.Controls.Add(this.txtEmailCopia1);
            this.xtbpEmail.Controls.Add(this.labelControl2);
            this.xtbpEmail.Controls.Add(this.txtEmailRecebimentoPrincipal);
            this.xtbpEmail.Controls.Add(this.labelControl1);
            this.xtbpEmail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtbpEmail.ImageOptions.Image")));
            this.xtbpEmail.Name = "xtbpEmail";
            this.xtbpEmail.Size = new System.Drawing.Size(605, 366);
            this.xtbpEmail.Text = "Email";
            // 
            // txtEmailCopia2
            // 
            this.txtEmailCopia2.Location = new System.Drawing.Point(3, 142);
            this.txtEmailCopia2.Name = "txtEmailCopia2";
            this.txtEmailCopia2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCopia2.Properties.Appearance.Options.UseFont = true;
            this.txtEmailCopia2.Properties.DisplayFormat.FormatString = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.txtEmailCopia2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtEmailCopia2.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.txtEmailCopia2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmailCopia2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtEmailCopia2.Properties.MaxLength = 60;
            this.txtEmailCopia2.Size = new System.Drawing.Size(599, 26);
            this.txtEmailCopia2.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Email copia 2:";
            // 
            // txtEmailCopia1
            // 
            this.txtEmailCopia1.Location = new System.Drawing.Point(3, 85);
            this.txtEmailCopia1.Name = "txtEmailCopia1";
            this.txtEmailCopia1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCopia1.Properties.Appearance.Options.UseFont = true;
            this.txtEmailCopia1.Properties.DisplayFormat.FormatString = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.txtEmailCopia1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtEmailCopia1.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.txtEmailCopia1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmailCopia1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtEmailCopia1.Properties.MaxLength = 60;
            this.txtEmailCopia1.Size = new System.Drawing.Size(599, 26);
            this.txtEmailCopia1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Email copia 1:";
            // 
            // txtEmailRecebimentoPrincipal
            // 
            this.txtEmailRecebimentoPrincipal.Location = new System.Drawing.Point(3, 28);
            this.txtEmailRecebimentoPrincipal.Name = "txtEmailRecebimentoPrincipal";
            this.txtEmailRecebimentoPrincipal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRecebimentoPrincipal.Properties.Appearance.Options.UseFont = true;
            this.txtEmailRecebimentoPrincipal.Properties.DisplayFormat.FormatString = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.txtEmailRecebimentoPrincipal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtEmailRecebimentoPrincipal.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,4}";
            this.txtEmailRecebimentoPrincipal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmailRecebimentoPrincipal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtEmailRecebimentoPrincipal.Properties.MaxLength = 60;
            this.txtEmailRecebimentoPrincipal.Size = new System.Drawing.Size(599, 26);
            this.txtEmailRecebimentoPrincipal.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(556, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Conta principal de email para recebimento dos emails automáticos do sistema:";
            // 
            // xtbpFocusNFE
            // 
            this.xtbpFocusNFE.Controls.Add(this.panelControl1);
            this.xtbpFocusNFE.Controls.Add(this.tsAtivaApiFocusNfe);
            this.xtbpFocusNFE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtbpFocusNFE.ImageOptions.Image")));
            this.xtbpFocusNFE.Name = "xtbpFocusNFE";
            this.xtbpFocusNFE.Size = new System.Drawing.Size(605, 366);
            this.xtbpFocusNFE.Text = "Api - FocusNFe";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblAmbiente);
            this.panelControl1.Controls.Add(this.rgbAmbiente);
            this.panelControl1.Controls.Add(this.txtTokenProducao);
            this.panelControl1.Controls.Add(this.lblTokenProducao);
            this.panelControl1.Controls.Add(this.txtTokenHomologacao);
            this.panelControl1.Controls.Add(this.lblTokenHomologacao);
            this.panelControl1.Location = new System.Drawing.Point(3, 33);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(599, 232);
            this.panelControl1.TabIndex = 3;
            // 
            // lblAmbiente
            // 
            this.lblAmbiente.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmbiente.Appearance.Options.UseFont = true;
            this.lblAmbiente.Location = new System.Drawing.Point(5, 119);
            this.lblAmbiente.Name = "lblAmbiente";
            this.lblAmbiente.Size = new System.Drawing.Size(74, 19);
            this.lblAmbiente.TabIndex = 9;
            this.lblAmbiente.Text = "Ambiente:";
            // 
            // rgbAmbiente
            // 
            this.rgbAmbiente.Location = new System.Drawing.Point(5, 144);
            this.rgbAmbiente.Name = "rgbAmbiente";
            this.rgbAmbiente.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("homologacao", "Homologação"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("producao", "Produção")});
            this.rgbAmbiente.Size = new System.Drawing.Size(589, 51);
            this.rgbAmbiente.TabIndex = 4;
            // 
            // txtTokenProducao
            // 
            this.txtTokenProducao.Location = new System.Drawing.Point(5, 87);
            this.txtTokenProducao.Name = "txtTokenProducao";
            this.txtTokenProducao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTokenProducao.Properties.Appearance.Options.UseFont = true;
            this.txtTokenProducao.Properties.MaxLength = 60;
            this.txtTokenProducao.Size = new System.Drawing.Size(589, 26);
            this.txtTokenProducao.TabIndex = 3;
            // 
            // lblTokenProducao
            // 
            this.lblTokenProducao.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenProducao.Appearance.Options.UseFont = true;
            this.lblTokenProducao.Location = new System.Drawing.Point(5, 62);
            this.lblTokenProducao.Name = "lblTokenProducao";
            this.lblTokenProducao.Size = new System.Drawing.Size(143, 19);
            this.lblTokenProducao.TabIndex = 7;
            this.lblTokenProducao.Text = "Token de produção:";
            // 
            // txtTokenHomologacao
            // 
            this.txtTokenHomologacao.Location = new System.Drawing.Point(5, 30);
            this.txtTokenHomologacao.Name = "txtTokenHomologacao";
            this.txtTokenHomologacao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTokenHomologacao.Properties.Appearance.Options.UseFont = true;
            this.txtTokenHomologacao.Properties.MaxLength = 60;
            this.txtTokenHomologacao.Size = new System.Drawing.Size(589, 26);
            this.txtTokenHomologacao.TabIndex = 2;
            // 
            // lblTokenHomologacao
            // 
            this.lblTokenHomologacao.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenHomologacao.Appearance.Options.UseFont = true;
            this.lblTokenHomologacao.Location = new System.Drawing.Point(5, 5);
            this.lblTokenHomologacao.Name = "lblTokenHomologacao";
            this.lblTokenHomologacao.Size = new System.Drawing.Size(172, 19);
            this.lblTokenHomologacao.TabIndex = 1;
            this.lblTokenHomologacao.Text = "Token de homologação:";
            // 
            // tsAtivaApiFocusNfe
            // 
            this.tsAtivaApiFocusNfe.Location = new System.Drawing.Point(3, 3);
            this.tsAtivaApiFocusNfe.Name = "tsAtivaApiFocusNfe";
            this.tsAtivaApiFocusNfe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAtivaApiFocusNfe.Properties.Appearance.Options.UseFont = true;
            this.tsAtivaApiFocusNfe.Properties.OffText = "Usar Api - Off";
            this.tsAtivaApiFocusNfe.Properties.OnText = "Usar Api - On";
            this.tsAtivaApiFocusNfe.Size = new System.Drawing.Size(185, 24);
            this.tsAtivaApiFocusNfe.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.ImageOptions.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(520, 444);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 29);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar (F2)";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ConfiguracoesGerais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 496);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.xtbpcConfigGerais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ConfiguracoesGerais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações Gerais";
            this.Load += new System.EventHandler(this.ConfiguracoesGerais_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfiguracoesGerais_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfiguracoesGerais_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.xtbpcConfigGerais)).EndInit();
            this.xtbpcConfigGerais.ResumeLayout(false);
            this.xtbpVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTrocoMaximo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAvisarClienteAniversariante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAvisarProdutoEstoqueBaixo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsVendaCartaoPermitirDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsImprimirCPFCNPJCupomVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsImprimirNomeVendedorFinalizarVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsImprimirNotaFiscalFinalizarVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsImprimirCupomFiscalFinalizarVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsImprimirCupomFinalizarVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTrocoMaximo.Properties)).EndInit();
            this.xtbpEmail.ResumeLayout(false);
            this.xtbpEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailCopia2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailCopia1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailRecebimentoPrincipal.Properties)).EndInit();
            this.xtbpFocusNFE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgbAmbiente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTokenProducao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTokenHomologacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAtivaApiFocusNfe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtbpcConfigGerais;
        private DevExpress.XtraTab.XtraTabPage xtbpVenda;
        private DevExpress.XtraTab.XtraTabPage xtbpEmail;
        private DevExpress.XtraEditors.ToggleSwitch tsTrocoMaximo;
        private DevExpress.XtraEditors.ToggleSwitch tsImprimirCupomFinalizarVenda;
        private DevExpress.XtraEditors.ToggleSwitch tsImprimirCupomFiscalFinalizarVenda;
        private DevExpress.XtraEditors.ToggleSwitch tsImprimirNomeVendedorFinalizarVenda;
        private DevExpress.XtraEditors.ToggleSwitch tsImprimirNotaFiscalFinalizarVenda;
        private DevExpress.XtraEditors.ToggleSwitch tsImprimirCPFCNPJCupomVenda;
        private DevExpress.XtraEditors.ToggleSwitch tsVendaCartaoPermitirDesconto;
        private DevExpress.XtraEditors.ToggleSwitch tsAvisarProdutoEstoqueBaixo;
        private DevExpress.XtraEditors.ToggleSwitch tsAvisarClienteAniversariante;
        private DevExpress.XtraEditors.TextEdit txtTrocoMaximo;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.TextEdit txtEmailRecebimentoPrincipal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtbpFocusNFE;
        private DevExpress.XtraEditors.ToggleSwitch tsAtivaApiFocusNfe;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtTokenProducao;
        private DevExpress.XtraEditors.LabelControl lblTokenProducao;
        private DevExpress.XtraEditors.TextEdit txtTokenHomologacao;
        private DevExpress.XtraEditors.LabelControl lblTokenHomologacao;
        private DevExpress.XtraEditors.TextEdit txtEmailCopia2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtEmailCopia1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.RadioGroup rgbAmbiente;
        private DevExpress.XtraEditors.LabelControl lblAmbiente;
    }
}