using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class StaticGoods
    {
        public string G_ID { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public double Num { get; set; }
    }
}