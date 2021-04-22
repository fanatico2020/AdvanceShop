using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Models
{
    /*
    Homologação
    Client_Id_e86adfafe99bbe23a579e73221d89c39e6775e80
    Client_Secret_2d904858b5cb5cd499b05512e6eb57477b362558
    */
    public class ApiGerenciaNetModel
    {

        public int idapigerencianet { get; set; }
        public int usarapi { get; set; }
        public string clientidhomologacao { get; set; }
        public string clientsecrethomologacao { get; set; }
        public string clientidproducao { get; set; }
        public string clientsecretproducao { get; set; }
        public string ambiente { get; set; }

    }
}
