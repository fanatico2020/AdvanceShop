using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using AdvanceShop.Models;
using AdvanceShop.Shared.Validation;
using AdvanceShop.Controllers;
using AdvanceShop.Shared.CustomMessageBox;
using System.Net.Http;
using Newtonsoft.Json;
using AdvanceShop.JsonModels.FocusNFe.NFC_e;
using System.IO;
using DevExpress.XtraReports.UI;
using System.Net;
using SelectPdf;
using DevExpress.XtraPdfViewer;
using DevExpress.Utils.Menu;

namespace AdvanceShop.Views
{
    public partial class Vendas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UsuariosModel usuarioLogado = new UsuariosModel();
        ConfiguracoesGeraisController configGeraisController = new ConfiguracoesGeraisController();
        ConfiguracoesGeraisModel configGerais = new ConfiguracoesGeraisModel();
        DataHoraModel dataHora = new DataHoraModel();
        DataHoraController dataHoraController = new DataHoraController();
        ClientesPessoasModel clientePessoa = new ClientesPessoasModel();
        ClientesPessoasController clientePessoaController = new ClientesPessoasController();
        CaixasModel caixa = new CaixasModel();
        CaixasController caixaController = new CaixasController();
        VendasModel venda = new VendasModel();
        VendasController vendaController = new VendasController();
        ItensVendasModel itensVenda = new ItensVendasModel();
        ItensVendasController itensVendaController = new ItensVendasController();

        //fiscal
        Consulta consultaNFC_e = new Consulta();
        ApiFocusNfeModel apiFocusNfe = new ApiFocusNfeModel();
        ApiFocusNFeController apiFocusNfeController = new ApiFocusNFeController();
        public Vendas(UsuariosModel UsuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = UsuarioLogado;
            configGerais = configGeraisController.ObterConfiguracoesGerais();
            apiFocusNfe = apiFocusNfeController.ObterConfiguracoesApiFocusNfe();
        }
        public async void AtualizarGrid()
        {
            splashScreenManager1.ShowWaitForm();

            DataTable dataSource = vendaController.ObterTodasVendas();
            gridControl.DataSource = dataSource;
            gridControl.Refresh();
            bsiRecordsCount.Caption = "Registros : " + dataSource.Rows.Count;

            splashScreenManager1.CloseWaitForm();
            if (ValidacaoConexaoInternet.EstarConectado() && apiFocusNfe.usarapi == 1)
            {
                foreach (DataRow row in dataSource.Rows)
                {
                    string referencia = row[0].ToString();
                    consultaNFC_e = await apiFocusNfeController.RetornaInformacaoSobreNFC_e(apiFocusNfe, referencia);
                    if(consultaNFC_e.codigo != "nao_encontrado")
                    {
                        venda.IdVendas = Convert.ToInt32(referencia);
                        switch (consultaNFC_e.status)
                        {
                            case "autorizado":
                                venda.nfcstatus = 0;
                                break;
                            case "cancelado":
                                venda.nfcstatus = 1;
                                break;
                            case "erro_autorizacao":
                                venda.nfcstatus = 2;
                                break;
                            case "denegado":
                                venda.nfcstatus = 3;
                                break;
                            default:
                                venda.nfcstatus = int.Parse(null);
                                break;
                        }
                        
                        venda.nfcnumero = consultaNFC_e.numero;
                        venda.nfcmensagem_sefaz = consultaNFC_e.mensagem_sefaz;
                        venda.nfccaminho_xml_nota_fiscal = consultaNFC_e.caminho_xml_nota_fiscal;
                        venda.nfccaminho_danfe = consultaNFC_e.caminho_danfe;
                        vendaController.EditarVendaStatusFocusNFC_e(venda);
                    }
                    
                }
            }
            
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            
            
        }
        
        private void NovaVenda()
        {
            caixa.usuarios_idusuarios = usuarioLogado.IdUsuarios;
            
            if (caixaController.VerificarCaixaAbertoOuNao(caixa))
            {
                
                caixa = caixaController.AutenticarCaixaUsuario(caixa);
                Views.VendaCaixaPDV FormPDV = new VendaCaixaPDV(usuarioLogado,caixa);
                FormPDV.Show();
            }
            else
            {
                MessageBoxWarning.Show($"Você deve primeiro abrir seu caixa para usar o PDV!");
                Views.AbrirCaixa FormAbrirCaixa = new AbrirCaixa(usuarioLogado);
                FormAbrirCaixa.ShowDialog();
            }
        }
        private void TrocaDevolucao()
        {
            MessageBoxOK.Show("Ainda em desenvolvimento!");
            //venda.IdVendas = Convert.ToInt32(advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[0]));

            //if(advBandedGridViewVendas.SelectedRowsCount == 1 && MessageBoxQuestionYesNo.Show("Continuar para tela de Troca/Devolução de itens da venda selecionada?") == DialogResult.Yes)
            //{
            //    Views.TrocaDevolucao FormDevolucao = new TrocaDevolucao(venda,usuarioLogado);
            //    FormDevolucao.ShowDialog();
            //}
        }
        private void DeletarVenda()
        {
            venda.IdVendas = Convert.ToInt32(advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[0]));

            if (advBandedGridViewVendas.SelectedRowsCount == 1 && MessageBoxQuestionYesNo.Show("Confirmar deletar registro selecionado?") == DialogResult.Yes)
            {
                vendaController.Deletar(venda);
                MessageBoxOK.Show("Deletado com sucesso!");
                AtualizarGrid();
            }
        }
        private void ReimprimirCupomNaoFiscal()
        {
            if (advBandedGridViewVendas.SelectedRowsCount == 1)
            {
                try
                {
                    //Dados para cupom
                    venda.IdVendas = Convert.ToInt32(advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[0]));
                    if (advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[11]) != DBNull.Value) clientePessoa.IdClientesPessoas = Convert.ToInt32(advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[11]));
                    caixa.IdCaixas = Convert.ToInt32(advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[12]));
                    dataHora.vendas_idvendas = venda.IdVendas;

                    venda = vendaController.ObterDadosDaVendaPorID(venda);
                    clientePessoa = clientePessoaController.ObterDadosDoClientePessoaPorID(clientePessoa);
                    caixa = caixaController.ObterDadosDoCaixaPorID(caixa);
                    dataHora = dataHoraController.ObterDadosDataHoraPorIDVenda(dataHora);


                    //print
                    Shared.CustomPrint.CupomNaoFiscal.ImprimirCupom(venda, clientePessoa, usuarioLogado, caixa, dataHora, configGerais);
                }

                catch (Exception error)
                {
                    MessageBoxError.Show(error.Message);
                }

            }
        }
        private void ReimprimirCupomNFC_e()
        {
            string statusnfc = advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[13]).ToString();
            string referencia = advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[0]).ToString();
            if (statusnfc == "0")
            {
                string caminhoDanfe = advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[17]).ToString();


                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                string pagehtml = $"https://api.focusnfe.com.br{caminhoDanfe}";
                string html = wc.DownloadString(pagehtml);
                string arquivoPdf = $@"C:\AdvanceShop\NFC-e\NFC-e-Venda{referencia}.pdf";
                // instancia de HtmlToPdf
                HtmlToPdf converter = new HtmlToPdf();
                System.Text.Encoding.UTF8.GetBytes(html);
                // crear documento pdf convertendo html para pdf
                PdfDocument doc = converter.ConvertHtmlString(html);
                // salva documento em pdf
                doc.Save(arquivoPdf);
                // close pdf document
                doc.Close();
                FileInfo info = new FileInfo(arquivoPdf);
                if (info.Length > 50)
                {
                    VisualizarPDF FormVisualizarPDF = new VisualizarPDF(arquivoPdf);
                    FormVisualizarPDF.ShowDialog();
                }


            }
            else
            {
                MessageBoxWarning.Show("Não foi encontrado nenhuma NFC-e autorizada nessa venda!");
            }
        }
        private void VisualizarXML_NFC_e()
        {
            string statusnfc = advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[13]).ToString();
            if (statusnfc == "0" && statusnfc != "")
            {
                string caminhoXML = advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[16]).ToString();
                System.Diagnostics.Process.Start($@"https://api.focusnfe.com.br{caminhoXML}");
            }
            else
            {
                MessageBoxWarning.Show("Não foi encontrado nenhuma NFC-e autorizada nessa venda!");
            }
        }
        private void Vendas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void bbiNovaVenda_ItemClick(object sender, ItemClickEventArgs e)
        {

            NovaVenda();
        }

        private void bbiEditarVenda_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiDeletarVenda_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeletarVenda();
        }

        private void bbiAtualizarGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            AtualizarGrid();
        }

        private void bbiTrocaDevolucao_ItemClick(object sender, ItemClickEventArgs e)
        {
            TrocaDevolucao();
        }

        private void advBandedGridViewVendas_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "nome")
            {
                if (Convert.ToString(e.Value) == "") e.DisplayText = "CONSUMIDOR";
            }
            if(e.Column.FieldName == "nfcstatus")
            {
                if (e.Value == DBNull.Value) e.DisplayText = "Venda não fiscal";
                if (e.Value != DBNull.Value)
                {
                    if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Autorizado";
                    if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Cancelado";
                    if (Convert.ToInt32(e.Value) == 2) e.DisplayText = "2 - Error Autorização";
                    if (Convert.ToInt32(e.Value) == 3) e.DisplayText = "3 - Denegado";
                }
                
            }
        }

        private void advBandedGridViewVendas_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void advBandedGridViewVendas_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            itensVenda.vendas_idvendas = Convert.ToInt32(advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[0]));
            if (e.RelationIndex == 0)
            {
                e.ChildList = new BindingSource(itensVendaController.ObterTodosItensDaVendas(itensVenda), "");
            }
        }

        private void advBandedGridViewVendas_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            try
            {
                if (e.RelationIndex == 0)
                {
                    e.RelationName = $"Itens da Venda {advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[0])}";
                }
            }
            catch (System.IndexOutOfRangeException)
            {

            }
            catch (System.NullReferenceException)
            {

            }
        }

        private void advBandedGridViewVendas_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            if (e.RelationIndex == 0)
            {
                e.IsEmpty = false;
            }
        }

        private void advBandedGridViewVendas_MasterRowGetLevelDefaultView(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs e)
        {
            e.DefaultView = gridViewItensVenda;
        }

        private void bbiReimprimirCupomNaoFiscal_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReimprimirCupomNaoFiscal();
            
        }

        private void gridViewItensVenda_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "margemlucro")
            {
                e.DisplayText = $"{e.Value}%";
            }
        }

        private void bbiReimprimirNFC_e_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReimprimirCupomNFC_e();
        }
        

        private void bbiXML_NFC_e_ItemClick(object sender, ItemClickEventArgs e)
        {
            VisualizarXML_NFC_e();

        }

        private void advBandedGridViewVendas_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (advBandedGridViewVendas.SelectedRowsCount == 1)
            {
                if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
                {
                    DXMenuItem item1 = new DXMenuItem("Venda Caixa - PDV");
                    DXMenuItem item2 = new DXMenuItem("Troca / Devolução");
                    DXMenuItem item3 = new DXMenuItem("Deletar Venda");
                    DXMenuItem item4 = new DXMenuItem("Atualizar Grid");
                    DXMenuItem item5 = new DXMenuItem("Reimprimir Cupom Não Fiscal");
                    DXMenuItem item6 = new DXMenuItem("Reimprimir Cupom NFC-e");
                    DXMenuItem item7 = new DXMenuItem("Visualizar XML NFC-e");
                    item1.Click += (o, args) =>
                    {
                        NovaVenda();
                    };
                    item2.Click += (o, args) =>
                    {
                        TrocaDevolucao();
                    };
                    item3.Click += (o, args) =>
                    {
                        DeletarVenda();
                    };
                    item4.Click += (o, args) =>
                    {
                        AtualizarGrid();
                    };
                    item5.Click += (o, args) => {
                        ReimprimirCupomNaoFiscal();
                    };
                    item6.Click += (o, args) => {
                        ReimprimirCupomNFC_e();
                    };
                    item7.Click += (o, args) =>
                    {
                        VisualizarXML_NFC_e();
                    };
                    e.Menu.Items.Add(item1);
                    e.Menu.Items.Add(item2);
                    e.Menu.Items.Add(item3);
                    e.Menu.Items.Add(item4);
                    e.Menu.Items.Add(item5);
                    e.Menu.Items.Add(item6);
                    e.Menu.Items.Add(item7);
                }
            }
        }

        
    }
}