using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class CategoriaProdutosModel
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo Descrição é obrigatorio!")]
        [StringLength(50,MinimumLength = 3,ErrorMessage = "O campo Descrição deve conter no máximo 70 e no mínimo 3 caracteres!")]
        public string DescricaoCategoria { get; set; }
        public CategoriaProdutosModel()
        {

        }
        public CategoriaProdutosModel(int id,string descricao)
        {
            Id = id;
            DescricaoCategoria = descricao;
        }
    }
}
