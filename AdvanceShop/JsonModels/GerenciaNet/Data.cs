using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.JsonModels.GerenciaNet
{
    public class Data
    {
        public int charge_id { get; set; }
        public string status { get; set; }
        public int total { get; set; }
        public string custom_id { get; set; }
        public string created_at { get; set; }
    }
}
