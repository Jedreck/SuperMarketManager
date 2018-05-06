using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers.StoreList
{
    public class StoreList_C
    {
        //查找（商品ID或者商品名称）
        public static List<Storelist> SelectFuzzy(string info)
        {
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            string sql = "SELECT * FROM storelist "
                + "WHERE `G_ID` LIKE '%" + info + "%'"
                + "OR `G_Name` LIKE '%" + info + "%'";
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader(CommandBehavior.CloseConnection);

            if (odbcDataReader.HasRows)
            {
                List<Storelist> list = Storelist.getList(odbcDataReader);
                odbcConnection.Close();
                return list;
            }
            else
                odbcConnection.Close();
            return null;
        }
}
}