using AdvanceShop.Controllers;
using AdvanceShop.Models;
using AdvanceShop.Shared.Validation;
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
    public partial class RelParCaixa : DevExpress.XtraEditors.XtraForm
    {
        CaixasController caixasController = new CaixasController();
        CaixasModel caixas = new CaixasModel();
        public RelParCaixa(string Titulo)
        {
            InitializeComponent();
            Text = Titulo;
        }
        private void AtualizarCaixas()
        {
            gridControl1.DataSource = caixasController.ObterTodosCaixas();
        }
        private void RelParCaixa_Load(object sender, EventArgs e)
        {
            AtualizarCaixas();
        }

        private void RelParCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ConfirmacaoForm.Fechar(e, this);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            caixas.IdCaixas = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[0]));
            Shared.CustomPrint.FechamentoCaixa.ImprimirFechamentoCaixa(caixas);
        }
    }
}
