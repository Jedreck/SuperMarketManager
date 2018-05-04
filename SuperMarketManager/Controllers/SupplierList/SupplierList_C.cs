using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers
{
    public class SupplierList_C
    {
        private static List<Supplylist> GetSupplylists(string sql)
        {
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader();
            if (odbcDataReader.HasRows)
            {
                List<Supplylist> list = Supplylist.getList(odbcDataReader);
                odbcConnection.Close();
                return list;
            }
            odbcConnection.Close();
            return null;
        }
        
        public static List<Supplylist> GetSupplylistsByS_ID(string S_ID)
        {
            string sql = "SELECT * FROM `marketmanage`.`supplylist` WHERE `S_ID` LIKE '%" + S_ID + "%'";
            return GetSupplylists(sql);
        }

        public static List<Supplylist> GetSupplylistsByG_ID(string G_ID)
        {
            string sql = "SELECT * FROM `marketmanage`.`supplylist` WHERE `G_ID` LIKE '%" + G_ID + "%'";
            return GetSupplylists(sql);
        }

        //public static List<Supplylist> GetSupplylistsByS_Name(string S_Name="")
        //{
        //    string sql = "";
        //}
    }
}