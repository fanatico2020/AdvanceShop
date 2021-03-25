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
    public static class MessageBoxWarning
    {
        public static void Show(string Text)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = "Atenção";
            args.Text = Text;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            args.Icon = StockIconHelper.GetWindows8AssociatedIcon(SystemIcons.Warning);
            args.Showing += Args_Showing;
            XtraMessageBox.Show(args).ToString();
        }
        private static void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Appearance.FontSizeDelta = 3;
            e.Buttons[DialogResult.OK].Text = "OK";
            
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
