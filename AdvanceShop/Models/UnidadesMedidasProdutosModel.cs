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
        [StringLength(25, MinimumLength = 3, ErrorMessage = "O campo Descrição deve conter no máximo 25 e no mínimo 3 caracteres!")]
        public string DescricaoUnidadeMedida { get; set; }

    }
}
