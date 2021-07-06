namespace AdvanceShop.Views
{
    partial class Caixas
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixas));
            this.bandedGridColumnStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridViewCaixas = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumnCodigo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnUsuarioCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDataHoraCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnMaquina = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnSaldoInicial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnUsuarioEdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDataHoraEdi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnSaldoFinal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnValorInformado = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnQuebraCaixa = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnUsuarioFechamento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnDataHoraFechamento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumnObservacao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiVisualizarImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDeletar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAbrirCaixa = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTransacoesCaixa = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewCaixas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // bandedGridColumnStatus
            // 
            this.bandedGridColumnStatus.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnStatus.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnStatus.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnStatus.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnStatus.Caption = "Status";
            this.bandedGridColumnStatus.FieldName = "status";
            this.bandedGridColumnStatus.Name = "bandedGridColumnStatus";
            this.bandedGridColumnStatus.Visible = true;
            this.bandedGridColumnStatus.Width = 85;
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(0, 170);
            this.gridControl.MainView = this.advBandedGridViewCaixas;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(972, 399);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridViewCaixas});
            // 
            // advBandedGridViewCaixas
            // 
            this.advBandedGridViewCaixas.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridViewCaixas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.advBandedGridViewCaixas.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumnCodigo,
            this.bandedGridColumnMaquina,
            this.bandedGridColumnSaldoInicial,
            this.bandedGridColumnSaldoFinal,
            this.bandedGridColumnValorInformado,
            this.bandedGridColumnQuebraCaixa,
            this.bandedGridColumnObservacao,
            this.bandedGridColumnUsuarioFechamento,
            this.bandedGridColumnDataHoraCad,
            this.bandedGridColumnDataHoraEdi,
            this.bandedGridColumnUsuarioCad,
            this.bandedGridColumnUsuarioEdi,
            this.bandedGridColumnStatus,
            this.bandedGridColumnDataHoraFechamento});
            gridFormatRule1.Column = this.bandedGridColumnStatus;
            gridFormatRule1.ColumnApplyTo = this.bandedGridColumnStatus;
            gridFormatRule1.Name = "FormatStatusCaixaIcon";
            formatConditionIconSet1.CategoryName = "Symbols";
            formatConditionIconSetIcon1.PredefinedName = "Symbols23_2.png";
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "Symbols23_1.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Name = "Symbols3Uncircled";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            this.advBandedGridViewCaixas.FormatRules.Add(gridFormatRule1);
            this.advBandedGridViewCaixas.GridControl = this.gridControl;
            this.advBandedGridViewCaixas.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.advBandedGridViewCaixas.Name = "advBandedGridViewCaixas";
            this.advBandedGridViewCaixas.OptionsBehavior.Editable = false;
            this.advBandedGridViewCaixas.OptionsBehavior.ReadOnly = true;
            this.advBandedGridViewCaixas.OptionsPrint.EnableAppearanceEvenRow = true;
            this.advBandedGridViewCaixas.OptionsPrint.PrintBandHeader = false;
            this.advBandedGridViewCaixas.OptionsPrint.PrintDetails = true;
            this.advBandedGridViewCaixas.OptionsPrint.PrintFilterInfo = true;
            this.advBandedGridViewCaixas.OptionsPrint.PrintGroupFooter = false;
            this.advBandedGridViewCaixas.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridViewCaixas.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.advBandedGridViewCaixas.OptionsView.EnableAppearanceEvenRow = true;
            this.advBandedGridViewCaixas.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.advBandedGridViewCaixas.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.advBandedGridViewCaixas_PopupMenuShowing);
            this.advBandedGridViewCaixas.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.advBandedGridViewCaixas_CustomColumnDisplayText);
            this.advBandedGridViewCaixas.DoubleClick += new System.EventHandler(this.advBandedGridViewCaixas_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.bandedGridColumnCodigo);
            this.gridBand1.Columns.Add(this.bandedGridColumnStatus);
            this.gridBand1.Columns.Add(this.bandedGridColumnUsuarioCad);
            this.gridBand1.Columns.Add(this.bandedGridColumnDataHoraCad);
            this.gridBand1.Columns.Add(this.bandedGridColumnMaquina);
            this.gridBand1.Columns.Add(this.bandedGridColumnSaldoInicial);
            this.gridBand1.Columns.Add(this.bandedGridColumnUsuarioEdi);
            this.gridBand1.Columns.Add(this.bandedGridColumnDataHoraEdi);
            this.gridBand1.Columns.Add(this.bandedGridColumnSaldoFinal);
            this.gridBand1.Columns.Add(this.bandedGridColumnValorInformado);
            this.gridBand1.Columns.Add(this.bandedGridColumnQuebraCaixa);
            this.gridBand1.Columns.Add(this.bandedGridColumnUsuarioFechamento);
            this.gridBand1.Columns.Add(this.bandedGridColumnDataHoraFechamento);
            this.gridBand1.Columns.Add(this.bandedGridColumnObservacao);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1506;
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
            this.bandedGridColumnCodigo.FieldName = "idcaixas";
            this.bandedGridColumnCodigo.Name = "bandedGridColumnCodigo";
            this.bandedGridColumnCodigo.Visible = true;
            this.bandedGridColumnCodigo.Width = 66;
            // 
            // bandedGridColumnUsuarioCad
            // 
            this.bandedGridColumnUsuarioCad.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnUsuarioCad.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnUsuarioCad.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnUsuarioCad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnUsuarioCad.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnUsuarioCad.Caption = "Usuário Abertura";
            this.bandedGridColumnUsuarioCad.FieldName = "usuariocadastro";
            this.bandedGridColumnUsuarioCad.Name = "bandedGridColumnUsuarioCad";
            this.bandedGridColumnUsuarioCad.Visible = true;
            this.bandedGridColumnUsuarioCad.Width = 129;
            // 
            // bandedGridColumnDataHoraCad
            // 
            this.bandedGridColumnDataHoraCad.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnDataHoraCad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDataHoraCad.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
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
            this.bandedGridColumnDataHoraCad.Width = 100;
            // 
            // bandedGridColumnMaquina
            // 
            this.bandedGridColumnMaquina.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnMaquina.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnMaquina.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnMaquina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnMaquina.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnMaquina.Caption = "Maquina";
            this.bandedGridColumnMaquina.FieldName = "maquina";
            this.bandedGridColumnMaquina.Name = "bandedGridColumnMaquina";
            this.bandedGridColumnMaquina.Visible = true;
            this.bandedGridColumnMaquina.Width = 137;
            // 
            // bandedGridColumnSaldoInicial
            // 
            this.bandedGridColumnSaldoInicial.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnSaldoInicial.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnSaldoInicial.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnSaldoInicial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnSaldoInicial.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnSaldoInicial.Caption = "Saldo Inicial";
            this.bandedGridColumnSaldoInicial.DisplayFormat.FormatString = "c";
            this.bandedGridColumnSaldoInicial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumnSaldoInicial.FieldName = "saldoinicial";
            this.bandedGridColumnSaldoInicial.Name = "bandedGridColumnSaldoInicial";
            this.bandedGridColumnSaldoInicial.Visible = true;
            this.bandedGridColumnSaldoInicial.Width = 96;
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
            this.bandedGridColumnUsuarioEdi.Width = 103;
            // 
            // bandedGridColumnDataHoraEdi
            // 
            this.bandedGridColumnDataHoraEdi.AppearanceCell.Options.UseTextOptions = true;
            this.bandedGridColumnDataHoraEdi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDataHoraEdi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
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
            this.bandedGridColumnDataHoraEdi.Width = 96;
            // 
            // bandedGridColumnSaldoFinal
            // 
            this.bandedGridColumnSaldoFinal.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnSaldoFinal.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnSaldoFinal.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnSaldoFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnSaldoFinal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnSaldoFinal.Caption = "Saldo Final";
            this.bandedGridColumnSaldoFinal.DisplayFormat.FormatString = "c";
            this.bandedGridColumnSaldoFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumnSaldoFinal.FieldName = "saldofinal";
            this.bandedGridColumnSaldoFinal.Name = "bandedGridColumnSaldoFinal";
            this.bandedGridColumnSaldoFinal.Visible = true;
            this.bandedGridColumnSaldoFinal.Width = 98;
            // 
            // bandedGridColumnValorInformado
            // 
            this.bandedGridColumnValorInformado.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnValorInformado.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnValorInformado.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnValorInformado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnValorInformado.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnValorInformado.Caption = "Valor Informado";
            this.bandedGridColumnValorInformado.DisplayFormat.FormatString = "c";
            this.bandedGridColumnValorInformado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumnValorInformado.FieldName = "valorinformado";
            this.bandedGridColumnValorInformado.Name = "bandedGridColumnValorInformado";
            this.bandedGridColumnValorInformado.Visible = true;
            this.bandedGridColumnValorInformado.Width = 99;
            // 
            // bandedGridColumnQuebraCaixa
            // 
            this.bandedGridColumnQuebraCaixa.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnQuebraCaixa.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnQuebraCaixa.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnQuebraCaixa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnQuebraCaixa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnQuebraCaixa.Caption = "Quebra Caixa";
            this.bandedGridColumnQuebraCaixa.DisplayFormat.FormatString = "c";
            this.bandedGridColumnQuebraCaixa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumnQuebraCaixa.FieldName = "quebracaixa";
            this.bandedGridColumnQuebraCaixa.Name = "bandedGridColumnQuebraCaixa";
            this.bandedGridColumnQuebraCaixa.Visible = true;
            this.bandedGridColumnQuebraCaixa.Width = 101;
            // 
            // bandedGridColumnUsuarioFechamento
            // 
            this.bandedGridColumnUsuarioFechamento.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnUsuarioFechamento.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnUsuarioFechamento.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnUsuarioFechamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnUsuarioFechamento.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnUsuarioFechamento.Caption = "Usuário Fechamento";
            this.bandedGridColumnUsuarioFechamento.FieldName = "usuariofechamento";
            this.bandedGridColumnUsuarioFechamento.Name = "bandedGridColumnUsuarioFechamento";
            this.bandedGridColumnUsuarioFechamento.Visible = true;
            this.bandedGridColumnUsuarioFechamento.Width = 106;
            // 
            // bandedGridColumnDataHoraFechamento
            // 
            this.bandedGridColumnDataHoraFechamento.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnDataHoraFechamento.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnDataHoraFechamento.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnDataHoraFechamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnDataHoraFechamento.Caption = "Data/Hora Fechamento";
            this.bandedGridColumnDataHoraFechamento.DisplayFormat.FormatString = "g";
            this.bandedGridColumnDataHoraFechamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.bandedGridColumnDataHoraFechamento.FieldName = "datahorafechamento";
            this.bandedGridColumnDataHoraFechamento.Name = "bandedGridColumnDataHoraFechamento";
            this.bandedGridColumnDataHoraFechamento.Visible = true;
            this.bandedGridColumnDataHoraFechamento.Width = 100;
            // 
            // bandedGridColumnObservacao
            // 
            this.bandedGridColumnObservacao.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumnObservacao.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumnObservacao.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumnObservacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumnObservacao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridColumnObservacao.Caption = "Observaçao";
            this.bandedGridColumnObservacao.FieldName = "observacaocaixa";
            this.bandedGridColumnObservacao.Name = "bandedGridColumnObservacao";
            this.bandedGridColumnObservacao.Visible = true;
            this.bandedGridColumnObservacao.Width = 190;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiVisualizarImprimir,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEditar,
            this.bbiDeletar,
            this.bbiAtualizar,
            this.bbiAbrirCaixa,
            this.bbiTransacoesCaixa,
            this.bbiExportarExcel});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 23;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(972, 164);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiVisualizarImprimir
            // 
            this.bbiVisualizarImprimir.Caption = "Visualizar e Imprimir";
            this.bbiVisualizarImprimir.Id = 14;
            this.bbiVisualizarImprimir.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiVisualizarImprimir.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiVisualizarImprimir.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiVisualizarImprimir.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiVisualizarImprimir.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiVisualizarImprimir.Name = "bbiVisualizarImprimir";
            this.bbiVisualizarImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "Registros : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Abrir Caixa";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiNew.ImageOptions.Image")));
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiNew.ImageOptions.LargeImage")));
            this.bbiNew.Name = "bbiNew";
            // 
            // bbiEditar
            // 
            this.bbiEditar.Caption = "Editar Saldo Inicial";
            this.bbiEditar.Id = 17;
            this.bbiEditar.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEditar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiEditar.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiEditar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bbiDeletar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bbiAtualizar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiAtualizar.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiAtualizar.Name = "bbiAtualizar";
            this.bbiAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAtualizar_ItemClick);
            // 
            // bbiAbrirCaixa
            // 
            this.bbiAbrirCaixa.Caption = "Abrir Caixa";
            this.bbiAbrirCaixa.Id = 20;
            this.bbiAbrirCaixa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiAbrirCaixa.ImageOptions.Image")));
            this.bbiAbrirCaixa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAbrirCaixa.ImageOptions.LargeImage")));
            this.bbiAbrirCaixa.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiAbrirCaixa.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiAbrirCaixa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiAbrirCaixa.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiAbrirCaixa.Name = "bbiAbrirCaixa";
            this.bbiAbrirCaixa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAbrirCaixa_ItemClick);
            // 
            // bbiTransacoesCaixa
            // 
            this.bbiTransacoesCaixa.Caption = "Transações Caixa";
            this.bbiTransacoesCaixa.Id = 21;
            this.bbiTransacoesCaixa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiTransacoesCaixa.ImageOptions.SvgImage")));
            this.bbiTransacoesCaixa.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiTransacoesCaixa.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiTransacoesCaixa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiTransacoesCaixa.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiTransacoesCaixa.Name = "bbiTransacoesCaixa";
            this.bbiTransacoesCaixa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTransacoesCaixa_ItemClick);
            // 
            // bbiExportarExcel
            // 
            this.bbiExportarExcel.Caption = "Exportar Excel";
            this.bbiExportarExcel.Id = 22;
            this.bbiExportarExcel.ImageOptions.Image = global::AdvanceShop.Properties.Resources.Excel_48x48;
            this.bbiExportarExcel.ImageOptions.LargeImage = global::AdvanceShop.Properties.Resources.Excel_48x48;
            this.bbiExportarExcel.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiExportarExcel.ItemAppearance.Hovered.Options.UseFont = true;
            this.bbiExportarExcel.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbiExportarExcel.ItemAppearance.Normal.Options.UseFont = true;
            this.bbiExportarExcel.Name = "bbiExportarExcel";
            this.bbiExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExportarExcel_ItemClick);
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
            this.ribbonPage1.Text = "Caixas";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAbrirCaixa);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEditar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDeletar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAtualizar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiTransacoesCaixa);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tarefas";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiVisualizarImprimir);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiExportarExcel);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Grid";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 575);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(972, 24);
            // 
            // Caixas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 599);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.KeyPreview = true;
            this.Name = "Caixas";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Caixas_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Caixas_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridViewCaixas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiVisualizarImprimir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEditar;
        private DevExpress.XtraBars.BarButtonItem bbiDeletar;
        private DevExpress.XtraBars.BarButtonItem bbiAtualizar;
        private DevExpress.XtraBars.BarButtonItem bbiAbrirCaixa;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridViewCaixas;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnCodigo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnMaquina;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnSaldoInicial;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnSaldoFinal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnValorInformado;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnQuebraCaixa;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnObservacao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnUsuarioFechamento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnUsuarioCad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDataHoraCad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnUsuarioEdi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDataHoraEdi;
        private DevExpress.XtraBars.BarButtonItem bbiTransacoesCaixa;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnDataHoraFechamento;
        private DevExpress.XtraBars.BarButtonItem bbiExportarExcel;
    }
}