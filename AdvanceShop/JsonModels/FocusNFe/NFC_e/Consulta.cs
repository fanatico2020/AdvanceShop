using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.JsonModels.FocusNFe.NFC_e
{
    public class Consulta
    {
        public string cnpj_emitente { get; set; }
        //public string ref { get; set; }
        public string status { get; set; }
        public string status_sefaz { get; set; }
        public string mensagem_sefaz { get; set; }
        public string chave_nfe { get; set; }
        public string numero { get; set; }
        public string serie { get; set; }
        public string caminho_xml_nota_fiscal { get; set; }
        public string caminho_danfe { get; set; }
        public string qrcode_url { get; set; }
        public string url_consulta_nf { get; set; }

    }
}
