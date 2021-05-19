using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class VendasModel
    {
        //se a venda for editada, deve-se alterar data somente nas transações do caixa
        //venda editada altera também meio de pagamento seguido da mesma id ..
        public int IdVendas { get; set; }//tambem ref da nf
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public decimal TotalFinal { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Troco { get; set; }
        public int deletado { get; set; }
        public int clientespessoas_idclientespessoas { get; set; }
        public int caixas_idcaixas { get; set; }
        //api focus
        public string nfcstatus { get; set; }
        public string nfcnumero { get; set; }
        public string nfcmensagem_sefaz { get; set; }
        public string nfccaminho_xml_nota_fiscal { get; set; }
        public string nfccaminho_danfe { get; set; }
    }
}
