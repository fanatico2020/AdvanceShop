using AdvanceShop.Controllers;
using AdvanceShop.Models;
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
    public partial class PagamentoContaAPagar : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        ContasAPagarModel contaAPagar = new ContasAPagarModel();
        ContasAPagarController contaAPagarController = new ContasAPagarController();
        //ClientesPessoasModel clientePessoa = new ClientesPessoasModel();
        ClientesPessoasController clientePessoaController = new ClientesPessoasController();

        public PagamentoContaAPagar(UsuariosModel UsuarioLogado,ContasAPagarModel ContaAPagar)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            contaAPagar = ContaAPagar;
            cbxFornecedor.EditValue = ContaAPagar.clientespessoas_idclientespessoas;
            txtReferentea.Text = ContaAPagar.Referentea;
            txtDocumento.Text = ContaAPagar.Documento;
            txtObservacao.Text = ContaAPagar.Observacao;
            txtValor.Text = Convert.ToString(ContaAPagar.Valor);
            txtVencimento.DateTime = Convert.ToDateTime(ContaAPagar.DataVencimento);
            txtPagamento.DateTime = DateTime.Now;
        }
        private void AtualizarFornecedor()
        {
            cbxFornecedor.Properties.DataSource = clientePessoaController.ObterTodosClientesPessoas();
            cbxFornecedor.Properties.DisplayMember = "nome";
            cbxFornecedor.Properties.ValueMember = "idclientespessoas";

        }
        private void AtualizarGrid()
        {
            Views.ContasAPagar view = Application.OpenForms["ContasAPagar"] as Views.ContasAPagar;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void PagamentoContaAPagar_Load(object sender, EventArgs e)
        {
            AtualizarFornecedor();
        }

        private void cbxAbaterValorCaixaAtual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                contaAPagar.ValorPago = Convert.ToDecimal(txtValorPago.Text.Replace("R$", ""));
                contaAPagar.DataRecebimento = txtPagamento.DateTime;
                contaAPagar.Observacao = txtObservacao.Text;
                contaAPagar.Status = 1;

                ValidacaoCampos.Validar(contaAPagar);
                if (ValidacaoCampos.IsValid() && MessageBoxQuestionYesNo.Show($"Deseja salvar?") == DialogResult.Yes)
                {
                    contaAPagarController.EditarEfetuarPagamento(contaAPagar,usuarioLogado);
                    MessageBoxOK.Show("Salvo com sucesso!");
                    AtualizarGrid();
                    Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBoxError.Show($"{ex.Message} Informe um valor de pagamento valido!");
            }
            
        }

        private void PagamentoContaAPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void cbxFornecedor_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                Views.ClientesPessoas FormClientesPessoas = new ClientesPessoas(usuarioLogado);
                FormClientesPessoas.ShowDialog();
            }
        }

        private void txtValorPago_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoCamposCustom.StringKeyPressNumeroPontoVirgula(sender, e);
        }
    }
}
