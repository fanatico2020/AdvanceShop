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
    public partial class RelParStatusPgPeriodo : DevExpress.XtraEditors.XtraForm
    {
        public RelParStatusPgPeriodo(string Titulo)
        {
            InitializeComponent();
            Text = Titulo;
        }

        private void RelParStatusPgPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void RelParStatusPgPeriodo_Load(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxStatusPagamento.Text))
            {
                Shared.CustomPrint.ContasAPagarPagas.ImprimirContasAPagarPagasPorStatusPeriodo(
                        cbxStatusPagamento.Text.Substring(0,1), txtPeriodoInicial.DateTime, txtPeriodoFinal.DateTime);
                Close();
            }
            else
            {
                MessageBoxError.Show("Preencher todos os parâmetros!");
            }
        }
    }
}
