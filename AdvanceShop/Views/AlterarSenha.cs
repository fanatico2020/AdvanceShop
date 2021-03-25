using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Library;
using AdvanceShop.Shared.Validation;
using System;
using System.Windows.Forms;

namespace AdvanceShop.Views
{
    public partial class AlterarSenha : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        UsuariosController usuarioController = new UsuariosController();
        public AlterarSenha(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            this.Text = $"{Text} usuário {usuarioLogado.UsuarioAcesso}";
        }

        private void AlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void txtSenhaAcessoAtual_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarSenha.SenhaTextEdit(txtSenhaAcessoAtual);
        }

        private void txtSenhaAcessoAtual_MouseMove(object sender, MouseEventArgs e)
        {
            MostrarSenha.MensagemToolTipTextEdit(txtSenhaAcessoAtual);
        }

        private void txtNovaSenhaAcesso_TextChanged(object sender, EventArgs e)
        {
            ValidacaoForcaSenha.IncrementDecrementScoreProgressBar(pbcForcaSenha, txtNovaSenhaAcesso.Text);
        }

        private void txtNovaSenhaAcesso_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarSenha.SenhaTextEdit(txtNovaSenhaAcesso);
        }

        private void txtNovaSenhaAcesso_MouseMove(object sender, MouseEventArgs e)
        {
            MostrarSenha.MensagemToolTipTextEdit(txtNovaSenhaAcesso);
        }


        private void txtConfimarNovaSenha_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarSenha.SenhaTextEdit(txtConfimarNovaSenha);
        }

        private void txtConfimarNovaSenha_MouseMove(object sender, MouseEventArgs e)
        {
            MostrarSenha.MensagemToolTipTextEdit(txtConfimarNovaSenha);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNovaSenhaAcesso.Text == txtConfimarNovaSenha.Text)
            {
                //As senhas conferem
                usuarioLogado.SenhaAcesso = txtNovaSenhaAcesso.Text;
                ValidacaoCampos.Validar(usuarioLogado);
                if (ValidacaoCampos.IsValid() && MessageBoxQuestionYesNo.Show($"Deseja salvar?") == DialogResult.Yes)
                {
                    usuarioController.EditarSenha(usuarioLogado);
                    MessageBoxOK.Show("Senha alterada com sucesso!");
                    Close();
                }
                    
                
            }
            else
            {
                //As senhas não conferem
                MessageBoxError.Show("As novas senhas não conferem!");
            }
        }

        private void txtSenhaAcessoAtual_Leave(object sender, EventArgs e)
        {
            usuarioLogado.SenhaAcesso = txtSenhaAcessoAtual.Text;
            if (!usuarioController.AutenticarSenha(usuarioLogado))
            {
                MessageBoxError.Show("Senha atual não conferem!");
            }
        }
    }
}
