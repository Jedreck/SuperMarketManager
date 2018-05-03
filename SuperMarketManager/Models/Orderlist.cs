using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class Orderlist
    {
        public string O_ID { set; get; }
        public string G_ID { set; get; }
        public double Price { set; get; }
        public double Num { set; get; }
        public double Discount { set; get; }
    }
}