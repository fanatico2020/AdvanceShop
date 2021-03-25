namespace AdvanceShop.Views
{
    partial class Produtos
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridViewProdutos = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumnCodigo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDescricao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCodigoBarra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnStatusProduto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumncontrolarestoque = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnEstoqueAtual = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnEstoqueMin = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnEstoqueMax = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnPrecoCusto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnMargemLucro = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnPrecoVenda = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumncategoriasprodutos_idcategoriasprodutos = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnCategoria = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnclientespessoas_idclientespessoas = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnFornecedor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnmarcasprodutos_idmarcasprodutos = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnMarca = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnUnidadeMedida = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumncalcularprecovendaauto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiImprimirVisualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNovoProduto = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditarProduto = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeletarProduto = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(0, 164);
            this.gridControl.MainView = this.advBandedGridViewProdutos;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(798, 405);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridViewProdutos});
            // 
            // advBandedGridViewProdutos
            // 
            this.advBandedGridViewProdutos.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridViewProdutos.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.advBandedGridViewProdutos.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumnCodigo,
            this.bandedGridColumnDescricao,
            this.bandedGridColumnCodigoBarra,
            this.bandedGridColumnEstoqueAtual,
            this.bandedGridColumnEstoqueMin,
            this.bandedGridColumnEstoqueMax,
            this.bandedGridColumnPrecoCusto,
            this.bandedGridColumnMargemLucro,
            this.bandedGridColumnPrecoVenda,
            this.bandedGridColumnStatusProduto,
            this.bandedGridColumncategoriasprodutos_idcategoriasprodutos,
            this.bandedGridColumnclientespessoas_idclientespessoas,
            this.bandedGridColumnmarcasprodutos_idmarcasprodutos,
            this.bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos,
            this.bandedGridColumncalcularprecovendaauto,
            this.bandedGridColumncontrolarestoque,
            this.bandedGridColumnCategoria,
            this.bandedGridColumnFornecedor,
            this.bandedGridColumnMarca,
            this.bandedGridColumnUnidadeMedida});
            this.advBandedGridViewProdutos.GridControl = this.gridControl;
            this.advBandedGridViewProdutos.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.advBandedGridViewProdutos.Name = "advBandedGridViewProdutos";
            this.advBandedGridViewProdutos.OptionsBehavior.Editable = false;
            this.advBandedGridViewProdutos.OptionsBehavior.ReadOnly = true;
            this.advBandedGridViewProdutos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridViewProdutos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.advBandedGridViewProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.advBandedGridViewProdutos.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.advBandedGridViewProdutos.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.advBandedGridViewProdutos_PopupMenuShowing);
            this.advBandedGridViewProdutos.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.advBandedGridViewProdutos_CustomColumnDisplayText);
            this.advBandedGridViewProdutos.DoubleClick += new System.EventHandler(this.advBandedGridViewProdutos_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.bandedGridColumnCodigo);
            this.gridBand1.Columns.Add(this.bandedGridColumnDescricao);
            this.gridBand1.Columns.Add(this.bandedGridColumnCodigoBarra);
            this.gridBand1.Columns.Add(this.bandedGridColumnStatusProduto);
            this.gridBand1.Columns.Add(this.bandedGridColumncontrolarestoque);
            this.gridBand1.Columns.Add(this.bandedGridColumnEstoqueAtual);
            this.gridBand1.Columns.Add(this.bandedGridColumnEstoqueMin);
            this.gridBand1.Columns.Add(this.bandedGridColumnEstoqueMax);
            this.gridBand1.Columns.Add(this.bandedGridColumnPrecoCusto);
            this.gridBand1.Columns.Add(this.bandedGridColumnMargemLucro);
            this.gridBand1.Columns.Add(this.bandedGridColumnPrecoVenda);
            this.gridBand1.Columns.Add(this.bandedGridColumncategoriasprodutos_idcategoriasprodutos);
            this.gridBand1.Columns.Add(this.bandedGridColumnCategoria);
            this.gridBand1.Columns.Add(this.bandedGridColumnclientespessoas_idclientespessoas);
            this.gridBand1.Columns.Add(this.bandedGridColumnFornecedor);
            this.gridBand1.Columns.Add(this.bandedGridColumnmarcasprodutos_idmarcasprodutos);
            this.gridBand1.Columns.Add(this.bandedGridColumnMarca);
            this.gridBand1.Columns.Add(this.bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos);
            this.gridBand1.Columns.Add(this.bandedGridColumnUnidadeMedida);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1941;
            // 
            // bandedGridColumnCodigo
            // 
            this.bandedGridColumnCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnCodigo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnCodigo.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnCodigo.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnCodigo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnCodigo.Caption = "Código";
            this.bandedGridColumnCodigo.FieldName = "idprodutos";
            this.bandedGridColumnCodigo.Name = "bandedGridColumnCodigo";
            this.bandedGridColumnCodigo.Visible = true;
            // 
            // bandedGridColumnDescricao
            // 
            this.bandedGridColumnDescricao.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnDescricao.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnDescricao.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnDescricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDescricao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnDescricao.Caption = "Descrição Produto";
            this.bandedGridColumnDescricao.FieldName = "descricaoproduto";
            this.bandedGridColumnDescricao.Name = "bandedGridColumnDescricao";
            this.bandedGridColumnDescricao.Visible = true;
            this.bandedGridColumnDescricao.Width = 291;
            // 
            // bandedGridColumnCodigoBarra
            // 
            this.bandedGridColumnCodigoBarra.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnCodigoBarra.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnCodigoBarra.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnCodigoBarra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnCodigoBarra.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnCodigoBarra.Caption = "Código Barra";
            this.bandedGridColumnCodigoBarra.FieldName = "codigobarra";
            this.bandedGridColumnCodigoBarra.Name = "bandedGridColumnCodigoBarra";
            this.bandedGridColumnCodigoBarra.Visible = true;
            this.bandedGridColumnCodigoBarra.Width = 166;
            // 
            // bandedGridColumnStatusProduto
            // 
            this.bandedGridColumnStatusProduto.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnStatusProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnStatusProduto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnStatusProduto.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnStatusProduto.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnStatusProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnStatusProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnStatusProduto.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnStatusProduto.Caption = "Status";
            this.bandedGridColumnStatusProduto.FieldName = "statusproduto";
            this.bandedGridColumnStatusProduto.Name = "bandedGridColumnStatusProduto";
            this.bandedGridColumnStatusProduto.Visible = true;
            this.bandedGridColumnStatusProduto.Width = 86;
            // 
            // bandedGridColumncontrolarestoque
            // 
            this.bandedGridColumncontrolarestoque.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumncontrolarestoque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumncontrolarestoque.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumncontrolarestoque.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumncontrolarestoque.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumncontrolarestoque.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumncontrolarestoque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumncontrolarestoque.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumncontrolarestoque.Caption = "Controlar Estoque";
            this.bandedGridColumncontrolarestoque.FieldName = "controlarestoque";
            this.bandedGridColumncontrolarestoque.Name = "bandedGridColumncontrolarestoque";
            this.bandedGridColumncontrolarestoque.Visible = true;
            // 
            // bandedGridColumnEstoqueAtual
            // 
            this.bandedGridColumnEstoqueAtual.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnEstoqueAtual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnEstoqueAtual.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnEstoqueAtual.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnEstoqueAtual.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnEstoqueAtual.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnEstoqueAtual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnEstoqueAtual.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnEstoqueAtual.Caption = "Estoque Atual";
            this.bandedGridColumnEstoqueAtual.FieldName = "estoqueatual";
            this.bandedGridColumnEstoqueAtual.Name = "bandedGridColumnEstoqueAtual";
            this.bandedGridColumnEstoqueAtual.Visible = true;
            this.bandedGridColumnEstoqueAtual.Width = 96;
            // 
            // bandedGridColumnEstoqueMin
            // 
            this.bandedGridColumnEstoqueMin.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnEstoqueMin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnEstoqueMin.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnEstoqueMin.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnEstoqueMin.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnEstoqueMin.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnEstoqueMin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnEstoqueMin.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnEstoqueMin.Caption = "Estoque Min.";
            this.bandedGridColumnEstoqueMin.FieldName = "estoqueminimo";
            this.bandedGridColumnEstoqueMin.Name = "bandedGridColumnEstoqueMin";
            this.bandedGridColumnEstoqueMin.Visible = true;
            this.bandedGridColumnEstoqueMin.Width = 92;
            // 
            // bandedGridColumnEstoqueMax
            // 
            this.bandedGridColumnEstoqueMax.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnEstoqueMax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnEstoqueMax.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnEstoqueMax.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnEstoqueMax.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnEstoqueMax.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnEstoqueMax.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnEstoqueMax.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnEstoqueMax.Caption = "Estoque Max.";
            this.bandedGridColumnEstoqueMax.FieldName = "estoquemaximo";
            this.bandedGridColumnEstoqueMax.Name = "bandedGridColumnEstoqueMax";
            this.bandedGridColumnEstoqueMax.Visible = true;
            this.bandedGridColumnEstoqueMax.Width = 94;
            // 
            // bandedGridColumnPrecoCusto
            // 
            this.bandedGridColumnPrecoCusto.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnPrecoCusto.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnPrecoCusto.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnPrecoCusto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnPrecoCusto.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnPrecoCusto.Caption = "Preço Custo";
            this.bandedGridColumnPrecoCusto.DisplayFormat.FormatString = "c";
            this.bandedGridColumnPrecoCusto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumnPrecoCusto.FieldName = "precocusto";
            this.bandedGridColumnPrecoCusto.Name = "bandedGridColumnPrecoCusto";
            this.bandedGridColumnPrecoCusto.Visible = true;
            this.bandedGridColumnPrecoCusto.Width = 115;
            // 
            // bandedGridColumnMargemLucro
            // 
            this.bandedGridColumnMargemLucro.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnMargemLucro.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnMargemLucro.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnMargemLucro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnMargemLucro.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnMargemLucro.Caption = "Margem Lucro";
            this.bandedGridColumnMargemLucro.DisplayFormat.FormatString = "n";
            this.bandedGridColumnMargemLucro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumnMargemLucro.FieldName = "margemlucro";
            this.bandedGridColumnMargemLucro.Name = "bandedGridColumnMargemLucro";
            this.bandedGridColumnMargemLucro.Visible = true;
            this.bandedGridColumnMargemLucro.Width = 120;
            // 
            // bandedGridColumnPrecoVenda
            // 
            this.bandedGridColumnPrecoVenda.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnPrecoVenda.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnPrecoVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnPrecoVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnPrecoVenda.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnPrecoVenda.Caption = "Preço Venda";
            this.bandedGridColumnPrecoVenda.DisplayFormat.FormatString = "c";
            this.bandedGridColumnPrecoVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.bandedGridColumnPrecoVenda.FieldName = "precovenda";
            this.bandedGridColumnPrecoVenda.Name = "bandedGridColumnPrecoVenda";
            this.bandedGridColumnPrecoVenda.Visible = true;
            this.bandedGridColumnPrecoVenda.Width = 133;
            // 
            // bandedGridColumncategoriasprodutos_idcategoriasprodutos
            // 
            this.bandedGridColumncategoriasprodutos_idcategoriasprodutos.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumncategoriasprodutos_idcategoriasprodutos.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumncategoriasprodutos_idcategoriasprodutos.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumncategoriasprodutos_idcategoriasprodutos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumncategoriasprodutos_idcategoriasprodutos.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumncategoriasprodutos_idcategoriasprodutos.Caption = "Código Categ.";
            this.bandedGridColumncategoriasprodutos_idcategoriasprodutos.FieldName = "categoriasprodutos_idcategoriasprodutos";
            this.bandedGridColumncategoriasprodutos_idcategoriasprodutos.Name = "bandedGridColumncategoriasprodutos_idcategoriasprodutos";
            // 
            // bandedGridColumnCategoria
            // 
            this.bandedGridColumnCategoria.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnCategoria.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnCategoria.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnCategoria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnCategoria.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnCategoria.Caption = "Categoria";
            this.bandedGridColumnCategoria.FieldName = "descricaocategoria";
            this.bandedGridColumnCategoria.Name = "bandedGridColumnCategoria";
            this.bandedGridColumnCategoria.Visible = true;
            this.bandedGridColumnCategoria.Width = 174;
            // 
            // bandedGridColumnclientespessoas_idclientespessoas
            // 
            this.bandedGridColumnclientespessoas_idclientespessoas.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnclientespessoas_idclientespessoas.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnclientespessoas_idclientespessoas.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnclientespessoas_idclientespessoas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnclientespessoas_idclientespessoas.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnclientespessoas_idclientespessoas.Caption = "Código Forn.";
            this.bandedGridColumnclientespessoas_idclientespessoas.FieldName = "clientespessoas_idclientespessoas";
            this.bandedGridColumnclientespessoas_idclientespessoas.Name = "bandedGridColumnclientespessoas_idclientespessoas";
            // 
            // bandedGridColumnFornecedor
            // 
            this.bandedGridColumnFornecedor.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnFornecedor.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnFornecedor.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnFornecedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnFornecedor.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnFornecedor.Caption = "Fornecedor";
            this.bandedGridColumnFornecedor.FieldName = "nome";
            this.bandedGridColumnFornecedor.Name = "bandedGridColumnFornecedor";
            this.bandedGridColumnFornecedor.Visible = true;
            this.bandedGridColumnFornecedor.Width = 194;
            // 
            // bandedGridColumnmarcasprodutos_idmarcasprodutos
            // 
            this.bandedGridColumnmarcasprodutos_idmarcasprodutos.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnmarcasprodutos_idmarcasprodutos.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnmarcasprodutos_idmarcasprodutos.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnmarcasprodutos_idmarcasprodutos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnmarcasprodutos_idmarcasprodutos.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnmarcasprodutos_idmarcasprodutos.Caption = "Código Mar.";
            this.bandedGridColumnmarcasprodutos_idmarcasprodutos.FieldName = "marcasprodutos_idmarcasprodutos";
            this.bandedGridColumnmarcasprodutos_idmarcasprodutos.Name = "bandedGridColumnmarcasprodutos_idmarcasprodutos";
            // 
            // bandedGridColumnMarca
            // 
            this.bandedGridColumnMarca.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnMarca.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnMarca.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnMarca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnMarca.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnMarca.Caption = "Marca";
            this.bandedGridColumnMarca.FieldName = "descricaomarca";
            this.bandedGridColumnMarca.Name = "bandedGridColumnMarca";
            this.bandedGridColumnMarca.Visible = true;
            this.bandedGridColumnMarca.Width = 114;
            // 
            // bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos
            // 
            this.bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos.Caption = "Código Unid.";
            this.bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos.FieldName = "unidadesmedidasprodutos_idunidadesmedidasprodutos";
            this.bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos.Name = "bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos";
            // 
            // bandedGridColumnUnidadeMedida
            // 
            this.bandedGridColumnUnidadeMedida.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnUnidadeMedida.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnUnidadeMedida.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnUnidadeMedida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnUnidadeMedida.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnUnidadeMedida.Caption = "Unidade Medida";
            this.bandedGridColumnUnidadeMedida.FieldName = "descricaounidademedida";
            this.bandedGridColumnUnidadeMedida.Name = "bandedGridColumnUnidadeMedida";
            this.bandedGridColumnUnidadeMedida.Visible = true;
            this.bandedGridColumnUnidadeMedida.Width = 116;
            // 
            // bandedGridColumncalcularprecovendaauto
            // 
            this.bandedGridColumncalcularprecovendaauto.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumncalcularprecovendaauto.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumncalcularprecovendaauto.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumncalcularprecovendaauto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumncalcularprecovendaauto.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumncalcularprecovendaauto.Caption = "calcularprecovendaauto";
            this.bandedGridColumncalcularprecovendaauto.FieldName = "calcularprecovendaauto";
            this.bandedGridColumncalcularprecovendaauto.Name = "bandedGridColumncalcularprecovendaauto";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiImprimirVisualizar,
            this.bsiRecordsCount,
            this.bbiNovoProduto,
            this.bbiEditarProduto,
            this.bbiDeletarProduto,
            this.bbiAtualizar,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 22;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(798, 158);
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
            // bbiNovoProduto
            // 
            this.bbiNovoProduto.Caption = "Novo Produto";
            this.bbiNovoProduto.Id = 16;
            this.bbiNovoProduto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiNovoProduto.ImageOptions.Image")));
            this.bbiNovoProduto.ImageOptions.ImageUri.Uri = "New";
            this.bbiNovoProduto.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiNovoProduto.ImageOptions.LargeImage")));
            this.bbiNovoProduto.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiNovoProduto.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiNovoProduto.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiNovoProduto.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiNovoProduto.Name = "bbiNovoProduto";
            this.bbiNovoProduto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNovoProduto_ItemClick);
            // 
            // bbiEditarProduto
            // 
            this.bbiEditarProduto.Caption = "Editar";
            this.bbiEditarProduto.Id = 17;
            this.bbiEditarProduto.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEditarProduto.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiEditarProduto.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiEditarProduto.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiEditarProduto.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiEditarProduto.Name = "bbiEditarProduto";
            this.bbiEditarProduto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditarProduto_ItemClick);
            // 
            // bbiDeletarProduto
            // 
            this.bbiDeletarProduto.Caption = "Deletar";
            this.bbiDeletarProduto.Id = 18;
            this.bbiDeletarProduto.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDeletarProduto.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiDeletarProduto.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiDeletarProduto.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiDeletarProduto.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiDeletarProduto.Name = "bbiDeletarProduto";
            this.bbiDeletarProduto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeletarProduto_ItemClick);
            // 
            // bbiAtualizar
            // 
            this.bbiAtualizar.Caption = "Atualizar";
            this.bbiAtualizar.Id = 19;
            this.bbiAtualizar.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiAtualizar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiAtualizar.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiAtualizar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiAtualizar.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiAtualizar.Name = "bbiAtualizar";
            this.bbiAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAtualizar_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Entrada";
            this.barButtonItem1.Id = 20;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Saída";
            this.barButtonItem2.Id = 21;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Prudutos";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNovoProduto);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEditarProduto);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDeletarProduto);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAtualizar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 575);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(798, 24);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.KeyPreview = true;
            this.Name = "Produtos";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Produtos_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewProdutos)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiNovoProduto;
        private DevExpress.XtraBars.BarButtonItem bbiEditarProduto;
        private DevExpress.XtraBars.BarButtonItem bbiDeletarProduto;
        private DevExpress.XtraBars.BarButtonItem bbiAtualizar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridViewProdutos;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCodigo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDescricao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCodigoBarra;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnEstoqueAtual;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnEstoqueMin;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnEstoqueMax;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnPrecoCusto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnMargemLucro;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnPrecoVenda;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnStatusProduto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumncategoriasprodutos_idcategoriasprodutos;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnclientespessoas_idclientespessoas;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnmarcasprodutos_idmarcasprodutos;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnunidadesmedidasprodutos_idunidadesmedidasprodutos;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumncalcularprecovendaauto;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumncontrolarestoque;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCategoria;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnFornecedor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnMarca;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnUnidadeMedida;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    }
}