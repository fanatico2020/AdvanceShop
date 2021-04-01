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
    public partial class SuplementoSangria : DevExpress.XtraEditors.XtraForm
    {
        TransacoesCaixaModel transacaoCaixa = new TransacoesCaixaModel();
        TransacoesCaixaController transacaoCaixaController = new TransacoesCaixaController();
        UsuariosModel usuarioLogado = new UsuariosModel();
        string SuplementoOuSangria = "";
        public SuplementoSangria(TransacoesCaixaModel TransacaoCaixa,UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            transacaoCaixa.caixas_idcaixas = TransacaoCaixa.caixas_idcaixas;
            transacaoCaixa.Tipo = TransacaoCaixa.Tipo;
            if(transacaoCaixa.Tipo == 1)
            {
                
                Text = "Adiconar dinheiro";
                SuplementoOuSangria = "Suplemento/Adicionar Dinheiro";
                transacaoCaixa.DescricaoTransacao = "Suplemento, Dinheiro adicionado ao caixa";
            }
            else if(transacaoCaixa.Tipo == 0)
            {
                
                Text = "Retirar dinheiro";
                SuplementoOuSangria = "Sangria/Retirar Dinheiro";
                transacaoCaixa.DescricaoTransacao = "Sangria, Dinheiro retirado do caixa";
                //txtValor.Text = Convert.ToString(TransacaoCaixa.SaldoEmDinheiro);
                transacaoCaixa.SaldoEmDinheiro = TransacaoCaixa.SaldoEmDinheiro;
            }
        }
        private void txtValor_EditValueChanged(object sender, EventArgs e)
        {
            if(Text == "Retirar dinheiro" && Convert.ToDecimal(txtValor.Text.Replace("R$","")) > transacaoCaixa.SaldoEmDinheiro && txtValor.Text.Length > transacaoCaixa.SaldoEmDinheiro.ToString().Length)
            {
                MessageBoxWarning.Show($"Não tem como retira do caixa um valor maior do que se tem no caixa em dinheiro!, seu saldo atual em espécie e R${transacaoCaixa.SaldoEmDinheiro} ");
                btnSalvar.Enabled = false;
                txtValor.Focus();
            }
            else
            {
                btnSalvar.Enabled = true;
            }
        }
        private void AtualizarGrid()
        {
            Views.TransacoesCaixa view = Application.OpenForms["TransacoesCaixa"] as Views.TransacoesCaixa;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void SuplementoSangria_Load(object sender, EventArgs e)
        {
            txtValor.Focus();
        }

        private void SuplementoSangria_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                transacaoCaixa.Valor = Convert.ToDecimal(txtValor.Text.Replace("R$", ""));
                transacaoCaixa.ObservacaoTransacao = txtObservacao.Text;
                transacaoCaixa.Status = 1;
                if (transacaoCaixa.Valor > 0 && MessageBoxQuestionYesNo.Show($"Deseja salvar?") == DialogResult.Yes)
                {
                    transacaoCaixaController.Adicionar_SuplementoSangria(transacaoCaixa, usuarioLogado);
                    MessageBoxOK.Show("Salvo com sucesso!");
                    AtualizarGrid();
                    Close();
                }
                else
                {
                    MessageBoxWarning.Show($"Informe um valor maior que R$0,00, não faz sentido {SuplementoOuSangria} com valor zerado...");
                }
            }
            catch (System.FormatException)
            {

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
