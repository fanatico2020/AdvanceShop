using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Validation;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
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
    public partial class VendaCaixaPDV : DevExpress.XtraEditors.XtraForm
    {
        
        UsuariosModel usuarioLogado = new UsuariosModel();
        UsuariosController usuarioController = new UsuariosController();
        ConfiguracoesGeraisController configGeraisController = new ConfiguracoesGeraisController();
        ConfiguracoesGeraisModel configGerais = new ConfiguracoesGeraisModel();
        CaixasModel caixa = new CaixasModel();
        CaixasController caixaController = new CaixasController();
        DataHoraModel dataHora = new DataHoraModel();
        ProdutosModel produto = new ProdutosModel();
        ProdutosController produtoController = new ProdutosController();
        ClientesPessoasModel clientePessoa = new ClientesPessoasModel();
        VendasModel venda = new VendasModel();
        TransacoesCaixaModel transacaoCaixa = new TransacoesCaixaModel();
        DataTable dtItensVenda;
        ProdutosPDVModel produtosPDV = new ProdutosPDVModel();
        List<ItensVendasModel> itensVenda = new List<ItensVendasModel>();
        int contagemItem = 1;
        public VendaCaixaPDV(UsuariosModel UsuarioLogado,CaixasModel Caixa)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            usuarioLogado = usuarioController.ObterDadosUsuarioPorNomeUsuario(usuarioLogado);
            caixa = Caixa;
            venda.caixas_idcaixas = caixa.IdCaixas;
            transacaoCaixa.caixas_idcaixas = caixa.IdCaixas;
            
            configGerais = configGeraisController.ObterConfiguracoesGerais();

        }
        public void FecharPDV()
        {
            Close();
        }
        public void NovaVenda()
        {
            itensVenda.Clear();
            contagemItem = 1;
            gridControlItensVenda.DataSource = null;
            advBandedGridViewItensPDV.SelectAll();
            advBandedGridViewItensPDV.DeleteSelectedRows();
            MontarDataTableItensVenda();
            txtQtd.Text = "1";
            lblClienteSelecionado.Text = "CONSUMIDOR";
            lblSubtotal.Text = "Subtotal = R$0,00";
            lblDesconto.Text = "Desconto = R$0,00";
            lblQtditensValorTotal.Text = "Qtd Itens = 0 | Total = R$0,00";
            cbxPesquisarProduto.ClearSelection();
            cbxProcurarProduto.Text = "Código,Nome ou use o leitor de código de barras";
            AtualizarProdutos();
            venda.Desconto = 0;
            venda.ValorPago = 0;
            transacaoCaixa.ObservacaoTransacao = "";
        }
        
        private void MontarDataTableItensVenda()//Montando a estrutura source do grid para receber os produtos
        {
            dtItensVenda = new DataTable();
            dtItensVenda.Columns.Add("codigoproduto", typeof(int));
            dtItensVenda.Columns.Add("item", typeof(int));
            dtItensVenda.Columns.Add("descricaoproduto", typeof(string));
            dtItensVenda.Columns.Add("quantidade", typeof(int));
            dtItensVenda.Columns.Add("precounitario", typeof(decimal));
            dtItensVenda.Columns.Add("subtotal", typeof(decimal));
            dtItensVenda.Columns.Add("unidademedida", typeof(string));
            dtItensVenda.Columns.Add("codigo_ncm", typeof(string));
            dtItensVenda.Columns.Add("cfop", typeof(string));
            dtItensVenda.Columns.Add("icms_origem", typeof(string));
            dtItensVenda.Columns.Add("icms_situacao_tributaria", typeof(string));
            gridControlItensVenda.DataSource = dtItensVenda;
        }
        private void CalcularTotalItensTotalSubTotal()
        {
            advBandedGridViewItensPDV.UpdateTotalSummary();
            decimal totalGeral = Convert.ToDecimal(advBandedGridViewItensPDV.Columns["subtotal"].SummaryItem.SummaryValue);
            int totalItens = Convert.ToInt32(advBandedGridViewItensPDV.Columns["quantidade"].SummaryItem.SummaryValue);
            decimal totalfinal = totalGeral - venda.Desconto;
            lblSubtotal.Text = $"Subtotal = {totalGeral.ToString("C")}";
            lblQtditensValorTotal.Text = $"Qtd Itens = {totalItens} | Total = {totalfinal.ToString("C")}";
            transacaoCaixa.Valor = totalfinal;
            venda.Valor = totalGeral;
            venda.TotalFinal = totalfinal;
        }
        private void AdicionarNovaRowItem(ProdutosPDVModel Produto)
        {
            advBandedGridViewItensPDV.AddNewRow();
            int rowHandle = advBandedGridViewItensPDV.GetRowHandle(advBandedGridViewItensPDV.DataRowCount);
            if (advBandedGridViewItensPDV.IsNewItemRow(rowHandle))
            {
                //adicionando o item a o grid do PDV
                advBandedGridViewItensPDV.SetRowCellValue(rowHandle, advBandedGridViewItensPDV.Columns[0], Produto.codigoproduto) ;//Codigo produto
                advBandedGridViewItensPDV.SetRowCellValue(rowHandle, advBandedGridViewItensPDV.Columns[1], Produto.item);//Item
                advBandedGridViewItensPDV.SetRowCellValue(rowHandle, advBandedGridViewItensPDV.Columns[2], Produto.descricaoproduto);//Descrição do Produto
                advBandedGridViewItensPDV.SetRowCellValue(rowHandle, advBandedGridViewItensPDV.Columns[3], Produto.quantidade);//Quantidade
                advBandedGridViewItensPDV.SetRowCellValue(rowHandle, advBandedGridViewItensPDV.Columns[4], Produto.precounitario);//Preço
                advBandedGridViewItensPDV.SetRowCellValue(rowHandle, advBandedGridViewItensPDV.Columns[5], Produto.subtotal);//Total
                advBandedGridViewItensPDV.SetRowCellValue(rowHandle, advBandedGridViewItensPDV.Columns[6], Produto.codigo_ncm);//codigo_ncm
                advBandedGridViewItensPDV.SetRowCellValue(rowHandle, advBandedGridViewItensPDV.Columns[7], Produto.cfop);//cfop
                advBandedGridViewItensPDV.SetRowCellValue(rowHandle, advBandedGridViewItensPDV.Columns[8], Produto.icms_origem);//icms_origem
                advBandedGridViewItensPDV.SetRowCellValue(rowHandle, advBandedGridViewItensPDV.Columns[9], Produto.icms_situacao_tributaria);//icms_situacao_tributaria
                advBandedGridViewItensPDV.SetRowCellValue(rowHandle, advBandedGridViewItensPDV.Columns[10], Produto.unidademedida);//icms_situacao_tributaria

                //adicionando o item a listas de itens 
                itensVenda.Add(new ItensVendasModel()
                {
                    produtos_idprodutos = Produto.codigoproduto,
                    DescricaoProduto = Produto.descricaoproduto,
                    Quantidade = Produto.quantidade,
                    ValorUnitario = Produto.precounitario,
                    Subtotal = Produto.subtotal,
                    Precocusto = Produto.precocusto,
                    Margemlucro = Produto.margemlucro,
                    Item = Produto.item,
                    UnidadeMedida = Produto.unidademedida,
                    codigo_ncm = Produto.codigo_ncm,
                    cfop = Produto.cfop,
                    icms_origem = Produto.icms_origem,
                    icms_situacao_tributaria = Produto.icms_situacao_tributaria

                });
            }
        }
        private void FinalizarVenda()//Seguindo para Form de pagamento
        {
            if(advBandedGridViewItensPDV.SelectedRowsCount > 0)
            {
                
                Views.PagamentoPDV FormPagamento = new PagamentoPDV(venda, clientePessoa, transacaoCaixa,itensVenda,caixa,usuarioLogado);
                FormPagamento.ShowDialog();
            }
            else
            {
                MessageBoxWarning.Show("Só e possível finalizar a venda que contém itens no grid!");
            }
            
        }
        private void DescontoVenda()//Form de desconto sobre a venda
        {
            if (!Convert.ToBoolean(usuarioLogado.UsaDescontoMaximo))
            {
                MessageBoxWarning.Show("Opa você não tem permissão para da desconto!");

            }
            else
            {
                decimal totalGeral = Convert.ToDecimal(advBandedGridViewItensPDV.Columns["subtotal"].SummaryItem.SummaryValue);
                venda.Valor = totalGeral;
                Views.DescontoPDV FormDesconto = new DescontoPDV(venda, usuarioLogado);
                DialogResult ResultadoDescontoVenda = FormDesconto.ShowDialog();
                if (ResultadoDescontoVenda == DialogResult.OK)
                {
                    venda.Desconto = FormDesconto.vendaPDV.Desconto;
                    lblDesconto.Text = $"Desconto = {venda.Desconto.ToString("C")}";
                    CalcularTotalItensTotalSubTotal();
                }
            }
            
        }
        private void RemoverItemGrid()
        {
            if (advBandedGridViewItensPDV.SelectedRowsCount == 1)
            {
                if (MessageBoxQuestionYesNo.Show("Confirmar o cancelamento do item selecionado?") == DialogResult.Yes)
                {
                    
                    //1 - remove item da lista de itens
                    int item = Convert.ToInt32(advBandedGridViewItensPDV.GetRowCellValue(advBandedGridViewItensPDV.GetSelectedRows()[0], advBandedGridViewItensPDV.Columns[1]));
                    itensVenda.RemoveAll(x => x.Item.Equals(item));

                    //2 - remove item do grid
                    advBandedGridViewItensPDV.DeleteRow(advBandedGridViewItensPDV.FocusedRowHandle);
                    
                    
                    cbxProcurarProduto.Focus();
                }
            }
            else
            {
                MessageBoxOK.Show("Não a item selecionado para ser cancelado!");
            }
        }
        private void SelecionarClienteVenda()//Form de clientes para selecionar o cliente da venda caso não seja cliente padrão CONSUMIDOR!
        {
            Views.ClientesPessoas FormPesquisarCliente = new ClientesPessoas(usuarioLogado);
            DialogResult ResultadoPesquisarCliente = FormPesquisarCliente.ShowDialog();
            if (ResultadoPesquisarCliente == DialogResult.OK)
            {
                clientePessoa = FormPesquisarCliente.clientePessoaPDV;
                lblClienteSelecionado.Text = clientePessoa.NomeClientePessoa;
                //Avisar cliente aniversariante
                
                if (Convert.ToBoolean(configGerais.avisarclienteaniversariante) && clientePessoa.IdClientesPessoas != 0 &&
                    clientePessoa.DataNascimento.ToShortDateString() != "01/01/0001")
                {
                    if (clientePessoa.DataNascimento.Day == DateTime.Now.Day && clientePessoa.DataNascimento.Month == DateTime.Now.Month)
                    {
                        MessageBoxOK.Show($"Cliente '{lblClienteSelecionado.Text}' estar aniversariando hoje!");
                    }
                }
                
            }
        }
        private void ObservacaoVenda()//Adicionando uma observaçao a venda, pela transação
        {
            
            Views.ObservacaoPDV FormObservacao = new ObservacaoPDV(transacaoCaixa);
            DialogResult ResultadoObservacaoVenda = FormObservacao.ShowDialog();
            if(ResultadoObservacaoVenda == DialogResult.OK)
            {
                transacaoCaixa.ObservacaoTransacao = FormObservacao.transacaoVendaPDV.ObservacaoTransacao;
            }
        }
        private void FecharCaixa()
        {
            
            caixa = caixaController.ObterDadosDoCaixaPorID(caixa);
            Views.TransacoesCaixa FormTransacoesCaixa = new TransacoesCaixa(usuarioLogado, caixa);
            FormTransacoesCaixa.ShowDialog();
        }
        private void btnCalculadora_Click(object sender, EventArgs e)//Abrir a calculadora do windows
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            DescontoVenda();
        }

        private void btnObservacao_Click(object sender, EventArgs e)
        {
            ObservacaoVenda();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }
        private void AtualizarProdutos()
        {
            cbxProcurarProduto.Properties.DataSource = produtoController.ObterTodosProdutos_PDV();
            cbxProcurarProduto.Properties.DisplayMember = "descricaoproduto";
            cbxProcurarProduto.Properties.ValueMember = "idprodutos";
            cbxProcurarProduto.Refresh();
            
        }
        private void VendaCaixaPDV_Load(object sender, EventArgs e)
        {
            AtualizarProdutos();
            cbxProcurarProduto.Properties.PopupFormSize = new Size(1200, 1000);
            MontarDataTableItensVenda();
            cbxProcurarProduto.Focus();
        }

        private void VendaCaixaPDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
            
        }

        private void txtQtd_EditValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtQtd.Text) < 1)
            {
                txtQtd.Text = "1";
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            SelecionarClienteVenda();
        }
        private void CancelarVenda()
        {
            if (MessageBoxQuestionYesNo.Show("Confirmar cancelamento da venda?") == DialogResult.Yes)
            {
                NovaVenda();
            }
        }
        private void VendaCaixaPDV_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //case Keys.F1:
                //    cbxProcurarProduto.ShowPopup();
                //    break;
                case Keys.F2:
                    //Finalizar venda
                    FinalizarVenda();
                    break;;
                case Keys.F3:
                    //Adicionar desconto na venda
                    DescontoVenda();
                    break;
                case Keys.F4:
                    //Adicionar observação na venda 
                    ObservacaoVenda();
                    break;
                case Keys.F5:
                    //Selecionar cliente da venda
                    SelecionarClienteVenda();
                    break;
                case Keys.F6:
                    //Remove Item da venda
                    RemoverItemGrid();
                    break;
                case Keys.F7:
                    //Cancelar Venda
                    CancelarVenda();
                    break;
                case Keys.F8: //Fechar caixa
                    FecharCaixa();
                    break;
                default:
                    break;
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            produtosPDV.codigoproduto = Convert.ToInt32(cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[0]));
            produtosPDV.item = contagemItem++;
            produtosPDV.descricaoproduto = cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[1]).ToString();
            produtosPDV.quantidade = Convert.ToInt32(txtQtd.Text);
            produtosPDV.precounitario = Convert.ToDecimal(cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[4]));
            produtosPDV.subtotal = produtosPDV.quantidade * produtosPDV.precounitario;
            produtosPDV.margemlucro = Convert.ToDecimal(cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[3]));
            produtosPDV.precocusto = Convert.ToDecimal(cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[2]));
            produtosPDV.unidademedida = cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[8]).ToString();
            produtosPDV.codigo_ncm = cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[10]).ToString();
            produtosPDV.cfop = cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[11]).ToString();
            produtosPDV.icms_origem = cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[12]).ToString();
            produtosPDV.icms_situacao_tributaria = cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[13]).ToString();

            AdicionarNovaRowItem(produtosPDV);

            txtQtd.Text = "1";
            lblPrecoUniTotal.Text = "Preço: R$0,00 Total: R$0,00";

            advBandedGridViewItensPDV.FocusedRowHandle = advBandedGridViewItensPDV.RowCount;
            
            cbxProcurarProduto.Focus();
        }

        private void cbxProcurarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Verificar se produto estar com estoque baixo, caso a conf esteja marcado pra avisar usuario
                produto.IdProdutos = Convert.ToInt32(cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[0]));
                if (Convert.ToBoolean(configGerais.avisarprodutoestoquebaixo) && Convert.ToBoolean(produtoController.VerificarProdutoEstoqueBaixo(produto)))
                {
                    MessageBoxWarning.Show($"Produto '{cbxProcurarProduto.Text}' com estoque baixo!");
                }
                if (e.KeyChar == (char)13)
                {
                    decimal valorproduto = Convert.ToDecimal(cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[4]));
                    int quantidade = Convert.ToInt32(txtQtd.Text);
                    decimal subtotal = quantidade * valorproduto;
                    lblPrecoUniTotal.Text = $"Preço: {valorproduto.ToString("C")} Total: {subtotal.ToString("C")}";

                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
            }
            catch (IndexOutOfRangeException)
            {
                cbxProcurarProduto.Focus();
            }
            
            
        }

        private void advBandedGridViewItensPDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            CalcularTotalItensTotalSubTotal();
        }

        private void advBandedGridViewItensPDV_RowCountChanged(object sender, EventArgs e)
        {
            CalcularTotalItensTotalSubTotal();
        }

        private void advBandedGridViewItensPDV_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (advBandedGridViewItensPDV.SelectedRowsCount == 1)
            {
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                {
                    DXMenuItem item1 = new DXMenuItem("Concluir Venda (F2)");
                    DXMenuItem item2 = new DXMenuItem("Inserir Desconto Venda (F3)");
                    DXMenuItem item3 = new DXMenuItem("Observação Venda (F4)");
                    DXMenuItem item4 = new DXMenuItem("Selecionar Cliente Venda (F5)");
                    DXMenuItem item5 = new DXMenuItem("Remover Item da Venda (F6)");
                    DXMenuItem item6 = new DXMenuItem("Cancelar Venda (F7)");
                    DXMenuItem item7 = new DXMenuItem("Fechar Caixa (F8)");
                    item1.Click += (o, args) =>
                    {
                        FinalizarVenda();
                    };
                    item2.Click += (o, args) =>
                    {
                        DescontoVenda();
                    };
                    item3.Click += (o, args) =>
                    {
                        ObservacaoVenda();
                    };
                    item4.Click += (o, args) =>
                    {
                        SelecionarClienteVenda();
                    };
                    item5.Click += (o, args) =>
                    {
                        RemoverItemGrid();
                    };
                    item6.Click += (o, args) =>
                    {
                        CancelarVenda();
                    };
                    item7.Click += (o, args) =>
                    {
                        FecharCaixa();
                    };
                    e.Menu.Items.Add(item1);
                    e.Menu.Items.Add(item2);
                    e.Menu.Items.Add(item3);
                    e.Menu.Items.Add(item4);
                    e.Menu.Items.Add(item5);
                    e.Menu.Items.Add(item6);
                    e.Menu.Items.Add(item7);
                }
            }
        }

        private void cbxProcurarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    e.Handled = true;
                    SendKeys.Send("{F1}");
                    break;
                case Keys.Down:
                    e.Handled = true;
                    SendKeys.Send("{F1}");
                    break;
                default:
                    break;
            }
        }

        private void txtQtd_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}
