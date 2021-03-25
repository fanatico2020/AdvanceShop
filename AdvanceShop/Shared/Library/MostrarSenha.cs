using AdvanceShop.Properties;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Shared.Library
{
    public static class MostrarSenha
    {
        public static void SenhaTextEdit(TextEdit textEdit)
        {
            if (textEdit.Properties.UseSystemPasswordChar)
            {
                textEdit.Properties.UseSystemPasswordChar = false;
                textEdit.Properties.ContextImageOptions.Image = Resources.hide_16x16;
            }
            else if (!textEdit.Properties.UseSystemPasswordChar)
            {

                textEdit.Properties.UseSystemPasswordChar = true;
                textEdit.Properties.ContextImageOptions.Image = Resources.show_16x16;
            }
        }
        public static void MensagemToolTipTextEdit(TextEdit textEdit)
        {
            if (textEdit.Properties.UseSystemPasswordChar)
            {
                textEdit.ToolTip = "Duplo clicks sobre a imagem no controle para visualizar a senha!";

            }
            else if (!textEdit.Properties.UseSystemPasswordChar)
            {
                textEdit.ToolTip = "Duplo clicks sobre a imagem no controle para esconder a senha!";
            }
        }
    }
}
