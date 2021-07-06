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
using AdvanceShop.Models;
using AdvanceShop.Controllers;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Validation;
using DevExpress.Utils.Menu;
using AdvanceShop.Shared.Library;

namespace AdvanceShop.Views
{
    public partial class TransacoesEstoque : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        /*
        Entrada=
        Entrada de Estoque,
        Devolução Cliente,
        Ajuste Estoque,


        Saidas=
        Saida de Estoque,
        Venda,
        Devolução Fornecedor,
        Transferencia Entre Lojas,
        Uso Consumo,
        Bonificação

        */
        UsuariosModel usuarioLogado = new UsuariosModel();
        TransacoesEstoqueModel transacaoEstoque = new TransacoesEstoqueModel();
        TransacoesEstoqueController transacaoEstoqueController = new TransacoesEstoqueController();
        ItensVendasModel itensVenda = new ItensVendasModel();
        ItensVendasController itensVendaController = new ItensVendasController();
        UsuarioTemPermissaoModel usuarioTemPermissao = new UsuarioTemPermissaoModel();
        public TransacoesEstoque(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            usuarioTemPermissao.usuarios_idusuarios = UsuarioLogado.IdUsuarios;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public void AtualizarGrid()
        {
            DataTable dataSource = transacaoEstoqueController.ObterTodasTransacoes();
            gridControl.DataSource = dataSource;
            gridControl.Refresh();
            bsiRecordsCount.Caption = "Registros : " + dataSource.Rows.Count;
        }
        
        private void TransacoesEstoque_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        private void NovaTransacaoEntrada()
        {
            usuarioTemPermissao.permissoes_idpermissoes = 20;
            if (UsuarioTemPermissaoController.AutenticarPermissao(usuarioTemPermissao))
            {
                Views.NovaEntradaEstoque FormEntradaEstoque = new NovaEntradaEstoque(usuarioLogado);
                FormEntradaEstoque.ShowDialog();
            }
            
        }
        private void NovaTransacaoSaida()
        {
            usuarioTemPermissao.permissoes_idpermissoes = 21;
            if (UsuarioTemPermissaoController.AutenticarPermissao(usuarioTemPermissao))
            {
                Views.NovaSaidaEstoque FormSaidaEstoque = new NovaSaidaEstoque(usuarioLogado);
                FormSaidaEstoque.ShowDialog();
            }
            
        }
        private void EditarTransacao()
        {

        }
        private void DeletarTransacao()
        {
            usuarioTemPermissao.permissoes_idpermissoes = 22;
            if (UsuarioTemPermissaoController.AutenticarPermissao(usuarioTemPermissao))
            {
                transacaoEstoque.IdTransacoesEstoque = Convert.ToInt32(advBandedGridViewTransacoesEstoque.GetRowCellValue(advBandedGridViewTransacoesEstoque.GetSelectedRows()[0], advBandedGridViewTransacoesEstoque.Columns[0]));
                transacaoEstoque.TipoDescricao = Convert.ToInt32(advBandedGridViewTransacoesEstoque.GetRowCellValue(advBandedGridViewTransacoesEstoque.GetSelectedRows()[0], advBandedGridViewTransacoesEstoque.Columns[12]));
                if (Convert.ToInt32(advBandedGridViewTransacoesEstoque.GetRowCellValue(advBandedGridViewTransacoesEstoque.GetSelectedRows()[0], advBandedGridViewTransacoesEstoque.Columns[1])) != 5)
                {
                    if (advBandedGridViewTransacoesEstoque.SelectedRowsCount == 1 &&
                    MessageBoxQuestionYesNo.Show("Confirmar deletar registro selecionado?") == DialogResult.Yes)
                    {
                        transacaoEstoqueController.Deletar(transacaoEstoque);
                        MessageBoxOK.Show("Deletado com sucesso!");
                        AtualizarGrid();
                    }
                }
                else
                {
                    MessageBoxWarning.Show("Opa para deletar esse tipo de transação de venda somente deletando a venda!");
                }
            }
            
        }
        private void bbiEntrada_ItemClick(object sender, ItemClickEventArgs e)
        {
            NovaTransacaoEntrada();
        }

        private void bbiSaida_ItemClick(object sender, ItemClickEventArgs e)
        {
            NovaTransacaoSaida();
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

        private void advBandedGridViewTransacoesEstoque_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            /*
            Entrada_Estoque = 1,
            Devolucao_Cliente = 2,
            Ajuste_Estoque = 3,
            Saida_Estoque = 4,
            Venda = 5,
            Devolucao_Fornecedor = 6,
            Transferencia_Entre_Lojas = 7,
            Uso_Consumo = 8,
            Bonificao = 9

           */
            if (e.Column.FieldName == "nome")
            {
                if (Convert.ToString(e.Value) == "") e.DisplayText = "CONSUMIDOR";
            }
            if (e.Column.FieldName == "tipo")
            {
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Entrada Estoque";
                if (Convert.ToInt32(e.Value) == 2) e.DisplayText = "2 - Devolução Cliente";
                if (Convert.ToInt32(e.Value) == 3) e.DisplayText = "3 - Ajuste Estoque";
                if (Convert.ToInt32(e.Value) == 4) e.DisplayText = "4 - Saida Estoque";
                if (Convert.ToInt32(e.Value) == 5) e.DisplayText = "5 - Venda";
                if (Convert.ToInt32(e.Value) == 6) e.DisplayText = "6 - Devolução Fornecedor";
                if (Convert.ToInt32(e.Value) == 7) e.DisplayText = "7 - Transferencia Entre Lojas";
                if (Convert.ToInt32(e.Value) == 8) e.DisplayText = "8 - Uso Consumo";
                if (Convert.ToInt32(e.Value) == 9) e.DisplayText = "9 - Bonificação";

            }
        }

        private void advBandedGridViewTransacoesEstoque_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void advBandedGridViewTransacoesEstoque_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            itensVenda.transacoesestoque_idtransacoesestoque = Convert.ToInt32(advBandedGridViewTransacoesEstoque.GetRowCellValue(advBandedGridViewTransacoesEstoque.GetSelectedRows()[0], advBandedGridViewTransacoesEstoque.Columns[0]));
            if (e.RelationIndex == 0)
            {
                e.ChildList = new BindingSource(itensVendaController.ObterTodosItensDaTransacaoEstoque(itensVenda), "");
            }
        }

        private void advBandedGridViewTransacoesEstoque_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            try
            {
                if (e.RelationIndex == 0)
                {
                    e.RelationName = $"Itens da Transação {advBandedGridViewTransacoesEstoque.GetRowCellValue(advBandedGridViewTransacoesEstoque.GetSelectedRows()[0], advBandedGridViewTransacoesEstoque.Columns[0])}";
                }
            }
            catch (System.IndexOutOfRangeException)
            {

            }
            catch (System.NullReferenceException)
            {

            }
        }

        private void advBandedGridViewTransacoesEstoque_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            if (e.RelationIndex == 0)
            {
                e.IsEmpty = false;
            }
        }

        private void advBandedGridViewTransacoesEstoque_MasterRowGetLevelDefaultView(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs e)
        {
            e.DefaultView = gridViewItensTransacaoEstoque;
        }

        private void TransacoesEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void advBandedGridViewTransacoesEstoque_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (advBandedGridViewTransacoesEstoque.SelectedRowsCount == 1)
            {
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                {
                    DXMenuItem item1 = new DXMenuItem("Novo Entrada Estoque");
                    DXMenuItem item2 = new DXMenuItem("Nova Saída Estoque");
                    DXMenuItem item3 = new DXMenuItem("Deletar Transação");
                    DXMenuItem item4 = new DXMenuItem("Atualizar Grid");
                    

                    item1.Click += (o, args) =>
                    {
                        NovaTransacaoEntrada();
                    };
                    item2.Click += (o, args) =>
                    {
                        NovaTransacaoSaida();
                    };
                    item3.Click += (o, args) =>
                    {
                        DeletarTransacao();
                    };
                    item4.Click += (o, args) =>
                    {
                        AtualizarGrid();
                    };

                    e.Menu.Items.Add(item1);
                    e.Menu.Items.Add(item2);
                    e.Menu.Items.Add(item3);
                    e.Menu.Items.Add(item4);


                }
            }
        }

        private void bbiExportarExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExportarExcel.Grid(advBandedGridViewTransacoesEstoque);
        }
    }
}