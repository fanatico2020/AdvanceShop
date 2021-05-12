using AdvanceShop.Report.Devexpress;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Shared.CustomPrint
{
    public class MeiosDePagamento
    {
        public static void ImprimirMeiosPagamentoPorPeriodo(DateTime DataInicial,DateTime DataFinal)
        {
            Report.Devexpress.xrMeiosDePagamento report = new xrMeiosDePagamento();
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
