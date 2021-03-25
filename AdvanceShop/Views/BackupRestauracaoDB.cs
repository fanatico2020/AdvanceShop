using AdvanceShop.Data;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomMessageBox;
using AdvanceShop.Shared.Validation;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdvanceShop.Views
{
    public partial class BackupRestauracaoDB : DevExpress.XtraEditors.XtraForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        //BackgroundWorker bgwProgresso = new BackgroundWorker();
        private System.ComponentModel.BackgroundWorker bgwProgresso = new System.ComponentModel.BackgroundWorker();
        bool restaurar = false;
        public BackupRestauracaoDB(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            bgwProgresso.WorkerReportsProgress = true;
            bgwProgresso.WorkerSupportsCancellation = true;
            bgwProgresso.DoWork += new System.ComponentModel.DoWorkEventHandler(bgwProgresso_DoWork);
            bgwProgresso.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(bgwProgresso_ProgressChanged);
            bgwProgresso.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(bgwProgresso_RunWorkerCompleted);
            
        }

        private void BackupRestauracaoDB_Load(object sender, EventArgs e)
        {
            txtCaminhoBackup.Text = $@"{System.AppDomain.CurrentDomain.BaseDirectory.ToString()}Backup";

            //barra backup
            pgbProgressoBackup.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            pgbProgressoBackup.Properties.EndColor = System.Drawing.Color.Green;
            pgbProgressoBackup.Properties.StartColor = System.Drawing.Color.DarkGreen;
            pgbProgressoBackup.Properties.ShowTitle = false;
            pgbProgressoBackup.Properties.LookAndFeel.SetStyle(DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat, false, false);
            //barra restauração
            pgbProgressoRestaurar.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            pgbProgressoRestaurar.Properties.EndColor = System.Drawing.Color.Green;
            pgbProgressoRestaurar.Properties.StartColor = System.Drawing.Color.DarkGreen;
            pgbProgressoRestaurar.Properties.ShowTitle = false;
            pgbProgressoRestaurar.Properties.LookAndFeel.SetStyle(DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat, false, false);
        }
        private void EfetuarBackup(string local, string nomeArquivo)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            MySqlBackup mb = new MySqlBackup(comando);
            mb.ExportToFile(local + "\\" + nomeArquivo + ".sql");
            conexao.Close();
        }
        private void RestaurarBackup(string arquivo)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            MySqlBackup mb = new MySqlBackup(comando);
            mb.ImportFromFile(arquivo);
            conexao.Close();
        }
        private void btnProcurarCaminho_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            if(fbDialog.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoBackup.Text = fbDialog.SelectedPath;
            }
            
        }
        private void GerarBackup()
        {
            if(MessageBoxQuestionYesNo.Show($"Deseja salvar o backup no caminho '{txtCaminhoBackup.Text}' ?") == DialogResult.Yes)
            {
                restaurar = false;
                if (!Directory.Exists(txtCaminhoBackup.Text) && MessageBoxQuestionYesNo.Show($"O caminho informado não existe deseja criá-lo e continuar com o backup?") == DialogResult.Yes)
                {
                    
                    Directory.CreateDirectory(txtCaminhoBackup.Text);
                    bgwProgresso.RunWorkerAsync();
                }
                else if(Directory.Exists(txtCaminhoBackup.Text))
                {
                    bgwProgresso.RunWorkerAsync();
                }
                
            }
        }

        private void btnGerarBackup_Click(object sender, EventArgs e)
        {
            GerarBackup();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (bgwProgresso.IsBusy)
            {
                bgwProgresso.CancelAsync();
            }
        }

        private void BackupRestauracaoDB_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void BackupRestauracaoDB_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    GerarBackup();
                    break;
                case Keys.F3:
                    RestaurarBackup();
                    break;
                default:
                    break;
            }
            
        }
        private void bgwProgresso_DoWork(object sender, DoWorkEventArgs e)//onde chama a tarefa demorada.
        {

            if (!restaurar)
            {
                var data = DateTime.Now.ToShortDateString().Replace("/", "");
                var hora = DateTime.Now.ToLongTimeString().Replace(":", "");

                EfetuarBackup(txtCaminhoBackup.Text, "ADVSHOP" + data + hora);


                for (int i = 0; i < 100; i++)
                {

                    //incrementa o progresso do backgroundWorker 
                    //a cada passagem do loop.
                    bgwProgresso.ReportProgress(i);

                    //Verifica se houve uma requisição para cancelar a operação.
                    if (bgwProgresso.CancellationPending)
                    {
                        //se sim, define a propriedade Cancel para true
                        //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                        e.Cancel = true;

                        //zera o percentual de progresso do backgroundWorker1.
                        bgwProgresso.ReportProgress(0);
                        return;
                    }
                    else
                    {
                        //Tempo
                        System.Threading.Thread.Sleep(20);
                        bgwProgresso.ReportProgress(i * 1);
                    }
                }
            }
            else
            {
                RestaurarBackup(txtCaminhoArquivoRestaurar.Text);
                for (int i = 0; i < 100; i++)
                {

                    //incrementa o progresso do backgroundWorker 
                    //a cada passagem do loop.
                    this.bgwProgresso.ReportProgress(i);

                    //Verifica se houve uma requisição para cancelar a operação.
                    if (bgwProgresso.CancellationPending)
                    {
                        //se sim, define a propriedade Cancel para true
                        //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                        e.Cancel = true;

                        //zera o percentual de progresso do backgroundWorker1.
                        bgwProgresso.ReportProgress(0);
                        return;
                    }
                    else
                    {
                        //Tempo
                        System.Threading.Thread.Sleep(20);
                        bgwProgresso.ReportProgress(i * 1);
                    }

                }
                //Finalmente, caso tudo esteja ok, finaliza
                //o progresso em 100%.
                bgwProgresso.ReportProgress(100);
            }
            
        }
        private void bgwProgresso_ProgressChanged(object sender, ProgressChangedEventArgs e)//Motra Incremento do processo ou decremento na barra.
        {
            if (!restaurar)
            {
                //Incrementa o valor da progressbar com o valor
                //atual do progresso da tarefa.
                for (int i = 1; i <= e.ProgressPercentage; i++)
                {
                    pgbProgressoBackup.Decrement(100);
                    pgbProgressoBackup.Increment(i);
                }

                //informa o percentual na forma de texto.
                lblProgressoBackup.Text = (e.ProgressPercentage.ToString() + "%");
            }
            else
            {
                //Incrementa o valor da progressbar com o valor
                //atual do progresso da tarefa.
                for (int i = 1; i <= e.ProgressPercentage; i++)
                {
                    pgbProgressoRestaurar.Decrement(100);
                    pgbProgressoRestaurar.Increment(i);
                }

                //informa o percentual na forma de texto.
                //lblProgressoRestaurar.Visible = true;
                lblProgressoRestaurar.Text = (e.ProgressPercentage.ToString() + "%");
            }
            
        }
        private void bgwProgresso_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!restaurar)
            {
                //O que fazer após concluir a tarefa.
                if (e.Cancelled)
                {
                    //caso a operação seja cancelada, informa ao usuario.
                    lblProgressoBackup.Text = "Operação cancelada pelo usuário!";
                    pgbProgressoBackup.Decrement(100);
                    //habilita o Botao cancelar
                    btnCancelarBackup.Enabled = true;
                }
                else if (e.Error != null)
                {
                    //informa ao usuario do acontecimento de algum erro.
                    lblProgressoBackup.Text = "Aconteceu um erro durante a execução do processo!";
                }
                else
                {
                    //informa que a tarefa foi concluida com sucesso.
                    lblProgressoBackup.Text = "Tarefa concluida com sucesso!";
                    btnBackup.Enabled = true;


                    if (cbxFecharSistema.Checked)
                    {
                        lblProgressoBackup.Text = "Sistema sendo fechado...";
                        Application.Exit();
                    }
                }
            }
            else
            {
                //O que fazer após concluir a tarefa.
                if (e.Cancelled)
                {
                    //caso a operação seja cancelada, informa ao usuario.
                    lblProgressoRestaurar.Text = "Operação Cancelada pelo Usuário!";

                }
                else if (e.Error != null)
                {
                    //informa ao usuario do acontecimento de algum erro.
                    lblProgressoRestaurar.Text = "Aconteceu um erro durante a execução do processo!";
                }
                else
                {
                    //informa que a tarefa foi concluida com sucesso.
                    lblProgressoRestaurar.Text = "Concluido!";
                    MessageBoxOK.Show("Banco restaurado com sucesso!");

                }
            }
            
        }
        private void RestaurarBackup()
        {
            if (MessageBoxQuestionYesNo.Show($"Deseja restaurar o banco de dados com o backup '{txtCaminhoArquivoRestaurar.Text}' ?") == DialogResult.Yes)
            {
                restaurar = true;
                if (!bgwProgresso.IsBusy)
                {
                    bgwProgresso.RunWorkerAsync();
                }
               
            }
        }
        private void btnProcurarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Title = "Procurar arquivo de backup";
            ofDialog.InitialDirectory = $@"{System.AppDomain.CurrentDomain.BaseDirectory.ToString()}Backup";
            ofDialog.Filter = "SQL Backup(*.sql)|*.sql";
            ofDialog.RestoreDirectory = true;
            ofDialog.CheckFileExists = true;
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoArquivoRestaurar.Text = ofDialog.FileName;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            RestaurarBackup();
        }

        private void btnCancelarRestaurar_Click(object sender, EventArgs e)
        {
            if (bgwProgresso.IsBusy)//Se o backgroundWork estiver ocupado
            {
                //Notifica a thread que o cancelamento foi solicitado.
                //Cancela a tarefa DoWork
                bgwProgresso.CancelAsync();
            }
        }
    }
}
