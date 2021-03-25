using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Shared.CustomMessageBox
{
    public static class MessageBoxQuestionYesNo
    {
        public static DialogResult Show(string Text)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = "Confirmação";
            args.Text = Text;
            args.Buttons = new DialogResult[] { DialogResult.Yes,DialogResult.No };
            args.Icon = StockIconHelper.GetWindows8AssociatedIcon(SystemIcons.Question);
            args.Showing += Args_Showing;
            DialogResult result =  XtraMessageBox.Show(args);
            return result;
        }
        private static void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Appearance.FontSizeDelta = 3;
            e.Buttons[DialogResult.Yes].Text = "Sim";
            e.Buttons[DialogResult.No].Text = "Não";
            //increased button height and font size
            MessageButtonCollection buttons = e.Buttons as MessageButtonCollection;
            SimpleButton btn = buttons[System.Windows.Forms.DialogResult.OK] as SimpleButton;
            if (btn != null)
            {
                btn.Size = new Size(64, 18);
                btn.Appearance.FontSizeDelta = 3;
                btn.Height += 10;
            }
            
        }
    }
}
