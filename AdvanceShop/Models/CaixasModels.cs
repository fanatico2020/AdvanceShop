using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class CaixasModels
    {
        public int Id { get; set; }
        public string Maquina { get; set; }
        public string UsuarioCaixa { get; set; }
        public DateTime DataHoraAbertura { get; set; }
        public DateTime DataHoraFechamento { get; set; }
        public string UsuarioFechamento { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public decimal ValorInformado { get; set; }
        public decimal QuebraCaixa { get; set; }
        public string ObservacaoCaixa { get; set; }


    }
}
