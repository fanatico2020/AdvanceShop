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

namespace AdvanceShop.Views
{
    public partial class TransacoesCaixa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
            
        }
        private void SomarTotalSaldoCaixa()
        {
            //Entradas
            decimal saldoinicial, saldovendasemdinheiro, saldovendasemcartaocredito, saldovendascartaodebito, saldosuplemento,saldoentradas;

            saldoinicial = formaPagamentoController.SomarTotalDinheiroAberturaCaixa(transacaoCaixa);
            saldovendasemdinheiro = formaPagamentoController.SomarTotalDinheiroCaixa(transacaoCaixa);
            saldovendasemcartaocredito = formaPagamentoController.SomarTotalCartaoCreditoCaixa(transacaoCaixa);
            saldovendascartaodebito = formaPagamentoController.SomarTotalCartaoDebitoCaixa(transacaoCaixa);
            saldosuplemento = formaPagamentoController.SomarTotalDinheiroSuplementoCaixa(transacaoCaixa);
            saldoentradas = saldoinicial + saldovendasemdinheiro + saldovendasemcartaocredito + saldovendascartaodebito + saldosuplemento;

            txtSaldoInicial.Text = Convert.ToString(saldoinicial);
            txtDinheiro.Text = Convert.ToString(saldovendasemdinheiro);
            txtCartaoCredito.Text = Convert.ToString(saldovendasemcartaocredito);
            txtCartaoDebito.Text = Convert.ToString(saldovendascartaodebito);
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
            
        }
        private void DeletarTransacao()
        {
            transacaoCaixa.IdTransacoesCaixa = Convert.ToInt32(advBandedGridViewTransacoesCaixa.GetRowCellValue(advBandedGridViewTransacoesCaixa.GetSelectedRows()[0], advBandedGridViewTransacoesCaixa.Columns[0]));
            transacaoCaixa.DescricaoTransacao = advBandedGridViewTransacoesCaixa.GetRowCellValue(advBandedGridViewTransacoesCaixa.GetSelectedRows()[0], advBandedGridViewTransacoesCaixa.Columns[2]).ToString();
            if (transacaoCaixa.DescricaoTransacao != "Abertura Caixa" && advBandedGridViewTransacoesCaixa.SelectedRowsCount == 1 && MessageBoxQuestionYesNo.Show("Confirmar deletar registro selecionado?") == DialogResult.Yes)
            {
                transacaoCaixaController.Deletar(transacaoCaixa);
                MessageBoxOK.Show("Deletado com sucesso!");
                AtualizarGrid();
            }
            else
            {
                MessageBoxWarning.Show("Opa a Abertura do caixa não pode ser deletada, você pode editar o valor da mesma na tela dos caixas!");
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
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Aguardando Pagamento";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Pagamento Efetuado";
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

                    e.Menu.Items.Add(item1);
                    e.Menu.Items.Add(item2);
                    e.Menu.Items.Add(item3);
                    e.Menu.Items.Add(item4);
                    e.Menu.Items.Add(item5);
                    e.Menu.Items.Add(item6);


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

        private void bbiContadorDinheiro_ItemClick(object sender, ItemClickEventArgs e)
        {
            Views.ContadorDinheiro FormContadorDinheiro = new ContadorDinheiro();
            FormContadorDinheiro.Show();
        }
    }
}