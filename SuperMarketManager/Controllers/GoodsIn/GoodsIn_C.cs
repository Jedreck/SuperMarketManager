using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers
{
    public class GoodsIn_C
    {
        //入库
        public static GoodsIn AddGoods(GoodsIn goodsin)
        {
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            OdbcCommand odbcCommand = new OdbcCommand();
            OdbcDataReader odbcDataReader = null;
            odbcCommand.Connection = odbcConnection;
            //检查商品ID是否已存在
            string selectSql = "select * from goods where G_ID='" + goodsin.G_ID + "'";
            odbcCommand.CommandText = selectSql;
            odbcDataReader = odbcCommand.ExecuteReader(CommandBehavior.CloseConnection);
            if (odbcDataReader.HasRows)//结果集不为空返回true,表示用户该商品ID已存在，可插入
            {
                odbcDataReader.Close();
                odbcConnection.Close();
                odbcConnection.Open();
                String insertSql = String.Format("insert into `marketmanage`.`goodsin`  (`GI_ID`, `G_ID`,`S_ID`,`GI_PriceIn`,`GI_Num`,`GI_Date`,`GI_OriginPrice`) " +
                    "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')"
                    , goodsin.GI_ID, goodsin.G_ID, goodsin.S_ID, goodsin.PriceIn, goodsin.Num, goodsin.Date, goodsin.OriginPlace);
                odbcCommand.CommandText = insertSql;
                int i = odbcCommand.ExecuteNonQuery();
                odbcConnection.Close();
                return (i > 0) ? goodsin : null;//插入成功返回goods，失败返回null
            }
            return null;//商品ID不存在，返回null
        }
    }
}