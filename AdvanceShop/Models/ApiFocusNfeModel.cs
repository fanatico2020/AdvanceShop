using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    public class ApiFocusNfeModel
    {
        public int idapifocusnfe { get; set; }
        public int usarapi { get; set; }
        public string tokenhomologacao { get; set; }
        public string tokenproducao { get; set; }
        public string ambiente { get; set; }
        public string indicadoriedestinatario { get; set; }
        public int clientespessoas_idclientespessoas { get; set; }
    }
}
