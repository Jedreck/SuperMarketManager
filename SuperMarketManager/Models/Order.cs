using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class Order
    {
        public string ID { set; get; }
        public double Price { set; get; }
        public DateTime Time { set; get; }
        public int E_ID { set; get; }
    }
}