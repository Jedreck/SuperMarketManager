using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class GoodsIn
    {
        public string GI_ID { set; get; }
        public string G_ID { set; get; }
        public int S_ID { set; get; }
        public double PriceIn { set; get; }
        public double Num { set; get; }
        public DateTime Date { set; get; }
        public string OriginPlace { set; get; }

        public GoodsIn(string GI_ID, string G_ID, int S_ID, double PriceIn, double Num, DateTime Date, string OriginPlace)
            {
            this.GI_ID = GI_ID;
            this.G_ID = G_ID;
            this.S_ID = S_ID;
            this.PriceIn = PriceIn;
            this.Num = Num;
            this.Date = Date;
            this.OriginPlace = OriginPlace;
            }
        public GoodsIn()
        {

        }
        public static List<GoodsIn> getList(OdbcDataReader reader)
        {
            List<GoodsIn> list = new List<GoodsIn>();
            GoodsIn s;
            while (reader.Read())
            {
                s = new GoodsIn();
                s.GI_ID = reader.GetString(0);
                s.G_ID = reader.GetString(1);
                s.S_ID = reader.GetInt32(2);
                s.PriceIn = reader.GetDouble(3);
                s.Num = reader.GetDouble(4);
                s.Date = reader.GetDate(5);
                s.OriginPlace = reader.GetString(6);
                list.Add(s);
            }
            return list;
        }
    }
}