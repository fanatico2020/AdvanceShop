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
    public partial class ConfiguracoesGerais : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        ConfiguracoesGeraisModel configGerais = new ConfiguracoesGeraisModel();
        ConfiguracoesGeraisController configGeraisController = new ConfiguracoesGeraisController();
        EmailSistemaModel emailSistema = new EmailSistemaModel();
        EmailSistemaController emailSistemaController = new EmailSistemaController();
        ApiFocusNfeModel apiFocusNfe = new ApiFocusNfeModel();
        ApiFocusNFeController apiFocusNfeController = new ApiFocusNFeController();
        ApiGerenciaNetModel apiGerenciaNet = new ApiGerenciaNetModel();
        ApiGerenciaNetController apiGerenciaNetController = new ApiGerenciaNetController();
        ClientesPessoasController clientePessoaController = new ClientesPessoasController();
        public ConfiguracoesGerais(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
        }
        private void AtualizarConfiguracoesGerais()
        {
            configGerais = configGeraisController.ObterConfiguracoesGerais();
            tsAvisarClienteAniversariante.IsOn = Convert.ToBoolean(configGerais.avisarclienteaniversariante);
            tsAvisarProdutoEstoqueBaixo.IsOn = Convert.ToBoolean(configGerais.avisarprodutoestoquebaixo);
            tsImprimirCPFCNPJCupomVenda.IsOn = Convert.ToBoolean(configGerais.imprimircpfcnpjnocupom);
            tsImprimirCupomFinalizarVenda.IsOn = Convert.ToBoolean(configGerais.imprimircupomfinalizarvenda);
            tsImprimirCupomFiscalFinalizarVenda.IsOn = Convert.ToBoolean(configGerais.imprimircupomfiscalnfcefinalizarvenda);
            tsImprimirNomeVendedorFinalizarVenda.IsOn = Convert.ToBoolean(configGerais.imprimirnomevendedorfinalizarvenda);
            //tsImprimirNotaFiscalFinalizarVenda.IsOn = Convert.ToBoolean();
            tsVendaCartaoPermitirDesconto.IsOn = Convert.ToBoolean(configGerais.vendacartaopermitirdesconto);
            tsPermitirVenderCEstoqueZerado.IsOn = Convert.ToBoolean(configGerais.permitirvendercomestoquezerado);
            tsTrocoMaximo.IsOn = Convert.ToBoolean(configGerais.trocomaximo);
            txtTrocoMaximo.Text = Convert.ToString(configGerais.valortrocomaximo);
        }
        private void AtualizarApiFocusNFe()
        {
            apiFocusNfe = apiFocusNfeController.ObterConfiguracoesApiFocusNfe();
            tsAtivarApiFocusNfe.IsOn = Convert.ToBoolean(apiFocusNfe.usarapi);
            txtTokenHomologacao.Text = apiFocusNfe.tokenhomologacao;
            txtTokenProducao.Text = apiFocusNfe.tokenproducao;
            cbxIndicadorIEdestinatario.EditValue = apiFocusNfe.indicadoriedestinatario;
            cbxEmpresaEmitente.EditValue = apiFocusNfe.clientespessoas_idclientespessoas;
            if (apiFocusNfe.ambiente =="homologacao")
            {
                rgbAmbienteFocusNfe.SelectedIndex = 0;
            }
            else if(apiFocusNfe.ambiente == "producao")
            {
                rgbAmbienteFocusNfe.SelectedIndex = 1;
            }
                

        }
        private void AtualizarApiGerenciaNet()
        {
            apiGerenciaNet = apiGerenciaNetController.ObterConfiguracoesApiGerenciaNet();
            tsAtivarApiGerenciaNet.IsOn = Convert.ToBoolean(apiGerenciaNet.usarapi);
            txtClientIdHomologacao.Text = apiGerenciaNet.clientidhomologacao;
            txtClientSecretHomologacao.Text = apiGerenciaNet.clientsecrethomologacao;
            txtClienteIdProducao.Text = apiGerenciaNet.clientidproducao;
            txtClientSecretProducao.Text = apiGerenciaNet.clientsecretproducao;
            if(apiGerenciaNet.ambiente == "homologacao")
            {
                rgbAmbienteGerenciaNet.SelectedIndex = 0;
            }else if(apiGerenciaNet.ambiente == "producao")
            {
                rgbAmbienteGerenciaNet.SelectedIndex = 1;
            }
        }
        private void AtualizarEmpresaEmitente()
        {
            cbxEmpresaEmitente.Properties.DataSource = clientePessoaController.ObterTodosClientesPessoas();
            cbxEmpresaEmitente.Properties.DisplayMember = "nome";
            cbxEmpresaEmitente.Properties.ValueMember = "idclientespessoas";
        }
        private void AtualizarEmailSistema()
        {
            emailSistema = emailSistemaController.ObterConfiguracoesEmailSistema();
            txtEmailRecebimentoPrincipal.Text = emailSistema.emailprincipal;
            txtEmailCopia1.Text = emailSistema.emailcopia1;
            txtEmailCopia2.Text = emailSistema.emailcopia2;
        }
        private void ConfiguracoesGerais_Load(object sender, EventArgs e)
        {
            AtualizarEmpresaEmitente();
            AtualizarConfiguracoesGerais();
            AtualizarApiFocusNFe();
            AtualizarApiGerenciaNet();
            AtualizarEmailSistema();
            
        }

        private void ConfiguracoesGerais_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }
        private void Salvar()
        {
            if (MessageBoxQuestionYesNo.Show($"Deseja salvar?") == DialogResult.Yes)
            {
                //Configurações Vendas
                configGerais.imprimircpfcnpjnocupom = Convert.ToInt32(tsImprimirCPFCNPJCupomVenda.IsOn);
                configGerais.imprimircupomfinalizarvenda = Convert.ToInt32(tsImprimirCupomFinalizarVenda.IsOn);
                configGerais.imprimircupomfiscalnfcefinalizarvenda = Convert.ToInt32(tsImprimirCupomFiscalFinalizarVenda.IsOn);
                configGerais.imprimirnomevendedorfinalizarvenda = Convert.ToInt32(tsImprimirNomeVendedorFinalizarVenda.IsOn);
                configGerais.trocomaximo = Convert.ToInt32(tsTrocoMaximo.IsOn);
                configGerais.valortrocomaximo = Convert.ToDecimal(txtTrocoMaximo.Text.Replace("R$", ""));
                configGerais.vendacartaopermitirdesconto = Convert.ToInt32(tsVendaCartaoPermitirDesconto.IsOn);
                configGerais.avisarclienteaniversariante = Convert.ToInt32(tsAvisarClienteAniversariante.IsOn);
                configGerais.avisarprodutoestoquebaixo = Convert.ToInt32(tsAvisarProdutoEstoqueBaixo.IsOn);
                configGerais.permitirvendercomestoquezerado = Convert.ToInt32(tsPermitirVenderCEstoqueZerado.IsOn);

                configGeraisController.SalvarConfiguracao(configGerais);

                //Api FocusNfe
                apiFocusNfe.usarapi = Convert.ToInt32(tsAtivarApiFocusNfe.IsOn);
                apiFocusNfe.tokenhomologacao = txtTokenHomologacao.Text;
                apiFocusNfe.tokenproducao = txtTokenProducao.Text;
                apiFocusNfe.ambiente = Convert.ToString(rgbAmbienteFocusNfe.EditValue);
                apiFocusNfe.clientespessoas_idclientespessoas = Convert.ToInt32(cbxEmpresaEmitente.EditValue);
                apiFocusNfe.indicadoriedestinatario = ValidacaoCamposCustom.StringApenasNumeros(Convert.ToString(cbxIndicadorIEdestinatario.EditValue));

                apiFocusNfeController.SalvarConfiguracao(apiFocusNfe);

                //Api GerenciaNet
                apiGerenciaNet.usarapi = Convert.ToInt32(tsAtivarApiGerenciaNet.IsOn);
                apiGerenciaNet.clientidhomologacao = txtClientIdHomologacao.Text;
                apiGerenciaNet.clientsecrethomologacao = txtClientSecretHomologacao.Text;
                apiGerenciaNet.clientidproducao = txtClienteIdProducao.Text;
                apiGerenciaNet.clientsecretproducao = txtClientSecretProducao.Text;
                apiGerenciaNet.ambiente = Convert.ToString(rgbAmbienteGerenciaNet.EditValue);

                apiGerenciaNetController.SalvarConfiguracao(apiGerenciaNet);
                
                //Emails para envios automaticos
                emailSistema.emailprincipal = txtEmailRecebimentoPrincipal.Text;
                emailSistema.emailcopia1 = txtEmailCopia1.Text;
                emailSistema.emailcopia2 = txtEmailCopia2.Text;

                emailSistemaController.SalvarConfiguracao(emailSistema);

                MessageBoxOK.Show("Configurações salvas com sucesso!");
                Close();
            }
            
        }
        private void ConfiguracoesGerais_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                Salvar();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void lblLinkFocusNfe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://focusnfe.com.br/");
        }

        private void lblLinkGerencianet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://login.gerencianet.com.br/");
        }
    }
}
