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
using AdvanceShop.Shared.Validation;

namespace AdvanceShop.Views
{
    public partial class FecharCaixa : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        CaixasModel caixa = new CaixasModel();
        CaixasController caixaController = new CaixasController();
        DataHoraModel dataHora = new DataHoraModel();
        EmailSistemaController emailController = new EmailSistemaController();
        EmailSistemaModel emailenvio = new EmailSistemaModel();
        UsuariosModel usuarioCaixa = new UsuariosModel();
        UsuariosController usuarioController = new UsuariosController();
        public FecharCaixa(UsuariosModel UsuarioLogado,DataHoraModel DataHora, CaixasModel Caixa)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            caixa = Caixa;
            dataHora = DataHora;
            txtSaldoFinalSistema.Text = Convert.ToString(caixa.SaldoFinal);
            Text = $"Fechar Caixa Código {caixa.IdCaixas} usuário do caixa {dataHora.usuariocadastro}";
            emailenvio = emailController.ObterConfiguracoesEmailSistema();
            usuarioCaixa.IdUsuarios = caixa.usuarios_idusuarios;
            usuarioCaixa = usuarioController.ObterDadosUsuarioPorNomeUsuario(usuarioCaixa);
        }
        
        private void FecharCaixa_Load(object sender, EventArgs e)
        {

        }
        private void AtualizarGrid()
        {
            Views.Caixas view = Application.OpenForms["Caixas"] as Views.Caixas;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void Salvar()
        {
            caixa.SaldoFinal = Convert.ToDecimal(txtSaldoFinalSistema.Text.Replace("R$", ""));
            caixa.ValorInformado = Convert.ToDecimal(txtSaldoFinal.Text.Replace("R$", ""));
            caixa.QuebraCaixa = Convert.ToDecimal(txtQuebraCaixa.Text.Replace("R$", ""));
            caixa.ObservacaoCaixa = txtObservacao.Text;
            caixa.status = 1;
            caixa.UsuarioFechamento = usuarioLogado.UsuarioAcesso;
            caixa.DataHoraFechamento = DateTime.Now;

            if (MessageBoxQuestionYesNo.Show($"Deseja salvar fechamento do caixa com valor informado {txtSaldoFinal.Text} é a quebra de caixa {txtQuebraCaixa.Text} ?") == DialogResult.Yes)
            {
                caixaController.FecharCaixa(caixa);
                MessageBoxOK.Show("Fechado com sucesso!");
                if (ValidacaoConexaoInternet.EstarConectado())
                {
                    Shared.CustomPrint.FechamentoCaixa.EnviarFechamentoCaixa(caixa,usuarioCaixa, emailenvio);
                }
                else
                {
                    Shared.CustomPrint.FechamentoCaixa.ImprimirFechamentoCaixa(caixa);
                }

                AtualizarGrid();

                Close();
            }
            //try
            //{
                
            //}
            //catch (Exception error)
            //{
            //    MessageBoxError.Show(error.Message);
            //}

        }
        private void FecharCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void FecharCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                Salvar();
            }
        }

        private void btnContadorDinheiro_Click(object sender, EventArgs e)
        {
            Views.ContadorDinheiro FormContadorDinheiro = new ContadorDinheiro();
            FormContadorDinheiro.Show();
        }

        private void txtSaldoFinal_EditValueChanged(object sender, EventArgs e)
        {
            decimal quebracaixa, saldofinal, saldofinalsistema;
            saldofinal = Convert.ToDecimal(txtSaldoFinal.Text.Replace("R$", ""));
            saldofinalsistema = Convert.ToDecimal(txtSaldoFinalSistema.Text.Replace("R$", ""));
            quebracaixa = saldofinalsistema - saldofinal;
            txtQuebraCaixa.Text = Convert.ToString(quebracaixa);
        }

        private void txtSaldoFinal_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSaldoFinalSistema_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void txtQuebraCaixa_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSaldoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoCamposCustom.StringKeyPressNumeroPontoVirgula(sender, e);
        }

        private void txtSaldoFinalSistema_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoCamposCustom.StringKeyPressNumeroPontoVirgula(sender, e);
        }

        private void txtQuebraCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoCamposCustom.StringKeyPressNumeroPontoVirgula(sender, e);
        }
    }
}
