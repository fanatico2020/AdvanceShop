using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Views
{
    public partial class ContadorDinheiro : DevExpress.XtraEditors.XtraForm
    {
        public ContadorDinheiro()
        {
            InitializeComponent();
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            BindingList<CedulaMoeda> dataSource = GetDataSource();
            gridControlContadorDinheiro.DataSource = dataSource;
        }
        private void ContadorDinheiro_Load(object sender, EventArgs e)
        {

        }
        public BindingList<CedulaMoeda> GetDataSource()
        {
            BindingList<CedulaMoeda> cedulaMoeda = new BindingList<CedulaMoeda>();
            cedulaMoeda.Add(new CedulaMoeda()
            {
                Descricao = 0.05m,
                Quantidade = 0

            });
            cedulaMoeda.Add(new CedulaMoeda()
            {
                Descricao = 0.10m,
                Quantidade = 0

            });
            cedulaMoeda.Add(new CedulaMoeda()
            {
                Descricao = 0.50m,
                Quantidade = 0

            });
            cedulaMoeda.Add(new CedulaMoeda()
            {
                Descricao = 1,
                Quantidade = 0

            });
            cedulaMoeda.Add(new CedulaMoeda()
            {
                Descricao = 2,
                Quantidade = 0

            });
            cedulaMoeda.Add(new CedulaMoeda()
            {
                Descricao = 5,
                Quantidade = 0

            });
            cedulaMoeda.Add(new CedulaMoeda()
            {
                Descricao = 10,
                Quantidade = 0

            });
            cedulaMoeda.Add(new CedulaMoeda()
            {
                Descricao = 20,
                Quantidade = 0

            });
            cedulaMoeda.Add(new CedulaMoeda()
            {
                Descricao = 50,
                Quantidade = 0

            });
            cedulaMoeda.Add(new CedulaMoeda()
            {
                Descricao = 100,
                Quantidade = 0

            });
            cedulaMoeda.Add(new CedulaMoeda()
            {
                Descricao = 200,
                Quantidade = 0

            });
            return cedulaMoeda;
        }
        public class CedulaMoeda
        {
            
            public decimal Descricao { get; set; }
            [Required]
            public int Quantidade { get; set; }
            //public string Total { get; set; }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Descricao")
            {
                if ((e.Value).ToString() == "0,05") e.DisplayText = "R$0,05 Centavos";
                if ((e.Value).ToString() == "0,10") e.DisplayText = "R$0,10 Centavos";
                if ((e.Value).ToString() == "0,50") e.DisplayText = "R$0,50 Centavos";
                if ((e.Value).ToString() == "1") e.DisplayText = "R$1,00 Real";
                if ((e.Value).ToString() == "2") e.DisplayText = "R$2,00 Reais";
                if ((e.Value).ToString() == "5") e.DisplayText = "R$5,00 Reais";
                if ((e.Value).ToString() == "10") e.DisplayText = "R$10,00 Reais";
                if ((e.Value).ToString() == "20") e.DisplayText = "R$20,00 Reais";
                if ((e.Value).ToString() == "50") e.DisplayText = "R$50,00 Reais";
                if ((e.Value).ToString() == "100") e.DisplayText = "R$100,00 Reais";
                if ((e.Value).ToString() == "200") e.DisplayText = "R$200,00 Reais";
            }
        }

        private void btnZerarContador_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
    }

}
