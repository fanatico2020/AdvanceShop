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
using System.IO;
using System.Net.Mail;
using System.Net;

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
        public static void EnviarFechamentoCaixa(CaixasModel Caixa,UsuariosModel UsuarioCaixa,EmailSistemaModel EmailEnvio)
        {
            Report.Devexpress.xrFechamentoCaixa report = new xrFechamentoCaixa();
            //Parametros
            report.Parameters["Emissao"].Value = DateTime.Now;
            report.Parameters["CodigoCaixa"].Value = Caixa.IdCaixas;
            //filter
            //report.FilterString = $"[id_caixa] = {Caixa.IdCaixas}";
            report.CreateDocument();
            if (!Directory.Exists(@"C:\AdvanceShop\Temp"))
            {
                Directory.CreateDirectory(@"C:\AdvanceShop\Temp");
            }
            string anexo = $@"C:\AdvanceShop\Temp\Caixa-{Caixa.IdCaixas}.pdf";
            report.ExportToPdf(anexo);

            
            //Crie uma nova mensagem e anexe o documento PDF.
            Email.EmailSistema.EnviarEmailComAnexo(EmailEnvio.emailprincipal, EmailEnvio.emailcopia1, EmailEnvio.emailcopia2,
                $"AdvanceShop - Fechamento de Caixa", $"Olá, segue em anexo fechamento do caixa {Caixa.IdCaixas} do usuário {UsuarioCaixa.UsuarioAcesso} fechado pelo usuário {Caixa.UsuarioFechamento} em {Caixa.DataHoraFechamento}.",anexo);


        }
    }
}
