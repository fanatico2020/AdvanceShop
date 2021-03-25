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
    public partial class DescontoPDV : DevExpress.XtraEditors.XtraForm
    {
        public VendasModel vendaPDV { get; set; }
        public DescontoPDV(VendasModel Venda)
        {
            InitializeComponent();
            vendaPDV = new VendasModel();
            vendaPDV.Desconto = Venda.Desconto;
            vendaPDV.Valor = Venda.Valor;
            txtTotal.Text = Convert.ToString(vendaPDV.Valor);
            txtDescontoValor.Text = Convert.ToString(Venda.Desconto);
        }
        private void CalcularPrecoDesconto(bool DescontoPorcentagem)
        {
            try
            {
                decimal ValorTotal = Convert.ToDecimal(txtTotal.Text.Replace("R$", ""));
                decimal Desconto = Convert.ToDecimal(txtDescontoValor.Text.Replace("R$", ""));
                decimal DescontoPorcetagem = Convert.ToDecimal(txtDescontoPorcentagem.Text.Replace("%", ""));
                decimal TotalAPagar = 0;
                decimal Porcentagem = 0;
                if (!DescontoPorcentagem)
                {
                    TotalAPagar = ValorTotal - Desconto;
                    txtTotalAPagar.Text = Convert.ToString(TotalAPagar);
                    Porcentagem = Desconto / ValorTotal;
                    txtDescontoPorcentagem.Text = Convert.ToString(Porcentagem.ToString("P"));
                }
                else 
                {
                    Desconto = ValorTotal * DescontoPorcetagem /100;
                    txtDescontoValor.Text = Convert.ToString(Desconto);
                    TotalAPagar = ValorTotal - Desconto;
                    txtTotalAPagar.Text = Convert.ToString(TotalAPagar);
                    Porcentagem = Desconto / ValorTotal;
                    txtDescontoPorcentagem.Text = Convert.ToString(Porcentagem.ToString("P"));
                }

            }
            catch (FormatException)
            {

            }
            catch (DivideByZeroException)
            {

            }
        }
        private void DescontoPDV_Load(object sender, EventArgs e)
        {
            txtDescontoValor.Focus();
        }
        private void AdicionarDescontoPDV()
        {
            vendaPDV.Desconto = Convert.ToDecimal(txtDescontoValor.Text.Replace("R$", ""));

            DialogResult = DialogResult.OK;
        }
        private void DescontoPDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                Close();
            }
        }

        private void DescontoPDV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                AdicionarDescontoPDV();

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AdicionarDescontoPDV();
        }

        private void txtDescontoValor_EditValueChanged(object sender, EventArgs e)
        {
            CalcularPrecoDesconto(false);
        }

        private void txtDescontoPorcentagem_EditValueChanged(object sender, EventArgs e)
        {
            CalcularPrecoDesconto(true);
        }
    }
}
