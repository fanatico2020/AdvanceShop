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
    public partial class AbrirCaixa : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        CaixasModel caixa = new CaixasModel();
        CaixasController caixaController = new CaixasController();
        bool edicao = false;
        public AbrirCaixa(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            caixa.usuarios_idusuarios = usuarioLogado.IdUsuarios;
        }
        public AbrirCaixa(UsuariosModel UsuarioLogado,CaixasModel caixaEditaSaldoInicial)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            caixa.IdCaixas = caixaEditaSaldoInicial.IdCaixas;
            txtSaldoInicial.Text = Convert.ToString(caixaEditaSaldoInicial.SaldoInicial);
            Text = "Editar Saldo Inicial";
            lblSaldoInicial.Text = "Editar saldo inicial de caixa já existente!";
            edicao = true;
        }
        private void AtualizarGrid()
        {
            Views.Caixas view = Application.OpenForms["Caixas"] as Views.Caixas;
            if (view != null)
            {
                view.AtualizarGrid();
            }
        }
        private void AbrirCaixa_Load(object sender, EventArgs e)
        {
            txtSaldoInicial.Focus();
        }

        private void AbrirCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }
        private void Salvar()
        {
            caixa.SaldoInicial = Convert.ToDecimal(txtSaldoInicial.Text.Replace("R$", ""));
            caixa.Maquina = Environment.MachineName;
            caixa.status = 0;
            if (MessageBoxQuestionYesNo.Show($"Deseja salvar caixa com saldo inicial {txtSaldoInicial.Text} ?") == DialogResult.Yes)
            {
                if (!edicao)
                {
                    caixaController.Adicionar_AbrirCaixa(caixa, usuarioLogado);
                }
                else
                {
                    caixaController.Editar_SaldoInicial(caixa, usuarioLogado);
                }

                MessageBoxOK.Show("Salvo com sucesso!");
                AtualizarGrid();
                Close();
            }
        }
        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            Salvar();

        }

        private void AbrirCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                Salvar();
            }
        }
    }
}
