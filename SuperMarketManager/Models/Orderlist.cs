using System;
using System.Collections.Generic;
using System.Data.Odbc;
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

        public static List<Orderlist> getList(OdbcDataReader reader)
        {
            List<Orderlist> list = new List<Orderlist>();
            Orderlist s;
            while (reader.Read())
            {
                s = new Orderlist();
                s.O_ID = reader.GetString(0);
                s.G_ID = reader.GetString(1);
                s.Price = reader.GetDouble(2);
                s.Num = reader.GetDouble(3);
                s.Discount = reader.GetDouble(4);
                list.Add(s);
            }
            return list;
        }
    }
}