using SuperMarketManager.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
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
        public int G_Store { set; get; }

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
                string sql = "select G_Store from goods where G_ID='"+s.G_ID+"'";
                OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
                odbcConnection.Open();
                OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
                OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader(CommandBehavior.CloseConnection);
                odbcDataReader.Read();
                s.G_Store = odbcDataReader.GetInt32(0);
                list.Add(s);
            }
            return list;
        }
    }
}