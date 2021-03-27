using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Email;
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
    public partial class EsqueceuSenha : DevExpress.XtraEditors.XtraForm
    {
        UsuariosController usuarioController = new UsuariosController();
        UsuariosModel usuario = new UsuariosModel();
        Random rnd = new Random();
        public EsqueceuSenha(UsuariosModel Usuario)
        {
            InitializeComponent();
            usuario = Usuario;
            txtUsuario.Text = usuario.UsuarioAcesso;
            
        }

        private void EsqueceuSenha_Load(object sender, EventArgs e)
        {

        }
        private async void GerarNovaSenhaAcesso()
        {
            try
            {
                if (txtEmail.Text == usuario.Email)
                {
                    btnNovaSenha.Enabled = false;
                    using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                    {
                        smtp.Host = EmailSistema.host;
                        smtp.Port = EmailSistema.porta;
                        smtp.EnableSsl = EmailSistema.EnableSsl;
                        smtp.UseDefaultCredentials = EmailSistema.UseDefaultCredentials;
                        smtp.Credentials = new System.Net.NetworkCredential(EmailSistema.email, EmailSistema.senha);

                        using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                        {
                            mail.From = new System.Net.Mail.MailAddress(EmailSistema.email);

                            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                            {
                                mail.To.Add(new System.Net.Mail.MailAddress(txtEmail.Text));
                            }

                            mail.Subject = "AdvanceShop - Recuperação de acesso ao sistema";

                            usuario.SenhaAcesso = rnd.Next(100000, 999999).ToString();
                            mail.Body = $"Olá Sr(a) {usuario.UsuarioAcesso}, sua nova senha de acesso ao sistema advanceshop é {usuario.SenhaAcesso}";
                            usuarioController.GerarNovaSenhaAcesso(usuario);
                            await smtp.SendMailAsync(mail);
                            MessageBoxOK.Show($"Nova senha de acesso disponível no seu email {txtEmail.Text}");
                            Close();
                        }
                    }
                }
                else
                {
                    MessageBoxWarning.Show("Verifique se o email informado está correto, o mesmo não corresponde ao email cadastrado para esse usuário!");
                }
            }
            catch (Exception error)
            {
                btnNovaSenha.Enabled = true;
                MessageBoxError.Show(error.Message);
            }
            
        }
        private void EsqueceuSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void EsqueceuSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                GerarNovaSenhaAcesso();
            }
        }

        private void btnNovaSenha_Click(object sender, EventArgs e)
        {
            GerarNovaSenhaAcesso();
        }
    }
}
