using System;
using System.Collections.Generic;
using System.Data.Odbc;
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

        public static List<Order> getList(OdbcDataReader reader)
        {
            List<Order> list = new List<Order>();
            Order s;
            while (reader.Read())
            {
                s = new Order();
                s.ID = reader.GetString(0);
                s.Price = reader.GetDouble(1);
                s.Time = reader.GetDate(2);
                s.E_ID = reader.GetInt32(3);
                list.Add(s);
            }
            return list;
        }
    }
}