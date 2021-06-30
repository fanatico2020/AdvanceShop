using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomInputBox;
using AdvanceShop.Shared.CustomMessageBox;
using DevExpress.XtraLayout.HitInfo;
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
    public partial class Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        UsuarioTemPermissaoModel usuarioTemPermissao = new UsuarioTemPermissaoModel();

        CaixasModel caixa = new CaixasModel();
        CaixasController caixaController = new CaixasController();
        public Principal(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            usuarioTemPermissao.usuarios_idusuarios = UsuarioLogado.IdUsuarios;
            lblNomeUsuario.Caption = usuarioLogado.UsuarioAcesso;

            lblCaminhoSistema.Caption = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.Text = Text + " - " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //Checa update
            usuarioTemPermissao.permissoes_idpermissoes = 1;
            if (!UsuarioTemPermissaoController.AutenticarPermissao(usuarioTemPermissao))
            {
                Application.Exit();
            }

        }
       
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bbiApp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://advanceshopsistema.com.br/app");
        }

        private void bbiUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.Usuarios FormUsuarios = new Usuarios(usuarioLogado);
            FormUsuarios.Show();
            
            
            
        }

        private void bbiVendas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.Vendas FormVendas = new Vendas(usuarioLogado);
            FormVendas.Show();
        }

        private void bbiClientesPessoas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.ClientesFornecedores FormClientesPessoas = new ClientesFornecedores(usuarioLogado);
            FormClientesPessoas.Show();
        }

        private void bbiProdutos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.Produtos FormProdutos = new Produtos(usuarioLogado);
            FormProdutos.Show();
        }

        private void bbiTransacoesEstoque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.TransacoesEstoque FormTransacoesEstoque = new TransacoesEstoque(usuarioLogado);
            FormTransacoesEstoque.Show();
        }

        private void bbiContasApagar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.ContasAPagarPagas FormContasAPagar = new ContasAPagarPagas(usuarioLogado);
            FormContasAPagar.Show();
        }

        private void bbiCaixas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.Caixas FormCaixas = new Caixas(usuarioLogado);
            FormCaixas.Show();
        }

        private void bbiFiscal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void SairDoSistema()
        {
            if (MessageBoxQuestionYesNo.Show("Confirmar sair do sistema?") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void bbiSairSistema_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SairDoSistema();
        }

        private void bbiAlterarSenha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.AlterarSenha FormAlterarSenha = new AlterarSenha(usuarioLogado);
            FormAlterarSenha.ShowDialog();
        }

        private void bbiTrocarUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void Principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)27)
            {
                SairDoSistema();
            }
            
        }

        private void bbiConfiguracoesGerais_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ConfiguracoesGerais FormConfiguracoes = new ConfiguracoesGerais(usuarioLogado);
            FormConfiguracoes.ShowDialog();
        }

        private void bbiBackupRestauracaoDB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BackupRestauracaoDB FormBackupRestauracao = new BackupRestauracaoDB(usuarioLogado);
            FormBackupRestauracao.ShowDialog();
        }

        private void bbiAcessoRemoto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(".\\AnyDesk.exe");
            }
            catch (System.ComponentModel.Win32Exception error)
            {
                MessageBoxError.Show(error.Message);
            }
            
        }

        private void bbiSuporteTelefone_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            string link = "https://api.whatsapp.com/send?phone=5591993389501&text=Ol%C3%A1%2C%20preciso%20de%20ajuda%20com%20o%20sistema!";
            System.Diagnostics.Process.Start(link);
        }

        private void lblCaminhoSistema_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", lblCaminhoSistema.Caption);
        }

        private void bbiAtualizacaoSoftware_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Views.AtualizacaoSoftware FormAtualizarSoftware = new AtualizacaoSoftware();
            FormAtualizarSoftware.ShowDialog();
        }

        private void lblCaminhoSistema_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bbiRelFechmanetoCaixa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RelParCaixa FormParametros = new RelParCaixa("Selecione o caixa");
            FormParametros.ShowDialog();
            //caixa.IdCaixas = Convert.ToInt32(InputBoxTextEdit.Show("Número do caixa", "Relatório Fechamento de Caixa"));
            //caixa = caixaController.ObterDadosDoCaixaPorID(caixa);
            //if (caixa.status == 1)
            //{
            //    Shared.CustomPrint.FechamentoCaixa.ImprimirFechamentoCaixa(caixa);
            //}
            //else
            //{
            //    MessageBoxWarning.Show("Caixa inexistente ou não foi fechado ainda, favor verifique!");
            //}
        }

        private void bbiRelMeioDePagamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RelParPeriodo FormParametros = new RelParPeriodo("Informe o período de pagamentos", "RelatorioMeiosDePagamento");
            FormParametros.ShowDialog();
        }

        private void bbiRelProdutosMaisVendidos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RelParPeriodo FormParametros = new RelParPeriodo("Informe o período de vendas", "RelatorioProdutosMaisVendidos");
            FormParametros.ShowDialog();
        }

        private void bbiRelComissaoPorVendedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RelParPeriodoComissaoPorVendedor FormParametros = new RelParPeriodoComissaoPorVendedor("Informe o período de vendas/vendedor/% Comissão", "RelatorioComissaoPorVendedor");
            FormParametros.ShowDialog();
        }

        private void bbiRelVendasPorVendedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RelParPeriodoVendasPorVendedor FormParametros = new RelParPeriodoVendasPorVendedor("Informe o vendedor/período de vendas");
            FormParametros.ShowDialog();
        }

        private void bbiRelRelacaoDeContasPorStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RelParStatusPgPeriodo FormParametros = new RelParStatusPgPeriodo("Informe o status pagamento e o período");
            FormParametros.ShowDialog();
        }
    }
}
