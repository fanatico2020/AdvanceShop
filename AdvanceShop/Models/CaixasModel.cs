using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class CaixasModel
    {
        [Key]
        public int IdCaixas { get; set; }
        public string Maquina { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public decimal ValorInformado { get; set; }
        public decimal QuebraCaixa { get; set; }
        public string ObservacaoCaixa { get; set; }
        public int status { get; set; }
        public string UsuarioFechamento { get; set; }
        public DateTime DataHoraFechamento { get; set; }
        public int usuarios_idusuarios { get; set; }
        public bool caixaAberto { get; set; }
        public int Deletado { get; set; }
    }
}
