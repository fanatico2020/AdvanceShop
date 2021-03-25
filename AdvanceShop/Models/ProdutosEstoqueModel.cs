using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class ProdutosEstoqueModel
    {
        public int idprodutos { get; set; }
        public int item { get; set; }
        public string descricaoprotudo { get; set; }
        public int quantidade { get; set; }
        public decimal precocusto { get; set; }
        public decimal margem { get; set; }
        public decimal precovenda { get; set; }
        public int idclientespessoas { get; set; }
        public string fornecedor { get; set; }
    }
}
