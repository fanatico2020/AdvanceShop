using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace AdvanceShop.Report.Devexpress
{
    public partial class xrProdutosMaisVendidos : DevExpress.XtraReports.UI.XtraReport
    {
        public xrProdutosMaisVendidos()
        {
            InitializeComponent();
        }

        private void tclPorcLucro_AfterPrint(object sender, EventArgs e)
        {
            //if (Convert.ToDecimal(tclLucro.Text.Replace("R$","")) > 0.00m)
            //{
            //    decimal lucro = Convert.ToDecimal(tclLucro.Text.Replace("R$", ""));
            //    decimal totalvenda = Convert.ToDecimal(tclTotalVenda.Text.Replace("R$", ""));
            //    tclPorcLucro.Text = Convert.ToString((lucro / totalvenda) / 100);
            //}
            //else
            //{
            //    tclPorcLucro.Text = "0";
            //}
        }

        private void tclPorcLucro_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
    }
}
