using AdvanceShop.Controllers;
using AdvanceShop.JsonModels.ReceitaWS;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Validation;
using Correios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdvanceShop.Views
{
    public partial class NovoClienteFornecedor : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        ClientesPessoasModel clientePessoa = new ClientesPessoasModel();
        ClientesPessoasController clientePessoaController = new ClientesPessoasController();
        bool edicao = false;
        public NovoClienteFornecedor(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
        }
        public NovoClienteFornecedor(UsuariosModel UsuarioLogado,ClientesPessoasModel ClientePessoaEdicao)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            edicao = true;
            tsEmpresa.IsOn = Convert.ToBoolean(ClientePessoaEdicao.TipoPessoa);
            MascaraCpfCnpj();
            clientePessoa.IdClientesPessoas = ClientePessoaEdicao.IdClientesPessoas;
            txtNome.Text = ClientePessoaEdicao.NomeClientePessoa;
            
            txtDataNascimento.DateTime = Convert.ToDateTime(ClientePessoaEdicao.DataNascimento);
            txtRGIE.Text = ClientePessoaEdicao.RGIE;
            txtContato1.Text = ClientePessoaEdicao.Contato1;
            txtContato2.Text = ClientePessoaEdicao.Contato2;
            txtEmail.Text = ClientePessoaEdicao.Email;
            cbxSexo.SelectedItem = ClientePessoaEdicao.Sexo;
            txtObservacao.Text = ClientePessoaEdicao.Observacao;
            txtEndereco.Text = ClientePessoaEdicao.Endereco;
            txtCEP.Text = ClientePessoaEdicao.CEP;
            txtBairro.Text = ClientePessoaEdicao.Bairro;
            txtCidade.Text = ClientePessoaEdicao.Cidade;
            txtComplemento.Text = ClientePessoaEdicao.Complemento;
            txtNumero.Text = ClientePessoaEdicao.NumeroCasa;
            txtUF.Text = ClientePessoaEdicao.UF;
            tsStatus.IsOn = Convert.ToBoolean(ClientePessoaEdicao.StatusClientePessoa);
            if (ClientePessoaEdicao.CPFCNPJ.Length == 14)
            {
                txtCpfCnpj.Properties.Mask.BeepOnError = true;
                txtCpfCnpj.Properties.Mask.EditMask = "00.000.000/0000-00";
            }
            else if (ClientePessoaEdicao.CPFCNPJ.Length == 11)
            {
                txtCpfCnpj.Properties.Mask.BeepOnError = true;
                txtCpfCnpj.Properties.Mask.EditMask = "000.000.000-00";
            }
            txtCpfCnpj.Text = ClientePessoaEdicao.CPFCNPJ;
        }

        private void cbxEmpresa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NovoClientePessoa_Load(object sender, EventArgs e)
        {
            this.txtCpfCnpj.Properties.Mask.BeepOnError = true;
            this.txtCpfCnpj.Properties.Mask.EditMask = "000.000.000-00";
            txtNome.Focus();

        }
        private void MascaraCpfCnpj()
        {
            if (tsEmpresa.IsOn)
            {
                txtCpfCnpj.Text = "";
                cbxSexo.Text = "";
                cbxSexo.Enabled = false;
                lblCpfCnpj.Text = "CNPJ";
                lblRgIE.Text = "IE";
                this.txtCpfCnpj.Properties.Mask.BeepOnError = true;
                this.txtCpfCnpj.Properties.Mask.EditMask = "00.000.000/0000-00";
            }
            else if (!tsEmpresa.IsOn)
            {
                txtCpfCnpj.Text = "";
                cbxSexo.Text = "";
                cbxSexo.Enabled = true;
                lblCpfCnpj.Text = "CPF";
                lblRgIE.Text = "RG";
                this.txtCpfCnpj.Properties.Mask.BeepOnError = true;
                this.txtCpfCnpj.Properties.Mask.EditMask = "000.000.000-00";
            }
        }
        private void tsEmpresa_Toggled(object sender, EventArgs e)
        {
            MascaraCpfCnpj();
        }

        private void NovoClientePessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void txtCpfCnpj_Leave(object sender, EventArgs e)
        {
            clientePessoa.CPFCNPJ = txtCpfCnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "");
            if (!clientePessoaController.VerificarSer_CPF_CNPJ_JaCadastrado(clientePessoa))
            {
                var CpfCnpj = txtCpfCnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "");
                if (CpfCnpj != string.Empty)
                {
                    if (!ValidacaoCamposCustom.Validar_CPF_CNPJ(CpfCnpj))
                    {
                        MessageBoxError.Show($"{lblCpfCnpj.Text} invalido!");
                    }
                    else
                    {
                        try
                        {
                            //Usando api da receitaws poucas consulta por dia e gratis
                            if (CpfCnpj.Length == 14 &&
                                MessageBoxQuestionYesNo.Show("Deseja buscar dados da Receita Federal?") == DialogResult.Yes)
                            {
                                var cnpj = txtCpfCnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "");

                                string endpoint = "https://www.receitaws.com.br/v1/cnpj/" + cnpj;
                                string method = "GET";

                                HttpWebRequest request = WebRequest.CreateHttp(endpoint);
                                request.Method = method;

                                using (StreamReader responseStream = new StreamReader(request.GetResponse().GetResponseStream()))
                                {
                                    string dadosRecuperados = responseStream.ReadToEnd();
                                    ReceitaWS receitaWS = JsonConvert.DeserializeObject<ReceitaWS>(dadosRecuperados);
                                    txtNome.Text = receitaWS.nome;
                                    txtCEP.Text = receitaWS.cep.Replace(".", "");
                                    txtEndereco.Text = receitaWS.logradouro;
                                    txtNumero.Text = receitaWS.numero;
                                    txtBairro.Text = receitaWS.bairro;
                                    txtCidade.Text = receitaWS.municipio.ToLower();
                                    txtUF.Text = receitaWS.uf;
                                    txtEmail.Text = receitaWS.email;
                                    txtContato1.Text = receitaWS.telefone.Replace("(", "").Replace(")", "").Replace("/", "").Substring(0, 12);
                                    txtComplemento.Text = receitaWS.complemento;
                                    txtDataNascimento.DateTime = Convert.ToDateTime(receitaWS.abertura);

                                }

                            }
                        }
                        catch (Exception error)
                        {
                            MessageBoxError.Show(error.Message);
                        }

                    }
                }
            }
            else
            {
                MessageBoxError.Show("Cliente/Pessoa já cadastrado(a)!");
            }

            
        }
        private void AtualizarGrid()
        {
            Views.ClientesFornecedores view = Application.OpenForms["ClientesFornecedores"] as Views.ClientesFornecedores;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void Salvar()
        {
            try
            {
                clientePessoa.NomeClientePessoa = txtNome.Text;
                clientePessoa.CPFCNPJ = txtCpfCnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "");
                clientePessoa.RGIE = txtRGIE.Text;
                clientePessoa.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                clientePessoa.Sexo = cbxSexo.Text;
                clientePessoa.Contato1 = txtContato1.Text;
                clientePessoa.Contato2 = txtContato2.Text;
                clientePessoa.Email = txtEmail.Text;
                clientePessoa.Observacao = txtObservacao.Text;
                clientePessoa.CEP = txtCEP.Text;
                clientePessoa.Endereco = txtEndereco.Text;
                clientePessoa.NumeroCasa = txtNumero.Text;
                clientePessoa.Complemento = txtComplemento.Text;
                clientePessoa.Bairro = txtBairro.Text;
                clientePessoa.Cidade = txtCidade.Text;
                clientePessoa.UF = txtUF.Text;
                clientePessoa.StatusClientePessoa = Convert.ToInt32(tsStatus.EditValue);
                clientePessoa.TipoPessoa = Convert.ToInt32(tsEmpresa.EditValue);

                ValidacaoCampos.Validar(clientePessoa);
                if (ValidacaoCampos.IsValid() && MessageBoxQuestionYesNo.Show($"Deseja salvar?") == DialogResult.Yes)
                {
                    if (!edicao)
                    {
                        clientePessoaController.Adicionar(clientePessoa, usuarioLogado);
                    }
                    else
                    {
                        clientePessoaController.Editar(clientePessoa, usuarioLogado);
                    }

                    MessageBoxOK.Show("Salvo com sucesso!");
                    AtualizarGrid();
                    Close();
                }
            }
            catch (System.FormatException)
            {

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

        private void NovoClientePessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                Salvar();
            }
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Replace("-_", "").Trim();
            if (MessageBoxQuestionYesNo.Show("Deseja buscar dados do CEP no WebService do Correio?") == DialogResult.Yes)
            {
                try
                {
                    var service = new CorreiosApi();
                    var endereco = service.consultaCEP(cep);

                    if (endereco != null)
                    {
                        txtEndereco.Text = endereco.end;
                        txtBairro.Text = endereco.bairro;
                        txtCidade.Text = endereco.cidade;
                        txtUF.Text = endereco.uf;

                    }
                }
                catch (Exception error)
                {
                    MessageBoxError.Show(error.Message);
                }
                
               
            }

        }

        private void txtContato1_Leave(object sender, EventArgs e)
        {
            
        }
        
    }
}
