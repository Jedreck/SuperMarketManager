using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Models
{
    public class Supplier_List_Goods
    {
        string S_ID { get; set; }
        string S_Name { get; set; }
        string G_ID { get; set; }
        string G_Name { get; set; }
        double SL_Price { get; set; }
        double G_Price { get; set; }
        double G_Store { get; set; }

        public static List<Supplier_List_Goods> GetSupplierAndLists(OdbcDataReader reader)
        {
            List<Supplier_List_Goods> list = new List<Supplier_List_Goods>();
            Supplier_List_Goods s;
            while (reader.Read())
            {
                s = new Supplier_List_Goods();
                s.S_ID = reader.GetString(0);
                s.S_Name = reader.GetString(1);
                s.G_ID = reader.GetString(2);
                s.G_Name = reader.GetString(3);
                s.SL_Price = reader.GetDouble(4);
                s.G_Price = reader.GetDouble(5);
                s.G_Store = reader.GetDouble(6);
                list.Add(s);
            }
            return list;
        }
    }
}