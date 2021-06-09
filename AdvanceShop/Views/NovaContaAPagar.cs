using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomInputBox;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Validation;
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
    public partial class NovaContaAPagar : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        ContasAPagarModel contaAPagar = new ContasAPagarModel();
        ContasAPagarController contaAPagarController = new ContasAPagarController();
        CategoriasContasAPagarController categoriaContaAPagarController = new CategoriasContasAPagarController();
        CategoriasContasAPagarModel categoriaContaApagar = new CategoriasContasAPagarModel();
        ClientesPessoasController clientePessoaController = new ClientesPessoasController();
        bool edicao = false;
        public NovaContaAPagar(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            txtQtdMesesRepetir.Enabled = false;
            txtVencimento.EditValue = DateTime.Now;
        }
        public NovaContaAPagar(UsuariosModel UsuarioLogado,ContasAPagarModel ContaAPagarEdicao)
        {
            InitializeComponent();
            edicao = true;
            usuarioLogado = UsuarioLogado;
            contaAPagar.IdContasApagar = ContaAPagarEdicao.IdContasApagar;
            txtReferentea.Text = ContaAPagarEdicao.Referentea;
            txtDocumento.Text = ContaAPagarEdicao.Documento;
            txtObservacao.Text = ContaAPagarEdicao.Observacao;
            txtVencimento.DateTime = ContaAPagarEdicao.DataVencimento;
            txtValor.Text = Convert.ToString(ContaAPagarEdicao.Valor);
            cbxCategoria.EditValue = Convert.ToInt32(ContaAPagarEdicao.categoriascontasapagar_idcategoriascontasapagar);
            cbxFornecedor.EditValue = Convert.ToInt32(ContaAPagarEdicao.clientespessoas_idclientespessoas);

            tsRepetirLancamento.Enabled = false;
            txtQtdMesesRepetir.Enabled = false;
        }
        private void AtualizarGrid()
        {
            Views.ContasAPagarPagas view = Application.OpenForms["ContasAPagar"] as Views.ContasAPagarPagas;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void cbxFornecedor_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                Views.ClientesPessoas FormClientesPessoas = new ClientesPessoas(usuarioLogado);
                FormClientesPessoas.ShowDialog();
            }
        }
        private void AtualizarFornecedor()
        {
            cbxFornecedor.Properties.DataSource = clientePessoaController.ObterTodosClientesPessoas();
            cbxFornecedor.Properties.DisplayMember = "nome";
            cbxFornecedor.Properties.ValueMember = "idclientespessoas";

        }
        private void AtualizarCategoriaContaAPagar()
        {
            cbxCategoria.Properties.DataSource = categoriaContaAPagarController.ObterTodasCategorias();
            cbxCategoria.Properties.DisplayMember = "descricaocategoria";
            cbxCategoria.Properties.ValueMember = "idcategoriascontasapagar";
        }
        private void NovaContaAPagar_Load(object sender, EventArgs e)
        {
            AtualizarFornecedor();
            AtualizarCategoriaContaAPagar();
            txtReferentea.Focus();
        }

        private void NovaContaAPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }
        private void Salvar()
        {
            try
            {
                if(MessageBoxQuestionYesNo.Show($"Deseja salvar?") == DialogResult.Yes)
                {
                    if(!edicao)
                        txtVencimento.EditValue = txtVencimento.DateTime.AddMonths(-1);
                    for (int i = 1; i <= Convert.ToInt32(txtQtdMesesRepetir.Text); i++)
                    {
                        
                        contaAPagar.Referentea = txtReferentea.Text;
                        contaAPagar.Documento = txtDocumento.Text;
                        contaAPagar.Observacao = txtObservacao.Text;
                        contaAPagar.DataVencimento = Convert.ToDateTime(txtVencimento.DateTime);//validação
                        contaAPagar.Valor = Convert.ToDecimal(txtValor.Text.Replace("R$", ""));
                        contaAPagar.categoriascontasapagar_idcategoriascontasapagar = Convert.ToInt32(cbxCategoria.EditValue);
                        contaAPagar.clientespessoas_idclientespessoas = Convert.ToInt32(cbxFornecedor.EditValue);
                        
                        //gambiara
                        contaAPagar.DataRecebimento = DateTime.Now;
                        contaAPagar.ValorPago = 1;

                        ValidacaoCampos.Validar(contaAPagar);
                        if (ValidacaoCampos.IsValid())
                        {
                            if (!edicao)
                            {

                                contaAPagar.DataVencimento = Convert.ToDateTime(txtVencimento.EditValue = txtVencimento.DateTime.AddMonths(1));
                                contaAPagarController.Adicionar(contaAPagar, usuarioLogado);
                            }
                            else
                            {
                                contaAPagar.DataVencimento = Convert.ToDateTime(txtVencimento.DateTime);
                                contaAPagarController.Editar(contaAPagar, usuarioLogado);
                            }
                            
                        }
                    }
                    if (ValidacaoCampos.IsValid())
                    {
                        MessageBoxOK.Show("Salvo com sucesso!");
                        AtualizarGrid();
                        Close();
                    }
                    
                }
                
            }
            catch (Exception error)
            {

                MessageBoxError.Show(error.Message);
            }
            //catch (FormatException)
            //{
            //    MessageBoxError.Show("Informe um valor valido!");
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    MessageBoxError.Show($"Informe um vencimento valido!");
            //}

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();

        }

        private void NovaCategoriaContaAPagar()
        {
            categoriaContaApagar.DescricaoCategoria = InputBoxTextEdit.Show("Descrição", "Nova Categoria");
            ValidacaoCampos.Validar(categoriaContaApagar);
            if (ValidacaoCampos.IsValid() && MessageBoxQuestionYesNo.Show($"Deseja salvar nova categoria?") == DialogResult.Yes)
            {
                categoriaContaAPagarController.Adicionar(categoriaContaApagar);
                MessageBoxOK.Show("Salvo com sucesso!");
                AtualizarCategoriaContaAPagar();
            }

        }
        private void DeletarCategoriaContaAPagar()
        {
            categoriaContaApagar.IdCategoriascontasapagar = Convert.ToInt32(cbxCategoria.EditValue);
            if (MessageBoxQuestionYesNo.Show("Confirmar deletar categoria selecionada?") == DialogResult.Yes)
            {
                categoriaContaAPagarController.Deletar(categoriaContaApagar);
                MessageBoxOK.Show("Deletado com sucesso!");
                AtualizarCategoriaContaAPagar();
            }

        }
        private void cbxCategoria_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                DeletarCategoriaContaAPagar();
            }
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                NovaCategoriaContaAPagar();
            }
        }

        private void cbxFornecedor_DoubleClick(object sender, EventArgs e)
        {
            AtualizarFornecedor();
        }

        private void NovaContaAPagar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                Salvar();
            }
        }

        private void tsRepetirLancamento_Toggled(object sender, EventArgs e)
        {
            if (tsRepetirLancamento.IsOn)
            {
                txtQtdMesesRepetir.Enabled = true;
                
            }
            else
            {
                txtQtdMesesRepetir.Enabled = false;
                txtQtdMesesRepetir.Text = "1";
            }
        }

        private void txtValor_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoCamposCustom.StringKeyPressNumeroPontoVirgula(sender, e);

        }
    }
}
