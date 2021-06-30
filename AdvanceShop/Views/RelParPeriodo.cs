using AdvanceShop.Shared.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Views
{
    public partial class RelParPeriodo : DevExpress.XtraEditors.XtraForm
    {
        string relatorio;
        public RelParPeriodo(string Titulo,string Relatorio)
        {
            InitializeComponent();
            Text = Titulo;
            relatorio = Relatorio;
        }

        private void RelParPeriodo_Load(object sender, EventArgs e)
        {

        }
        private void GerarRelatorio(string Relatorio)
        {
            switch (Relatorio)
            {
                case "RelatorioMeiosDePagamento":
                    Shared.CustomPrint.MeiosDePagamento.ImprimirMeiosPagamentoPorPeriodo(txtPeriodoInicial.DateTime,txtPeriodoFinal.DateTime);
                    Close();
                    break;
                case "RelatorioProdutosMaisVendidos":
                    Shared.CustomPrint.ProdutosMaisVendidos.ImprimirProdutosMaisVendidos(txtPeriodoInicial.DateTime, txtPeriodoFinal.DateTime);
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            GerarRelatorio(relatorio);
        }

        private void RelParPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }
    }
}
