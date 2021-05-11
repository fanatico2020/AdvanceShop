using AdvanceShop.Report.Devexpress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using AdvanceShop.Models;
using AdvanceShop.Controllers;
using DevExpress.LookAndFeel;

namespace AdvanceShop.Shared.CustomPrint
{
    public static class FechamentoCaixa
    {
        
        public static void ImprimirFechamentoCaixa(CaixasModel Caixa)
        {
            Report.Devexpress.xrFechamentoCaixa report = new xrFechamentoCaixa();
            //Parametros
            report.Parameters["Emissao"].Value = DateTime.Now;
            report.Parameters["CodigoCaixa"].Value = Caixa.IdCaixas;
            //filter
            //report.FilterString = $"[id_caixa] = {Caixa.IdCaixas}";
            report.CreateDocument();

            report.ShowPreview(UserLookAndFeel.Default);
        }
    }
}
