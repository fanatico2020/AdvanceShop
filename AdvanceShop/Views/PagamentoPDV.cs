using AdvanceShop.Controllers;
using AdvanceShop.JsonModels.FocusNFe.NFC_e;
using AdvanceShop.JsonModels.GerenciaNet;
using AdvanceShop.Models;
using AdvanceShop.Report.Devexpress;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Validation;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Views
{
    public partial class PagamentoPDV : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();

        //Api FocusNfe - fiscal
        ApiFocusNfeModel apiFocusNfe = new ApiFocusNfeModel();
        ApiFocusNFeController apiFocusNfeController = new ApiFocusNFeController();
        ClientesPessoasModel empresaEmitente = new ClientesPessoasModel();
        FocusNFe focusNFe = new FocusNFe();
        IList<Iten> focusItemNfe = new List<Iten>();
        List<FormasPagamento> focusFormasPagamentoNfe = new List<FormasPagamento>();
        List<Duplicata> focusDuplicata = new List<Duplicata>();
        List<Volume> focusVolume = new List<Volume>();
        //--
        //Api gerencianet - Link Pagamento
        ApiGerenciaNetModel apiGerenciaNet = new ApiGerenciaNetModel();
        ApiGerenciaNetController apiGerenciaNetController = new ApiGerenciaNetController();
        GerenciaNet gerenciaNet = new GerenciaNet();

        //--
        ConfiguracoesGeraisController configGeraisController = new ConfiguracoesGeraisController();
        ConfiguracoesGeraisModel configGerais = new ConfiguracoesGeraisModel();
        DataHoraModel dataHora = new DataHoraModel();
        VendasModel venda = new VendasModel();
        VendasController vendaController = new VendasController();
        TransacoesCaixaModel transacaoCaixa = new TransacoesCaixaModel();
        TransacoesCaixaController transacaoCaixaController = new TransacoesCaixaController();
        ClientesPessoasModel clientePessoa = new ClientesPessoasModel();
        CaixasModel caixa = new CaixasModel();
        List<ItensVendasModel> itensVenda = new List<ItensVendasModel>();
        List<FormasPagamentoModel> formasPagamento = new List<FormasPagamentoModel>();
        List<Item> GerenciaNetItem = new List<Item>();
        decimal Dinheiro, CartaoDeCredito, CartaoDeDebito, LinkPagamento, ValorRestante, ValorAPagar, Troco;
        bool editarformaspagamento = false;
        string VendaOuEditarFormaPagamento = "", URL_LinkPagamento = "";
        public PagamentoPDV(VendasModel Venda,ClientesPessoasModel ClientePessoa,TransacoesCaixaModel TransacaoCaixa,List<ItensVendasModel> ItensVenda,CaixasModel Caixa,UsuariosModel UsuarioLogado)//Nova Venda
        {
            InitializeComponent();

            usuarioLogado = UsuarioLogado;
            itensVenda.AddRange(ItensVenda);//Adicoonar lista de itens da tela PDV a lista de itens da tela de pagamento

            foreach (var item in itensVenda)
            {
                GerenciaNetItem.Add(new Item()
                {
                    name = item.DescricaoProduto,
                    value = Convert.ToInt32(item.ValorUnitario.ToString().Replace(",","").Replace(".","")),
                    amount = Convert.ToInt32(item.Quantidade)
                });
            }

            foreach (var item in itensVenda)
            {
                focusItemNfe.Add(new Iten()
                {
                    numero_item = item.Item.ToString(),
                    codigo_produto = item.produtos_idprodutos.ToString(),
                    codigo_ncm = item.codigo_ncm,
                    cfop = item.cfop,
                    icms_origem = item.icms_origem,
                    icms_situacao_tributaria = item.icms_situacao_tributaria,
                    quantidade_comercial = item.Quantidade.ToString(),
                    quantidade_tributavel = item.Quantidade.ToString(),
                    valor_unitario_comercial = item.ValorUnitario.ToString().Replace(",", "."),
                    valor_unitario_tributavel = item.ValorUnitario.ToString().Replace(",", "."),
                    descricao = item.DescricaoProduto,//descrição produto
                    unidade_comercial = item.UnidadeMedida,
                    unidade_tributavel = item.UnidadeMedida,
                    valor_bruto = Convert.ToString(item.ValorUnitario * item.Quantidade).Replace(",", "."),
                    inclui_no_total = "1"//Valor do item (valor_bruto) compõe valor total da NFe (valor_produtos)?. Valores possíveis:0 – Não;1 – Sim.

                });
            }


            venda = Venda;
            caixa = Caixa;
            venda.caixas_idcaixas = Caixa.IdCaixas;
            clientePessoa = ClientePessoa;
            venda.clientespessoas_idclientespessoas = clientePessoa.IdClientesPessoas;
            transacaoCaixa = TransacaoCaixa;
            lblValorTotalAPagar.Text = $"{venda.TotalFinal.ToString("C")}";
            lblValorDesconto.Text = $"{venda.Desconto.ToString("C")}";
            VendaOuEditarFormaPagamento = "Venda";

            configGerais = configGeraisController.ObterConfiguracoesGerais();
            apiFocusNfe = apiFocusNfeController.ObterConfiguracoesApiFocusNfe();
            empresaEmitente = apiFocusNfeController.ObterEmpresaEmitenteApiFocusNfe(apiFocusNfe);
            apiGerenciaNet = apiGerenciaNetController.ObterConfiguracoesApiGerenciaNet();

            txtLinkPagamento.Enabled = Convert.ToBoolean(apiGerenciaNet.usarapi);
            lblLinkPagamento.Enabled = Convert.ToBoolean(apiGerenciaNet.usarapi);

            cbxImprimirNFCe.Enabled = Convert.ToBoolean(configGerais.imprimircupomfiscalnfcefinalizarvenda);
            cbxImprimirNFCe.Checked = Convert.ToBoolean(configGerais.imprimircupomfiscalnfcefinalizarvenda);

            if (venda.Desconto > 0.00M)
            {
                txtCartaoCredito.Enabled = Convert.ToBoolean(configGerais.vendacartaopermitirdesconto);
                lblCartaoCredito.Enabled = Convert.ToBoolean(configGerais.vendacartaopermitirdesconto);
                txtCartaoDebito.Enabled = Convert.ToBoolean(configGerais.vendacartaopermitirdesconto);
                lblCartaoDebito.Enabled = Convert.ToBoolean(configGerais.vendacartaopermitirdesconto); 
            }

        }
        public PagamentoPDV(TransacoesCaixaModel TransacaoCaixa, UsuariosModel UsuarioLogado)//Editar Formas de pagamento
        {
            InitializeComponent();

            usuarioLogado = UsuarioLogado;
            editarformaspagamento = true;
            transacaoCaixa = TransacaoCaixa;
            lblValorTotalAPagar.Text = $"{transacaoCaixa.Valor.ToString("C")}";
            lblValorDesconto.Text = $"{transacaoCaixaController.ObterValorDescontoVenda(TransacaoCaixa).ToString("C")}";
            
            cbxImprimirNFCe.Visible = false;
            VendaOuEditarFormaPagamento = "Edição de formas de pagamento";

        }
        private void AtualizarGridVendas()
        {
            Views.Vendas view = Application.OpenForms["Vendas"] as Views.Vendas;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void AtualizarGridTransacoesCaixa()
        {
            Views.TransacoesCaixa view = Application.OpenForms["TransacoesCaixa"] as Views.TransacoesCaixa;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void NovaVenda()
        {
            Views.VendaCaixaPDV view = Application.OpenForms["VendaCaixaPDV"] as Views.VendaCaixaPDV;
            if (view != null)
            {
                view.NovaVenda();
            }
        }
        private void ChecarConfigacoes()
        {
            if (Convert.ToBoolean(configGerais.trocomaximo))
            {
                if (Convert.ToDecimal(lblValorTroco.Text.Replace("R$", "")) <= Convert.ToDecimal(configGerais.valortrocomaximo))
                {
                    FinalizarVenda();
                }
                else
                {
                    MessageBoxWarning.Show($"Troco máximo permitido {configGerais.valortrocomaximo.ToString("C")}");
                }
            }
            else
            {
                FinalizarVenda();
            }
        }
        private void FinalizarVenda()
        {
            if (Troco >= 0 && lblTroco.Text == "Troco" && MessageBoxQuestionYesNo.Show($"Deseja finalizar a {VendaOuEditarFormaPagamento}?") == DialogResult.Yes)
            {
                if (!editarformaspagamento)
                {
                    decimal[] ValoresPagamento = new decimal[]
                {
                    decimal.Parse(txtDinheiro.Text.Replace("R$","")),
                    decimal.Parse(txtCartaoCredito.Text.Replace("R$","")),
                    decimal.Parse(txtCartaoDebito.Text.Replace("R$","")),
                    decimal.Parse(txtLinkPagamento.Text.Replace("R$",""))
                };
                    venda.Troco = Troco;
                    transacaoCaixa.Status = 1;
                    for (int i = 0; i <= ValoresPagamento.Length; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                if (ValoresPagamento[0] > 0)
                                {
                                    
                                    focusFormasPagamentoNfe.Add(new FormasPagamento()//FocusNfe
                                    {
                                        forma_pagamento = "1",
                                        valor_pagamento = ValoresPagamento[0].ToString().Replace(",", "."),

                                    });

                                    formasPagamento.Add(new FormasPagamentoModel()
                                    {
                                        Descricao = "DINHEIRO",
                                        Valor = ValoresPagamento[0]
                                    });
                                }
                                break;
                            case 1:
                                if (ValoresPagamento[1] > 0)
                                {
                                    focusFormasPagamentoNfe.Add(new FormasPagamento()//FocusNfe
                                    {
                                        forma_pagamento = "3",
                                        valor_pagamento = ValoresPagamento[0].ToString().Replace(",", ".")
                                    });
                                    formasPagamento.Add(new FormasPagamentoModel()
                                    {
                                        Descricao = "CARTÃO CRÉDITO",
                                        Valor = ValoresPagamento[1]
                                    });
                                }
                                break;
                            case 2:
                                if (ValoresPagamento[2] > 0)
                                {
                                    focusFormasPagamentoNfe.Add(new FormasPagamento()//FocusNfe
                                    {
                                        forma_pagamento = "4",
                                        valor_pagamento = ValoresPagamento[0].ToString().Replace(",", ".")
                                    });
                                    formasPagamento.Add(new FormasPagamentoModel()
                                    {
                                        Descricao = "CARTÃO DÉBITO",
                                        Valor = ValoresPagamento[2]
                                    });
                                }
                                break;
                            case 3:
                                if(ValoresPagamento[3] > 0 && ValoresPagamento[0] == 0 && ValoresPagamento[1] == 0 && ValoresPagamento[2] == 0)
                                {
                                    focusFormasPagamentoNfe.Add(new FormasPagamento()//FocusNfe
                                    {
                                        forma_pagamento = "4",
                                        valor_pagamento = ValoresPagamento[0].ToString().Replace(",",".")
                                    });
                                    formasPagamento.Add(new FormasPagamentoModel()
                                    {
                                        Descricao = "LINK PAGAMENTO",
                                        Valor = ValoresPagamento[3]
                                    });
                                    gerenciaNet = apiGerenciaNetController.CriarTransacaoLinkPagamento(apiGerenciaNet, GerenciaNetItem, venda.IdVendas.ToString(), $"CAIXA {caixa.IdCaixas} - Vendedor {usuarioLogado.UsuarioAcesso}");
                                    URL_LinkPagamento = gerenciaNet.data.payment_url;
                                    transacaoCaixa.payment_url = gerenciaNet.data.payment_url;
                                    transacaoCaixa.charge_id = gerenciaNet.data.charge_id;
                                    transacaoCaixa.Status = 0;
                                }
                                break;
                            default:
                                break;
                        }

                    }

                    for (int x = 0; x < ValoresPagamento.Length; x++)
                    {
                        venda.ValorPago += ValoresPagamento[x];
                    }

                    vendaController.Adicionar(venda, formasPagamento, itensVenda, transacaoCaixa, usuarioLogado);
                    venda.IdVendas = vendaController.ObterUltimoIDVendaInserido();
                    
                    if (Convert.ToBoolean(configGerais.imprimircupomfinalizarvenda))
                    {
                        //ImprimirCupom
                        
                        dataHora.datahoracadastro = DateTime.Now;
                        caixa.Maquina = Environment.MachineName;
                        if (cbxImprimirNFCe.Checked && Convert.ToBoolean(apiFocusNfe.usarapi))//focusNfe
                        {
                            try
                            {
                                //emitente
                                focusNFe.nome_emitente = empresaEmitente.NomeClientePessoa;
                                focusNFe.inscricao_estadual_emitente = empresaEmitente.RGIE;
                                focusNFe.cnpj_emitente = empresaEmitente.CPFCNPJ;
                                focusNFe.telefone_emitente = empresaEmitente.Contato1.Replace("-","").Trim();
                                focusNFe.logradouro_emitente = empresaEmitente.Endereco;
                                focusNFe.numero_emitente = empresaEmitente.NumeroCasa;
                                focusNFe.bairro_emitente = empresaEmitente.Bairro;
                                focusNFe.municipio_emitente = empresaEmitente.Cidade;
                                focusNFe.uf_emitente = empresaEmitente.UF;
                                focusNFe.cep_emitente = empresaEmitente.CEP.Replace("-", "").Trim();
                                focusNFe.data_emissao = DateTime.Now;
                                focusNFe.finalidade_emissao = "1";
                                focusNFe.tipo_documento = "1";
                                focusNFe.consumidor_final = "0";
                                focusNFe.indicador_intermediario = "0";
                                focusNFe.indicador_inscricao_estadual_destinatario = apiFocusNfe.indicadoriedestinatario;
                                focusNFe.modalidade_frete = "9";//'1' – Por conta do destinatário
                                focusNFe.local_destino = "1";//'1' – Operação interna;
                                focusNFe.presenca_comprador = "1";//1 – Operação presencial
                                focusNFe.natureza_operacao = "VENDA AO CONSUMIDOR";
                                focusNFe.itens = focusItemNfe;
                                focusNFe.formas_pagamento = focusFormasPagamentoNfe;
                                focusDuplicata.Add(new Duplicata()
                                {
                                    data_vencimento = null,
                                    numero = null,
                                    valor = null
                                });
                                focusNFe.duplicatas = focusDuplicata;
                                focusVolume.Add(new Volume()
                                {
                                    especie = null  ,
                                    marca = null,
                                    peso_bruto = null,
                                    peso_liquido = null,
                                    quantidade = null
                                });
                                focusNFe.volumes = focusVolume;
                                //destinatario
                                if(clientePessoa != null)
                                {
                                    focusNFe.nome_destinatario = clientePessoa.NomeClientePessoa;
                                    if (clientePessoa.CPFCNPJ.Length == 11) focusNFe.cpf_destinatario = clientePessoa.CPFCNPJ;
                                    if (clientePessoa.CPFCNPJ.Length == 14) focusNFe.cnpj_destinatario = clientePessoa.CPFCNPJ;
                                    focusNFe.telefone_destinatario = clientePessoa.Contato1.Replace("-", "").Trim();
                                    focusNFe.logradouro_destinatario = clientePessoa.Endereco;
                                    focusNFe.numero_destinatario = clientePessoa.NumeroCasa;
                                    focusNFe.bairro_destinatario = clientePessoa.Bairro;
                                    focusNFe.municipio_destinatario = clientePessoa.Cidade;
                                    focusNFe.uf_destinatario = clientePessoa.UF;
                                    focusNFe.cep_destinatario = clientePessoa.CEP.Replace("-", "").Trim();
                                }
                                
                            }
                            catch (NullReferenceException)
                            {

                            }
                            

                            apiFocusNfeController.EnviandoNFC_e(apiFocusNfe, focusNFe,venda.IdVendas.ToString());

                        }
                        
                        //cupom não fiscal
                        Shared.CustomPrint.CupomNaoFiscal.ImprimirCupom(venda, clientePessoa, usuarioLogado, caixa, dataHora, configGerais);

                    }
                    //Iniciar nova venda no pdv
                    NovaVenda();
                    AtualizarGridVendas();

                }
                else//Editar formas de pagamento
                {

                    AtualizarGridTransacoesCaixa();

                }

                //fim
                formasPagamento.Clear();
                venda.ValorPago = 0;

                MessageBoxOK.Show($"{VendaOuEditarFormaPagamento} finalizada com sucesso!");
                if(URL_LinkPagamento != string.Empty)
                {
                    LinkPagamentoCompartilha FormLinkPagamento = new LinkPagamentoCompartilha(URL_LinkPagamento);
                    FormLinkPagamento.ShowDialog();
                }
                
                Close();
            }
            else
            {
                MessageBoxWarning.Show($"Opa ainda falta receber {lblValorTroco.Text}");
            }
            
        }
        
        private void PagamentoPDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void PagamentoPDV_Load(object sender, EventArgs e)
        {
            CalcularValorTroco();
            txtDinheiro.Focus();
            
        }
        private void CalcularValorTroco()
        {

            Dinheiro = Convert.ToDecimal(txtDinheiro.Text.Replace("R$", ""));
            CartaoDeCredito = Convert.ToDecimal(txtCartaoCredito.Text.Replace("R$", ""));
            CartaoDeDebito = Convert.ToDecimal(txtCartaoDebito.Text.Replace("R$", ""));
            LinkPagamento = Convert.ToDecimal(txtLinkPagamento.Text.Replace("R$", ""));
            ValorRestante = 0;
            ValorAPagar = venda.TotalFinal;
            Troco = 0;

            ValorRestante = ValorAPagar - Dinheiro - CartaoDeCredito - CartaoDeDebito - LinkPagamento;

            if (ValorRestante <= 0)
            {
                lblValorTroco.Text = "R$0,00";
                Troco = Math.Abs(ValorRestante);
                lblTroco.Text = "Troco";
                lblTroco.ForeColor = Color.Green;
                lblValorTroco.ForeColor = Color.Green;
                lblValorTroco.Text = Troco.ToString("c");
            }
            else
            {
                lblTroco.Text = "Falta receber";
                lblTroco.ForeColor = Color.Blue;
                lblValorTroco.ForeColor = Color.Blue;
                lblValorTroco.Text = ValorRestante.ToString("c");
            }

        }

        private void txtDinheiro_EditValueChanged(object sender, EventArgs e)
        {
            
            CalcularValorTroco();
        }

        private void txtCartaoCredito_EditValueChanged(object sender, EventArgs e)
        {
            CalcularValorTroco();
        }

        private void txtCartaoDebito_EditValueChanged(object sender, EventArgs e)
        {
            CalcularValorTroco();
        }

        private void PagamentoPDV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                ChecarConfigacoes();
            }
        }

        private void txtDinheiro_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCartaoCredito_Properties_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCartaoDebito_Properties_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void txtLinkPagamento_Properties_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        

        private void txtLinkPagamento_EditValueChanged(object sender, EventArgs e)
        {
            CalcularValorTroco();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ChecarConfigacoes();
        }

        private void txtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoCamposCustom.StringKeyPressNumeroPontoVirgula(sender,e);

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            
        }

        private void txtCartaoCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoCamposCustom.StringKeyPressNumeroPontoVirgula(sender, e);

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCartaoDebito_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoCamposCustom.StringKeyPressNumeroPontoVirgula(sender, e);

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtLinkPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoCamposCustom.StringKeyPressNumeroPontoVirgula(sender, e);

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
