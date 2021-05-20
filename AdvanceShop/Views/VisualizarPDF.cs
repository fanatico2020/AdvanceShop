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
    public partial class VisualizarPDF : DevExpress.XtraEditors.XtraForm
    {
        public VisualizarPDF(string Arquivo)
        {
            InitializeComponent();
            pdfViewer1.LoadDocument(Arquivo);
        }

        private void VisualizarPDF_Load(object sender, EventArgs e)
        {

        }
    }
}
