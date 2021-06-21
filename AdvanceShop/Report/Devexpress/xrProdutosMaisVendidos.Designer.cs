
namespace AdvanceShop.Report.Devexpress
{
    partial class xrProdutosMaisVendidos
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xrProdutosMaisVendidos));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.tbProdutosMaisVendidos = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tclCodigoProd = new DevExpress.XtraReports.UI.XRTableCell();
            this.tclDescricaoProduto = new DevExpress.XtraReports.UI.XRTableCell();
            this.tclCodigoBarra = new DevExpress.XtraReports.UI.XRTableCell();
            this.tclQuantidade = new DevExpress.XtraReports.UI.XRTableCell();
            this.tclTotalCusto = new DevExpress.XtraReports.UI.XRTableCell();
            this.tclTotalVenda = new DevExpress.XtraReports.UI.XRTableCell();
            this.tclPorcLucro = new DevExpress.XtraReports.UI.XRTableCell();
            this.tclLucro = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblpPeriodoFinal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblpPeriodoInicial = new DevExpress.XtraReports.UI.XRLabel();
            this.xrtDescricaoColunas = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.lblCodigoCaixa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.lblFechamentoCaixa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblEmissao = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPag = new DevExpress.XtraReports.UI.XRLabel();
            this.lblsite = new DevExpress.XtraReports.UI.XRLabel();
            this.PeriodoInicial = new DevExpress.XtraReports.Parameters.Parameter();
            this.PeriodoFinal = new DevExpress.XtraReports.Parameters.Parameter();
            this.Emissao = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.CalcTotalLucro = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcPorcLucro = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosMaisVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtDescricaoColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 2F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 3F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbProdutosMaisVendidos});
            this.Detail.HeightF = 26.04148F;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("quantidade", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)});
            // 
            // tbProdutosMaisVendidos
            // 
            this.tbProdutosMaisVendidos.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.tbProdutosMaisVendidos.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tbProdutosMaisVendidos.LocationFloat = new DevExpress.Utils.PointFloat(1.589457E-05F, 1.041476F);
            this.tbProdutosMaisVendidos.Name = "tbProdutosMaisVendidos";
            this.tbProdutosMaisVendidos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.tbProdutosMaisVendidos.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.tbProdutosMaisVendidos.SizeF = new System.Drawing.SizeF(1123F, 25F);
            this.tbProdutosMaisVendidos.StylePriority.UseBorderDashStyle = false;
            this.tbProdutosMaisVendidos.StylePriority.UseBorders = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tclCodigoProd,
            this.tclDescricaoProduto,
            this.tclCodigoBarra,
            this.tclQuantidade,
            this.tclTotalCusto,
            this.tclTotalVenda,
            this.tclPorcLucro,
            this.tclLucro});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // tclCodigoProd
            // 
            this.tclCodigoProd.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[idprodutos]")});
            this.tclCodigoProd.Multiline = true;
            this.tclCodigoProd.Name = "tclCodigoProd";
            this.tclCodigoProd.StylePriority.UseTextAlignment = false;
            this.tclCodigoProd.Text = "tclCodigoProd";
            this.tclCodigoProd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tclCodigoProd.Weight = 0.82291648864746092D;
            // 
            // tclDescricaoProduto
            // 
            this.tclDescricaoProduto.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[descricaoproduto]")});
            this.tclDescricaoProduto.Multiline = true;
            this.tclDescricaoProduto.Name = "tclDescricaoProduto";
            this.tclDescricaoProduto.StylePriority.UseTextAlignment = false;
            this.tclDescricaoProduto.Text = "tclDescricaoProduto";
            this.tclDescricaoProduto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tclDescricaoProduto.Weight = 3.8333329010009765D;
            // 
            // tclCodigoBarra
            // 
            this.tclCodigoBarra.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[codigobarra]")});
            this.tclCodigoBarra.Multiline = true;
            this.tclCodigoBarra.Name = "tclCodigoBarra";
            this.tclCodigoBarra.StylePriority.UseTextAlignment = false;
            this.tclCodigoBarra.Text = "tclCodigoBarra";
            this.tclCodigoBarra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tclCodigoBarra.Weight = 2.3437506103515626D;
            // 
            // tclQuantidade
            // 
            this.tclQuantidade.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[quantidade]")});
            this.tclQuantidade.Multiline = true;
            this.tclQuantidade.Name = "tclQuantidade";
            this.tclQuantidade.StylePriority.UseTextAlignment = false;
            this.tclQuantidade.Text = "tclQuantidade";
            this.tclQuantidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tclQuantidade.Weight = 0.54166625976562521D;
            // 
            // tclTotalCusto
            // 
            this.tclTotalCusto.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[totalcusto]")});
            this.tclTotalCusto.Multiline = true;
            this.tclTotalCusto.Name = "tclTotalCusto";
            this.tclTotalCusto.StylePriority.UseTextAlignment = false;
            this.tclTotalCusto.Text = "tclTotalCusto";
            this.tclTotalCusto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tclTotalCusto.TextFormatString = "{0:c}";
            this.tclTotalCusto.Weight = 1.1700164794921868D;
            // 
            // tclTotalVenda
            // 
            this.tclTotalVenda.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[totalvenda]")});
            this.tclTotalVenda.Multiline = true;
            this.tclTotalVenda.Name = "tclTotalVenda";
            this.tclTotalVenda.StylePriority.UseTextAlignment = false;
            this.tclTotalVenda.Text = "tclTotalVenda";
            this.tclTotalVenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tclTotalVenda.TextFormatString = "{0:c}";
            this.tclTotalVenda.Weight = 1.1491839599609377D;
            // 
            // tclPorcLucro
            // 
            this.tclPorcLucro.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CalcPorcLucro]")});
            this.tclPorcLucro.Multiline = true;
            this.tclPorcLucro.Name = "tclPorcLucro";
            this.tclPorcLucro.Scripts.OnAfterPrint = "tclPorcLucro_AfterPrint";
            this.tclPorcLucro.StylePriority.UseTextAlignment = false;
            this.tclPorcLucro.Text = "tclPorcLucro";
            this.tclPorcLucro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tclPorcLucro.TextFormatString = "{0:0.00%}";
            this.tclPorcLucro.Weight = 0.58705078124999943D;
            this.tclPorcLucro.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.tclPorcLucro_BeforePrint);
            this.tclPorcLucro.AfterPrint += new System.EventHandler(this.tclPorcLucro_AfterPrint);
            // 
            // tclLucro
            // 
            this.tclLucro.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CalcTotalLucro]")});
            this.tclLucro.Multiline = true;
            this.tclLucro.Name = "tclLucro";
            this.tclLucro.StylePriority.UseTextAlignment = false;
            this.tclLucro.Text = "tclLucro";
            this.tclLucro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tclLucro.TextFormatString = "{0:c}";
            this.tclLucro.Weight = 0.78208374023437521D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblpPeriodoFinal,
            this.xrLabel2,
            this.lblpPeriodoInicial,
            this.xrtDescricaoColunas,
            this.xrLine3,
            this.lblCodigoCaixa,
            this.xrLine2,
            this.lblFechamentoCaixa,
            this.xrLine1});
            this.ReportHeader.HeightF = 143.9167F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblpPeriodoFinal
            // 
            this.lblpPeriodoFinal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?PeriodoFinal")});
            this.lblpPeriodoFinal.LocationFloat = new DevExpress.Utils.PointFloat(488.5417F, 72.12498F);
            this.lblpPeriodoFinal.Multiline = true;
            this.lblpPeriodoFinal.Name = "lblpPeriodoFinal";
            this.lblpPeriodoFinal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblpPeriodoFinal.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblpPeriodoFinal.StylePriority.UseTextAlignment = false;
            this.lblpPeriodoFinal.Text = "lblpPeriodoFinal";
            this.lblpPeriodoFinal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblpPeriodoFinal.TextFormatString = "{0:d}";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(468.7501F, 72.12499F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(19.7916F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "a";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblpPeriodoInicial
            // 
            this.lblpPeriodoInicial.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?PeriodoInicial")});
            this.lblpPeriodoInicial.LocationFloat = new DevExpress.Utils.PointFloat(368.7501F, 72.12498F);
            this.lblpPeriodoInicial.Multiline = true;
            this.lblpPeriodoInicial.Name = "lblpPeriodoInicial";
            this.lblpPeriodoInicial.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblpPeriodoInicial.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblpPeriodoInicial.StylePriority.UseTextAlignment = false;
            this.lblpPeriodoInicial.Text = "lblpPeriodoInicial";
            this.lblpPeriodoInicial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblpPeriodoInicial.TextFormatString = "{0:d}";
            // 
            // xrtDescricaoColunas
            // 
            this.xrtDescricaoColunas.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtDescricaoColunas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrtDescricaoColunas.LocationFloat = new DevExpress.Utils.PointFloat(0F, 118.125F);
            this.xrtDescricaoColunas.Name = "xrtDescricaoColunas";
            this.xrtDescricaoColunas.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrtDescricaoColunas.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrtDescricaoColunas.SizeF = new System.Drawing.SizeF(1123F, 25F);
            this.xrtDescricaoColunas.StylePriority.UseBorders = false;
            this.xrtDescricaoColunas.StylePriority.UseFont = false;
            this.xrtDescricaoColunas.StylePriority.UseTextAlignment = false;
            this.xrtDescricaoColunas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell6,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "Código";
            this.xrTableCell1.Weight = 0.82291664123535158D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "Descrição";
            this.xrTableCell2.Weight = 3.8333333587646483D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "Código Barra";
            this.xrTableCell3.Weight = 2.3437498474121097D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "Qtd";
            this.xrTableCell6.Weight = 0.54166687011718728D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Total Custo";
            this.xrTableCell4.Weight = 1.1700165557861324D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Total Venda";
            this.xrTableCell5.Weight = 1.14918342590332D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "% Lucro";
            this.xrTableCell7.Weight = 0.58705078125000043D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Total Lucro";
            this.xrTableCell8.Weight = 0.78208129882812494D;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 95.12499F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(1123F, 23F);
            // 
            // lblCodigoCaixa
            // 
            this.lblCodigoCaixa.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCaixa.LocationFloat = new DevExpress.Utils.PointFloat(1.589457E-05F, 72.12499F);
            this.lblCodigoCaixa.Multiline = true;
            this.lblCodigoCaixa.Name = "lblCodigoCaixa";
            this.lblCodigoCaixa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCodigoCaixa.SizeF = new System.Drawing.SizeF(368.75F, 23F);
            this.lblCodigoCaixa.StylePriority.UseFont = false;
            this.lblCodigoCaixa.StylePriority.UseTextAlignment = false;
            this.lblCodigoCaixa.Text = "Todos os produtos estão ordenados por quantidade, no período:";
            this.lblCodigoCaixa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 49.12499F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1123F, 23F);
            // 
            // lblFechamentoCaixa
            // 
            this.lblFechamentoCaixa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechamentoCaixa.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23F);
            this.lblFechamentoCaixa.Multiline = true;
            this.lblFechamentoCaixa.Name = "lblFechamentoCaixa";
            this.lblFechamentoCaixa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFechamentoCaixa.SizeF = new System.Drawing.SizeF(1123F, 26.12498F);
            this.lblFechamentoCaixa.StylePriority.UseFont = false;
            this.lblFechamentoCaixa.StylePriority.UseTextAlignment = false;
            this.lblFechamentoCaixa.Text = "PRODUTOS MAIS VENDIDOS";
            this.lblFechamentoCaixa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1123F, 23F);
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.ReportFooter.HeightF = 26.91717F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1123F, 25F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.Text = "Total.:";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell11.Weight = 6.9999998474121092D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([quantidade])")});
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell12.Summary = xrSummary1;
            this.xrTableCell12.Text = "Qtd";
            this.xrTableCell12.Weight = 0.54166687011718728D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([totalcusto])")});
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell13.Summary = xrSummary2;
            this.xrTableCell13.Text = "Total Custo";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell13.TextFormatString = "{0:c}";
            this.xrTableCell13.Weight = 1.1700165557861324D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([totalvenda])")});
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell14.Summary = xrSummary3;
            this.xrTableCell14.Text = "Total Venda";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell14.TextFormatString = "{0:c}";
            this.xrTableCell14.Weight = 1.14918342590332D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Multiline = true;
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Weight = 0.58705078125000043D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([CalcTotalLucro])")});
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell16.Summary = xrSummary4;
            this.xrTableCell16.Text = "Total Lucro";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell16.TextFormatString = "{0:c}";
            this.xrTableCell16.Weight = 0.782083740234375D;
            // 
            // lblEmissao
            // 
            this.lblEmissao.LocationFloat = new DevExpress.Utils.PointFloat(911.5468F, 0F);
            this.lblEmissao.Multiline = true;
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblEmissao.SizeF = new System.Drawing.SizeF(64.58331F, 23F);
            this.lblEmissao.StylePriority.UseTextAlignment = false;
            this.lblEmissao.Text = "Emissão:";
            this.lblEmissao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblPag
            // 
            this.lblPag.LocationFloat = new DevExpress.Utils.PointFloat(563.5416F, 0F);
            this.lblPag.Multiline = true;
            this.lblPag.Name = "lblPag";
            this.lblPag.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPag.SizeF = new System.Drawing.SizeF(35.33337F, 23F);
            this.lblPag.StylePriority.UseTextAlignment = false;
            this.lblPag.Text = "Pag:";
            this.lblPag.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblsite
            // 
            this.lblsite.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsite.ForeColor = System.Drawing.Color.Blue;
            this.lblsite.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblsite.Multiline = true;
            this.lblsite.Name = "lblsite";
            this.lblsite.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblsite.SizeF = new System.Drawing.SizeF(218.7501F, 23F);
            this.lblsite.StylePriority.UseFont = false;
            this.lblsite.StylePriority.UseForeColor = false;
            this.lblsite.StylePriority.UseTextAlignment = false;
            this.lblsite.Text = "www.advanceshopsistema.com.br";
            this.lblsite.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PeriodoInicial
            // 
            this.PeriodoInicial.AllowNull = true;
            this.PeriodoInicial.Description = "PeriodoInicial";
            this.PeriodoInicial.Name = "PeriodoInicial";
            this.PeriodoInicial.Type = typeof(System.DateTime);
            this.PeriodoInicial.Visible = false;
            // 
            // PeriodoFinal
            // 
            this.PeriodoFinal.AllowNull = true;
            this.PeriodoFinal.Description = "PeriodoFinal";
            this.PeriodoFinal.Name = "PeriodoFinal";
            this.PeriodoFinal.Type = typeof(System.DateTime);
            this.PeriodoFinal.Visible = false;
            // 
            // Emissao
            // 
            this.Emissao.AllowNull = true;
            this.Emissao.Description = "Emissao";
            this.Emissao.Name = "Emissao";
            this.Emissao.Type = typeof(System.DateTime);
            this.Emissao.Visible = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Emissao")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(976.1301F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(146.87F, 23F);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel1.TextFormatString = "{0:d}";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_advanceshopdb_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "advanceshopdb_RelatorioProdutosMaisVendidos";
            queryParameter1.Name = "@DataInicial";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?PeriodoInicial", typeof(System.DateTime));
            queryParameter2.Name = "@DataFinal";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("?PeriodoFinal", typeof(System.DateTime));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.StoredProcName = "advanceshopdb.RelatorioProdutosMaisVendidos";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.lblEmissao,
            this.xrLabel1,
            this.lblsite,
            this.lblPag});
            this.PageFooter.HeightF = 27.08398F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(600F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(48.95831F, 22.99999F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // CalcTotalLucro
            // 
            this.CalcTotalLucro.DataMember = "advanceshopdb_RelatorioProdutosMaisVendidos";
            this.CalcTotalLucro.Expression = "[totalvenda]-[totalcusto]";
            this.CalcTotalLucro.Name = "CalcTotalLucro";
            // 
            // CalcPorcLucro
            // 
            this.CalcPorcLucro.DataMember = "advanceshopdb_RelatorioProdutosMaisVendidos";
            this.CalcPorcLucro.Expression = "[CalcTotalLucro]/[totalvenda]";
            this.CalcPorcLucro.Name = "CalcPorcLucro";
            // 
            // xrProdutosMaisVendidos
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter,
            this.PageFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.CalcTotalLucro,
            this.CalcPorcLucro});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "advanceshopdb_RelatorioProdutosMaisVendidos";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(23, 23, 2, 3);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.PeriodoInicial,
            this.PeriodoFinal,
            this.Emissao});
            this.ScriptsSource = "\r\nprivate void tclPorcLucro_AfterPrint(object sender, System.EventArgs e) {\r\n\r\n}\r" +
    "\n";
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.tbProdutosMaisVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtDescricaoColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel lblFechamentoCaixa;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLabel lblCodigoCaixa;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRTable xrtDescricaoColunas;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRLabel lblsite;
        private DevExpress.XtraReports.UI.XRLabel lblPag;
        private DevExpress.XtraReports.UI.XRLabel lblEmissao;
        private DevExpress.XtraReports.UI.XRLabel lblpPeriodoFinal;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel lblpPeriodoInicial;
        private DevExpress.XtraReports.Parameters.Parameter PeriodoInicial;
        private DevExpress.XtraReports.Parameters.Parameter PeriodoFinal;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter Emissao;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRTable tbProdutosMaisVendidos;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tclCodigoProd;
        private DevExpress.XtraReports.UI.XRTableCell tclDescricaoProduto;
        private DevExpress.XtraReports.UI.XRTableCell tclCodigoBarra;
        private DevExpress.XtraReports.UI.XRTableCell tclQuantidade;
        private DevExpress.XtraReports.UI.XRTableCell tclTotalCusto;
        private DevExpress.XtraReports.UI.XRTableCell tclTotalVenda;
        private DevExpress.XtraReports.UI.XRTableCell tclPorcLucro;
        private DevExpress.XtraReports.UI.XRTableCell tclLucro;
        private DevExpress.XtraReports.UI.CalculatedField CalcTotalLucro;
        private DevExpress.XtraReports.UI.CalculatedField CalcPorcLucro;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
    }
}
