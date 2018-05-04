using System;
using System.Collections.Generic;
using System.Data.Odbc;
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

        public static List<Goods> getList(OdbcDataReader reader)
        {
            List<Goods> list = new List<Goods>();
            Goods s;
            while (reader.Read())
            {
                s = new Goods();
                s.ID = reader.GetString(0);
                s.Name = reader.GetString(1);
                s.Class = reader.GetInt32(2);
                s.Unit = reader.GetString(3);
                s.ExpirationDate = reader.GetInt32(4);
                s.Price = reader.GetDouble(5);
                s.Store = reader.GetInt32(6);
                list.Add(s);
            }
            return list;
        }
    }
}