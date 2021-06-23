using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace AdvanceShop.Report.Devexpress
{
    public partial class xrVendasPorVendedor : DevExpress.XtraReports.UI.XtraReport
    {
        public xrVendasPorVendedor()
        {
            InitializeComponent();
        }

        private void sqlDataSource2_CustomizeFilterExpression(object sender, DevExpress.DataAccess.Sql.CustomizeFilterExpressionEventArgs e)
        {
           
        }

        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //FilterString = $"[vendas_idvendas] = {tbcVenda.Value}";
        }

        private void DetailReport_AfterPrint(object sender, EventArgs e)
        {
            
           
            
        }
    }
}
