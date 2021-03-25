using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class UsuariosModel
    {
        [Key]
        public int IdUsuarios { get; set; }
        [Required(ErrorMessage = "O campo Usuário Acesso é obrigatorio!")]
        [StringLength(35, MinimumLength = 3, ErrorMessage = "O Usuário Acesso deve conter no máximo 35 e no mínimo 3 caracteres!")]
        public string UsuarioAcesso { get; set; }
        [Required(ErrorMessage = "O campo Senha Acesso é obrigatorio!")]
        [StringLength(35, MinimumLength = 6, ErrorMessage = "A Senha Acesso deve conter no máximo 35 e no mínimo 6 caracteres!")]
        public string SenhaAcesso { get; set; }
        [Required(ErrorMessage = "O campo Nome Completo é obrigatorio!")]
        [StringLength(35, MinimumLength = 6, ErrorMessage = "O Nome Completo deve conter no máximo 35 e no mínimo 6 caracteres!")]
        public string NomeCompleto { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatorio!")]
        public string Email { get; set; }
        public string Contato { get; set; }
        public int UsaDescontoMaximo { get; set; }//true = 1 e false = 0
        public decimal DescontoMaximo { get; set; }
        public int Status { get; set; }//true = 1 e false = 0
        public int logado { get; set; }

        
    }
}
