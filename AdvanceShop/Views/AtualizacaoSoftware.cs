using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Library;
using AdvanceShop.Shared.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        //host = geonosis09.umbler.host
        //porta = 21
        //diretorio = /home/advanceshopsistema.com.br/
        const string urlversao = "ftp://advanceshopsistema-com-br@geonosis09.umbler.host/setup/version/version.txt";
        const string urlsetup = "ftp://advanceshopsistema-com-br@geonosis09.umbler.host/setup/install/setup.exe";
        const string usuarioftp = "advanceshopsistema-com-br", senhaftp = "[M5;Dt=H9R{+=0k";
        string versaoServidor = "", versaoAssembly = "",diretorioTemp = "";
        NetworkCredential credentials;
        long sizeSetup;
        
        private System.ComponentModel.BackgroundWorker bgwProgresso = new System.ComponentModel.BackgroundWorker();
        public AtualizacaoSoftware()
        {
            InitializeComponent();
            lblProgresso.Visible = false;
            credentials = new NetworkCredential(usuarioftp, senhaftp);

            bgwProgresso.WorkerReportsProgress = true;
            bgwProgresso.WorkerSupportsCancellation = true;
            bgwProgresso.DoWork += new System.ComponentModel.DoWorkEventHandler(bgwProgresso_DoWork);
            bgwProgresso.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(bgwProgresso_ProgressChanged);
            bgwProgresso.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(bgwProgresso_RunWorkerCompleted);
        }

        private void AtualizacaoSoftware_Load(object sender, EventArgs e)
        {
            versaoAssembly = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lblVersaoAtualServidor.Text = $"Versão atual {versaoAssembly} ";

        }
        
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            CheckVersao();
        }
        private void CheckVersao()
        {

            WebClient request = new WebClient();
            request.Credentials = credentials;

            byte[] newfileData = request.DownloadData(urlversao);
            versaoServidor = System.Text.Encoding.UTF8.GetString(newfileData);

            lblVersaoAtualServidor.Text = $"Versão atual {versaoAssembly} | Versão servidor {versaoServidor}";

            //Tamanho setup
            FtpWebRequest requestSizeSetup =
            (FtpWebRequest)WebRequest.Create(urlsetup);
            requestSizeSetup.Credentials = credentials;
            requestSizeSetup.Method = WebRequestMethods.Ftp.GetFileSize;
            sizeSetup = requestSizeSetup.GetResponse().ContentLength;
            
            if (Convert.ToInt32(versaoServidor.Replace(".", "")) > Convert.ToInt32(versaoAssembly.Replace(".", "")) &&
                MessageBoxQuestionYesNo.Show($"Estar disponivel uma nova versão do sistema para download Setup.exe({SufixoTamanhoBytes.Converter(sizeSetup)}) deseja baixar e instalar ?") == DialogResult.Yes)
            {
                if (!bgwProgresso.IsBusy)
                {
                    lblProgresso.Visible = true;
                    btnVerificar.Enabled = false;
                    bgwProgresso.RunWorkerAsync();
                }
                else
                {
                    MessageBoxWarning.Show("Sistema ocupado, por favor espere!");
                }
                
            }

        }
        
        private void AtualizacaoSoftware_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }
        
        private void bgwProgresso_DoWork(object sender, DoWorkEventArgs e)//onde chama a tarefa demorada.
        {
            

            FtpWebRequest request =
            (FtpWebRequest)WebRequest.Create(urlsetup);
            request.Credentials = credentials;
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            diretorioTemp = $@"{System.AppDomain.CurrentDomain.BaseDirectory.ToString()}Temp";
            if (!Directory.Exists(diretorioTemp))
            {
                Directory.CreateDirectory(diretorioTemp);
            }
            using (Stream ftpStream = request.GetResponse().GetResponseStream())
            using (Stream fileStream = File.Create($@"{diretorioTemp}\setup.exe"))
            {
                byte[] buffer = new byte[10240];
                int read;


                while ((read = ftpStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fileStream.Write(buffer, 0, read);
                    lblProgresso.Invoke(
                        (MethodInvoker)(() => lblProgresso.Text = $"Baixando {SufixoTamanhoBytes.Converter(fileStream.Position)} de {SufixoTamanhoBytes.Converter(sizeSetup)}, aguarde..."));
                    
                }
            }

        }
        private void bgwProgresso_ProgressChanged(object sender, ProgressChangedEventArgs e)//Motra Incremento do processo ou decremento na barra.
        {
            
        }
        private void bgwProgresso_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //O que fazer após concluir a tarefa.
            if (e.Cancelled)
            {
                //caso a operação seja cancelada, informa ao usuario.
                lblProgresso.Text = "Operação cancelada pelo usuário!";
                btnVerificar.Enabled = true;
                
            }
            else if (e.Error != null)
            {
                //informa ao usuario do acontecimento de algum erro.
                lblProgresso.Text = "Aconteceu um erro durante a execução do processo!";
                btnVerificar.Enabled = true;
            }
            else
            {
                //informa que a tarefa foi concluida com sucesso.
                lblProgresso.Text = "Tarefa concluida com sucesso!";
                if(MessageBoxQuestionYesNo.Show("Download concluido, deseja instalar agora?") == DialogResult.Yes)
                {
                    Process.Start($@"{diretorioTemp}\setup.exe");
                    Application.Exit();
                }
                else
                {
                    Process.Start("explorer.exe", $@"{diretorioTemp})");
                    Close();
                }
            }
        }
    }
}
