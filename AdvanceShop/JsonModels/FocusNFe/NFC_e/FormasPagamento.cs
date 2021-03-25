using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.JsonModels.FocusNFe.NFC_e
{
    public class FormasPagamento
    {
        public string forma_pagamento { get; set; }//OBGT - Forma do recebimento. Valores possíveis:01: Dinheiro.02: Cheque.03: Cartão de Crédito.04: Cartão de Débito.05: Crédito Loja.10: Vale Alimentação.11: Vale Refeição.12: Vale Presente.13: Vale Combustível.99: Outros
        public string valor_pagamento { get; set; }//OBGT - Valor do recebimento.
        public string nome_credenciadora { get; set; }//Ex: Cielo
        public string bandeira_operadora { get; set; }//Obrigatório se forma_pagamento = 03 ou 04 (pagamento em cartão) - Bandeira da operadora de cartão de crédito e/ou débito. Valores possíveis:01: Visa.02: Mastercard.03: American Express.04: Sorocred.99: Outros.
        public string numero_autorizacao { get; set; }//Obrigatório se tipo_integracao for 1 - TEF, Comércio Eletrônico
    }
}
