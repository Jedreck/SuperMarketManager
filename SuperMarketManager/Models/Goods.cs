using SuperMarketManager.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class Goods
    {
        public string ID { set; get ; }
        public string Name { set; get; }
        public int Category { set; get; }
        public string GC_Name { set; get; }
        public string Unit { set; get; }
        public int ExpirationDate { set; get; }
        public double Price { set; get; }
        public int Store { set; get; }
        public Goods() { }
        public Goods(string id,string name, int category,string unit,int expirationdate,double price,int store)
        {
            this.ID = id;
            this.Name = name;
            this.Category = category;
            this.Unit = unit;
            this.ExpirationDate = expirationdate;
            this.Price = price;
            this.Store = store;
        }
        public static List<Goods> getList(OdbcDataReader reader)
        {
            List<Goods> list = new List<Goods>();
            Goods s;
            while (reader.Read())
            {
                s = new Goods();
                s.ID = reader.GetString(0);
                s.Name = reader.GetString(1);
                s.Category = reader.GetInt32(2);
                s.GC_Name = goodsclass_name(s.Category);
                s.Unit = reader.GetString(3);
                s.ExpirationDate = reader.GetInt32(4);
                s.Price = reader.GetDouble(5);
                s.Store = reader.GetInt32(6);
                list.Add(s);
            }
            return list;
        }
        public static string goodsclass_name(int category)
        {
            string sql = "select * from goodsclass where GC_ID=" + category;
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            odbcCommand.ExecuteNonQuery();
            OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader(CommandBehavior.CloseConnection);

            if (odbcDataReader.HasRows)
            {
                odbcDataReader.Read();
                return Convert.ToString(odbcDataReader[2]);
            }
            return null;
        }
    }
}