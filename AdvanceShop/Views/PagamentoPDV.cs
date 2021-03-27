using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Report.Devexpress;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Validation;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
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
    public partial class PagamentoPDV : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        DataHoraModel dataHora = new DataHoraModel();
        VendasModel venda = new VendasModel();
        VendasController vendaController = new VendasController();
        TransacoesCaixaModel transacaoCaixa = new TransacoesCaixaModel();
        TransacoesCaixaController transacaoCaixaController = new TransacoesCaixaController();
        //FormasPagamentoModel formaPagamento = new FormasPagamentoModel();
        ClientesPessoasModel clientePessoa = new ClientesPessoasModel();
        CaixasModel caixa = new CaixasModel();
        List<ItensVendasModel> itensVenda = new List<ItensVendasModel>();
        List<FormasPagamentoModel> formasPagamento = new List<FormasPagamentoModel>();
        decimal Dinheiro, CartaoDeCredito, CartaoDeDebito, LinkPagamento, ValorRestante, ValorAPagar, Troco;
        bool editarformaspagamento = false;
        string VendaOuEditarFormaPagamento = "";
        public PagamentoPDV(VendasModel Venda,ClientesPessoasModel ClientePessoa,TransacoesCaixaModel TransacaoCaixa,List<ItensVendasModel> ItensVenda,CaixasModel Caixa,UsuariosModel UsuarioLogado)//Nova Venda
        {
            InitializeComponent();

            usuarioLogado = UsuarioLogado;
            itensVenda.AddRange(ItensVenda);//Adicoonar lista de itens da tela PDV a lista de itens da tela de pagamento
            
            venda = Venda;
            caixa = Caixa;
            venda.caixas_idcaixas = Caixa.IdCaixas;
            clientePessoa = ClientePessoa;
            venda.clientespessoas_idclientespessoas = clientePessoa.IdClientesPessoas;
            transacaoCaixa = TransacaoCaixa;
            lblValorTotalAPagar.Text = $"{venda.TotalFinal.ToString("C")}";
            lblValorDesconto.Text = $"{venda.Desconto.ToString("C")}";
            VendaOuEditarFormaPagamento = "Venda";

        }
        public PagamentoPDV(TransacoesCaixaModel TransacaoCaixa, UsuariosModel UsuarioLogado)//Editar Formas de pagamento
        {
            InitializeComponent();

            usuarioLogado = UsuarioLogado;
            editarformaspagamento = true;
            transacaoCaixa = TransacaoCaixa;
            lblValorTotalAPagar.Text = $"{transacaoCaixa.Valor.ToString("C")}";
            lblValorDesconto.Text = $"{transacaoCaixaController.ObterValorDescontoVenda(TransacaoCaixa).ToString("C")}";
            cbxImprimirComprovante.Visible = false;
            cbxImprimirNFCe.Visible = false;
            VendaOuEditarFormaPagamento = "Edição de formas de pagamento";

        }
        private void AtualizarGridVendas()
        {
            Views.Vendas view = Application.OpenForms["Vendas"] as Views.Vendas;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void AtualizarGridTransacoesCaixa()
        {
            Views.TransacoesCaixa view = Application.OpenForms["TransacoesCaixa"] as Views.TransacoesCaixa;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void NovaVenda()
        {
            Views.VendaCaixaPDV view = Application.OpenForms["VendaCaixaPDV"] as Views.VendaCaixaPDV;
            if (view != null)
            {
                view.NovaVenda();
            }
        }
        
        private void FinalizarVenda()
        {
           
            if (Troco >= 0 && lblTroco.Text == "Troco" && MessageBoxQuestionYesNo.Show($"Deseja finalizar a {VendaOuEditarFormaPagamento}?") == DialogResult.Yes)
            {
                if (!editarformaspagamento)
                {
                    decimal[] ValoresPagamento = new decimal[]
                {
                    decimal.Parse(txtDinheiro.Text.Replace("R$","")),
                    decimal.Parse(txtCartaoCredito.Text.Replace("R$","")),
                    decimal.Parse(txtCartaoDebito.Text.Replace("R$",""))
                };
                    venda.Troco = Troco;

                    for (int i = 0; i <= ValoresPagamento.Length; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                if (ValoresPagamento[0] > 0)
                                {
                                    formasPagamento.Add(new FormasPagamentoModel()
                                    {
                                        Descricao = "DINHEIRO",
                                        Valor = ValoresPagamento[0]
                                    });
                                }
                                break;
                            case 1:
                                if (ValoresPagamento[1] > 0)
                                {
                                    formasPagamento.Add(new FormasPagamentoModel()
                                    {
                                        Descricao = "CARTÃO CRÉDITO",
                                        Valor = ValoresPagamento[1]
                                    });
                                }
                                break;
                            case 2:
                                if (ValoresPagamento[2] > 0)
                                {
                                    formasPagamento.Add(new FormasPagamentoModel()
                                    {
                                        Descricao = "CARTÃO DÉBITO",
                                        Valor = ValoresPagamento[2]
                                    });
                                }
                                break;
                            default:
                                break;
                        }
                        
                    }
                    
                    for (int x = 0; x < ValoresPagamento.Length; x++)
                    {
                        venda.ValorPago += ValoresPagamento[x];
                    }
                    


                    vendaController.Adicionar(venda, formasPagamento, itensVenda, transacaoCaixa, usuarioLogado);
                    //ImprimirCupom
                    venda.IdVendas = vendaController.ObterUltimoIDVendaInserido();
                    dataHora.datahoracadastro = DateTime.Now;
                    caixa.Maquina = Environment.MachineName;
                    Shared.CustomPrint.CupomNaoFiscal.ImprimirCupom(venda, clientePessoa, usuarioLogado, caixa, dataHora);
                    //Iniciar nova venda no pdv
                    NovaVenda();
                    AtualizarGridVendas();
                    
                }
                else//Editar formas de pagamento
                {
                    
                    AtualizarGridTransacoesCaixa();
                    
                }
                
                //fim
                formasPagamento.Clear();
                venda.ValorPago = 0;
                
                MessageBoxOK.Show($"{VendaOuEditarFormaPagamento} finalizada com sucesso!");
                Close();
            }
            else
            {
                MessageBoxWarning.Show($"Opa ainda falta receber {lblValorTroco.Text}");
            }

            
        }
        
        private void PagamentoPDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void PagamentoPDV_Load(object sender, EventArgs e)
        {
            CalcularValorTroco();
            txtDinheiro.Focus();
            // remove quando implementar link pagamento via mercado pago ou outra api
            txtLinkPagamento.Enabled = false;
            lblLinkPagamento.Enabled = false;
        }
        private void CalcularValorTroco()
        {

            Dinheiro = Convert.ToDecimal(txtDinheiro.Text.Replace("R$", ""));
            CartaoDeCredito = Convert.ToDecimal(txtCartaoCredito.Text.Replace("R$", ""));
            CartaoDeDebito = Convert.ToDecimal(txtCartaoDebito.Text.Replace("R$", ""));
            LinkPagamento = Convert.ToDecimal(txtLinkPagamento.Text.Replace("R$", ""));
            ValorRestante = 0;
            ValorAPagar = venda.TotalFinal;
            Troco = 0;

            ValorRestante = ValorAPagar - Dinheiro - CartaoDeCredito - CartaoDeDebito - LinkPagamento;

            if (ValorRestante <= 0)
            {
                lblValorTroco.Text = "R$0,00";
                Troco = Math.Abs(ValorRestante);
                lblTroco.Text = "Troco";
                lblTroco.ForeColor = Color.Green;
                lblValorTroco.ForeColor = Color.Green;
                lblValorTroco.Text = Troco.ToString("c");
            }
            else
            {
                lblTroco.Text = "Falta receber";
                lblTroco.ForeColor = Color.Blue;
                lblValorTroco.ForeColor = Color.Blue;
                lblValorTroco.Text = ValorRestante.ToString("c");
            }

        }

        private void txtDinheiro_EditValueChanged(object sender, EventArgs e)
        {
            CalcularValorTroco();
        }

        private void txtCartaoCredito_EditValueChanged(object sender, EventArgs e)
        {
            CalcularValorTroco();
        }

        private void txtCartaoDebito_EditValueChanged(object sender, EventArgs e)
        {
            CalcularValorTroco();
        }

        private void PagamentoPDV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                FinalizarVenda();
            }
        }

        private void txtLinkPagamento_EditValueChanged(object sender, EventArgs e)
        {
            CalcularValorTroco();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            
        }

        private void txtCartaoCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCartaoDebito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtLinkPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
