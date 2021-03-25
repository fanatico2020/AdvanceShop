using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class ProdutoModels
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Descrição é obrigatorio!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo Descrição deve conter no máximo 200 e no mínimo 3 caracteres!")]
        public string DescricaoProduto { get; set; }
        public string CodigoBarra { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal MargemLucro { get; set; }
        public decimal PrecoVenda { get; set; }
        public int CalcularAutomatico { get; set; }
        public int EstoqueAtual { get; set; }
        public int EstoqueMinimo { get; set; }
        public int EstoqueMaximo { get; set; }
        public int ControlarEstoque { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public string UsuarioCadastro { get; set; }
        public DateTime DataHoraAlteracao { get; set; }
        public string UsuarioAlteracao { get; set; }
        public int StatusProduto { get; set; }


    }
}
