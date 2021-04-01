using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class ItensVendasModel
    {
        public int IdItensVendas { get; set; }
        public string DescricaoProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public int vendas_idvendas { get; set; }
        public int produtos_idprodutos { get; set; }
        public int Item { get; set; }
        public int transacoesestoque_idtransacoesestoque { get; set; }
        public string UnidadeMedida { get; set; }
        public string codigo_ncm { get; set; }
        public string cfop { get; set; }
        public string icms_origem { get; set; }
        public string icms_situacao_tributaria { get; set; }

    }
}
