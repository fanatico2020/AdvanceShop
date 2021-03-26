using AdvanceShop.Shared.Library;
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
    public partial class IdentidadePlano : DevExpress.XtraEditors.XtraForm
    {
        public IdentidadePlano()
        {
            InitializeComponent();
        }

        private void txtSenha_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarSenha.SenhaTextEdit(txtSenha);
        }

        private void txtSenha_MouseMove(object sender, MouseEventArgs e)
        {
            MostrarSenha.MensagemToolTipTextEdit(txtSenha);
        }

        private void cbxOfflineChave_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxOfflineChave.Checked)
            {
                txtEmail.Text = string.Empty;
                txtSenha.Text = string.Empty;
                txtEmail.Enabled = false;
                txtSenha.Enabled = false;
                txtChave.Enabled = true;
            }
            else
            {

                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                txtChave.Enabled = false;
            }
        }

        private void IdentidadePlano_Load(object sender, EventArgs e)
        {

        }

        private void IdentidadePlano_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void IdentidadePlano_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
