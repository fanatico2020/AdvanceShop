using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class VendasModels
    {
        //se a venda for editada, deve-se alterar data somente nas transações do caixa
        //venda editada altera também meio de pagamento seguido da mesma id ..
        public int Id { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public int ClienteVenda { get; set; }//(FK)
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public decimal TotalFinal { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Troco { get; set; }
        public string UsuarioCadastro { get; set; }

    }
}
