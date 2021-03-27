using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class ClientesPessoasModel
    {
        [Key]
        public int IdClientesPessoas { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatorio!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Nome deve conter no máximo 60 e no mínimo 3 caracteres!")]
        public string NomeClientePessoa { get; set; }
        public DateTime DataNascimento { get; set; }
        public string RGIE { get; set; }
        [Required(ErrorMessage = "O campo CPF ou CNPJ é obrigatorio!")]
        public string CPFCNPJ { get; set; }
        public string Endereco { get; set; }
        public string NumeroCasa { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string Sexo { get; set; }
        [Required(ErrorMessage = "O campo Contato 1 é obrigatorio!")]
        public string Contato1 { get; set; }
        public string Contato2 { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public int TipoPessoa { get; set; }
        public int StatusClientePessoa { get; set; }
        public int Deletado { get; set; }

    }
}
