using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using AdvanceShop.Shared.Validation;
using AdvanceShop.Models;
using AdvanceShop.Controllers;
using AdvanceShop.Shared.CustomMessageBox;
using DevExpress.Utils.Menu;
using AdvanceShop.JsonModels.GerenciaNet;

namespace AdvanceShop.Views
{
    public partial class TransacoesCaixa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //api - GerenciaNet
        ApiGerenciaNetModel apiGerenciaNet = new ApiGerenciaNetModel();
        ApiGerenciaNetController apiGerenciaNetController = new ApiGerenciaNetController();
        GerenciaNet gerenciaNet = new GerenciaNet();
        //--
        UsuariosModel usuarioLogado = new UsuariosModel();
        TransacoesCaixaModel transacaoCaixa = new TransacoesCaixaModel();
        TransacoesCaixaController transacaoCaixaController = new TransacoesCaixaController();
        CaixasModel caixa = new CaixasModel();
        CaixasController caixaController = new CaixasController();
        FormasPagamentoModel formaPagamento = new FormasPagamentoModel();
        FormasPagamentoController formaPagamentoController = new FormasPagamentoController();
        DataHoraModel dataHora = new DataHoraModel();
        public TransacoesCaixa(UsuariosModel UsuarioLogado,CaixasModel Caixa,DataHoraModel DataHora)
        {
            InitializeComponent();
            apiGerenciaNet = apiGerenciaNetController.ObterConfiguracoesApiGerenciaNet();
            usuarioLogado = UsuarioLogado;
            caixa = Caixa;
            transacaoCaixa.caixas_idcaixas = caixa.IdCaixas;
            dataHora.usuariocadastro = DataHora.usuariocadastro;
            Text = Text + $" Caixa Código {caixa.IdCaixas} usuário do caixa {dataHora.usuariocadastro}";
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public void AtualizarGrid()
        {
            SomarTotalSaldoCaixa();

            DataTable dataSource = transacaoCaixaController.ObterTodosTransacoes(transacaoCaixa);
            gridControl.DataSource = dataSource;
            gridControl.Refresh();
            bsiRecordsCount.Caption = "Registros : " + dataSource.Rows.Count;

            //atualizar status pagamento
            //int id = Convert.ToInt32(advBandedGridViewTransacoesCaixa.GetRowCellValue(advBandedGridViewTransacoesCaixa.GetSelectedRows()[0], advBandedGridViewTransacoesCaixa.Columns[12]));
            foreach (DataRow row in dataSource.Rows)
            {
                if (row[9] != DBNull.Value)
                {
                    int charge_id = int.Parse(row[9].ToString());
                    gerenciaNet = apiGerenciaNetController.RetornaInformacaoSobreTransacao(apiGerenciaNet, charge_id);
                    transacaoCaixa.charge_id = gerenciaNet.data.charge_id;
                    switch (gerenciaNet.data.status)
                    {
                        case "waiting"://Forma de pagamento selecionada, aguardando a confirmação do pagamento. O termo "waiting" equivale a "aguardando".
                            transacaoCaixa.Status = 0;
                            break;
                        case "paid": //Pagamento confirmado. O termo "paid" equivale a "pago".
                            transacaoCaixa.Status = 1;
                            break;
                        case "unpaid": //Não foi possível confirmar o pagamento da cobrança. O termo "unpaid" equivale a "não pago".
                            transacaoCaixa.Status = 2;
                            break;
                        case "refunded"://Pagamento devolvido pelo lojista ou pelo intermediador Gerencianet. O termo "refunded" equivale a "devolvido".
                            transacaoCaixa.Status = 3;
                            break;
                        case "contested"://Pagamento em processo de contestação. O termo "contested" equivale a "contestado".
                            transacaoCaixa.Status = 4;
                            break;
                        case "canceled": //Cobrança cancelada pelo vendedor ou pelo pagador. O termo "canceled" equivale a "cancelado".
                            transacaoCaixa.Status = 5;
                            break;
                        case "settled"://Cobrança foi confirmada manualmente. O termo "settled" equivale a "marcar como pago".
                            transacaoCaixa.Status = 6;
                            break;
                        case "link"://Status aplicável a Link de Pagamento. Este status indica que trata-se de uma cobrança que está associada a um link de pagamento. O termo "link" equivale a "link".
                            transacaoCaixa.Status = 7;
                            break;
                        case "expired"://Um link de pagamento receberá este status ao atingir a data de vencimento. O termo "expired" equivale a "expirado".
                            transacaoCaixa.Status = 8;
                            break;
                        default:
                            break;

                    }
                    transacaoCaixaController.EditarStatusGerenciaNet(transacaoCaixa);
                }
            }
            
        }
        private void SomarTotalSaldoCaixa()
        {
            //Entradas
            decimal saldoinicial, saldovendasemdinheiro, saldovendasemcartaocredito, saldovendascartaodebito, saldosuplemento,saldoentradas,saldovendaslinkpagamento;

            saldoinicial = formaPagamentoController.SomarTotalDinheiroAberturaCaixa(transacaoCaixa);
            saldovendasemdinheiro = formaPagamentoController.SomarTotalDinheiroCaixa(transacaoCaixa);
            saldovendasemcartaocredito = formaPagamentoController.SomarTotalCartaoCreditoCaixa(transacaoCaixa);
            saldovendascartaodebito = formaPagamentoController.SomarTotalCartaoDebitoCaixa(transacaoCaixa);
            saldosuplemento = formaPagamentoController.SomarTotalDinheiroSuplementoCaixa(transacaoCaixa);
            saldovendaslinkpagamento = formaPagamentoController.SomarTotalLinkPagamentoCaixa(transacaoCaixa);
            saldoentradas = saldoinicial + saldovendasemdinheiro + saldovendasemcartaocredito + saldovendascartaodebito + saldosuplemento + saldovendaslinkpagamento;

            txtSaldoInicial.Text = Convert.ToString(saldoinicial);
            txtDinheiro.Text = Convert.ToString(saldovendasemdinheiro);
            txtCartaoCredito.Text = Convert.ToString(saldovendasemcartaocredito);
            txtCartaoDebito.Text = Convert.ToString(saldovendascartaodebito);
            txtLinkPagamento.Text = Convert.ToString(saldovendaslinkpagamento);
            txtTotalSuplemento.Text = Convert.ToString(saldosuplemento);
            txtSaldoEntradas.Text = Convert.ToString(saldoentradas);

            //Saidas
            decimal saldosangria,saldosaidas;

            saldosangria = formaPagamentoController.SomarTotalDinheiroSangriaCaixa(transacaoCaixa);
            saldosaidas = saldosangria;

            txtTotalSangria.Text = Convert.ToString(saldosangria);
            txtSaldoSaidas.Text = Convert.ToString(saldosaidas);

            //Saldo caixa
            txtSaldoCaixa.Text = Convert.ToString(saldoentradas - saldosaidas);

            //Saldo em dinheiro, para não permitir retirar do caixa mais do que tem em dinheiro
            transacaoCaixa.SaldoEmDinheiro = (saldoinicial + saldovendasemdinheiro + saldosuplemento) - saldosaidas;
        }
        
        private void TranscoesCaixa_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        private void FecharCaixa()
        {
            if(caixa.status == 0)
            {
                AtualizarGrid();
                caixa.SaldoFinal = Convert.ToDecimal(txtSaldoCaixa.Text.Replace("R$", ""));
                Views.FecharCaixa FormFecharCaixa = new FecharCaixa(usuarioLogado, dataHora, caixa);
                FormFecharCaixa.ShowDialog();
            }
            else
            {
                MessageBoxWarning.Show($"Opa esse caixa já foi fechado pelo usuário {caixa.UsuarioFechamento} no dia {caixa.DataHoraFechamento}!");
            }
            
        }
        private void EditarTransacao()//Editar forma de pagamento
        {
            MessageBoxOK.Show("Ainda em desenvolvimento!");
            /*
            transacaoCaixa.DescricaoTransacao = advBandedGridViewTransacoesCaixa.GetRowCellValue(advBandedGridViewTransacoesCaixa.GetSelectedRows()[0], advBandedGridViewTransacoesCaixa.Columns[2]).ToString();
            if (transacaoCaixa.DescricaoTransacao != "Abertura Caixa" && transacaoCaixa.DescricaoTransacao != "Suplemento, Dinheiro adicionado ao caixa" &&
                transacaoCaixa.DescricaoTransacao != "Sangria, Dinheiro retirado do caixa")
            {
                transacaoCaixa.vendas_idvendas = Convert.ToInt32(advBandedGridViewTransacoesCaixa.GetRowCellValue(advBandedGridViewTransacoesCaixa.GetSelectedRows()[0], advBandedGridViewTransacoesCaixa.Columns[11]));
                transacaoCaixa.Valor = Convert.ToDecimal(advBandedGridViewTransacoesCaixa.GetRowCellValue(advBandedGridViewTransacoesCaixa.GetSelectedRows()[0], advBandedGridViewTransacoesCaixa.Columns[3]));
                Views.PagamentoPDV FormEditarFormasPagamento = new PagamentoPDV(transacaoCaixa, usuarioLogado);
                FormEditarFormasPagamento.ShowDialog();
            }
            else
            {
                MessageBoxWarning.Show("Opa só e possível editar formas de pagamento das vendas!");
            }
            */
        }
        private void DeletarTransacao()
        {
            transacaoCaixa.IdTransacoesCaixa = Convert.ToInt32(advBandedGridViewTransacoesCaixa.GetRowCellValue(advBandedGridViewTransacoesCaixa.GetSelectedRows()[0], advBandedGridViewTransacoesCaixa.Columns[0]));
            transacaoCaixa.DescricaoTransacao = advBandedGridViewTransacoesCaixa.GetRowCellValue(advBandedGridViewTransacoesCaixa.GetSelectedRows()[0], advBandedGridViewTransacoesCaixa.Columns[2]).ToString();
            
            if(transacaoCaixa.DescricaoTransacao == "Abertura Caixa")
            {
                MessageBoxWarning.Show("Opa a Abertura do caixa não pode ser deletada, você pode editar o valor da mesma na tela dos caixas!");
            }
            else if(transacaoCaixa.DescricaoTransacao.Substring(0,5) == "VENDA")
            {
                MessageBoxWarning.Show("Opa para deletar uma transação referente a uma venda, vá a tela vendas e delete a venda, assim a transação e deletada junto!");
            }
            else if(advBandedGridViewTransacoesCaixa.SelectedRowsCount == 1 && MessageBoxQuestionYesNo.Show("Confirmar deletar registro selecionado?") == DialogResult.Yes)
            {
                transacaoCaixaController.Deletar(transacaoCaixa);
                MessageBoxOK.Show("Deletado com sucesso!");
                AtualizarGrid();
            }
        }
        private void SuplementoSangria(int Tipo)
        {
            if(caixa.status == 0)
            {
                transacaoCaixa.Tipo = Tipo;
                Views.SuplementoSangria FormSuplementoSangria = new SuplementoSangria(transacaoCaixa, usuarioLogado);
                FormSuplementoSangria.ShowDialog();
            }
            else
            {
                MessageBoxWarning.Show($"Opa esse caixa já foi fechado pelo usuário {caixa.UsuarioFechamento} no dia {caixa.DataHoraFechamento}, não tem como adicionar ou retirar dinheiro de um caixa fechado!");
            }
            
        }
        private void LinkPagamento()
        {
            string url = advBandedGridViewTransacoesCaixa.GetRowCellValue(advBandedGridViewTransacoesCaixa.GetSelectedRows()[0], advBandedGridViewTransacoesCaixa.Columns[13]).ToString();
            if (!string.IsNullOrEmpty(url))
            {
                System.Diagnostics.Process.Start(url);
            }
            else
            {
                MessageBoxWarning.Show("Meio de pagamento dessa transação não foi LINK PAGAMENTO!");
            }
        }
        private void bbiFecharCaixa_ItemClick(object sender, ItemClickEventArgs e)
        {
            FecharCaixa();
        }

        private void bbiEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditarTransacao();
        }

        private void bbiDeletar_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeletarTransacao();
        }

        private void bbiAtualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            AtualizarGrid();
        }

        private void bbiAdicionarDinheiro_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            SuplementoSangria(1);
        }

        private void bbiRetirarDinheiro_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            SuplementoSangria(0);
        }

        private void TranscoesCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void advBandedGridViewTransacoesCaixa_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "tipo")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Saída";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Entrada";
            }
            if (e.Column.FieldName == "status")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Aguardando";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Efetuado";
                if (Convert.ToInt32(e.Value) == 2) e.DisplayText = "2 - Não Pago";
                if (Convert.ToInt32(e.Value) == 3) e.DisplayText = "3 - Devolvido";
                if (Convert.ToInt32(e.Value) == 4) e.DisplayText = "4 - Contestado";
                if (Convert.ToInt32(e.Value) == 5) e.DisplayText = "5 - Cancelado";
                if (Convert.ToInt32(e.Value) == 6) e.DisplayText = "6 - Efetuado Manualmente";
                if (Convert.ToInt32(e.Value) == 7) e.DisplayText = "7 - Link";
                if (Convert.ToInt32(e.Value) == 8) e.DisplayText = "8 - Expirado";
            }

        }

        private void advBandedGridViewTransacoesCaixa_DoubleClick(object sender, EventArgs e)
        {
            EditarTransacao();
        }

        private void advBandedGridViewTransacoesCaixa_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (advBandedGridViewTransacoesCaixa.SelectedRowsCount == 1)
            {
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                {
                    DXMenuItem item1 = new DXMenuItem("Fechar Caixa");
                    DXMenuItem item2 = new DXMenuItem("Editar Formas Pagamento");
                    DXMenuItem item3 = new DXMenuItem("Deletar");
                    DXMenuItem item4 = new DXMenuItem("Atualizar Grid");
                    DXMenuItem item5 = new DXMenuItem("Adicionar Dinheiro");
                    DXMenuItem item6 = new DXMenuItem("Retirar Dinheiro");
                    DXMenuItem item7 = new DXMenuItem("Contador Dinheiro");
                    DXMenuItem item8 = new DXMenuItem("Link Pagamento");

                    item1.Click += (o, args) =>
                    {
                        FecharCaixa();
                    };
                    item2.Click += (o, args) =>
                    {
                        EditarTransacao();
                    };
                    item3.Click += (o, args) =>
                    {
                        DeletarTransacao();
                    };
                    item4.Click += (o, args) =>
                    {
                        AtualizarGrid();
                    };
                    item5.Click += (o, args) =>
                    {
                        SuplementoSangria(1);
                    };
                    item6.Click += (o, args) =>
                    {
                        SuplementoSangria(0);
                    };
                    item7.Click += (o, args) =>
                    {
                        ContadorDinheiro();
                    };
                    item8.Click += (o, args) =>
                    {
                        LinkPagamento();
                    };

                    e.Menu.Items.Add(item1);
                    e.Menu.Items.Add(item2);
                    e.Menu.Items.Add(item3);
                    e.Menu.Items.Add(item4);
                    e.Menu.Items.Add(item5);
                    e.Menu.Items.Add(item6);
                    e.Menu.Items.Add(item7);
                    e.Menu.Items.Add(item8);
                }
            }
        }

        private void advBandedGridViewTransacoesCaixa_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void advBandedGridViewTransacoesCaixa_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            
            formaPagamento.transacoescaixa_idtransacoescaixa = Convert.ToInt32(advBandedGridViewTransacoesCaixa.GetRowCellValue(advBandedGridViewTransacoesCaixa.GetSelectedRows()[0], advBandedGridViewTransacoesCaixa.Columns[0]));
            if (e.RelationIndex == 0)
            {
                e.ChildList = new BindingSource(formaPagamentoController.ObterFormasPagamentos(formaPagamento), "");
            }
            
        }

        private void advBandedGridViewTransacoesCaixa_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            try
            {
                if (e.RelationIndex == 0)
                {
                    e.RelationName = $"Formas de pagamento {advBandedGridViewTransacoesCaixa.GetRowCellValue(advBandedGridViewTransacoesCaixa.GetSelectedRows()[0], advBandedGridViewTransacoesCaixa.Columns[0])}";
                }
            }
            catch (System.IndexOutOfRangeException)
            {

            }
            catch (System.NullReferenceException)
            {

            }
        }

        private void advBandedGridViewTransacoesCaixa_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            if (e.RelationIndex == 0)
            {
                e.IsEmpty = false;
            }
        }

        private void advBandedGridViewTransacoesCaixa_MasterRowGetLevelDefaultView(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs e)
        {
            e.DefaultView = gridViewFormasPagamento;
        }
        private void ContadorDinheiro()
        {
            Views.ContadorDinheiro FormContadorDinheiro = new ContadorDinheiro();
            FormContadorDinheiro.Show();
        }
        private void bbiContadorDinheiro_ItemClick(object sender, ItemClickEventArgs e)
        {
            ContadorDinheiro();
        }

        private void bbiLinkPagamento_ItemClick(object sender, ItemClickEventArgs e)
        {
            LinkPagamento();
        }
    }
}