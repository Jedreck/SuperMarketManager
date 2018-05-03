using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class GoodsIn
    {
        public string GI_ID { set; get; }
        public string G_ID { set; get; }
        public int S_ID { set; get; }
        public double PriceIn { set; get; }
        public double Num { set; get; }
        public DateTime Date { set; get; }
        public string OriginPlace { set; get; }
    }
}