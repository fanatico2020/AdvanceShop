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
using AdvanceShop.Shared.Validation;
using AdvanceShop.Controllers;
using AdvanceShop.Shared.CustomMessageBox;
using DevExpress.Utils.Menu;

namespace AdvanceShop.Views
{
    public partial class Caixas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        CaixasModel caixa = new CaixasModel();
        CaixasController caixaController = new CaixasController();
        UsuarioTemPermissaoModel usuarioTemPermissao = new UsuarioTemPermissaoModel();
        public Caixas(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;

        }
        public void AtualizarGrid()
        {
            DataTable dataSource = caixaController.ObterTodosCaixas();
            gridControl.DataSource = dataSource;
            gridControl.Refresh();
            bsiRecordsCount.Caption = "Registros : " + dataSource.Rows.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void Caixas_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        private void NovoCaixa()
        {
            caixa.usuarios_idusuarios = usuarioLogado.IdUsuarios;
            caixa = caixaController.AutenticarCaixaUsuario(caixa);
            if(!caixa.caixaAberto)
            {
                Views.AbrirCaixa FormAbrirCaixa = new AbrirCaixa(usuarioLogado);
                FormAbrirCaixa.ShowDialog();
            }
            else
            {
                MessageBoxWarning.Show($"Já existe um caixa aberto para o seu usuário na maquina {caixa.Maquina}, Código do caixa {caixa.IdCaixas}, você deve fechar o caixa aberto para iniciar um novo!");
            }
            
        }
        private void EditarCaixa()
        {

            caixa.IdCaixas = Convert.ToInt32(advBandedGridViewCaixas.GetRowCellValue(advBandedGridViewCaixas.GetSelectedRows()[0], advBandedGridViewCaixas.Columns[0]));
            caixa.SaldoInicial = Convert.ToDecimal(advBandedGridViewCaixas.GetRowCellValue(advBandedGridViewCaixas.GetSelectedRows()[0], advBandedGridViewCaixas.Columns[2]));
            if(advBandedGridViewCaixas.SelectedRowsCount == 1 && Convert.ToInt32(advBandedGridViewCaixas.GetRowCellValue(advBandedGridViewCaixas.GetSelectedRows()[0], advBandedGridViewCaixas.Columns[12])) == 0)
            {
                Views.AbrirCaixa FormEditaSaldoInicial = new AbrirCaixa(usuarioLogado, caixa);
                FormEditaSaldoInicial.ShowDialog();
            }
            else
            {
                MessageBoxWarning.Show("Só e permitido editar saldo inicial de caixa com status 0 - Aberto!");
            }
            

        }
        private void DeletarCaixa()
        {
            caixa.IdCaixas = Convert.ToInt32(advBandedGridViewCaixas.GetRowCellValue(advBandedGridViewCaixas.GetSelectedRows()[0], advBandedGridViewCaixas.Columns[0]));
            
            if (advBandedGridViewCaixas.SelectedRowsCount == 1 && MessageBoxQuestionYesNo.Show("Confirmar deletar registro selecionado?") == DialogResult.Yes)
            {
                caixaController.Deletar(caixa);
                MessageBoxOK.Show("Deletado com sucesso!");
                AtualizarGrid();
            }
            
        }
        private void TransacoesCaixa()
        {

            caixa.IdCaixas = Convert.ToInt32(advBandedGridViewCaixas.GetRowCellValue(advBandedGridViewCaixas.GetSelectedRows()[0], advBandedGridViewCaixas.Columns[0]));
            
            Views.TransacoesCaixa FormTransacoesCaixa = new TransacoesCaixa(usuarioLogado,caixa);
            FormTransacoesCaixa.ShowDialog();
        }
        private void bbiAbrirCaixa_ItemClick(object sender, ItemClickEventArgs e)
        {
            NovoCaixa();
        }

        private void bbiEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditarCaixa();
        }

        private void bbiDeletar_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeletarCaixa();
        }

        private void bbiAtualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            AtualizarGrid();
        }

        private void Caixas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void advBandedGridViewCaixas_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "status")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Aberto";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Fechado";
            }
        }

        private void advBandedGridViewCaixas_DoubleClick(object sender, EventArgs e)
        {
            EditarCaixa();
        }

        private void advBandedGridViewCaixas_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (advBandedGridViewCaixas.SelectedRowsCount == 1)
            {
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                {
                    DXMenuItem item1 = new DXMenuItem("Abrir Caixa");
                    DXMenuItem item2 = new DXMenuItem("Editar Saldo Inicial");
                    DXMenuItem item3 = new DXMenuItem("Deletar Caixa");
                    DXMenuItem item4 = new DXMenuItem("Atualizar Grid");
                    DXMenuItem item5 = new DXMenuItem("Transações Caixa");
                    
                    item1.Click += (o, args) =>
                    {
                        NovoCaixa();
                    };
                    item2.Click += (o, args) =>
                    {
                        EditarCaixa();
                    };
                    item3.Click += (o, args) =>
                    {
                        DeletarCaixa();
                    };
                    item4.Click += (o, args) =>
                    {
                        AtualizarGrid();
                    };
                    item5.Click += (o, args) =>
                    {
                        TransacoesCaixa();
                    };
                    e.Menu.Items.Add(item1);
                    e.Menu.Items.Add(item2);
                    e.Menu.Items.Add(item3);
                    e.Menu.Items.Add(item4);

                }
            }
        }

        private void bbiTransacoesCaixa_ItemClick(object sender, ItemClickEventArgs e)
        {
            TransacoesCaixa();
        }
    }
}