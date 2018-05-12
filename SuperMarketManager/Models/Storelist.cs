using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class Storelist
    {
        public string G_ID { set; get; }
        public string GI_ID { set; get; }
        public double Num { set; get; }
        public DateTime ProducedDate { set; get; }
      // public String ProducedDate { set; get; }

        public static List<Storelist> getList(OdbcDataReader reader)
        {
            List<Storelist> list = new List<Storelist>();
            Storelist s;
            while (reader.Read())
            {
                s = new Storelist();
                s.G_ID = reader.GetString(0);
                s.GI_ID = reader.GetString(1);
                s.Num = reader.GetDouble(2);
                s.ProducedDate = reader.GetDate(3);
                list.Add(s);
            }
            return list;
        }
    }
}