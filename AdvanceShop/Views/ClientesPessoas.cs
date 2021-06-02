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
    public partial class ClientesPessoas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        ClientesPessoasModel clientePessoa = new ClientesPessoasModel();
        ClientesPessoasController clientePessoaController = new ClientesPessoasController();
        public ClientesPessoasModel clientePessoaPDV { get; set; }
        bool PDVAtivo = false;

        public ClientesPessoas(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            
        }
        public void AtualizarGrid()
        {
            DataTable dataSource = clientePessoaController.ObterTodosClientesPessoas();
            gridControl.DataSource = dataSource;
            gridControl.Refresh();
            bsiRecordsCount.Caption = "Registros : " + dataSource.Rows.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            Views.VendaCaixaPDV view = Application.OpenForms["VendaCaixaPDV"] as Views.VendaCaixaPDV;
            if (view != null)
            {
                PDVAtivo = true;
                bbiAdicionarClientePDV.Enabled = true;
                clientePessoaPDV = new ClientesPessoasModel();
            }
        }

        private void bbiNovoClientePessoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            NovoClientePessoa();
        }

        private void bbiEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditarClientePessoa();
        }

        private void bbiDeletar_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeletarClientePessoa();
        }

        private void bbiAtualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            AtualizarGrid();
        }
        private void NovoClientePessoa()
        {
            Views.NovoClientePessoa FormNovoClientePessoa = new NovoClientePessoa(usuarioLogado);
            FormNovoClientePessoa.ShowDialog();
        }
        private void EditarClientePessoa()
        {
            clientePessoa.IdClientesPessoas = Convert.ToInt32(advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[0]));
            clientePessoa.NomeClientePessoa = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[1]).ToString();
            clientePessoa.CPFCNPJ = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[4]).ToString();
            clientePessoa.RGIE = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[3]).ToString();
            clientePessoa.DataNascimento = Convert.ToDateTime(advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[2]));
            clientePessoa.Sexo = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[12]).ToString();
            clientePessoa.Contato1 = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[13]).ToString();
            clientePessoa.Contato2 = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[14]).ToString();
            clientePessoa.Email = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[15]).ToString();
            clientePessoa.Observacao = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[16]).ToString();
            clientePessoa.CEP = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[11]).ToString();
            clientePessoa.Endereco = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[5]).ToString();
            clientePessoa.NumeroCasa = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[6]).ToString();
            clientePessoa.Complemento = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[7]).ToString();
            clientePessoa.Bairro = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[8]).ToString();
            clientePessoa.Cidade = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[9]).ToString();
            clientePessoa.UF = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[10]).ToString();
            clientePessoa.StatusClientePessoa = Convert.ToInt32(advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[18]));
            clientePessoa.TipoPessoa = Convert.ToInt32(advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[17]));

            Views.NovoClientePessoa FormEditarClientePessoa = new NovoClientePessoa(usuarioLogado,clientePessoa);
            FormEditarClientePessoa.Show();
        }
        private void DeletarClientePessoa()
        {
            clientePessoa.IdClientesPessoas = Convert.ToInt32(advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[0]));
            if (advBandedGridViewClientesPessoas.SelectedRowsCount == 1 && MessageBoxQuestionYesNo.Show("Confirmar deletar registro selecionado?") == DialogResult.Yes)
            {
                clientePessoaController.Deletar(clientePessoa);
                MessageBoxOK.Show("Deletado com sucesso!");
                AtualizarGrid();
            }

        }
        private void ClientesPessoas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void advBandedGridViewClientesPessoas_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "status")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Inativo";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Ativo";
            }
            if (e.Column.FieldName == "tipopessoa")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Pessoa Física";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Pessoa Jurídica";
            }
        }
        private void AdicionarClientePDV()
        {
            if(advBandedGridViewClientesPessoas.SelectedRowsCount == 1)
            {
                clientePessoaPDV.IdClientesPessoas = Convert.ToInt32(advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[0]));
                clientePessoaPDV.NomeClientePessoa = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[1]).ToString();
                clientePessoaPDV.CPFCNPJ = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[4]).ToString();
                clientePessoaPDV.RGIE = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[3]).ToString();
                clientePessoaPDV.DataNascimento = Convert.ToDateTime(advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[2]));
                clientePessoaPDV.Sexo = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[12]).ToString();
                clientePessoaPDV.Contato1 = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[13]).ToString();
                clientePessoaPDV.Contato2 = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[14]).ToString();
                clientePessoaPDV.Email = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[15]).ToString();
                clientePessoaPDV.Observacao = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[16]).ToString();
                clientePessoaPDV.CEP = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[11]).ToString();
                clientePessoaPDV.Endereco = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[5]).ToString();
                clientePessoaPDV.NumeroCasa = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[6]).ToString();
                clientePessoaPDV.Complemento = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[7]).ToString();
                clientePessoaPDV.Bairro = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[8]).ToString();
                clientePessoaPDV.Cidade = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[9]).ToString();
                clientePessoaPDV.UF = advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[10]).ToString();
                clientePessoaPDV.StatusClientePessoa = Convert.ToInt32(advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[18]));
                clientePessoaPDV.TipoPessoa = Convert.ToInt32(advBandedGridViewClientesPessoas.GetRowCellValue(advBandedGridViewClientesPessoas.GetSelectedRows()[0], advBandedGridViewClientesPessoas.Columns[17]));

                DialogResult = DialogResult.OK;
            }
        }
        private void advBandedGridViewClientesPessoas_DoubleClick(object sender, EventArgs e)
        {
            if (PDVAtivo)
            {
                //Adicionar cliente na VENDA
                AdicionarClientePDV();
            }
            else
            {
                EditarClientePessoa();
            }
            
        }

        private void advBandedGridViewClientesPessoas_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (advBandedGridViewClientesPessoas.SelectedRowsCount == 1)
            {
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                {
                    DXMenuItem item1 = new DXMenuItem("Novo Usuário");
                    DXMenuItem item2 = new DXMenuItem("Editar Usuário");
                    DXMenuItem item3 = new DXMenuItem("Deletar Usuário");
                    DXMenuItem item4 = new DXMenuItem("Atualizar Grid");
                    if(PDVAtivo)
                    {
                        DXMenuItem item5 = new DXMenuItem("Adicionar Cliente ao PDV");
                        item5.Click += (o, args) =>
                        {
                            AdicionarClientePDV();
                        };
                        e.Menu.Items.Add(item5);
                    }
                    
                    item1.Click += (o, args) =>
                    {
                        NovoClientePessoa();
                    };
                    item2.Click += (o, args) =>
                    {
                        EditarClientePessoa();
                    };
                    item3.Click += (o, args) =>
                    {
                        DeletarClientePessoa();
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

        private void advBandedGridViewClientesPessoas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                AdicionarClientePDV();
            }
        }

        private void bbiAdicionarClientePDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            AdicionarClientePDV();
        }
    }
}