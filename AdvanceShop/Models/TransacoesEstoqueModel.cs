using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    /*
        Entrada=
        Entrada de Estoque,
        Devolução Cliente,
        Ajuste Estoque,


        Saidas=
        Saida de Estoque,
        Venda,
        Devolução Fornecedor,
        Transferencia Entre Lojas,
        Uso Consumo,
        Bonificação

        */
    enum TipoTransacao
    {
        Entrada_Estoque = 1,
        Devolucao_Cliente = 2,
        Ajuste_Estoque = 3,
        Saida_Estoque = 4,
        Venda = 5,
        Devolucao_Fornecedor = 6,
        Transferencia_Entre_Lojas = 7,
        Uso_Consumo = 8,
        Bonificao = 9
    }
    public class TransacoesEstoqueModel
    {
        public int IdTransacoesEstoque { get; set; }
        public int Tipo { get; set; }
        public int TipoDescricao { get; set; }
        public string DescricaoTransacao { get; set; }
        public string Observacao { get; set; }
        public string Documento { get; set; }
        public string ChaveDocFiscal { get; set; }
        public int Deletado { get; set; }
        public int clientespessoas_idclientespessoas { get; set; }
        public int vendas_idvendas { get; set; }

    }
}
