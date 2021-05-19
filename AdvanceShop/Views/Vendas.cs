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
        public void AtualizarGrid()
        {
            splashScreenManager1.ShowWaitForm();

            DataTable dataSource = vendaController.ObterTodasVendas();
            gridControl.DataSource = dataSource;
            gridControl.Refresh();
            bsiRecordsCount.Caption = "Registros : " + dataSource.Rows.Count;


            if (ValidacaoConexaoInternet.EstarConectado())
            {
                foreach (DataRow row in dataSource.Rows)
                {
                    string referencia = row[0].ToString();
                    consultaNFC_e = apiFocusNfeController.RetornaInformacaoSobreNFC_e(apiFocusNfe, referencia).GetAwaiter().GetResult().;
                    venda.IdVendas = Convert.ToInt32(referencia);
                    venda.nfcstatus = consultaNFC_e.status;
                    venda.nfcnumero = consultaNFC_e.numero;
                    venda.nfcmensagem_sefaz = consultaNFC_e.mensagem_sefaz;
                    venda.nfccaminho_xml_nota_fiscal = consultaNFC_e.caminho_xml_nota_fiscal;
                    venda.nfccaminho_danfe = consultaNFC_e.caminho_danfe;
                    vendaController.EditarVendaStatusFocusNFC_e(venda);
                }
            }
            splashScreenManager1.CloseWaitForm();
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
            if(advBandedGridViewVendas.SelectedRowsCount == 1)
            {
                try
                {
                    //Dados para cupom
                    venda.IdVendas = Convert.ToInt32(advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[0]));
                    if(advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[11]) != DBNull.Value) clientePessoa.IdClientesPessoas = Convert.ToInt32(advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[11]));
                    caixa.IdCaixas = Convert.ToInt32(advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[12]));
                    dataHora.vendas_idvendas = venda.IdVendas;

                    venda = vendaController.ObterDadosDaVendaPorID(venda);
                    clientePessoa = clientePessoaController.ObterDadosDoClientePessoaPorID(clientePessoa);
                    caixa = caixaController.ObterDadosDoCaixaPorID(caixa);
                    dataHora = dataHoraController.ObterDadosDataHoraPorIDVenda(dataHora);


                    //print
                    Shared.CustomPrint.CupomNaoFiscal.ImprimirCupom(venda, clientePessoa, usuarioLogado, caixa, dataHora,configGerais);
                }
                
                catch(Exception error)
                {
                    MessageBoxError.Show(error.Message);
                }
                
            }
            
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
            string caminhoDanfe = advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[17]).ToString();
            System.Diagnostics.Process.Start($@"https://api.focusnfe.com.br{caminhoDanfe}");
        }

        private void bbiXML_NFC_e_ItemClick(object sender, ItemClickEventArgs e)
        {
            string caminhoXML = advBandedGridViewVendas.GetRowCellValue(advBandedGridViewVendas.GetSelectedRows()[0], advBandedGridViewVendas.Columns[16]).ToString();
            System.Diagnostics.Process.Start($@"https://api.focusnfe.com.br{caminhoXML}");
        }
    }
}