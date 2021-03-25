using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class ProdutosPDVModel
    {
        public int codigoproduto { get; set; }
        public int item { get; set; }
        public string descricaoproduto { get; set; }
        public int quantidade { get; set; }
        public decimal precounitario { get; set; }
        public decimal subtotal { get; set; }
    }
}
