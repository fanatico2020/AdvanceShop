using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.JsonModels.FocusNFe.NFC_e
{
    public class FocusNFe
    {
        public string cnpj_emitente { get; set; }//OBGT - CNPJ da empresa que está emitindo a NFCe.
        public DateTime data_emissao { get; set; }//OBGT - Utilize o formato ISO, exemplo 2015-11-19T13:54:31-02:00. Diferença máxima permitida de 5 minutos do horário atual.
        public string indicador_inscricao_estadual_destinatario { get; set; }//Não OBGT - Indicador da Inscrição Estadual do destinatário. Valores possíveis: '1' – Contribuinte ICMS (informar a IE do destinatário); '2' – Contribuinte isento de Inscrição no cadastro de Contribuintes do ICMS; '9' – Não Contribuinte, que pode ou não possuir Inscrição Estadual no Cadastro de Contribuintes do ICMS.
        public string modalidade_frete { get; set; }//OBGT - Indica a modalidade do frete da operação. Valores possíveis: '0' – Por conta do emitente; '1' – Por conta do destinatário; '2' – Por conta de terceiros; '9' – Sem frete.
        public string local_destino { get; set; }//OBGT - Local onde a operação irá acontecer. Valores possíveis: '1' – Operação interna; '2' – Operação interestadual; '3' – Operação com exterior.
        public string presenca_comprador { get; set; }//OBGT - Presença do comprador.Valores possíveis:1 – Operação presencial.4 – Entrega a domicílio.
        public string natureza_operacao { get; set; }//OBGT - "VENDA AO CONSUMIDOR"
        public IList<Item> items { get; set; }
        public IList<FormasPagamento> formas_pagamento { get; set; }
    }
}
