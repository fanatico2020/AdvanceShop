using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Validation;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using System;
using System.Data;
using System.Windows.Forms;
namespace AdvanceShop.Views
{
    public partial class Produtos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        ProdutosModel produto = new ProdutosModel();
        ProdutosController produtoController = new ProdutosController();
        UsuarioTemPermissaoModel usuarioTemPermissao = new UsuarioTemPermissaoModel();
        public Produtos(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        private void Produtos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        public void AtualizarGrid()
        {
            
            DataTable dataSource = produtoController.ObterTodosProdutos();
            gridControl.DataSource = dataSource;
            gridControl.Refresh();
            bsiRecordsCount.Caption = "Registros : " + dataSource.Rows.Count;
            
        }
        private void bbiNovoProduto_ItemClick(object sender, ItemClickEventArgs e)
        {
            NovoProduto();
        }

        private void bbiEditarProduto_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditarProduto();
        }

        private void bbiDeletarProduto_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeletarProduto();
        }

        private void bbiAtualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            AtualizarGrid();
        }
        private void NovoProduto()
        {
            Views.NovoProduto FormNovoProduto = new NovoProduto(usuarioLogado);
            FormNovoProduto.ShowDialog();
        }
        private void EditarProduto()
        {
            produto.IdProdutos = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[0]));
            produto.DescricaoProduto = advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[1]).ToString();
            produto.CodigoBarra = advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[2]).ToString();
            produto.clientespessoas_idclientespessoas = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[11]));
            produto.categoriasprodutos_idcategoriasprodutos = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[10]));
            produto.marcasprodutos_idmarcasprodutos = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[12]));
            produto.unidadesmedidasprodutos_idunidadesmedidasprodutos = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[13]));
            produto.PrecoCusto = Convert.ToDecimal(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[6]));
            produto.MargemLucro = Convert.ToDecimal(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[7]));
            produto.PrecoVenda = Convert.ToDecimal(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[8]));
            produto.EstoqueAtual = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[3]));
            produto.EstoqueMinimo = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[4]));
            produto.EstoqueMaximo = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[5]));
            produto.StatusProduto = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[9]));
            produto.CalcularAutomatico = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[14]));
            produto.ControlarEstoque = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[15]));
            //fiscal
            produto.Codigo_NCM = advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[20]).ToString();
            produto.Codigo_CFOP = advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[21]).ToString();
            produto.ICMS_Origem = advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[22]).ToString();
            produto.ICMS_Situacao_Tributaria = advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[23]).ToString();

            Views.NovoProduto FormEditarProduto = new NovoProduto(usuarioLogado, produto);
            FormEditarProduto.Show();
        }
        private void DeletarProduto()
        {
            produto.IdProdutos = Convert.ToInt32(advBandedGridViewProdutos.GetRowCellValue(advBandedGridViewProdutos.GetSelectedRows()[0], advBandedGridViewProdutos.Columns[0]));
            if (advBandedGridViewProdutos.SelectedRowsCount == 1 && MessageBoxQuestionYesNo.Show("Confirmar deletar registro selecionado?") == DialogResult.Yes)
            {
                produtoController.Deletar(produto);
                MessageBoxOK.Show("Deletado com sucesso!");
                AtualizarGrid();
            }
        }
        private void AtivarDesativarProduto()
        {

        }
        private void ClonarProduto()
        {

        }
        private void advBandedGridViewProdutos_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "statusproduto")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Inativo";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Ativo";
            }
            if (e.Column.FieldName == "controlarestoque")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Não";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Sim";
            }
            if (e.Column.FieldName == "margemlucro")
            {
                e.DisplayText = $"{e.Value}%";
            }
        }

        private void advBandedGridViewProdutos_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (advBandedGridViewProdutos.SelectedRowsCount == 1)
            {
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                {
                    DXMenuItem item1 = new DXMenuItem("Novo Produto");
                    DXMenuItem item2 = new DXMenuItem("Editar Produto");
                    DXMenuItem item3 = new DXMenuItem("Deletar Produto");
                    DXMenuItem item4 = new DXMenuItem("Atualizar Grid");
                    DXMenuItem item5 = new DXMenuItem("Clonar Produto");
                    DXMenuItem item6 = new DXMenuItem("Ativar/Desativar Produto");
                    item1.Click += (o, args) =>
                    {
                        NovoProduto();
                    };
                    item2.Click += (o, args) =>
                    {
                        EditarProduto();
                    };
                    item3.Click += (o, args) =>
                    {
                        DeletarProduto();
                    };
                    item4.Click += (o, args) =>
                    {
                        AtualizarGrid();
                    };
                    item5.Click += (o, args) => {
                        ClonarProduto();
                    };
                    item6.Click += (o, args) => {
                        AtivarDesativarProduto();
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

        private void advBandedGridViewProdutos_DoubleClick(object sender, EventArgs e)
        {
            EditarProduto();
        }

        private void Produtos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void Produtos_FormClosed(object sender, FormClosedEventArgs e)
        {
            VendaCaixaPDV view = Application.OpenForms["VendaCaixaPDV"] as VendaCaixaPDV;
            if (view != null)
            {
                view.AtualizarProdutos();
            }
        }
    }
}