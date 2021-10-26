using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class ConfiguracoesGeraisModel
    {
        public int idconfiguracoesgerais { get; set; }
        public int trocomaximo { get; set; }
        public decimal valortrocomaximo { get; set; }
        public int imprimircupomfinalizarvenda { get; set; }
        public int imprimircupomfiscalnfcefinalizarvenda { get; set; }
        public int imprimirnomevendedorfinalizarvenda { get; set; }
        public int imprimircpfcnpjnocupom { get; set; }
        public int vendacartaopermitirdesconto { get; set; }
        public int avisarprodutoestoquebaixo { get; set; }
        public int avisarclienteaniversariante { get; set; }
        public int permitirvendercomestoquezerado { get; set; }

    }
}
