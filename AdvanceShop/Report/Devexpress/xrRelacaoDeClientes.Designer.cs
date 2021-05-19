
namespace AdvanceShop.Report.Devexpress
{
    partial class xrRelacaoDeClientes
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lblEmissao = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.Emissao = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.lblFechamentoCaixa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.lblCodigoCaixa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.lblsite = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPag = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine3,
            this.xrLabel2,
            this.lblCodigoCaixa,
            this.xrLine2,
            this.lblFechamentoCaixa,
            this.xrLine1});
            this.TopMargin.HeightF = 118.75F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 1.041667F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.HeightF = 145.8333F;
            this.Detail.Name = "Detail";
            // 
            // lblEmissao
            // 
            this.lblEmissao.LocationFloat = new DevExpress.Utils.PointFloat(757.5467F, 1.041635F);
            this.lblEmissao.Multiline = true;
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblEmissao.SizeF = new System.Drawing.SizeF(64.58331F, 26.0417F);
            this.lblEmissao.StylePriority.UseTextAlignment = false;
            this.lblEmissao.Text = "Emissão:";
            this.lblEmissao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 5.208333F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPag,
            this.lblsite,
            this.xrLabel1,
            this.lblEmissao});
            this.PageFooter.HeightF = 27.08334F;
            this.PageFooter.Name = "PageFooter";
            // 
            // Emissao
            // 
            this.Emissao.AllowNull = true;
            this.Emissao.Description = "Emissao";
            this.Emissao.Name = "Emissao";
            this.Emissao.Type = typeof(System.DateTime);
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Emissao")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(822.13F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(146.87F, 23F);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel1.TextFormatString = "{0:d}";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(969F, 23F);
            // 
            // lblFechamentoCaixa
            // 
            this.lblFechamentoCaixa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechamentoCaixa.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23F);
            this.lblFechamentoCaixa.Multiline = true;
            this.lblFechamentoCaixa.Name = "lblFechamentoCaixa";
            this.lblFechamentoCaixa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblFechamentoCaixa.SizeF = new System.Drawing.SizeF(969F, 26.12498F);
            this.lblFechamentoCaixa.StylePriority.UseFont = false;
            this.lblFechamentoCaixa.StylePriority.UseTextAlignment = false;
            this.lblFechamentoCaixa.Text = "RELAÇÃO DE CLIENTES";
            this.lblFechamentoCaixa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 49.12499F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(969F, 23F);
            // 
            // lblCodigoCaixa
            // 
            this.lblCodigoCaixa.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCaixa.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 72.12499F);
            this.lblCodigoCaixa.Multiline = true;
            this.lblCodigoCaixa.Name = "lblCodigoCaixa";
            this.lblCodigoCaixa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCodigoCaixa.SizeF = new System.Drawing.SizeF(48.91656F, 23F);
            this.lblCodigoCaixa.StylePriority.UseFont = false;
            this.lblCodigoCaixa.StylePriority.UseTextAlignment = false;
            this.lblCodigoCaixa.Text = "Status:";
            this.lblCodigoCaixa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(118.3334F, 72.12499F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(37.45822F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Sexo:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 95.12499F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(969F, 23F);
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
            // lblPag
            // 
            this.lblPag.LocationFloat = new DevExpress.Utils.PointFloat(444.7916F, 0F);
            this.lblPag.Multiline = true;
            this.lblPag.Name = "lblPag";
            this.lblPag.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPag.SizeF = new System.Drawing.SizeF(73.87503F, 23F);
            this.lblPag.StylePriority.UseTextAlignment = false;
            this.lblPag.Text = "Pag: 1/1";
            this.lblPag.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrRelacaoDeClientes
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportFooter,
            this.PageFooter});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 119, 1);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Emissao});
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel lblEmissao;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter Emissao;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel lblFechamentoCaixa;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLabel lblCodigoCaixa;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLabel lblsite;
        private DevExpress.XtraReports.UI.XRLabel lblPag;
    }
}
