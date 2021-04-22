using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.JsonModels.GerenciaNet
{
    public class GerenciaNet
    {
        public int code { get; set; }
        public Data data { get; set; }
        public IList<Item> items { get; set; }
    }
}
