using AdvanceShop.Models;
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
    public partial class ObservacaoPDV : DevExpress.XtraEditors.XtraForm
    {
        public TransacoesCaixaModel transacaoVendaPDV { get; set; }
        public ObservacaoPDV(TransacoesCaixaModel transacaoCaixa)
        {
            InitializeComponent();
            transacaoVendaPDV = new TransacoesCaixaModel();
            transacaoVendaPDV.ObservacaoTransacao = transacaoCaixa.ObservacaoTransacao;
            txtObservacao.Text = transacaoVendaPDV.ObservacaoTransacao;
        }
        private void AdicionarObservacaoVenda()
        {
            transacaoVendaPDV.ObservacaoTransacao = txtObservacao.Text;

            DialogResult = DialogResult.OK;
        }
        private void ObservacaoPDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                Close();
            }
            
        }

        private void ObservacaoPDV_Load(object sender, EventArgs e)
        {
            txtObservacao.Focus();
        }

        private void ObservacaoPDV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                AdicionarObservacaoVenda();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AdicionarObservacaoVenda();
        }

        private void txtObservacao_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtObservacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
