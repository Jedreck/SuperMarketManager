using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class Goodsclass
    {
        public int ID { set; get; }
        public string Name { set; get; }

        public static List<Goodsclass> getList(OdbcDataReader reader)
        {
            List<Goodsclass> list = new List<Goodsclass>();
            Goodsclass s;
            while (reader.Read())
            {
                s = new Goodsclass();
                s.ID = reader.GetInt32(0);
                s.Name = reader.GetString(1);
                list.Add(s);
            }
            return list;
        }
    }
}