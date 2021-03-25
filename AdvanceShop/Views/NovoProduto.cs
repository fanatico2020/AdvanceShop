using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomInputBox;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Validation;
using System;
using System.Windows.Forms;

namespace AdvanceShop.Views
{

    public partial class NovoProduto : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        ProdutosModel produto = new ProdutosModel();
        ProdutosController produtoController = new ProdutosController();
        CategoriasProdutosModel categoria = new CategoriasProdutosModel();
        CategoriasProdutosController categoriaController = new CategoriasProdutosController();
        UnidadesMedidasProdutosModel unidadeMedida = new UnidadesMedidasProdutosModel();
        UnidadesMedidasProdutosController unidadeMedidaController = new UnidadesMedidasProdutosController();
        MarcasProdutosModel marca = new MarcasProdutosModel();
        MarcasProdutosController marcaController = new MarcasProdutosController();
        ClientesPessoasController clientePessoaController = new ClientesPessoasController();
        bool edicao = false;
        public NovoProduto(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            //txtEstoqueAtual.Enabled = false;
            //txtEstoqueMax.Enabled = false;
            //txtEstoqueMin.Enabled = false;
        }
        public NovoProduto(UsuariosModel UsuarioLogado,ProdutosModel produtoEdicao)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            edicao = true;

            produto.IdProdutos = produtoEdicao.IdProdutos;
            txtDescricao.Text = produtoEdicao.DescricaoProduto;
            txtCodigoBarra.Text = produtoEdicao.CodigoBarra;
            cbxFornecedor.EditValue = produtoEdicao.clientespessoas_idclientespessoas;
            cbxCategoria.EditValue = produtoEdicao.categoriasprodutos_idcategoriasprodutos;
            cbxMarca.EditValue = produtoEdicao.marcasprodutos_idmarcasprodutos;
            cbxUnidade.EditValue = produtoEdicao.unidadesmedidasprodutos_idunidadesmedidasprodutos;
            tsStatus.IsOn = Convert.ToBoolean(produtoEdicao.StatusProduto);
            txtPrecoCusto.Text = Convert.ToString(produtoEdicao.PrecoCusto);
            txtMargemLucro.Text = Convert.ToString(produtoEdicao.MargemLucro);
            txtPrecoVenda.Text = Convert.ToString(produtoEdicao.PrecoVenda);
            tsCalcularPrecoProdutoAut.IsOn = Convert.ToBoolean(produtoEdicao.CalcularAutomatico);
            txtEstoqueAtual.Text = Convert.ToString(produtoEdicao.EstoqueAtual);
            txtEstoqueMin.Text = Convert.ToString(produtoEdicao.EstoqueMinimo);
            txtEstoqueMax.Text = Convert.ToString(produtoEdicao.EstoqueMaximo);
            tsControlarEstoque.IsOn = Convert.ToBoolean(produtoEdicao.ControlarEstoque);
        }

        private void NovoProduto_Load(object sender, EventArgs e)
        {
            txtDescricao.Focus();
            AtualizarCategoriasProdutos();
            AtualizarMarcasProdutos();
            AtualizarUnidadesMedidas();
            AtualizarFornecedores();
            
        }
        private void AtualizarGrid()
        {
            Views.Produtos view = Application.OpenForms["Produtos"] as Views.Produtos;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        public void AtualizarFornecedores()
        {
            cbxFornecedor.Properties.DataSource = clientePessoaController.ObterTodosClientesPessoas();
            cbxFornecedor.Properties.DisplayMember = "nome";
            cbxFornecedor.Properties.ValueMember = "idclientespessoas";
        }
        private void AtualizarCategoriasProdutos()
        {
            cbxCategoria.Properties.DataSource = categoriaController.ObterTodasCategorias();
            cbxCategoria.Properties.DisplayMember = "descricaocategoria";
            cbxCategoria.Properties.ValueMember = "idcategoriasprodutos";
        }
        private void AtualizarMarcasProdutos()
        {
            cbxMarca.Properties.DataSource = marcaController.ObterTodasMarcas();
            cbxMarca.Properties.DisplayMember = "descricaomarca";
            cbxMarca.Properties.ValueMember = "idmarcasprodutos";
        }
        private void AtualizarUnidadesMedidas()
        {
            cbxUnidade.Properties.DataSource = unidadeMedidaController.ObterTodasUnidadesMedidas();
            cbxUnidade.Properties.DisplayMember = "descricaounidademedida";
            cbxUnidade.Properties.ValueMember = "idunidadesmedidasprodutos";
        }
        private void Salvar()
        {
            
            try
            {
                produto.DescricaoProduto = txtDescricao.Text;
                produto.CodigoBarra = txtCodigoBarra.Text;
                produto.clientespessoas_idclientespessoas = Convert.ToInt32(cbxFornecedor.EditValue);
                produto.categoriasprodutos_idcategoriasprodutos = Convert.ToInt32(cbxCategoria.EditValue);
                produto.marcasprodutos_idmarcasprodutos = Convert.ToInt32(cbxMarca.EditValue);
                produto.unidadesmedidasprodutos_idunidadesmedidasprodutos = Convert.ToInt32(cbxUnidade.EditValue);
                produto.PrecoCusto = Convert.ToDecimal(txtPrecoCusto.Text.Replace("R$", ""));
                produto.MargemLucro = Convert.ToDecimal(txtMargemLucro.Text.Replace("%", ""));
                produto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text.Replace("R$", ""));
                produto.EstoqueAtual = Convert.ToInt32(txtEstoqueAtual.Text);
                produto.EstoqueMinimo = Convert.ToInt32(txtEstoqueMin.Text);
                produto.EstoqueMaximo = Convert.ToInt32(txtEstoqueMax.Text);
                produto.StatusProduto = Convert.ToInt32(tsStatus.IsOn);
                produto.CalcularAutomatico = Convert.ToInt32(tsCalcularPrecoProdutoAut.IsOn);
                produto.ControlarEstoque = Convert.ToInt32(tsControlarEstoque.IsOn);
                ValidacaoCampos.Validar(produto);
                if (ValidacaoCampos.IsValid() && MessageBoxQuestionYesNo.Show($"Deseja salvar?") == DialogResult.Yes)
                {
                    if (!edicao)
                    {
                        produtoController.Adicionar(produto, usuarioLogado);
                    }
                    else
                    {
                        produtoController.Editar(produto, usuarioLogado);
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
        private void NovaCategoriaProduto()
        {
            categoria.DescricaoCategoria = InputBoxTextEdit.Show("Descrição", "Nova Categoria");
            ValidacaoCampos.Validar(categoria);
            if (ValidacaoCampos.IsValid() && MessageBoxQuestionYesNo.Show($"Deseja salvar nova categoria?") == DialogResult.Yes)
            {
                categoriaController.Adicionar(categoria);
                MessageBoxOK.Show("Salvo com sucesso!");
                AtualizarCategoriasProdutos();
            }
            
        }
        private void DeletarCategoriaProduto()
        {
            categoria.IdCategoriasProdutos = Convert.ToInt32(cbxCategoria.EditValue);
            if(MessageBoxQuestionYesNo.Show("Confirmar deletar categoria selecionada?") == DialogResult.Yes)
            {
                categoriaController.Deletar(categoria);
                MessageBoxOK.Show("Deletado com sucesso!");
                AtualizarCategoriasProdutos();
            }

        }
        private void NovaMarcaProduto()
        {
            marca.DescricaoMarca = InputBoxTextEdit.Show("Descrição", "Nova Marca");
            ValidacaoCampos.Validar(marca);
            if(ValidacaoCampos.IsValid() && MessageBoxQuestionYesNo.Show($"Deseja salvar nova marca?") == DialogResult.Yes)
            {
                marcaController.Adicionar(marca);
                MessageBoxOK.Show("Salvo com sucesso!");
                AtualizarMarcasProdutos();
            }
        }
        private void DeletarMarcaProduto()
        {
            marca.IdMarcasProdutos = Convert.ToInt32(cbxMarca.EditValue);
            if (MessageBoxQuestionYesNo.Show("Confirmar deletar marca selecionada?") == DialogResult.Yes)
            {
                marcaController.Deletar(marca);
                MessageBoxOK.Show("Deletado com sucesso!");
                AtualizarMarcasProdutos();
            }
        }
        private void NovaUnidadeMedidaProduto()
        {
            unidadeMedida.DescricaoUnidadeMedida = InputBoxTextEdit.Show("Descrição", "Nova Unidade Medida");
            ValidacaoCampos.Validar(unidadeMedida);
            if (ValidacaoCampos.IsValid() && MessageBoxQuestionYesNo.Show($"Deseja salvar nova unidade medida?") == DialogResult.Yes)
            {
                unidadeMedidaController.Adicionar(unidadeMedida);
                MessageBoxOK.Show("Salvo com sucesso!");
                AtualizarUnidadesMedidas();
            }
        }
        private void DeletarUnidadeMedidaProduto()
        {
            unidadeMedida.IdUnidadesMedidasProdutos = Convert.ToInt32(cbxUnidade.EditValue);
            if (MessageBoxQuestionYesNo.Show("Confirmar deletar unidade selecionada?") == DialogResult.Yes)
            {
                unidadeMedidaController.Deletar(unidadeMedida);
                MessageBoxOK.Show("Deletado com sucesso!");
                AtualizarUnidadesMedidas();
            }
        }
        private void cbxCategoria_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                DeletarCategoriaProduto();
            }
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                NovaCategoriaProduto();
            }
                
        }
        private void cbxMarca_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                DeletarMarcaProduto();
            }
            if(e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                NovaMarcaProduto();
            }
        }

        private void cbxUnidade_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                DeletarUnidadeMedidaProduto();
            }
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                NovaUnidadeMedidaProduto();
            }
        }

        private void cbxFornecedor_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                Views.ClientesPessoas FormClientesPessoas = new ClientesPessoas(usuarioLogado);
                FormClientesPessoas.ShowDialog();
            }
             
        }
        private void CalcularAutomaticoPrecoVenda(bool calc)
        {
            try
            {
                double precocusto = Convert.ToDouble(txtPrecoCusto.Text.Replace("R$", ""));
                double margemlucro = Convert.ToDouble(txtMargemLucro.Text.Replace("%", ""));
                if (calc && precocusto > 0 && margemlucro > 0)
                {
                    double valorlucro = precocusto * margemlucro / 100;
                    
                    txtPrecoVenda.Text = Convert.ToString(precocusto + valorlucro);
                }
            }
            catch (System.FormatException)
            {

            }
            
        }
        private void tsCalcularPrecoProdutoAut_Toggled(object sender, EventArgs e)
        {
            if (tsCalcularPrecoProdutoAut.IsOn)
            {
                txtPrecoVenda.ReadOnly = true;
                
            }
            else
            {
                txtPrecoVenda.ReadOnly = false;
            }
        }

        private void txtMargemLucro_EditValueChanged(object sender, EventArgs e)
        {

            CalcularAutomaticoPrecoVenda(tsCalcularPrecoProdutoAut.IsOn);
        }

        private void txtPrecoCusto_EditValueChanged(object sender, EventArgs e)
        {
            CalcularAutomaticoPrecoVenda(tsCalcularPrecoProdutoAut.IsOn);
        }

        private void cbxFornecedor_Properties_DoubleClick(object sender, EventArgs e)
        {
            AtualizarFornecedores();
        }

        private void NovoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void tsControlarEstoque_Toggled(object sender, EventArgs e)
        {
            if (tsControlarEstoque.IsOn)
            {
                txtEstoqueAtual.Enabled = true;
                txtEstoqueMin.Enabled = true;
                txtEstoqueMax.Enabled = true;
                
            }
            else
            {
                txtEstoqueAtual.Enabled = false;
                txtEstoqueMin.Enabled = false;
                txtEstoqueMax.Enabled = false;
                txtEstoqueAtual.Text = string.Empty;
                txtEstoqueMin.Text = string.Empty;
                txtEstoqueMax.Text = string.Empty;
            }
        }

        private void NovoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                Salvar();
            }
        }
    }
}
