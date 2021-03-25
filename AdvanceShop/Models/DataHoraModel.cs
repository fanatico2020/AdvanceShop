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

    }
}
