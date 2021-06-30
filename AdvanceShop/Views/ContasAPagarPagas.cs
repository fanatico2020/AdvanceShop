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
using DevExpress.Utils.Menu;
using AdvanceShop.Shared.Validation;

namespace AdvanceShop.Views
{
    public partial class ContasAPagarPagas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        ContasAPagarModel contaAPagar = new ContasAPagarModel();
        ContasAPagarController contaAPagarController = new ContasAPagarController();
        ClientesPessoasModel clientePessoa = new ClientesPessoasModel();
        UsuarioTemPermissaoModel usuarioTemPermissao = new UsuarioTemPermissaoModel();
        public ContasAPagarPagas(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public void AtualizarGrid()
        {
            DataTable dataSource = contaAPagarController.ObterTodasContasAPagar();
            gridControl.DataSource = dataSource;
            gridControl.Refresh();
            bsiRecordsCount.Caption = "Registros : " + dataSource.Rows.Count;
        }
        private void NovaContaAPagar()
        {
            Views.NovaContaAPagar FormNovaContaAPagar = new NovaContaAPagar(usuarioLogado);
            FormNovaContaAPagar.ShowDialog();
        }
        private void EditarContaAPagar()
        {
            contaAPagar.IdContasApagar = Convert.ToInt32(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[0]));
            contaAPagar.Referentea = advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[3]).ToString();
            contaAPagar.Documento = advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[7]).ToString();
            contaAPagar.Observacao = advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[8]).ToString();
            contaAPagar.DataVencimento = Convert.ToDateTime(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[1]));
            contaAPagar.Valor = Convert.ToDecimal(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[2]));
            contaAPagar.categoriascontasapagar_idcategoriascontasapagar = Convert.ToInt32(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[10]));
            contaAPagar.clientespessoas_idclientespessoas = Convert.ToInt32(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[9]));

            Views.NovaContaAPagar FormEditarContaAPagar = new NovaContaAPagar(usuarioLogado,contaAPagar);
            FormEditarContaAPagar.ShowDialog();
        }
        private void DeletarContaAPagar()
        {
            contaAPagar.IdContasApagar = Convert.ToInt32(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[0]));
            if (advBandedGridViewContasAPagar.SelectedRowsCount == 1 && MessageBoxQuestionYesNo.Show("Confirmar deletar registro selecionado?") == DialogResult.Yes)
            {
                contaAPagarController.Deletar(contaAPagar);
                MessageBoxOK.Show("Deletado com sucesso!");
                AtualizarGrid();
            }
        }
        private void PagarContaAPagar()
        {
            if(advBandedGridViewContasAPagar.SelectedRowsCount == 1 && Convert.ToInt32(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[4])) == 0)
            {
                contaAPagar.IdContasApagar = Convert.ToInt32(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[0]));
                contaAPagar.DataVencimento = Convert.ToDateTime(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[1]));
                contaAPagar.Referentea = advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[3]).ToString();
                contaAPagar.Documento = advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[7]).ToString();
                contaAPagar.Observacao = advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[8]).ToString();
                contaAPagar.DataVencimento = Convert.ToDateTime(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[1]));
                contaAPagar.Valor = Convert.ToDecimal(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[2]));
                contaAPagar.clientespessoas_idclientespessoas = Convert.ToInt32(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[9]));
                contaAPagar.categoriascontasapagar_idcategoriascontasapagar = Convert.ToInt32(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[10]));
                contaAPagar.Valor = Convert.ToDecimal(advBandedGridViewContasAPagar.GetRowCellValue(advBandedGridViewContasAPagar.GetSelectedRows()[0], advBandedGridViewContasAPagar.Columns[2]));
                Views.PagamentoContaAPagar FormPagarConta = new PagamentoContaAPagar(usuarioLogado, contaAPagar);
                FormPagarConta.ShowDialog();
            }
            else
            {
                MessageBoxOK.Show("Débito já pago, favor selecione somente com status A Pagar!");
            }
            
        }
        private void ContasAPagar_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void ContasAPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void advBandedGridViewContasAPagar_DoubleClick(object sender, EventArgs e)
        {
            EditarContaAPagar();
        }

        private void advBandedGridViewContasAPagar_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "status")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - A Pagar";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Pago";
            }
        }

        private void advBandedGridViewContasAPagar_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (advBandedGridViewContasAPagar.SelectedRowsCount == 1)
            {
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                {
                    DXMenuItem item1 = new DXMenuItem("Nova Conta APagar");
                    DXMenuItem item2 = new DXMenuItem("Editar Conta APagar");
                    DXMenuItem item3 = new DXMenuItem("Deletar Conta APagar");
                    DXMenuItem item4 = new DXMenuItem("Atualizar Grid");
                    DXMenuItem item5 = new DXMenuItem("Pagar Conta APagar");
                    item1.Click += (o, args) =>
                    {
                        NovaContaAPagar();
                    };
                    item2.Click += (o, args) =>
                    {
                        EditarContaAPagar();
                    };
                    item3.Click += (o, args) =>
                    {
                        DeletarContaAPagar();
                    };
                    item4.Click += (o, args) =>
                    {
                        AtualizarGrid();
                    };
                    item5.Click += (o, args) =>
                    {
                        PagarContaAPagar();
                    };
                    e.Menu.Items.Add(item1);
                    e.Menu.Items.Add(item2);
                    e.Menu.Items.Add(item3);
                    e.Menu.Items.Add(item4);
                    e.Menu.Items.Add(item5);

                }
            }
        }

        private void bbiNovoDebito_ItemClick(object sender, ItemClickEventArgs e)
        {
            NovaContaAPagar();
        }

        private void bbiEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditarContaAPagar();
        }

        private void bbiDeletar_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeletarContaAPagar();
        }

        private void bbiAtualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            AtualizarGrid();
        }

        private void bbiPagar_ItemClick(object sender, ItemClickEventArgs e)
        {
            PagarContaAPagar();
        }
    }
}