using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class UnidadesMedidasProdutosModel
    {
        public int IdUnidadesMedidasProdutos{ get; set; }
        [Required(ErrorMessage = "O campo Descrição é obrigatorio!")]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "O campo Descrição deve conter no máximo 3 e no mínimo 1 caracteres, Você pode utilizar valores como “KG”, “L”, “UN”, etc. Caso não se aplique utilize “UN”.")]
        public string DescricaoUnidadeMedida { get; set; }

    }
}
