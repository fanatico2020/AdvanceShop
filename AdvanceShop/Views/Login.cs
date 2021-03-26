using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Library;
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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogin = new UsuariosModel();
        UsuariosController usuarioControllers = new UsuariosController();
        public Login()
        {
            InitializeComponent();
            txtUsuario.Properties.DataSource = 
            usuarioControllers.ObterTodosUsuariosAcesso_Nome();
            txtUsuario.Properties.DisplayMember = "usuarioacesso";
            txtUsuario.Properties.ValueMember = "usuarioacesso";
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length > 1)
            {
                txtSenha.Properties.UseSystemPasswordChar = true;
            }

        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {

        }

        private void txtSenha_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarSenha.SenhaTextEdit(txtSenha);
        }

        private void txtSenha_MouseMove(object sender, MouseEventArgs e)
        {
            MostrarSenha.MensagemToolTipTextEdit(txtSenha);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            usuarioLogin.UsuarioAcesso = txtUsuario.Text;
            usuarioLogin.SenhaAcesso = txtSenha.Text;
            usuarioLogin =  usuarioControllers.AutenticarUsuario(usuarioLogin);
            if (usuarioLogin.logado == 1)
            {
                Hide();
                Views.Principal FormPrincipal = new Principal(usuarioLogin);
                FormPrincipal.Show();
            }
            else
            {
                MessageBoxOK.Show("Usuário de acesso ou senha de acesso incorreto!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AcceptButton = btnEntrar;
            
        }

        private void lblSiteAdvanceShop_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://advanceshopsistema.com.br/");
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblEsqueceuSuaSenha_Click(object sender, EventArgs e)
        {
            Views.EsqueceuSenha FormEsqueceuSenha = new EsqueceuSenha();
            FormEsqueceuSenha.ShowDialog();
        }
        /*
private void GetLicencaAtiva()
{
string KeyAtiva = c_licencas.GetLicencaKeyAtiva();
string DataUlt = c_licencas.GetUltimoAcesso();
DateTime DataOnline = c_GuerrillaNtp.GetDataHoraCerta();
DateTime DataVencimento;
DateTime DataUltimoAcesso;
if (c_EcrypDecryp.ValidarKey(KeyAtiva) || c_EcrypDecryp.ValidarUltimoAcesso(DataUlt))
{
DataVencimento = Convert.ToDateTime(c_EcrypDecryp.DecryptString(KeyAtiva, "masterkey@").Substring(10, 10));
DataUltimoAcesso = Convert.ToDateTime(c_EcrypDecryp.DecryptString(DataUlt, "masterkey@"));
//Compara duas instâncias do DateTime e retorna um inteiro que indica se a primeira instância é anterior, a mesma ou posterior à segunda instância.
//Menor que zero 	t1 é <  t2.
//Zero 	t1 == t2.
//Maior que zero 	t1 e >  t2.

//Compara a data de vencimento da licença com a data online certa, caso não tenho internet retorna data atual do pc
int Resultado1 = DateTime.Compare(DataVencimento, DataOnline);
//Compara a data do ultimo acesso com a data online certa, caso não tenha internet retorna a data atual do pc, se a data atual do pc der menor que a data do ultimo acesso vai expira a licença
int Resultado2 = DateTime.Compare(DataUltimoAcesso, DataOnline);
if (Resultado1 < 0 || Resultado2 > 0)
{
//Coloca todas as licenças antigas como vencidas
m_licencas.status = Convert.ToInt32(e_Status.Status_LicencasKey.Vencida);
c_licencas.VencerLicencas(m_licencas);
MessageBox.Show("Sua licença expirou!", "FoxShop", MessageBoxButtons.OK, MessageBoxIcon.Warning);

Hide();
Configuracoes.v_NovaLicencaKey FormNovaLicenca = new Configuracoes.v_NovaLicencaKey(false);
FormNovaLicenca.ShowDialog();
}


}
else
{
MessageBox.Show("Key é inválida entre com Key Valida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
this.Hide();
Configuracoes.v_NovaLicencaKey FormNovaLicenca = new Configuracoes.v_NovaLicencaKey(false);
FormNovaLicenca.ShowDialog();
}

}
*/
    }
}
