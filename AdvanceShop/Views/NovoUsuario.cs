using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Properties;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Library;
using AdvanceShop.Shared.Validation;
using DevExpress.XtraEditors;
using Microsoft.AspNetCore.Identity;
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
    
    public partial class NovoUsuario : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuario = new UsuariosModel();
        UsuariosModel usuarioLogado = new UsuariosModel();
        UsuariosController usuarioController = new UsuariosController();
        bool edicao = false;
        public NovoUsuario(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            
        }
        public NovoUsuario(UsuariosModel UsuarioLogado,UsuariosModel UsuarioEdicao)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            edicao = true;
            usuario.IdUsuarios = UsuarioEdicao.IdUsuarios;
            txtUsuarioAcesso.Text = UsuarioEdicao.UsuarioAcesso;
            txtSenhaAcesso.Text = UsuarioEdicao.SenhaAcesso;
            txtConfirmarSenhaAcesso.Text = UsuarioEdicao.SenhaAcesso;
            txtNomeCompleto.Text = UsuarioEdicao.NomeCompleto;
            txtEmail.Text = UsuarioEdicao.Email;
            txtConfirmarEmail.Text = UsuarioEdicao.Email;
            txtNumeroContato.Text = UsuarioEdicao.Contato;
            tsDescontoMaximoPorVenda.IsOn = Convert.ToBoolean(UsuarioEdicao.UsaDescontoMaximo);
            txtDescontoMaximoPorVenda.Text = Convert.ToString(UsuarioEdicao.DescontoMaximo);

        }
        private void AtualizarGrid()
        {
            Views.Usuarios view = Application.OpenForms["Usuarios"] as Views.Usuarios;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void NovoUsuario_Load(object sender, EventArgs e)
        {
            txtUsuarioAcesso.Focus();
        }

        private void txtSenhaAcesso_TextChanged(object sender, EventArgs e)
        {
            ValidacaoForcaSenha.IncrementDecrementScoreProgressBar(pbcForcaSenha,txtSenhaAcesso.Text);
        }

        private void txtSenhaAcesso_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarSenha.SenhaTextEdit(txtSenhaAcesso);
        }

        private void txtSenhaAcesso_MouseMove(object sender, MouseEventArgs e)
        {
            MostrarSenha.MensagemToolTipTextEdit(txtSenhaAcesso);
        }

        private void txtConfirmarSenhaAcesso_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarSenha.SenhaTextEdit(txtConfirmarSenhaAcesso);
        }

        private void txtConfirmarSenhaAcesso_MouseMove(object sender, MouseEventArgs e)
        {
            MostrarSenha.MensagemToolTipTextEdit(txtConfirmarSenhaAcesso);
        }
        private void Salvar()
        {
            try
            {
                usuario.UsuarioAcesso = txtUsuarioAcesso.Text;
                usuario.SenhaAcesso = txtSenhaAcesso.Text;
                usuario.NomeCompleto = txtNomeCompleto.Text;
                usuario.Email = txtEmail.Text;
                usuario.Contato = txtNumeroContato.Text.Trim();
                usuario.UsaDescontoMaximo = Convert.ToInt32(tsDescontoMaximoPorVenda.EditValue);
                usuario.DescontoMaximo = Convert.ToDecimal(txtDescontoMaximoPorVenda.Text.Replace("%", ""));
                usuario.Status = 1;
                ValidacaoCampos.Validar(usuario);
                if (ValidacaoCampos.IsValid() && MessageBoxQuestionYesNo.Show($"Deseja salvar?") == DialogResult.Yes)
                {
                    if (!edicao)
                    {
                        usuarioController.Adicionar(usuario, usuarioLogado);
                    }
                    else
                    {
                        usuarioController.Editar(usuario, usuarioLogado);
                    }

                    MessageBoxOK.Show("Salvo com sucesso!");
                    AtualizarGrid();
                    Close();
                }
            }
            catch (Exception error)
            {
                MessageBoxError.Show(error.Message);
            }
            
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void txtConfirmarSenhaAcesso_Leave(object sender, EventArgs e)
        {
            if(txtConfirmarSenhaAcesso.Text == txtSenhaAcesso.Text)
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
                MessageBoxOK.Show("As senhas não conferem!");
                return;
            }
        }

        private void txtConfirmarEmail_Leave(object sender, EventArgs e)
        {
            if(txtConfirmarEmail.Text == txtEmail.Text)
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
                MessageBoxOK.Show("Os e-mail não conferem!");
                return;
            }
        }

        private void txtUsuarioAcesso_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void txtDescontoMaximoPorVenda_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtDescontoMaximoPorVenda.Text.Replace("%", "")) > 100.00m)
            {
                btnSalvar.Enabled = false;
                MessageBoxOK.Show("Desconto máximo por venda, não pode ser maior que 100,00%");
                return;
            }
            else
            {
                btnSalvar.Enabled = true;
            }
        }

        private void NovoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void NovoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                Salvar();
            }
        }

        private void txtSenhaAcesso_EditValueChanged(object sender, EventArgs e)
        {
            if(txtSenhaAcesso.Text == "123456")
            {
                
                MessageBoxWarning.Show("123456 não e senha e uma contagem, por favor coloque uma senha valida!");
                
            }
        }

        private void txtConfirmarSenhaAcesso_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
