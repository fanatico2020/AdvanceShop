namespace AdvanceShop.Views
{
    partial class Vendas
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon4 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            this.gridViewItensVenda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCodigoproduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescricaoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValorUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValorProdutoHoje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnQuantidadeEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMargemLucro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrecoCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridViewVendas = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumnCodigo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCliente = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnValor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDesconto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnTotalFinal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnValorPago = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnTroco = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDataHoraCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnUsuarioCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDataHoraEdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnUsuarioEdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumnNfcStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnNfcNumero = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnNfcMensagem_Sefaz = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnNfcCaminho_xml = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnNfcCaminho_Danfe = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnclientespessoas_idclientespessoas = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumncaixas_idcaixas = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiImprimirVisualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNovaVenda = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditarVenda = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeletarVenda = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAtualizarGrid = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTrocaDevolucao = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReimprimirCupomNaoFiscal = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReimprimirNFC_e = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXML_NFC_e = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::AdvanceShop.Views.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewItensVenda
            // 
            this.gridViewItensVenda.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCodigoproduto,
            this.gridColumnDescricaoProduto,
            this.gridColumnQuantidade,
            this.gridColumnValorUnitario,
            this.gridColumnSubtotal,
            this.gridColumnValorProdutoHoje,
            this.gridColumnQuantidadeEstoque,
            this.gridColumnItem,
            this.gridColumnMargemLucro,
            this.gridColumnPrecoCusto});
            this.gridViewItensVenda.GridControl = this.gridControl;
            this.gridViewItensVenda.Name = "gridViewItensVenda";
            this.gridViewItensVenda.OptionsBehavior.Editable = false;
            this.gridViewItensVenda.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewItensVenda.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewItensVenda.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewItensVenda.OptionsView.ShowGroupPanel = false;
            this.gridViewItensVenda.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewItensVenda_CustomColumnDisplayText);
            // 
            // gridColumnCodigoproduto
            // 
            this.gridColumnCodigoproduto.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnCodigoproduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCodigoproduto.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnCodigoproduto.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnCodigoproduto.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCodigoproduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCodigoproduto.Caption = "Código Prod.";
            this.gridColumnCodigoproduto.FieldName = "idprodutos";
            this.gridColumnCodigoproduto.Name = "gridColumnCodigoproduto";
            this.gridColumnCodigoproduto.Visible = true;
            this.gridColumnCodigoproduto.VisibleIndex = 0;
            this.gridColumnCodigoproduto.Width = 67;
            // 
            // gridColumnDescricaoProduto
            // 
            this.gridColumnDescricaoProduto.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnDescricaoProduto.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnDescricaoProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDescricaoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDescricaoProduto.Caption = "Descrição Produto";
            this.gridColumnDescricaoProduto.FieldName = "descricaoproduto";
            this.gridColumnDescricaoProduto.Name = "gridColumnDescricaoProduto";
            this.gridColumnDescricaoProduto.Visible = true;
            this.gridColumnDescricaoProduto.VisibleIndex = 2;
            this.gridColumnDescricaoProduto.Width = 251;
            // 
            // gridColumnQuantidade
            // 
            this.gridColumnQuantidade.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnQuantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnQuantidade.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnQuantidade.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnQuantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnQuantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnQuantidade.Caption = "Qtd Vendido";
            this.gridColumnQuantidade.FieldName = "quantidade";
            this.gridColumnQuantidade.Name = "gridColumnQuantidade";
            this.gridColumnQuantidade.Visible = true;
            this.gridColumnQuantidade.VisibleIndex = 5;
            this.gridColumnQuantidade.Width = 67;
            // 
            // gridColumnValorUnitario
            // 
            this.gridColumnValorUnitario.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnValorUnitario.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnValorUnitario.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnValorUnitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnValorUnitario.Caption = "Valor Unitario";
            this.gridColumnValorUnitario.DisplayFormat.FormatString = "c";
            this.gridColumnValorUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnValorUnitario.FieldName = "valorunitario";
            this.gridColumnValorUnitario.Name = "gridColumnValorUnitario";
            this.gridColumnValorUnitario.Visible = true;
            this.gridColumnValorUnitario.VisibleIndex = 6;
            this.gridColumnValorUnitario.Width = 79;
            // 
            // gridColumnSubtotal
            // 
            this.gridColumnSubtotal.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnSubtotal.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnSubtotal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSubtotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSubtotal.Caption = "Subtotal";
            this.gridColumnSubtotal.DisplayFormat.FormatString = "c";
            this.gridColumnSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSubtotal.FieldName = "subtotal";
            this.gridColumnSubtotal.Name = "gridColumnSubtotal";
            this.gridColumnSubtotal.Visible = true;
            this.gridColumnSubtotal.VisibleIndex = 7;
            this.gridColumnSubtotal.Width = 88;
            // 
            // gridColumnValorProdutoHoje
            // 
            this.gridColumnValorProdutoHoje.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnValorProdutoHoje.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnValorProdutoHoje.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnValorProdutoHoje.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnValorProdutoHoje.Caption = "Valor Produto Hoje";
            this.gridColumnValorProdutoHoje.DisplayFormat.FormatString = "c";
            this.gridColumnValorProdutoHoje.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnValorProdutoHoje.FieldName = "precovenda";
            this.gridColumnValorProdutoHoje.Name = "gridColumnValorProdutoHoje";
            this.gridColumnValorProdutoHoje.Visible = true;
            this.gridColumnValorProdutoHoje.VisibleIndex = 8;
            this.gridColumnValorProdutoHoje.Width = 91;
            // 
            // gridColumnQuantidadeEstoque
            // 
            this.gridColumnQuantidadeEstoque.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnQuantidadeEstoque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnQuantidadeEstoque.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnQuantidadeEstoque.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnQuantidadeEstoque.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnQuantidadeEstoque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnQuantidadeEstoque.Caption = "Qtd Estoque Hoje";
            this.gridColumnQuantidadeEstoque.FieldName = "estoqueatual";
            this.gridColumnQuantidadeEstoque.Name = "gridColumnQuantidadeEstoque";
            this.gridColumnQuantidadeEstoque.Visible = true;
            this.gridColumnQuantidadeEstoque.VisibleIndex = 9;
            this.gridColumnQuantidadeEstoque.Width = 105;
            // 
            // gridColumnItem
            // 
            this.gridColumnItem.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnItem.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnItem.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnItem.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnItem.Caption = "Item";
            this.gridColumnItem.FieldName = "item";
            this.gridColumnItem.Name = "gridColumnItem";
            this.gridColumnItem.Visible = true;
            this.gridColumnItem.VisibleIndex = 1;
            this.gridColumnItem.Width = 65;
            // 
            // gridColumnMargemLucro
            // 
            this.gridColumnMargemLucro.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnMargemLucro.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnMargemLucro.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnMargemLucro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnMargemLucro.Caption = "Margem Lucro";
            this.gridColumnMargemLucro.DisplayFormat.FormatString = "d";
            this.gridColumnMargemLucro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnMargemLucro.FieldName = "margemlucro";
            this.gridColumnMargemLucro.Name = "gridColumnMargemLucro";
            this.gridColumnMargemLucro.Visible = true;
            this.gridColumnMargemLucro.VisibleIndex = 3;
            // 
            // gridColumnPrecoCusto
            // 
            this.gridColumnPrecoCusto.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnPrecoCusto.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnPrecoCusto.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPrecoCusto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPrecoCusto.Caption = "Preço Custo";
            this.gridColumnPrecoCusto.DisplayFormat.FormatString = "c";
            this.gridColumnPrecoCusto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPrecoCusto.FieldName = "precocusto";
            this.gridColumnPrecoCusto.Name = "gridColumnPrecoCusto";
            this.gridColumnPrecoCusto.Visible = true;
            this.gridColumnPrecoCusto.VisibleIndex = 4;
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.LevelTemplate = this.gridViewItensVenda;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl.Location = new System.Drawing.Point(0, 170);
            this.gridControl.MainView = this.advBandedGridViewVendas;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(978, 369);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridViewVendas,
            this.gridViewItensVenda});
            // 
            // advBandedGridViewVendas
            // 
            this.advBandedGridViewVendas.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.advBandedGridViewVendas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.advBandedGridViewVendas.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumnCodigo,
            this.bandedGridColumnCliente,
            this.bandedGridColumnValor,
            this.bandedGridColumnDesconto,
            this.bandedGridColumnTotalFinal,
            this.bandedGridColumnValorPago,
            this.bandedGridColumnTroco,
            this.bandedGridColumnDataHoraCad,
            this.bandedGridColumnDataHoraEdi,
            this.bandedGridColumnUsuarioCad,
            this.bandedGridColumnUsuarioEdi,
            this.bandedGridColumnclientespessoas_idclientespessoas,
            this.bandedGridColumncaixas_idcaixas,
            this.bandedGridColumnNfcStatus,
            this.bandedGridColumnNfcNumero,
            this.bandedGridColumnNfcMensagem_Sefaz,
            this.bandedGridColumnNfcCaminho_xml,
            this.bandedGridColumnNfcCaminho_Danfe});
            gridFormatRule1.Column = this.bandedGridColumnNfcStatus;
            gridFormatRule1.ColumnApplyTo = this.bandedGridColumnCodigo;
            gridFormatRule1.Name = "FormatStatusNFC";
            formatConditionIconSet1.CategoryName = "Symbols";
            formatConditionIconSetIcon1.PredefinedName = "Symbols3_1.png";
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "Symbols3_3.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "Symbols3_2.png";
            formatConditionIconSetIcon3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon4.PredefinedName = "Symbols3_2.png";
            formatConditionIconSetIcon4.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon4);
            formatConditionIconSet1.Name = "Symbols3Uncircled";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            this.advBandedGridViewVendas.FormatRules.Add(gridFormatRule1);
            this.advBandedGridViewVendas.GridControl = this.gridControl;
            this.advBandedGridViewVendas.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.advBandedGridViewVendas.Name = "advBandedGridViewVendas";
            this.advBandedGridViewVendas.OptionsBehavior.Editable = false;
            this.advBandedGridViewVendas.OptionsBehavior.ReadOnly = true;
            this.advBandedGridViewVendas.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridViewVendas.OptionsView.EnableAppearanceEvenRow = true;
            this.advBandedGridViewVendas.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.advBandedGridViewVendas.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.advBandedGridViewVendas_MasterRowEmpty);
            this.advBandedGridViewVendas.MasterRowGetLevelDefaultView += new DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(this.advBandedGridViewVendas_MasterRowGetLevelDefaultView);
            this.advBandedGridViewVendas.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.advBandedGridViewVendas_MasterRowGetChildList);
            this.advBandedGridViewVendas.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.advBandedGridViewVendas_MasterRowGetRelationName);
            this.advBandedGridViewVendas.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.advBandedGridViewVendas_MasterRowGetRelationCount);
            this.advBandedGridViewVendas.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.advBandedGridViewVendas_PopupMenuShowing);
            this.advBandedGridViewVendas.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.advBandedGridViewVendas_CustomColumnDisplayText);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand1.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand1.Caption = "Vendas";
            this.gridBand1.Columns.Add(this.bandedGridColumnCodigo);
            this.gridBand1.Columns.Add(this.bandedGridColumnCliente);
            this.gridBand1.Columns.Add(this.bandedGridColumnValor);
            this.gridBand1.Columns.Add(this.bandedGridColumnDesconto);
            this.gridBand1.Columns.Add(this.bandedGridColumnTotalFinal);
            this.gridBand1.Columns.Add(this.bandedGridColumnValorPago);
            this.gridBand1.Columns.Add(this.bandedGridColumnTroco);
            this.gridBand1.Columns.Add(this.bandedGridColumnDataHoraCad);
            this.gridBand1.Columns.Add(this.bandedGridColumnUsuarioCad);
            this.gridBand1.Columns.Add(this.bandedGridColumnDataHoraEdi);
            this.gridBand1.Columns.Add(this.bandedGridColumnUsuarioEdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1452;
            // 
            // bandedGridColumnCodigo
            // 
            this.bandedGridColumnCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnCodigo.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnCodigo.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnCodigo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnCodigo.Caption = "Código";
            this.bandedGridColumnCodigo.FieldName = "idvendas";
            this.bandedGridColumnCodigo.Name = "bandedGridColumnCodigo";
            this.bandedGridColumnCodigo.Visible = true;
            this.bandedGridColumnCodigo.Width = 78;
            // 
            // bandedGridColumnCliente
            // 
            this.bandedGridColumnCliente.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnCliente.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnCliente.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnCliente.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnCliente.Caption = "Cliente";
            this.bandedGridColumnCliente.FieldName = "nome";
            this.bandedGridColumnCliente.Name = "bandedGridColumnCliente";
            this.bandedGridColumnCliente.Visible = true;
            this.bandedGridColumnCliente.Width = 278;
            // 
            // bandedGridColumnValor
            // 
            this.bandedGridColumnValor.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnValor.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnValor.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnValor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnValor.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnValor.Caption = "Valor";
            this.bandedGridColumnValor.DisplayFormat.FormatString = "c";
            this.bandedGridColumnValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumnValor.FieldName = "valor";
            this.bandedGridColumnValor.Name = "bandedGridColumnValor";
            this.bandedGridColumnValor.Visible = true;
            this.bandedGridColumnValor.Width = 125;
            // 
            // bandedGridColumnDesconto
            // 
            this.bandedGridColumnDesconto.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnDesconto.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnDesconto.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnDesconto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDesconto.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnDesconto.Caption = "Deconto";
            this.bandedGridColumnDesconto.DisplayFormat.FormatString = "c";
            this.bandedGridColumnDesconto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumnDesconto.FieldName = "desconto";
            this.bandedGridColumnDesconto.Name = "bandedGridColumnDesconto";
            this.bandedGridColumnDesconto.Visible = true;
            this.bandedGridColumnDesconto.Width = 115;
            // 
            // bandedGridColumnTotalFinal
            // 
            this.bandedGridColumnTotalFinal.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnTotalFinal.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnTotalFinal.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnTotalFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnTotalFinal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnTotalFinal.Caption = "Total Final";
            this.bandedGridColumnTotalFinal.DisplayFormat.FormatString = "c";
            this.bandedGridColumnTotalFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumnTotalFinal.FieldName = "totalfinal";
            this.bandedGridColumnTotalFinal.Name = "bandedGridColumnTotalFinal";
            this.bandedGridColumnTotalFinal.Visible = true;
            this.bandedGridColumnTotalFinal.Width = 126;
            // 
            // bandedGridColumnValorPago
            // 
            this.bandedGridColumnValorPago.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnValorPago.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnValorPago.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnValorPago.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnValorPago.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnValorPago.Caption = "Valor Pago";
            this.bandedGridColumnValorPago.DisplayFormat.FormatString = "c";
            this.bandedGridColumnValorPago.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumnValorPago.FieldName = "valorpago";
            this.bandedGridColumnValorPago.Name = "bandedGridColumnValorPago";
            this.bandedGridColumnValorPago.Visible = true;
            this.bandedGridColumnValorPago.Width = 118;
            // 
            // bandedGridColumnTroco
            // 
            this.bandedGridColumnTroco.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnTroco.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnTroco.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnTroco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnTroco.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnTroco.Caption = "Troco";
            this.bandedGridColumnTroco.DisplayFormat.FormatString = "c";
            this.bandedGridColumnTroco.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumnTroco.FieldName = "troco";
            this.bandedGridColumnTroco.Name = "bandedGridColumnTroco";
            this.bandedGridColumnTroco.Visible = true;
            this.bandedGridColumnTroco.Width = 112;
            // 
            // bandedGridColumnDataHoraCad
            // 
            this.bandedGridColumnDataHoraCad.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnDataHoraCad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDataHoraCad.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnDataHoraCad.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnDataHoraCad.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnDataHoraCad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDataHoraCad.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnDataHoraCad.Caption = "Data/Hora Cad.";
            this.bandedGridColumnDataHoraCad.DisplayFormat.FormatString = "g";
            this.bandedGridColumnDataHoraCad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bandedGridColumnDataHoraCad.FieldName = "datahoracadastro";
            this.bandedGridColumnDataHoraCad.Name = "bandedGridColumnDataHoraCad";
            this.bandedGridColumnDataHoraCad.Visible = true;
            this.bandedGridColumnDataHoraCad.Width = 119;
            // 
            // bandedGridColumnUsuarioCad
            // 
            this.bandedGridColumnUsuarioCad.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnUsuarioCad.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnUsuarioCad.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnUsuarioCad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnUsuarioCad.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnUsuarioCad.Caption = "Usuário Cad.";
            this.bandedGridColumnUsuarioCad.FieldName = "usuariocadastro";
            this.bandedGridColumnUsuarioCad.Name = "bandedGridColumnUsuarioCad";
            this.bandedGridColumnUsuarioCad.Visible = true;
            this.bandedGridColumnUsuarioCad.Width = 120;
            // 
            // bandedGridColumnDataHoraEdi
            // 
            this.bandedGridColumnDataHoraEdi.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnDataHoraEdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDataHoraEdi.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnDataHoraEdi.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnDataHoraEdi.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnDataHoraEdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDataHoraEdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnDataHoraEdi.Caption = "Data/Hora Edi.";
            this.bandedGridColumnDataHoraEdi.DisplayFormat.FormatString = "g";
            this.bandedGridColumnDataHoraEdi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bandedGridColumnDataHoraEdi.FieldName = "datahoraedicao";
            this.bandedGridColumnDataHoraEdi.Name = "bandedGridColumnDataHoraEdi";
            this.bandedGridColumnDataHoraEdi.Visible = true;
            this.bandedGridColumnDataHoraEdi.Width = 128;
            // 
            // bandedGridColumnUsuarioEdi
            // 
            this.bandedGridColumnUsuarioEdi.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnUsuarioEdi.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnUsuarioEdi.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnUsuarioEdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnUsuarioEdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnUsuarioEdi.Caption = "Usuário Edi.";
            this.bandedGridColumnUsuarioEdi.FieldName = "usuarioedicao";
            this.bandedGridColumnUsuarioEdi.Name = "bandedGridColumnUsuarioEdi";
            this.bandedGridColumnUsuarioEdi.Visible = true;
            this.bandedGridColumnUsuarioEdi.Width = 133;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridBand2.AppearanceHeader.Options.UseForeColor = true;
            this.gridBand2.Caption = "NFC";
            this.gridBand2.Columns.Add(this.bandedGridColumnNfcStatus);
            this.gridBand2.Columns.Add(this.bandedGridColumnNfcNumero);
            this.gridBand2.Columns.Add(this.bandedGridColumnNfcMensagem_Sefaz);
            this.gridBand2.Columns.Add(this.bandedGridColumnNfcCaminho_xml);
            this.gridBand2.Columns.Add(this.bandedGridColumnNfcCaminho_Danfe);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 514;
            // 
            // bandedGridColumnNfcStatus
            // 
            this.bandedGridColumnNfcStatus.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnNfcStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnNfcStatus.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnNfcStatus.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnNfcStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnNfcStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnNfcStatus.Caption = "NFC Status";
            this.bandedGridColumnNfcStatus.FieldName = "nfcstatus";
            this.bandedGridColumnNfcStatus.Name = "bandedGridColumnNfcStatus";
            this.bandedGridColumnNfcStatus.Visible = true;
            this.bandedGridColumnNfcStatus.Width = 122;
            // 
            // bandedGridColumnNfcNumero
            // 
            this.bandedGridColumnNfcNumero.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnNfcNumero.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnNfcNumero.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnNfcNumero.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnNfcNumero.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnNfcNumero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnNfcNumero.Caption = "Número Nota";
            this.bandedGridColumnNfcNumero.FieldName = "nfcnumero";
            this.bandedGridColumnNfcNumero.Name = "bandedGridColumnNfcNumero";
            this.bandedGridColumnNfcNumero.Visible = true;
            this.bandedGridColumnNfcNumero.Width = 93;
            // 
            // bandedGridColumnNfcMensagem_Sefaz
            // 
            this.bandedGridColumnNfcMensagem_Sefaz.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnNfcMensagem_Sefaz.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnNfcMensagem_Sefaz.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnNfcMensagem_Sefaz.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnNfcMensagem_Sefaz.Caption = "Mensagem Sefa";
            this.bandedGridColumnNfcMensagem_Sefaz.FieldName = "nfcmensagem_sefaz";
            this.bandedGridColumnNfcMensagem_Sefaz.Name = "bandedGridColumnNfcMensagem_Sefaz";
            this.bandedGridColumnNfcMensagem_Sefaz.Visible = true;
            this.bandedGridColumnNfcMensagem_Sefaz.Width = 299;
            // 
            // bandedGridColumnNfcCaminho_xml
            // 
            this.bandedGridColumnNfcCaminho_xml.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnNfcCaminho_xml.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnNfcCaminho_xml.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnNfcCaminho_xml.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnNfcCaminho_xml.Caption = "NFC Caminho XML";
            this.bandedGridColumnNfcCaminho_xml.FieldName = "nfccaminho_xml_nota_fiscal";
            this.bandedGridColumnNfcCaminho_xml.Name = "bandedGridColumnNfcCaminho_xml";
            // 
            // bandedGridColumnNfcCaminho_Danfe
            // 
            this.bandedGridColumnNfcCaminho_Danfe.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnNfcCaminho_Danfe.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnNfcCaminho_Danfe.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnNfcCaminho_Danfe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnNfcCaminho_Danfe.Caption = "NFC Caminho Danfe";
            this.bandedGridColumnNfcCaminho_Danfe.FieldName = "nfccaminho_danfe";
            this.bandedGridColumnNfcCaminho_Danfe.Name = "bandedGridColumnNfcCaminho_Danfe";
            // 
            // bandedGridColumnclientespessoas_idclientespessoas
            // 
            this.bandedGridColumnclientespessoas_idclientespessoas.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnclientespessoas_idclientespessoas.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnclientespessoas_idclientespessoas.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnclientespessoas_idclientespessoas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnclientespessoas_idclientespessoas.Caption = "clientespessoas_idclientespessoas";
            this.bandedGridColumnclientespessoas_idclientespessoas.FieldName = "clientespessoas_idclientespessoas";
            this.bandedGridColumnclientespessoas_idclientespessoas.Name = "bandedGridColumnclientespessoas_idclientespessoas";
            // 
            // bandedGridColumncaixas_idcaixas
            // 
            this.bandedGridColumncaixas_idcaixas.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumncaixas_idcaixas.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumncaixas_idcaixas.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumncaixas_idcaixas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumncaixas_idcaixas.Caption = "caixas_idcaixas";
            this.bandedGridColumncaixas_idcaixas.FieldName = "caixas_idcaixas";
            this.bandedGridColumncaixas_idcaixas.Name = "bandedGridColumncaixas_idcaixas";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiImprimirVisualizar,
            this.bsiRecordsCount,
            this.bbiNovaVenda,
            this.bbiEditarVenda,
            this.bbiDeletarVenda,
            this.bbiAtualizarGrid,
            this.bbiTrocaDevolucao,
            this.bbiReimprimirCupomNaoFiscal,
            this.bbiReimprimirNFC_e,
            this.bbiXML_NFC_e});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 24;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(978, 164);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiImprimirVisualizar
            // 
            this.bbiImprimirVisualizar.Caption = "Visualizar e Imprimir";
            this.bbiImprimirVisualizar.Id = 14;
            this.bbiImprimirVisualizar.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiImprimirVisualizar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiImprimirVisualizar.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiImprimirVisualizar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiImprimirVisualizar.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiImprimirVisualizar.Name = "bbiImprimirVisualizar";
            this.bbiImprimirVisualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "Registros : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNovaVenda
            // 
            this.bbiNovaVenda.Caption = "Venda Caixa - PDV";
            this.bbiNovaVenda.Id = 16;
            this.bbiNovaVenda.ImageOptions.ImageUri.Uri = "New";
            this.bbiNovaVenda.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiNovaVenda.ImageOptions.SvgImage")));
            this.bbiNovaVenda.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiNovaVenda.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiNovaVenda.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiNovaVenda.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiNovaVenda.Name = "bbiNovaVenda";
            this.bbiNovaVenda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNovaVenda_ItemClick);
            // 
            // bbiEditarVenda
            // 
            this.bbiEditarVenda.Caption = "Editar";
            this.bbiEditarVenda.Id = 17;
            this.bbiEditarVenda.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEditarVenda.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiEditarVenda.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiEditarVenda.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiEditarVenda.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiEditarVenda.Name = "bbiEditarVenda";
            this.bbiEditarVenda.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bbiEditarVenda.VisibleInSearchMenu = false;
            this.bbiEditarVenda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditarVenda_ItemClick);
            // 
            // bbiDeletarVenda
            // 
            this.bbiDeletarVenda.Caption = "Deletar";
            this.bbiDeletarVenda.Id = 18;
            this.bbiDeletarVenda.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDeletarVenda.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiDeletarVenda.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiDeletarVenda.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiDeletarVenda.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiDeletarVenda.Name = "bbiDeletarVenda";
            this.bbiDeletarVenda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeletarVenda_ItemClick);
            // 
            // bbiAtualizarGrid
            // 
            this.bbiAtualizarGrid.Caption = "Atualizar";
            this.bbiAtualizarGrid.Id = 19;
            this.bbiAtualizarGrid.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiAtualizarGrid.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiAtualizarGrid.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiAtualizarGrid.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiAtualizarGrid.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiAtualizarGrid.Name = "bbiAtualizarGrid";
            this.bbiAtualizarGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAtualizarGrid_ItemClick);
            // 
            // bbiTrocaDevolucao
            // 
            this.bbiTrocaDevolucao.Caption = "Troca / Devolução";
            this.bbiTrocaDevolucao.Id = 20;
            this.bbiTrocaDevolucao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiTrocaDevolucao.ImageOptions.SvgImage")));
            this.bbiTrocaDevolucao.Name = "bbiTrocaDevolucao";
            this.bbiTrocaDevolucao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTrocaDevolucao_ItemClick);
            // 
            // bbiReimprimirCupomNaoFiscal
            // 
            this.bbiReimprimirCupomNaoFiscal.Caption = "Reimprimir Cupom Não Fiscal";
            this.bbiReimprimirCupomNaoFiscal.Id = 21;
            this.bbiReimprimirCupomNaoFiscal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiReimprimirCupomNaoFiscal.ImageOptions.Image")));
            this.bbiReimprimirCupomNaoFiscal.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiReimprimirCupomNaoFiscal.ImageOptions.LargeImage")));
            this.bbiReimprimirCupomNaoFiscal.Name = "bbiReimprimirCupomNaoFiscal";
            this.bbiReimprimirCupomNaoFiscal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReimprimirCupomNaoFiscal_ItemClick);
            // 
            // bbiReimprimirNFC_e
            // 
            this.bbiReimprimirNFC_e.Caption = "Reimprimir Cupom NFC-e";
            this.bbiReimprimirNFC_e.Id = 22;
            this.bbiReimprimirNFC_e.ImageOptions.Image = global::AdvanceShop.Properties.Resources.NFC_e_64x64;
            this.bbiReimprimirNFC_e.ImageOptions.LargeImage = global::AdvanceShop.Properties.Resources.NFC_e_64x64;
            this.bbiReimprimirNFC_e.Name = "bbiReimprimirNFC_e";
            this.bbiReimprimirNFC_e.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReimprimirNFC_e_ItemClick);
            // 
            // bbiXML_NFC_e
            // 
            this.bbiXML_NFC_e.Caption = "XML NFC-e";
            this.bbiXML_NFC_e.Id = 23;
            this.bbiXML_NFC_e.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiXML_NFC_e.ImageOptions.Image")));
            this.bbiXML_NFC_e.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiXML_NFC_e.ImageOptions.LargeImage")));
            this.bbiXML_NFC_e.Name = "bbiXML_NFC_e";
            this.bbiXML_NFC_e.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXML_NFC_e_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Vendas";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNovaVenda);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiTrocaDevolucao);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEditarVenda);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDeletarVenda);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAtualizarGrid);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReimprimirCupomNaoFiscal);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiReimprimirNFC_e);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiXML_NFC_e);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tarefas";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiImprimirVisualizar);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 545);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(978, 24);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 569);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.KeyPreview = true;
            this.Name = "Vendas";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vendas_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vendas_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiImprimirVisualizar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNovaVenda;
        private DevExpress.XtraBars.BarButtonItem bbiEditarVenda;
        private DevExpress.XtraBars.BarButtonItem bbiDeletarVenda;
        private DevExpress.XtraBars.BarButtonItem bbiAtualizarGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItensVenda;
        private DevExpress.XtraBars.BarButtonItem bbiTrocaDevolucao;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridViewVendas;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCodigo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCliente;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnValor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDesconto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnTotalFinal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnValorPago;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnTroco;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDataHoraCad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDataHoraEdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnUsuarioCad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnUsuarioEdi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodigoproduto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescricaoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValorUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValorProdutoHoje;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuantidadeEstoque;
        private DevExpress.XtraBars.BarButtonItem bbiReimprimirCupomNaoFiscal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnclientespessoas_idclientespessoas;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumncaixas_idcaixas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMargemLucro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrecoCusto;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnNfcStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnNfcNumero;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnNfcMensagem_Sefaz;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnNfcCaminho_xml;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnNfcCaminho_Danfe;
        private DevExpress.XtraBars.BarButtonItem bbiReimprimirNFC_e;
        private DevExpress.XtraBars.BarButtonItem bbiXML_NFC_e;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    }
}