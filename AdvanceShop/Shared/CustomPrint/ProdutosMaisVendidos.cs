﻿using AdvanceShop.Report.Devexpress;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Shared.CustomPrint
{
    public class ProdutosMaisVendidos
    {
        public static void ImprimirProdutosMaisVendidos(DateTime DataInicial, DateTime DataFinal)
        {
            //deixa data final com a hora 23:59:59
            DataFinal = new DateTime(DataFinal.Year, DataFinal.Month, DataFinal.Day, 23, 59, 59);

            Report.Devexpress.xrProdutosMaisVendidos report = new xrProdutosMaisVendidos();
            //Parametros
            report.Parameters["Emissao"].Value = DateTime.Now;
            report.Parameters["PeriodoInicial"].Value = DataInicial;
            report.Parameters["PeriodoFinal"].Value = DataFinal;
            //filter
            //report.FilterString = $"[id_caixa] = {Caixa.IdCaixas}";
            report.CreateDocument();

            report.ShowPreview(UserLookAndFeel.Default);
        }
    }
}
