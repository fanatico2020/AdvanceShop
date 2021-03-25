using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class ContasAPagarModel
    {
        public int IdContasApagar { get; set; }
        [Required(ErrorMessage = "O campo Vencimento é obrigatorio!")]
        [Range(typeof(DateTime), "2000-12-01", "2099-12-31",ErrorMessage = "A data de vencimento deve estar entre 01/12/2000 e 31/12/2099")]
        public DateTime DataVencimento { get; set; }
        [Range(1, 1000000000000, ErrorMessage = "O campo Valor é obrigatorio e deve ser maior que R$0,00!")]
        [Required(ErrorMessage = "O campo Valor é obrigatorio!")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "O campo Referente a é obrigatorio!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Referente a deve conter no máximo 60 e no mínimo 3 caracteres!")]
        public string Referentea { get; set; }
        public int Status { get; set; }
        [Range(1, 1000000000000, ErrorMessage = "O campo Valor Pago é obrigatorio e deve ser maior que R$0,00!")]
        [Required(ErrorMessage = "O campo Valor Pago é obrigatorio!")]
        public decimal ValorPago { get; set; }
        [Required(ErrorMessage = "O campo Pagamento é obrigatorio!")]
        [Range(typeof(DateTime), "2000-12-01", "2099-12-31", ErrorMessage = "A data de pagamento deve estar entre 01/12/2000 e 31/12/2099")]
        public DateTime DataRecebimento { get; set; }
        public string Documento { get; set; }
        public string Observacao { get; set; }
        [Range(1, 1000000000000, ErrorMessage = "O campo Categoria é obrigatorio!")]
        [Required(ErrorMessage = "O campo Categoria é obrigatorio!")]
        public int categoriascontasapagar_idcategoriascontasapagar { get; set; }//(FK)
        [Range(1, 1000000000000, ErrorMessage = "O campo Fornecedor é obrigatorio!")]
        [Required(ErrorMessage = "O campo Fornecedor é obrigatorio!")]
        public int clientespessoas_idclientespessoas { get; set; }//(FK)
    }
}
