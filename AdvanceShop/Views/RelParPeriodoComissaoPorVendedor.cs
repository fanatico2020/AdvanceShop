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
    public partial class RelParPeriodoComissaoPorVendedor : DevExpress.XtraEditors.XtraForm
    {
        string relatorio;
        UsuariosController usuarioController = new UsuariosController();
        public RelParPeriodoComissaoPorVendedor(string Titulo,string Relatorio)
        {
            InitializeComponent();
            Text = Titulo;
            relatorio = Relatorio;
        }
        private void AtualizarUsuariosVendedores()
        {
            cbxUsuarioVendedor.Properties.DataSource = usuarioController.ObterTodosUsuariosAcesso_Nome();
            cbxUsuarioVendedor.Properties.DisplayMember = "usuarioacesso";
            cbxUsuarioVendedor.Properties.ValueMember = "idusuarios";
        }
        private void RelParPeriodo_Load(object sender, EventArgs e)
        {
            AtualizarUsuariosVendedores();
        }
        private void GerarRelatorio(string Relatorio)
        {
            switch (Relatorio)
            {
                case "RelatorioComissaoPorVendedor":
                    Shared.CustomPrint.ComissaoPorVendedor.ImprimirComissaoPorVendedor(
                        cbxUsuarioVendedor.Text,txtPorcentagemComissao.Text,txtPeriodoInicial.DateTime,txtPeriodoFinal.DateTime);
                    Close();
                    break;
                
                default:
                    break;
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cbxUsuarioVendedor.Text) && !string.IsNullOrEmpty(txtPorcentagemComissao.Text))
            {
                GerarRelatorio(relatorio);
            }
            else
            {
                MessageBoxError.Show("Preencher todos os parâmetros!");
            }
            
        }

        private void RelParPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }
    }
}
