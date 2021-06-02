using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class ProdutosModel
    {
        
        public int IdProdutos { get; set; }
        [Required(ErrorMessage = "O campo Descrição é obrigatorio!")]
        [StringLength(55, MinimumLength = 3, ErrorMessage = "O campo Descrição deve conter no máximo 55 e no mínimo 3 caracteres!")]
        
        public string DescricaoProduto { get; set; }
        public string CodigoBarra { get; set; }
        [Range(0.01d, 1000000000000, ErrorMessage = "O campo Preço Custo é obrigatorio e deve ser maior que R$0,00!")]
        [Required(ErrorMessage = "O campo Preço Custo é obrigatorio!")]
        public decimal PrecoCusto { get; set; }
        public decimal MargemLucro { get; set; }
        [Range(0.01d, 1000000000000, ErrorMessage = "O campo Preço Venda é obrigatorio e deve ser maior que R$0,00!")]
        [Required(ErrorMessage = "O campo Preço Venda é obrigatorio!")]
        public decimal PrecoVenda { get; set; }
        public int CalcularAutomatico { get; set; }
        public int EstoqueAtual { get; set; }
        public int EstoqueMinimo { get; set; }
        public int EstoqueMaximo { get; set; }
        public int ControlarEstoque { get; set; }
        public int StatusProduto { get; set; }
        [Required(ErrorMessage = "O campo Fornecedor é obrigatorio!")]
        [Range(1, 1000000000000, ErrorMessage = "O campo Fornecedor é obrigatorio!")]
        public int clientespessoas_idclientespessoas { get; set; }

        [Required(ErrorMessage = "O campo Categoria é obrigatorio!")]
        [Range(1, 1000000000000, ErrorMessage = "O campo Categoria é obrigatorio!")]
        public int categoriasprodutos_idcategoriasprodutos { get; set; }
        public int marcasprodutos_idmarcasprodutos { get; set; }
        [Required(ErrorMessage = "O campo Unidade Medida é obrigatorio!")]
        [Range(1, 1000000000000, ErrorMessage = "O campo Unidade Medida é obrigatorio!")]
        public int unidadesmedidasprodutos_idunidadesmedidasprodutos { get; set; }
        public int Item { get; set; }//entrada estoque

        //fiscal
        public string Codigo_NCM { get; set; }
        public string Codigo_CFOP { get; set; }
        public string ICMS_Origem { get; set; }
        public string ICMS_Situacao_Tributaria { get; set; }

    }
}
