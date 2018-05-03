using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class Discount
    {
        public string ID { set; get; }
        public string G_ID { set; get; }
        public double DDiscount { set; get; }
        public DateTime Start { set; get; }
        public DateTime End { set; get; }
    }
}