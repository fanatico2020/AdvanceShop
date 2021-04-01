using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.JsonModels.FocusNFe.NFC_e
{
    public class FocusNFe
    {

        public string natureza_operacao { get; set; }
        public DateTime data_emissao { get; set; }
        public DateTime data_entrada_saida { get; set; }
        public string tipo_documento { get; set; }
        public string local_destino { get; set; }
        public string finalidade_emissao { get; set; }
        public string consumidor_final { get; set; }
        public string presenca_comprador { get; set; }
        public string indicador_intermediario { get; set; }
        public string cnpj_emitente { get; set; }
        public string telefone_emitente { get; set; }
        public string nome_emitente { get; set; }
        public string nome_fantasia_emitente { get; set; }
        public string logradouro_emitente { get; set; }
        public string numero_emitente { get; set; }
        public string bairro_emitente { get; set; }
        public string municipio_emitente { get; set; }
        public string uf_emitente { get; set; }
        public string cep_emitente { get; set; }
        public string inscricao_estadual_emitente { get; set; }
        public string regime_tributario_emitente { get; set; }
        public string cnpj_destinatario { get; set; }
        public string cpf_destinatario { get; set; }
        public string telefone_destinatario { get; set; }
        public string nome_destinatario { get; set; }
        public string logradouro_destinatario { get; set; }
        public string numero_destinatario { get; set; }
        public string bairro_destinatario { get; set; }
        public string municipio_destinatario { get; set; }
        public string uf_destinatario { get; set; }
        public string cep_destinatario { get; set; }
        public string indicador_inscricao_estadual_destinatario { get; set; }
        public string inscricao_estadual_destinatario { get; set; }
        public IList<Iten> itens { get; set; }
        public string icms_base_calculo { get; set; }
        public string icms_valor_total { get; set; }
        public string icms_valor_total_desonerado { get; set; }
        public string fcp_valor_total { get; set; }
        public string icms_base_calculo_st { get; set; }
        public string icms_valor_total_st { get; set; }
        public string fcp_valor_total_st { get; set; }
        public string fcp_valor_total_retido_st { get; set; }
        public string valor_produtos { get; set; }
        public string valor_frete { get; set; }
        public string valor_seguro { get; set; }
        public string valor_desconto { get; set; }
        public string valor_total_ii { get; set; }
        public string valor_ipi { get; set; }
        public string valor_ipi_devolvido { get; set; }
        public string valor_pis { get; set; }
        public string valor_cofins { get; set; }
        public string valor_outras_despesas { get; set; }
        public string valor_total { get; set; }
        public string modalidade_frete { get; set; }
        public IList<Volume> volumes { get; set; }
        public string numero_fatura { get; set; }
        public string valor_original_fatura { get; set; }
        public string valor_desconto_fatura { get; set; }
        public string valor_liquido_fatura { get; set; }
        public IList<Duplicata> duplicatas { get; set; }
        public IList<FormasPagamento> formas_pagamento { get; set; }
        public string informacoes_adicionais_contribuinte { get; set; }
        public string cnpj_responsavel_tecnico { get; set; }
        public string contato_responsavel_tecnico { get; set; }
        public string email_responsavel_tecnico { get; set; }
        public string telefone_responsavel_tecnico { get; set; }
    }
}
