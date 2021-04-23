using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class TransacoesCaixaModel
    {
        public int IdTransacoesCaixa { get; set; }
        public int Tipo { get; set; }
        public string DescricaoTransacao { get; set; }
        public decimal Valor { get; set; }
        public string ObservacaoTransacao { get; set; }
        public int Status { get; set; }
        public int caixas_idcaixas { get; set; }
        public int vendas_idvendas { get; set; }
        public decimal SaldoEmDinheiro { get; set; }
        public int charge_id { get; set; }
        public string payment_url { get; set; }
    }
}
