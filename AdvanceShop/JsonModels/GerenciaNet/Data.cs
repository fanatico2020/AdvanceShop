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
        public string payment_url { get; set; }
        public string payment_method { get; set; }
        public int billet_discount { get; set; }
        public int card_discount { get; set; }
        public object conditional_discount_date { get; set; }
        public bool request_delivery_address { get; set; }
        public string message { get; set; }
        public string expire_at { get; set; }
        public string created_at { get; set; }
        public object notification_url { get; set; }
        public IList<Item> items { get; set; }
        public IList<History> history { get; set; }
        public Link link { get; set; }
    }
}
