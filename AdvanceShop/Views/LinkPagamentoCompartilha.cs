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
    public partial class LinkPagamentoCompartilha : DevExpress.XtraEditors.XtraForm
    {
        public LinkPagamentoCompartilha(string URL)
        {
            InitializeComponent();
            txtLinkURL.EditValue = URL;
        }
        private void LinkPagamentoCompartilha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void LinkPagamentoCompartilha_Load(object sender, EventArgs e)
        {

        }

        private void LinkPagamentoCompartilha_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    Close();
                    break;
                case Keys.F4:
                    Clipboard.SetText(txtLinkURL.Text);
                    break;
                default:
                    break;
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCopiarLink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtLinkURL.Text);
        }
    }
}
