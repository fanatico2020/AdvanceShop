using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.JsonModels.GerenciaNet
{
    public class Link
    {

        public object billet_discount { get; set; }
        public object card_discount { get; set; }
        public object conditional_discount_value { get; set; }
        public object conditional_discount_type { get; set; }
        public object conditional_discount_date { get; set; }
        public string message { get; set; }
        public string expire_at { get; set; }
        public bool request_delivery_address { get; set; }
        public string payment_method { get; set; }
        public string payment_url { get; set; }
    }
}
