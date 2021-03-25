namespace AdvanceShop.Views
{
    partial class TransacoesEstoque
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransacoesEstoque));
            this.gridViewItensTransacaoEstoque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCodigoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescricaoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnValorUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridViewTransacoesEstoque = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumnCodigo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnTipo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDescricaoTransacao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnClienteFornecedor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnObservacao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDocumento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnChaveDocFiscal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDataHoraCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnUsuarioCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDataHoraEdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnUsuarioEdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnvendas_idvendas = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiImprimirVisualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiEntrada = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeletar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaida = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensTransacaoEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewTransacoesEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewItensTransacaoEstoque
            // 
            this.gridViewItensTransacaoEstoque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCodigoProduto,
            this.gridColumnDescricaoProduto,
            this.gridColumnQuantidade,
            this.gridColumnValorUnitario,
            this.gridColumnSubtotal});
            this.gridViewItensTransacaoEstoque.GridControl = this.gridControl;
            this.gridViewItensTransacaoEstoque.Name = "gridViewItensTransacaoEstoque";
            this.gridViewItensTransacaoEstoque.OptionsBehavior.Editable = false;
            this.gridViewItensTransacaoEstoque.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewItensTransacaoEstoque.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewItensTransacaoEstoque.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnCodigoProduto
            // 
            this.gridColumnCodigoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnCodigoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCodigoProduto.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnCodigoProduto.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnCodigoProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCodigoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCodigoProduto.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnCodigoProduto.Caption = "Código Prod.";
            this.gridColumnCodigoProduto.FieldName = "idprodutos";
            this.gridColumnCodigoProduto.Name = "gridColumnCodigoProduto";
            this.gridColumnCodigoProduto.Visible = true;
            this.gridColumnCodigoProduto.VisibleIndex = 0;
            this.gridColumnCodigoProduto.Width = 78;
            // 
            // gridColumnDescricaoProduto
            // 
            this.gridColumnDescricaoProduto.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnDescricaoProduto.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnDescricaoProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnDescricaoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnDescricaoProduto.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnDescricaoProduto.Caption = "Descrição Produto";
            this.gridColumnDescricaoProduto.FieldName = "descricaoproduto";
            this.gridColumnDescricaoProduto.Name = "gridColumnDescricaoProduto";
            this.gridColumnDescricaoProduto.Visible = true;
            this.gridColumnDescricaoProduto.VisibleIndex = 1;
            this.gridColumnDescricaoProduto.Width = 383;
            // 
            // gridColumnQuantidade
            // 
            this.gridColumnQuantidade.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnQuantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnQuantidade.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnQuantidade.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnQuantidade.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnQuantidade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnQuantidade.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnQuantidade.Caption = "Quantidade";
            this.gridColumnQuantidade.FieldName = "quantidade";
            this.gridColumnQuantidade.Name = "gridColumnQuantidade";
            this.gridColumnQuantidade.Visible = true;
            this.gridColumnQuantidade.VisibleIndex = 2;
            this.gridColumnQuantidade.Width = 77;
            // 
            // gridColumnValorUnitario
            // 
            this.gridColumnValorUnitario.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnValorUnitario.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnValorUnitario.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnValorUnitario.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnValorUnitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnValorUnitario.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnValorUnitario.Caption = "Valor Unitario";
            this.gridColumnValorUnitario.DisplayFormat.FormatString = "c";
            this.gridColumnValorUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnValorUnitario.FieldName = "valorunitario";
            this.gridColumnValorUnitario.Name = "gridColumnValorUnitario";
            this.gridColumnValorUnitario.Visible = true;
            this.gridColumnValorUnitario.VisibleIndex = 3;
            this.gridColumnValorUnitario.Width = 129;
            // 
            // gridColumnSubtotal
            // 
            this.gridColumnSubtotal.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumnSubtotal.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnSubtotal.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnSubtotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnSubtotal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumnSubtotal.Caption = "Subtotal";
            this.gridColumnSubtotal.DisplayFormat.FormatString = "c";
            this.gridColumnSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnSubtotal.FieldName = "subtotal";
            this.gridColumnSubtotal.Name = "gridColumnSubtotal";
            this.gridColumnSubtotal.Visible = true;
            this.gridColumnSubtotal.VisibleIndex = 4;
            this.gridColumnSubtotal.Width = 146;
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.LevelTemplate = this.gridViewItensTransacaoEstoque;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl.Location = new System.Drawing.Point(0, 170);
            this.gridControl.MainView = this.advBandedGridViewTransacoesEstoque;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(970, 366);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridViewTransacoesEstoque,
            this.gridViewItensTransacaoEstoque});
            // 
            // advBandedGridViewTransacoesEstoque
            // 
            this.advBandedGridViewTransacoesEstoque.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridViewTransacoesEstoque.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.advBandedGridViewTransacoesEstoque.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumnCodigo,
            this.bandedGridColumnTipo,
            this.bandedGridColumnClienteFornecedor,
            this.bandedGridColumnObservacao,
            this.bandedGridColumnDocumento,
            this.bandedGridColumnChaveDocFiscal,
            this.bandedGridColumnDescricaoTransacao,
            this.bandedGridColumnvendas_idvendas,
            this.bandedGridColumnDataHoraCad,
            this.bandedGridColumnDataHoraEdi,
            this.bandedGridColumnUsuarioCad,
            this.bandedGridColumnUsuarioEdi});
            this.advBandedGridViewTransacoesEstoque.GridControl = this.gridControl;
            this.advBandedGridViewTransacoesEstoque.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.advBandedGridViewTransacoesEstoque.Name = "advBandedGridViewTransacoesEstoque";
            this.advBandedGridViewTransacoesEstoque.OptionsBehavior.Editable = false;
            this.advBandedGridViewTransacoesEstoque.OptionsBehavior.ReadOnly = true;
            this.advBandedGridViewTransacoesEstoque.OptionsPrint.EnableAppearanceEvenRow = true;
            this.advBandedGridViewTransacoesEstoque.OptionsPrint.PrintDetails = true;
            this.advBandedGridViewTransacoesEstoque.OptionsPrint.PrintFilterInfo = true;
            this.advBandedGridViewTransacoesEstoque.OptionsPrint.PrintGroupFooter = false;
            this.advBandedGridViewTransacoesEstoque.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridViewTransacoesEstoque.OptionsView.EnableAppearanceEvenRow = true;
            this.advBandedGridViewTransacoesEstoque.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.advBandedGridViewTransacoesEstoque.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.advBandedGridViewTransacoesEstoque_MasterRowEmpty);
            this.advBandedGridViewTransacoesEstoque.MasterRowGetLevelDefaultView += new DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(this.advBandedGridViewTransacoesEstoque_MasterRowGetLevelDefaultView);
            this.advBandedGridViewTransacoesEstoque.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.advBandedGridViewTransacoesEstoque_MasterRowGetChildList);
            this.advBandedGridViewTransacoesEstoque.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.advBandedGridViewTransacoesEstoque_MasterRowGetRelationName);
            this.advBandedGridViewTransacoesEstoque.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.advBandedGridViewTransacoesEstoque_MasterRowGetRelationCount);
            this.advBandedGridViewTransacoesEstoque.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.advBandedGridViewTransacoesEstoque_CustomColumnDisplayText);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.bandedGridColumnCodigo);
            this.gridBand1.Columns.Add(this.bandedGridColumnTipo);
            this.gridBand1.Columns.Add(this.bandedGridColumnDescricaoTransacao);
            this.gridBand1.Columns.Add(this.bandedGridColumnClienteFornecedor);
            this.gridBand1.Columns.Add(this.bandedGridColumnObservacao);
            this.gridBand1.Columns.Add(this.bandedGridColumnDocumento);
            this.gridBand1.Columns.Add(this.bandedGridColumnChaveDocFiscal);
            this.gridBand1.Columns.Add(this.bandedGridColumnDataHoraCad);
            this.gridBand1.Columns.Add(this.bandedGridColumnUsuarioCad);
            this.gridBand1.Columns.Add(this.bandedGridColumnDataHoraEdi);
            this.gridBand1.Columns.Add(this.bandedGridColumnUsuarioEdi);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1645;
            // 
            // bandedGridColumnCodigo
            // 
            this.bandedGridColumnCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnCodigo.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnCodigo.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnCodigo.Caption = "Código";
            this.bandedGridColumnCodigo.FieldName = "idtransacoesestoque";
            this.bandedGridColumnCodigo.Name = "bandedGridColumnCodigo";
            this.bandedGridColumnCodigo.Visible = true;
            this.bandedGridColumnCodigo.Width = 83;
            // 
            // bandedGridColumnTipo
            // 
            this.bandedGridColumnTipo.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnTipo.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnTipo.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnTipo.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnTipo.Caption = "Tipo";
            this.bandedGridColumnTipo.FieldName = "tipo";
            this.bandedGridColumnTipo.Name = "bandedGridColumnTipo";
            this.bandedGridColumnTipo.Visible = true;
            this.bandedGridColumnTipo.Width = 127;
            // 
            // bandedGridColumnDescricaoTransacao
            // 
            this.bandedGridColumnDescricaoTransacao.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnDescricaoTransacao.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnDescricaoTransacao.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnDescricaoTransacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDescricaoTransacao.Caption = "Descrição Transação";
            this.bandedGridColumnDescricaoTransacao.FieldName = "descricaotransacao";
            this.bandedGridColumnDescricaoTransacao.Name = "bandedGridColumnDescricaoTransacao";
            this.bandedGridColumnDescricaoTransacao.Visible = true;
            this.bandedGridColumnDescricaoTransacao.Width = 251;
            // 
            // bandedGridColumnClienteFornecedor
            // 
            this.bandedGridColumnClienteFornecedor.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnClienteFornecedor.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnClienteFornecedor.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnClienteFornecedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnClienteFornecedor.Caption = "Cliente / Fornecedor";
            this.bandedGridColumnClienteFornecedor.FieldName = "nome";
            this.bandedGridColumnClienteFornecedor.Name = "bandedGridColumnClienteFornecedor";
            this.bandedGridColumnClienteFornecedor.Visible = true;
            this.bandedGridColumnClienteFornecedor.Width = 282;
            // 
            // bandedGridColumnObservacao
            // 
            this.bandedGridColumnObservacao.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnObservacao.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnObservacao.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnObservacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnObservacao.Caption = "Observação";
            this.bandedGridColumnObservacao.FieldName = "observacaotransacaoestoque";
            this.bandedGridColumnObservacao.Name = "bandedGridColumnObservacao";
            this.bandedGridColumnObservacao.Visible = true;
            this.bandedGridColumnObservacao.Width = 177;
            // 
            // bandedGridColumnDocumento
            // 
            this.bandedGridColumnDocumento.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnDocumento.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnDocumento.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnDocumento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDocumento.Caption = "Documento";
            this.bandedGridColumnDocumento.FieldName = "documento";
            this.bandedGridColumnDocumento.Name = "bandedGridColumnDocumento";
            this.bandedGridColumnDocumento.Visible = true;
            this.bandedGridColumnDocumento.Width = 164;
            // 
            // bandedGridColumnChaveDocFiscal
            // 
            this.bandedGridColumnChaveDocFiscal.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnChaveDocFiscal.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnChaveDocFiscal.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnChaveDocFiscal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnChaveDocFiscal.Caption = "Chave Doc.Fiscal";
            this.bandedGridColumnChaveDocFiscal.FieldName = "chavedocfiscal";
            this.bandedGridColumnChaveDocFiscal.Name = "bandedGridColumnChaveDocFiscal";
            this.bandedGridColumnChaveDocFiscal.Visible = true;
            this.bandedGridColumnChaveDocFiscal.Width = 138;
            // 
            // bandedGridColumnDataHoraCad
            // 
            this.bandedGridColumnDataHoraCad.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnDataHoraCad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDataHoraCad.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnDataHoraCad.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnDataHoraCad.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnDataHoraCad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDataHoraCad.Caption = "Data/Hora Cad.";
            this.bandedGridColumnDataHoraCad.DisplayFormat.FormatString = "g";
            this.bandedGridColumnDataHoraCad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bandedGridColumnDataHoraCad.FieldName = "datahoracadastro";
            this.bandedGridColumnDataHoraCad.Name = "bandedGridColumnDataHoraCad";
            this.bandedGridColumnDataHoraCad.Visible = true;
            this.bandedGridColumnDataHoraCad.Width = 102;
            // 
            // bandedGridColumnUsuarioCad
            // 
            this.bandedGridColumnUsuarioCad.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnUsuarioCad.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnUsuarioCad.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnUsuarioCad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnUsuarioCad.Caption = "Usuário Cad.";
            this.bandedGridColumnUsuarioCad.FieldName = "usuariocadastro";
            this.bandedGridColumnUsuarioCad.Name = "bandedGridColumnUsuarioCad";
            this.bandedGridColumnUsuarioCad.Visible = true;
            this.bandedGridColumnUsuarioCad.Width = 106;
            // 
            // bandedGridColumnDataHoraEdi
            // 
            this.bandedGridColumnDataHoraEdi.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnDataHoraEdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDataHoraEdi.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnDataHoraEdi.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnDataHoraEdi.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnDataHoraEdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDataHoraEdi.Caption = "Data/Hora Edi.";
            this.bandedGridColumnDataHoraEdi.DisplayFormat.FormatString = "g";
            this.bandedGridColumnDataHoraEdi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bandedGridColumnDataHoraEdi.FieldName = "datahoraedicao";
            this.bandedGridColumnDataHoraEdi.Name = "bandedGridColumnDataHoraEdi";
            this.bandedGridColumnDataHoraEdi.Visible = true;
            this.bandedGridColumnDataHoraEdi.Width = 105;
            // 
            // bandedGridColumnUsuarioEdi
            // 
            this.bandedGridColumnUsuarioEdi.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnUsuarioEdi.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnUsuarioEdi.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnUsuarioEdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnUsuarioEdi.Caption = "Usuário Edi.";
            this.bandedGridColumnUsuarioEdi.FieldName = "usuarioedicao";
            this.bandedGridColumnUsuarioEdi.Name = "bandedGridColumnUsuarioEdi";
            this.bandedGridColumnUsuarioEdi.Visible = true;
            this.bandedGridColumnUsuarioEdi.Width = 110;
            // 
            // bandedGridColumnvendas_idvendas
            // 
            this.bandedGridColumnvendas_idvendas.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnvendas_idvendas.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnvendas_idvendas.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnvendas_idvendas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnvendas_idvendas.Caption = "vendas_idvendas";
            this.bandedGridColumnvendas_idvendas.FieldName = "vendas_idvendas";
            this.bandedGridColumnvendas_idvendas.Name = "bandedGridColumnvendas_idvendas";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiImprimirVisualizar,
            this.bsiRecordsCount,
            this.bbiEntrada,
            this.bbiEditar,
            this.bbiDeletar,
            this.bbiAtualizar,
            this.bbiSaida});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(970, 164);
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
            // bbiEntrada
            // 
            this.bbiEntrada.Caption = "Entrada";
            this.bbiEntrada.Id = 16;
            this.bbiEntrada.ImageOptions.ImageUri.Uri = "New";
            this.bbiEntrada.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEntrada.ImageOptions.SvgImage")));
            this.bbiEntrada.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiEntrada.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiEntrada.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiEntrada.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiEntrada.Name = "bbiEntrada";
            this.bbiEntrada.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEntrada_ItemClick);
            // 
            // bbiEditar
            // 
            this.bbiEditar.Caption = "Editar";
            this.bbiEditar.Id = 17;
            this.bbiEditar.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEditar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiEditar.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiEditar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiEditar.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiEditar.Name = "bbiEditar";
            this.bbiEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditar_ItemClick);
            // 
            // bbiDeletar
            // 
            this.bbiDeletar.Caption = "Deletar";
            this.bbiDeletar.Id = 18;
            this.bbiDeletar.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDeletar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiDeletar.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiDeletar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiDeletar.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiDeletar.Name = "bbiDeletar";
            this.bbiDeletar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDeletar_ItemClick);
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
            // bbiSaida
            // 
            this.bbiSaida.Caption = "Saída";
            this.bbiSaida.Id = 20;
            this.bbiSaida.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSaida.ImageOptions.SvgImage")));
            this.bbiSaida.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiSaida.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiSaida.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiSaida.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiSaida.Name = "bbiSaida";
            this.bbiSaida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaida_ItemClick);
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
            this.ribbonPage1.Text = "Transações Estoque";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEntrada);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaida);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEditar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDeletar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAtualizar);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 542);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(970, 24);
            // 
            // TransacoesEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 566);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "TransacoesEstoque";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Transações Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TransacoesEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensTransacaoEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewTransacoesEstoque)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiEntrada;
        private DevExpress.XtraBars.BarButtonItem bbiEditar;
        private DevExpress.XtraBars.BarButtonItem bbiDeletar;
        private DevExpress.XtraBars.BarButtonItem bbiAtualizar;
        private DevExpress.XtraBars.BarButtonItem bbiSaida;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridViewTransacoesEstoque;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCodigo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnTipo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnClienteFornecedor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnObservacao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDocumento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnChaveDocFiscal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDescricaoTransacao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnvendas_idvendas;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDataHoraCad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDataHoraEdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnUsuarioCad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnUsuarioEdi;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItensTransacaoEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodigoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescricaoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnValorUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSubtotal;
    }
}