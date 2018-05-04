using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class Supplylist
    {
        public int S_ID { get; set; }
        public string G_ID { get; set; }
        public double SL_Price { get; set; }

        public static List<Supplylist> getList(OdbcDataReader reader)
        {
            List<Supplylist> list = new List<Supplylist>();
            Supplylist s;
            while (reader.Read())
            {
                s = new Supplylist();
                s.S_ID = reader.GetInt32(0);
                s.G_ID = reader.GetString(1);
                s.SL_Price = reader.GetDouble(2);
                list.Add(s);
            }
            return list;
        }
    }
}