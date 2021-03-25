using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.JsonModels.FocusNFe.NFC_e
{
    public class Item
    {
        public string numero_item { get; set; }//OBGT - Número do item. Comece com 1 e aumente sequencialmente para cada item da NFCe.
        public string codigo_ncm { get; set; }//OBGT - Código NCM do produto (8 dígitos).
        public string quantidade_comercial { get; set; }//OBGT - Quantidade do item.
        public string quantidade_tributavel { get; set; }//OBGT - Quantidade tributável do item. Caso não se aplique utilize o mesmo valor de quantidade_comercial.
        public string cfop { get; set; }//OBGT - Código Fiscal da operação. Utilize algum CFOP da operação válido para Nota ao Consumidor.
        public string valor_unitario_tributavel { get; set; }//OBGT - Valor unitário tributável do item. Caso não se aplique utilize o mesmo valor que valor_unitario_comercial.
        public string valor_unitario_comercial { get; set; }//OBGT - Valor unitário do item.
        public string valor_desconto { get; set; }//Valor do desconto do item.
        public string descricao { get; set; }//OBGT - Descrição do produto.
        public string codigo_produto { get; set; }//OBGT - Codigo do sistema, Código do produto.
        public string icms_origem { get; set; }//OBGT - Valores Possíveis: 0: nacional. 1: estrangeira (importação direta). 2: estrangeira (adquirida no mercado interno). 3: nacional com mais de 40% de conteúdo estrangeiro. 4: nacional produzida através de processos produtivos básicos. 5: nacional com menos de 40% de conteúdo estrangeiro. 6: estrangeira (importação direta) sem produto nacional similar. 7: estrangeira (adquirida no mercado interno) sem produto nacional similar.
        public string icms_situacao_tributaria { get; set; }//OBGT - Valores possíveis: Para empresas optantes do SIMPLES: 102 – Tributada pelo Simples Nacional sem permissão de crédito, 300 - Imune, 500 - CMS cobrado anteriormente por substituição tributária (substituído) ou por antecipação. Para empresas não optantes do SIMPLES: 00 – tributada integralmente, 40 – Isenta, 41 - Não tributada, 60 - ICMS cobrado anteriormente por substituição tributária
        public string unidade_comercial { get; set; }//OBGT - Unidade comercial do produto. Você pode utilizar valores como “KG”, “L”, “UN”, etc. Caso não se aplique utilize “UN”.
        public string unidade_tributavel { get; set; }//OBGT - Unidade tributável do produto. Caso não se aplique utilize o mesmo valor do campo unidade_comercial.
        public string valor_total_tributos { get; set; }
        public string valor_bruto { get; set; }//OBGT - Valor bruto do item. Calculado como valor_unitario_comercial * quantidade_comercial
    }
}
