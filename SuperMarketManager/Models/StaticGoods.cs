using System;
using System.Collections.Generic;
using System.Data.Odbc;
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

        public static List<StaticGoods> getList(OdbcDataReader reader)
        {
            List<StaticGoods> list = new List<StaticGoods>();
            StaticGoods s;
            while (reader.Read())
            {
                s = new StaticGoods();
                s.G_ID = reader.GetString(0);
                s.Date = reader.GetDate(1);
                s.Price = reader.GetDouble(2);
                s.Num = reader.GetDouble(3);
                list.Add(s);
            }
            return list;
        }
    }
}