using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.JsonModels.FocusNFe.NFC_e
{
    public class FormasPagamento
    {
        public string forma_pagamento { get; set; }
        
        public string valor_pagamento { get; set; }
        public object tipo_integracao { get; set; }
    }
}
