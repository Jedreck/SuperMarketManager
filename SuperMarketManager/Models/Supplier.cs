using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Rigion { get; set; }

        public static List<Supplier> getList(OdbcDataReader reader)
        {
            List<Supplier> list = new List<Supplier>();
            Supplier s;
            while (reader.Read())
            {
                s = new Supplier();
                s.ID = reader.GetInt32(0);
                s.Name = reader.GetString(1);
                s.Phone = reader.GetString(2);
                s.Rigion = reader.GetString(3);
                list.Add(s);
            }
            return list;
        }
    }
}