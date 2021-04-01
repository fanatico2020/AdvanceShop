﻿using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Validation;
using DevExpress.Utils.Menu;
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
    public partial class NovaSaidaEstoque : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        DataTable dtItensEntradEstoque;
        TransacoesEstoqueModel transacaoEstoque = new TransacoesEstoqueModel();
        TransacoesEstoqueController transacaoEstoqueController = new TransacoesEstoqueController();
        ClientesPessoasController clientePessoaController = new ClientesPessoasController();
        ProdutosController produtoController = new ProdutosController();
        List<ProdutosModel> produtosEntrada = new List<ProdutosModel>();
        ProdutosEstoqueModel produtoEstoque = new ProdutosEstoqueModel();
        List<ItensVendasModel> itensEstoque = new List<ItensVendasModel>();
        int contagemItem = 1;
        public NovaSaidaEstoque(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
        }
        
        private void MontarDataTableItensEntradaEstoque()//Montando a estrutura source do grid para receber os produtos
        {
            dtItensEntradEstoque = new DataTable();
            dtItensEntradEstoque.Columns.Add("idprodutos", typeof(int));
            dtItensEntradEstoque.Columns.Add("item", typeof(int));
            dtItensEntradEstoque.Columns.Add("descricaoproduto", typeof(string));
            dtItensEntradEstoque.Columns.Add("quantidade", typeof(int));
            dtItensEntradEstoque.Columns.Add("precocusto", typeof(decimal));
            dtItensEntradEstoque.Columns.Add("margem", typeof(decimal));
            dtItensEntradEstoque.Columns.Add("precovenda", typeof(decimal));
            dtItensEntradEstoque.Columns.Add("idclientespessoas", typeof(int));
            dtItensEntradEstoque.Columns.Add("fornecedor", typeof(string));
            gridControl1.DataSource = dtItensEntradEstoque;
        }
        private void AdicionarNovaRowItem(ProdutosEstoqueModel Produto)
        {
            advBandedGridViewProdutos.AddNewRow();
            int rowHandle = advBandedGridViewProdutos.GetRowHandle(advBandedGridViewProdutos.DataRowCount);
            if (advBandedGridViewProdutos.IsNewItemRow(rowHandle))
            {
                //adicionando o item a o grid 
                advBandedGridViewProdutos.SetRowCellValue(rowHandle, advBandedGridViewProdutos.Columns[0], Produto.idprodutos);
                advBandedGridViewProdutos.SetRowCellValue(rowHandle, advBandedGridViewProdutos.Columns[1], Produto.descricaoprotudo);
                advBandedGridViewProdutos.SetRowCellValue(rowHandle, advBandedGridViewProdutos.Columns[2], Produto.quantidade);
                advBandedGridViewProdutos.SetRowCellValue(rowHandle, advBandedGridViewProdutos.Columns[3], Produto.precocusto);
                advBandedGridViewProdutos.SetRowCellValue(rowHandle, advBandedGridViewProdutos.Columns[4], Produto.margem);
                advBandedGridViewProdutos.SetRowCellValue(rowHandle, advBandedGridViewProdutos.Columns[5], Produto.precovenda);
                advBandedGridViewProdutos.SetRowCellValue(rowHandle, advBandedGridViewProdutos.Columns[6], Produto.fornecedor);
                advBandedGridViewProdutos.SetRowCellValue(rowHandle, advBandedGridViewProdutos.Columns[7], Produto.idclientespessoas);
                advBandedGridViewProdutos.SetRowCellValue(rowHandle, advBandedGridViewProdutos.Columns[8], Produto.item);

                //adicionando o item a listas de itens 
                itensEstoque.Add(new ItensVendasModel()
                {
                    produtos_idprodutos = Produto.idprodutos,
                    Quantidade = Produto.quantidade,
                    ValorUnitario = Produto.precovenda,
                    Subtotal = Produto.precovenda * Produto.quantidade,
                    Item = Produto.item
                });
                //adicionando produto a lista de produtos a serem atualizado estoque
                produtosEntrada.Add(new ProdutosModel()
                {
                    IdProdutos = Produto.idprodutos,
                    Item = Produto.item,
                    EstoqueAtual = Produto.quantidade,
                    PrecoCusto = Produto.precocusto,
                    MargemLucro = Produto.margem,
                    PrecoVenda = Produto.precovenda,
                    clientespessoas_idclientespessoas = Produto.idclientespessoas
                });

            }
        }
        private void AtualizarGrid()
        {
            Views.TransacoesEstoque view = Application.OpenForms["TransacoesEstoque"] as Views.TransacoesEstoque;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void AtualizarProdutos()
        {
            cbxProcurarProduto.Properties.DataSource = produtoController.ObterTodosProdutosQueControlarEstoque();
            cbxProcurarProduto.Properties.DisplayMember = "descricaoproduto";
            cbxProcurarProduto.Properties.ValueMember = "idprodutos";
            cbxProcurarProduto.Refresh();

        }
        public void AtualizarFornecedores()
        {
            cbxFornecedor.Properties.DataSource = clientePessoaController.ObterTodosClientesPessoas();
            cbxFornecedor.Properties.DisplayMember = "nome";
            cbxFornecedor.Properties.ValueMember = "idclientespessoas";
        }
        

        private void EntradaEstoque_Load(object sender, EventArgs e)
        {
            AtualizarFornecedores();
            MontarDataTableItensEntradaEstoque();
            AtualizarProdutos();
        }
        private void AdicionarProdutoNaLista()
        {
            if(Convert.ToInt32(txtQuantidade.Text) > 0 && rgbMotivo.SelectedIndex > -1)
            {
                produtoEstoque.idprodutos = Convert.ToInt32(cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[0])); ;
                produtoEstoque.item = contagemItem++;
                produtoEstoque.descricaoprotudo = cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[1]).ToString();
                produtoEstoque.precocusto = Convert.ToDecimal(cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[2]));
                produtoEstoque.margem = Convert.ToDecimal(cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[3]));
                produtoEstoque.precovenda = Convert.ToDecimal(cbxPesquisarProduto.GetRowCellValue(cbxPesquisarProduto.GetSelectedRows()[0], cbxPesquisarProduto.Columns[4]));
                produtoEstoque.quantidade = Convert.ToInt32(txtQuantidade.Text);
                produtoEstoque.fornecedor = cbxFornecedor.Text;
                produtoEstoque.idclientespessoas = Convert.ToInt32(cbxFornecedor.EditValue);

                AdicionarNovaRowItem(produtoEstoque);

                //limpar
                txtQuantidade.Text = string.Empty;


                advBandedGridViewProdutos.FocusedRowHandle = advBandedGridViewProdutos.RowCount;

                cbxProcurarProduto.Focus();

            }
            else
            {
                MessageBoxWarning.Show("Opa, Quantidade deve ser maior que 0 e você deve seleciona um motivo da saída!");
            }
        }
        private void btnAddProdLista_Click(object sender, EventArgs e)
        {
            AdicionarProdutoNaLista();
        }
        private void Salvar()
        {
            try
            {
                if(advBandedGridViewProdutos.SelectedRowsCount > 0 && MessageBoxQuestionYesNo.Show($"Deseja salvar?") == DialogResult.Yes)
                {
                    switch (rgbMotivo.EditValue)
                    {
                        case 4: //"4 - Saida Estoque";
                            transacaoEstoque.DescricaoTransacao = "Saída sem motivo especifico";
                            break;
                        case 6: //"6 - Devolução Fornecedor";
                            transacaoEstoque.DescricaoTransacao = "Devolução da mercadorio para fornecedor";
                            break;
                        case 7: //"7 - Transferencia Entre Lojas";
                            transacaoEstoque.DescricaoTransacao = "Transaferência de mercadoria entre lojas filiais";
                            break;
                        case 8: //"8 - Uso Consumo";
                            transacaoEstoque.DescricaoTransacao = "Uso consumo proprio dentro da empresa";
                            break;
                        case 9: //"9 - Bonificação";
                            transacaoEstoque.DescricaoTransacao = "Bonificação para funcionários/clientes";
                            break;

                        default:
                            break;
                    }
                    transacaoEstoque.Observacao = txtObservacao.Text;
                    transacaoEstoque.clientespessoas_idclientespessoas = Convert.ToInt32(cbxFornecedor.EditValue);
                    transacaoEstoque.Tipo = Convert.ToInt32(rgbMotivo.EditValue);
                    transacaoEstoqueController.SaidaEstoque(transacaoEstoque, produtosEntrada, itensEstoque, usuarioLogado);

                    MessageBoxOK.Show("Salvo com sucesso!");
                    AtualizarGrid();
                    Close();
                }
                

            }
            catch (System.FormatException)
            {

            }
            catch (Exception error)
            {
                MessageBoxError.Show(error.Message);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void NovaEntradaEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void NovaEntradaEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    Salvar();
                    break;
                case Keys.F5:
                    AdicionarProdutoNaLista();
                    break;
                case Keys.F6:
                    RemoverItemGrid();
                    break;
                default:
                    break;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMargemLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnAddProdLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cbxProcurarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cbxFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void advBandedGridViewProdutos_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "margem")
            {
                e.DisplayText = $"{e.Value}%";
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

        private void advBandedGridViewProdutos_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (advBandedGridViewProdutos.SelectedRowsCount == 1)
            {
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                {
                    DXMenuItem item1 = new DXMenuItem("Salvar (F2)");
                    DXMenuItem item4 = new DXMenuItem("Adicionar a Lista (F5)");
                    DXMenuItem item5 = new DXMenuItem("Remover Item da lista (F6)");

                    item1.Click += (o, args) =>
                    {
                        Salvar();
                    };
                    item4.Click += (o, args) =>
                    {
                        AdicionarProdutoNaLista();
                    };
                    item5.Click += (o, args) =>
                    {
                        RemoverItemGrid();
                    };
                    e.Menu.Items.Add(item1);
                    e.Menu.Items.Add(item4);
                    e.Menu.Items.Add(item5);

                }
            }
        }

        private void RemoverItemGrid()
        {
            if (advBandedGridViewProdutos.SelectedRowsCount == 1)
            {
                if (MessageBoxQuestionYesNo.Show("Confirmar o cancelamento do item selecionado?") == DialogResult.Yes)
                {
                    //1 - remove item da lista de itens
                    int item = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[8]));
                    itensEstoque.RemoveAll(x => x.Item.Equals(item));

                    //2 - remove item do grid
                    advBandedGridViewProdutos.DeleteRow(advBandedGridViewProdutos.FocusedRowHandle);

                    cbxProcurarProduto.Focus();
                }
            }
            else
            {
                MessageBoxOK.Show("Não a item selecionado para ser cancelado!");
            }
        }

        private void cbxFornecedor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                Views.ClientesPessoas FormClientesPessoas = new ClientesPessoas(usuarioLogado);
                FormClientesPessoas.ShowDialog();
            }
        }

        private void cbxFornecedor_DoubleClick(object sender, EventArgs e)
        {
            AtualizarFornecedores();
        }

        private void txtQuantidade_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
    }
}
