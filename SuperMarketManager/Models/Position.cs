using System.Collections.Generic;
using System.Data.Odbc;

namespace SuperMarketManager.Models
{
    public class Position
    {
        public int ID { set; get; }
        public string Name { set; get; }

        public static List<Position> getList(OdbcDataReader reader)
        {
            List<Position> list = new List<Position>();
            Position s;
            while (reader.Read())
            {
                s = new Position();
                s.ID = reader.GetInt32(0);
                s.Name = reader.GetString(1);
                list.Add(s);
            }
            return list;
        }
    }
}