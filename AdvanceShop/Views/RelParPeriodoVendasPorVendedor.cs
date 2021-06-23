using AdvanceShop.Controllers;
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
    public partial class RelParPeriodoVendasPorVendedor : DevExpress.XtraEditors.XtraForm
    {
        string relatorio;
        UsuariosController usuarioController = new UsuariosController();
        public RelParPeriodoVendasPorVendedor(string Titulo)
        {
            InitializeComponent();
            Text = Titulo;
        }
        private void AtualizarUsuariosVendedores()
        {
            cbxUsuarioVendedor.Properties.DataSource = usuarioController.ObterTodosUsuariosAcesso_Nome();
            cbxUsuarioVendedor.Properties.DisplayMember = "usuarioacesso";
            cbxUsuarioVendedor.Properties.ValueMember = "idusuarios";
        }
        private void RelParPeriodoVendasPorVendedor_Load(object sender, EventArgs e)
        {
            AtualizarUsuariosVendedores();
        }

        private void RelParPeriodoVendasPorVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxUsuarioVendedor.Text))
            {
                Shared.CustomPrint.VendasPorVendedor.ImprimirVendasPorVendedor(
                       cbxUsuarioVendedor.Text,txtPeriodoInicial.DateTime, txtPeriodoFinal.DateTime);
                Close();
            }
            else
            {
                MessageBoxError.Show("Preencher todos os parâmetros!");
            }
        }
    }
}
