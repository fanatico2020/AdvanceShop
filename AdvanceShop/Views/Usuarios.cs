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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AdvanceShop.Views
{
    public partial class Usuarios : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UsuariosModel usuario = new UsuariosModel();
        UsuariosModel usuarioLogado = new UsuariosModel();
        UsuariosController usuarioController = new UsuariosController();
        PermissoesController permissoesController = new PermissoesController();
        UsuarioTemPermissaoModel usuarioTemPermissaoModel = new UsuarioTemPermissaoModel();
        UsuarioTemPermissaoModel usuarioTemPermissao = new UsuarioTemPermissaoModel();
        public Usuarios(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            usuarioTemPermissao.usuarios_idusuarios = UsuarioLogado.IdUsuarios;

        }
        public void AtualizarGrid()
        {
            DataTable dataSource = usuarioController.ObterTodosUsuarios();
            gridControlUsuarios.DataSource = dataSource;
            bsiRecordsCount.Caption = "Registros : " + dataSource.Rows.Count;
        }
        
        
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControlUsuarios.ShowRibbonPrintPreview();
        }
        
        private void Usuarios_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void bbiNovoUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            NovoUsuario();
        }

        private void bbiDeletarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeletarUsuario();
            
        }

        private void bbiAtualizarGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            AtualizarGrid();
        }

        private void bbiAtivarDesativarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            AtivarDesativarUsuario();
        }
        private void AtivarDesativarUsuario()
        {
            usuarioTemPermissao.permissoes_idpermissoes = 30;
            if (UsuarioTemPermissaoController.AutenticarPermissao(usuarioTemPermissao))
            {
                string msg;
                usuario.IdUsuarios = Convert.ToInt32(advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[0]));
                usuario.Status = Convert.ToInt32(advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[7]));
                usuario.UsuarioAcesso = advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[1]).ToString();
                if (usuario.Status == 1)
                {
                    msg = $"Confirmar desativar a conta do usuário {usuario.UsuarioAcesso} ?";
                    usuario.Status = 0;
                }
                else
                {
                    msg = $"Confirmar ativar a conta do usuário {usuario.UsuarioAcesso} ?";
                    usuario.Status = 1;
                }
                if (MessageBoxQuestionYesNo.Show(msg) == DialogResult.Yes)
                {
                    usuarioController.EditarStatus(usuario, usuarioLogado);
                    AtualizarGrid();
                }
            }
            

        }
        private void NovoUsuario()
        {
            usuarioTemPermissao.permissoes_idpermissoes = 27;
            if (UsuarioTemPermissaoController.AutenticarPermissao(usuarioTemPermissao))
            {
                Views.NovoUsuario FormNovoUsuario = new NovoUsuario(usuarioLogado);
                FormNovoUsuario.ShowDialog();
            }
            
        }
        private void EditarUsuario()
        {
            usuarioTemPermissao.permissoes_idpermissoes = 28;
            if (UsuarioTemPermissaoController.AutenticarPermissao(usuarioTemPermissao))
            {
                usuario.IdUsuarios = Convert.ToInt32(advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[0]));
                usuario.UsuarioAcesso = advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[1]).ToString();
                usuario.NomeCompleto = advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[2]).ToString();
                usuario.Email = advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[3]).ToString();
                usuario.Contato = advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[4]).ToString();
                usuario.DescontoMaximo = Convert.ToDecimal(advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[5]));
                usuario.UsaDescontoMaximo = Convert.ToInt32(advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[6]));
                usuario.Status = Convert.ToInt32(advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[7]));
                usuario.SenhaAcesso = advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[12]).ToString();
                Views.NovoUsuario FormNovoEditarUsuario = new NovoUsuario(usuarioLogado, usuario);
                FormNovoEditarUsuario.ShowDialog();
            }
            
        }
        private void DeletarUsuario()
        {
            usuarioTemPermissao.permissoes_idpermissoes = 29;
            if (UsuarioTemPermissaoController.AutenticarPermissao(usuarioTemPermissao))
            {
                usuario.IdUsuarios = Convert.ToInt32(advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[0]));
                if (advBandedGridViewUsuarios.SelectedRowsCount == 1 && MessageBoxQuestionYesNo.Show("Confirmar deletar registro selecionado?") == DialogResult.Yes)
                {
                    usuarioController.Deletar(usuario);
                    MessageBoxOK.Show("Deletado com sucesso!");
                    AtualizarGrid();
                }
            }
            

        }
        private void ClonarUsuario()
        {
            usuarioTemPermissao.permissoes_idpermissoes = 32;
            if (UsuarioTemPermissaoController.AutenticarPermissao(usuarioTemPermissao))
            {
                MessageBoxOK.Show("Em desenvolvimento...");
            }
            
        }
        private void bbiEditarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditarUsuario();
        }

        private void bbiClonarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClonarUsuario();
        }
        private void advBandedGridViewUsuarios_DoubleClick(object sender, EventArgs e)
        {
            EditarUsuario();
        }


        private void Usuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }


        private void PermitirNaoPermitir(int status)
        {
            usuarioTemPermissao.permissoes_idpermissoes = 31;
            if (UsuarioTemPermissaoController.AutenticarPermissao(usuarioTemPermissao))
            {
                var detailView = gridControlUsuarios.FocusedView as GridView;
                if (detailView.GetRowCellValue(detailView.GetSelectedRows()[0], gridViewPermissoes.Columns[0]) != null)
                {
                    usuarioTemPermissaoModel.status = status;
                    usuarioTemPermissaoModel.permissoes_idpermissoes = Convert.ToInt32(detailView.GetFocusedRowCellValue(gridViewPermissoes.Columns[0]));
                    usuarioTemPermissaoModel.usuarios_idusuarios = Convert.ToInt32(advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[0]));
                    UsuarioTemPermissaoController.EditarPermissaoSimNao(usuarioTemPermissaoModel);
                    AtualizarGrid();
                }
            }
            
        }
        private void bbiPermitir_ItemClick(object sender, ItemClickEventArgs e)
        {
            PermitirNaoPermitir(1);
        }

        private void bbiNaoPermitir_ItemClick(object sender, ItemClickEventArgs e)
        {
            PermitirNaoPermitir(0);
        }

        private void advBandedGridViewUsuarios_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "status")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Inativo";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Ativo";
            }

            if (e.Column.FieldName == "usadescontomaximo")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Não";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Sim";
            }
            if (e.Column.FieldName == "descontomaximo")
            {
                e.DisplayText = $"{e.Value}%";
            }
        }

        private void gridViewPermissoes_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "status")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Não";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Sim";
            }
        }

        private void advBandedGridViewUsuarios_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void advBandedGridViewUsuarios_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            usuario.IdUsuarios = Convert.ToInt32(advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[0]));
            if (e.RelationIndex == 0)
            {
                e.ChildList = new BindingSource(permissoesController.ObterTodasPermissoesUsuario(usuario), "");
            }
        }

        private void advBandedGridViewUsuarios_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            try
            {
                if (e.RelationIndex == 0)
                {
                    e.RelationName = $"Permissões {advBandedGridViewUsuarios.GetRowCellValue(advBandedGridViewUsuarios.GetSelectedRows()[0], advBandedGridViewUsuarios.Columns[1])}";
                }
            }
            catch (System.IndexOutOfRangeException)
            {

            }
            catch (System.NullReferenceException)
            {

            }
        }

        private void advBandedGridViewUsuarios_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            if (e.RelationIndex == 0)
            {
                e.IsEmpty = false;
            }
        }

        private void advBandedGridViewUsuarios_MasterRowGetLevelDefaultView(object sender, MasterRowGetLevelDefaultViewEventArgs e)
        {
            e.DefaultView = gridViewPermissoes;
        }

        private void advBandedGridViewUsuarios_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (advBandedGridViewUsuarios.SelectedRowsCount == 1)
            {
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                {
                    DXMenuItem item1 = new DXMenuItem("Novo Usuário");
                    DXMenuItem item2 = new DXMenuItem("Editar Usuário");
                    DXMenuItem item3 = new DXMenuItem("Deletar Usuário");
                    DXMenuItem item4 = new DXMenuItem("Atualizar Grid");
                    DXMenuItem item5 = new DXMenuItem("Clonar Usuário");
                    DXMenuItem item6 = new DXMenuItem("Ativar / Desativar Usuário");

                    item1.Click += (o, args) =>
                    {
                        NovoUsuario();
                    };
                    item2.Click += (o, args) =>
                    {
                        EditarUsuario();
                    };
                    item3.Click += (o, args) =>
                    {
                        DeletarUsuario();
                    };
                    item4.Click += (o, args) =>
                    {
                        AtualizarGrid();
                    };
                    item5.Click += (o, args) =>
                    {
                        ClonarUsuario();
                    };
                    item6.Click += (o, args) =>
                    {
                        AtivarDesativarUsuario();
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
    }
}