using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Shared.CustomInputBox
{
    public static class InputBoxTextEdit
    {
        public static string Show(string Prompt, string Caption)
        {
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.Caption = Caption;
            args.Prompt = Prompt;
            args.DefaultButtonIndex = 0;
            args.DefaultResponse = "";
            TextEdit editor = new TextEdit();
            editor.Properties.MaxLength = 70;
            editor.Properties.CharacterCasing = CharacterCasing.Upper;
            args.Editor = editor;
            
            XtraInputBox.Show(args);
            if (editor.Text != string.Empty){
                return editor.Text;
            }
            else
            {
                return null;
            }
            
        }

    }
}
