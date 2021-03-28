using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Shared.Validation;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class TrocaDevolucao : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        VendasModel venda = new VendasModel();
        VendasController vendaController = new VendasController();
        FormasPagamentoController formasPagamento = new FormasPagamentoController();
        ItensVendasController itensVendaController = new ItensVendasController();
        ItensVendasModel itensVenda = new ItensVendasModel();
        public TrocaDevolucao(VendasModel Venda,UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            venda = vendaController.ObterDadosDaVendaPorID(Venda);
            itensVenda.vendas_idvendas = venda.IdVendas;
            lblValoreVenda.Text = $"Valor Venda:{venda.Valor.ToString("C")} - Desconto:{venda.Desconto.ToString("C")} - Total Final:{venda.TotalFinal.ToString("C")}";
            lblValorPagoTroco.Text = $"Valor Pago:{venda.ValorPago.ToString("C")} - Troco:{venda.Troco.ToString("C")}";
            gridControlFormasPagamento.DataSource = formasPagamento.ObterFormasPagamentosPorIDVenda(Venda);
            gridControlItensDevolucao.DataSource = itensVendaController.ObterTodosItensDaVendas(itensVenda);
        }

        private void TrocaDevolucao_Load(object sender, EventArgs e)
        {
            
        }
        private void TrocaDevolucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void TrocaDevolucao_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
