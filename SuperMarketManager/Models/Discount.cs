using System;
using System.Collections.Generic;
using System.Data.Odbc;
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

        public Discount() { }

        public Discount(string id,string gid,double ddiscount,DateTime start,DateTime end) {
            id = ID;
            gid = G_ID;
            ddiscount = DDiscount;
            start = Start;
            end = End;
        }

        public static List<Discount> getList(OdbcDataReader reader)
        {
            List<Discount> list = new List<Discount>();
            Discount s;
            while (reader.Read())
            {
                s = new Discount();
                s.ID = reader.GetString(0);
                s.G_ID = reader.GetString(1);
                s.DDiscount = reader.GetDouble(2);
                s.Start = reader.GetDate(3);
                s.End = reader.GetDate(4);

                list.Add(s);
            }
            return list;
        }
    }
}