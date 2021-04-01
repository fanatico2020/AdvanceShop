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
        public string unidademedida { get; set; }
        public string codigo_ncm { get; set; }
        public string cfop { get; set; }
        public string icms_origem { get; set; }
        public string icms_situacao_tributaria { get; set; }
    }
}
