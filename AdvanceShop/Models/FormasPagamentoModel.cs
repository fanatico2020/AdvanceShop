using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class FormasPagamentoModel
    {
        public int IdFormasPagamento { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int transacoescaixa_idtransacoescaixa { get; set; }
    }
}
