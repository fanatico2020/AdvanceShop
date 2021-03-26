using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using AdvanceShop.Report.Devexpress;
using DevExpress.LookAndFeel;
using System.Drawing.Printing;
using AdvanceShop.Models;

namespace AdvanceShop.Shared.CustomPrint
{
    public static  class CupomNaoFiscal
    {
        //private class ItensVenda
        //{
        //    public int CodigoItem { get; set; }
        //    public string DescricaoProduto { get; set; }
        //    public int Quantidade { get; set; }
        //    public decimal VlrUnit { get; set; }
        //    public decimal Subtotal { get; set; }
        //}
        //private class FormasPagamento
        //{
        //    public string DescricaoPagamento { get; set; }
        //    public decimal Valor { get; set; }
        //}
        public static void ImprimirCupom(VendasModel Venda, ClientesPessoasModel Cliente, UsuariosModel Usuario, CaixasModel Caixa)
        {



            Report.Devexpress.xrCupomNaoFiscal report = new xrCupomNaoFiscal();


            report.Parameters["NumeroVenda"].Value = Venda.IdVendas;
            report.Parameters["DataHoraVenda"].Value = DateTime.Now;
            //Dados cliente da venda
            report.Parameters["ClienteVenda"].Value = Cliente.NomeClientePessoa;
            report.Parameters["CPFCNPJClienteVenda"].Value = Cliente.CPFCNPJ;
            report.Parameters["TelefonesClienteVenda"].Value = $"{Cliente.Contato1}  {Cliente.Contato2}";
            
            //Valores venda
            report.Parameters["ValorTotalVenda"].Value = Venda.Valor;
            report.Parameters["DescontoVenda"].Value = Venda.Desconto;
            report.Parameters["TotalAPagar"].Value = Venda.TotalFinal;
            report.Parameters["Troco"].Value = Venda.Troco;
            

            //Maquina e Vendedor
            report.Parameters["Maquina"].Value = Environment.MachineName;
            report.Parameters["UsuarioCaixa"].Value = $"{Usuario.UsuarioAcesso} - CAIXA {Caixa.IdCaixas}";
            //report.PrintDialog();


            //report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            //report.Landscape = true;
            report.RollPaper = true;
            //report.ReportUnit = ReportUnit.HundredthsOfAnInch;
            report.FilterString = $"[vendas_idvendas] = {Venda.IdVendas}";
            report.CreateDocument();
            report.ShowPreview(UserLookAndFeel.Default);//para teste
            //report.PrintDialog();//mostrar dialog para selecionar a impressora para impressão
        }

        
    }
}
