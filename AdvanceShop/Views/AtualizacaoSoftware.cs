using AdvanceShop.Shared.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Views
{
    public partial class AtualizacaoSoftware : DevExpress.XtraEditors.XtraForm
    {
        public AtualizacaoSoftware()
        {
            InitializeComponent();
        }

        private void AtualizacaoSoftware_Load(object sender, EventArgs e)
        {
            lblVersaoAtualServidor.Text = $"Versão atual {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()} ";
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            CheckDownload();
        }
        private void CheckDownload()
        {
            //host = geonosis09.umbler.host
            //porta = 21
            //diretorio = /home/advanceshopsistema.com.br/
            const string url = "ftp://advanceshopsistema-com-br@geonosis09.umbler.host/setup/version/version.txt";

            NetworkCredential credentials = new NetworkCredential("advanceshopsistema-com-br", "[M5;Dt=H9R{+=0k");

            
            WebClient request =  new WebClient();
            request.Credentials = credentials;

            byte[] newfileData = request.DownloadData(url);
            string fileString = System.Text.Encoding.UTF8.GetString(newfileData);

            lblVersaoAtualServidor.Text = $"{lblVersaoAtualServidor.Text} | Versão servidor {fileString}";

        }

        private void AtualizacaoSoftware_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }
    }
}
