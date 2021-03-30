using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace AdvanceShop.Report.Devexpress
{
    public partial class xrCupomNaoFiscal : DevExpress.XtraReports.UI.XtraReport
    {
        public xrCupomNaoFiscal()
        {
            InitializeComponent();
            
        }

        private void lblUsuario_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
            
            if (Parameters["UsuarioCaixa"].Value == null)
            {
                lblUsuario.Visible = false;
            }
        }

    }
}
