using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace SuperMarketManager.Models
{
    public class StatisticDay
    {
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public static List<StatisticDay> getList(OdbcDataReader reader)
        {
            List<StatisticDay> list = new List<StatisticDay>();
            StatisticDay s;
            while (reader.Read())
            {
                s = new StatisticDay();
                s.Date = reader.GetDate(0);
                s.Price = reader.GetDouble(1);
                list.Add(s);
            }
            return list;
        }
    }
}