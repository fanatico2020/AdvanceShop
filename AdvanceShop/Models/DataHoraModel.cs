using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class DataHoraModel
    {
        public int iddatahora { get; set; }
        public DateTime datahoracadastro { get; set; }
        public DateTime datahoraedicao{ get; set; }
        public string usuariocadastro { get; set; }
        public string usuarioedicao { get; set; }
        public int usuarios_idusuarios { get; set; }
        public int clientespessoas_idclientespessoas { get; set; }
        public int produtos_idprodutos { get; set; }
        public int contasapagar_idcontasapagar { get; set; }
        public int caixas_idcaixas { get; set; }
        public int transacoescaixa_idtransacoescaixa { get; set; }
        public int vendas_idvendas { get; set; }
        public int transacoesestoque_idtransacoesestoque { get; set; }

    }
}
