using AdvanceShop.Shared.CustomMessageBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Shared.Validation
{
    public static class ConfirmacaoForm
    {
        public static void Fechar(KeyPressEventArgs e, Form form)
        {
            if (e.KeyChar == (char)27 && MessageBoxQuestionYesNo.Show("Confirmar fechamento dessa tela?") == DialogResult.Yes)
            {
                form.Close();
            }
        }
    }
}
