using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class Goods
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public int Class { set; get; }
        public string Unit { set; get; }
        public int ExpirationDate { set; get; }
        public double Price { set; get; }
        public int Store { set; get; }
    }
}