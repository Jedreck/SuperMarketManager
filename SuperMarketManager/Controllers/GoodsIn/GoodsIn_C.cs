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
            bool flag;
            String insertSql = String.Format("insert into `marketmanage`.`goodsin`  (`GI_ID`, `G_ID`,`S_ID`,`GI_PriceIn`,`GI_Num`,`GI_Date`,`GI_OriginPrice`) " +
                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')"
                , goodsin.GI_ID, goodsin.G_ID, goodsin.S_ID, goodsin.PriceIn, goodsin.Num, goodsin.Date, goodsin.OriginPlace);
            flag=ExecuteSQL.ExecuteNonQuerySQL_GetBool(insertSql);
            String sql = "update Goods set G_Store=G_Store+"+goodsin.Num+"where G_ID='"+goodsin.G_ID+"'";
            ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
            return flag? goodsin : null;            
        }

        //全部入库信息
        public static List<GoodsIn> GetGoodsIn_ListsByG_ID(string G_ID = "")
        {
            string sql = "select `googsin`.`GI_ID`,`goodsin`.`G_ID`,`goodsin`.`S_ID`,`goodsin`.`GI_PriceIn`,`goodsin`.`GI_Num`,`goodsin`.`GI_Date`,`goodsin`.`GI_OriginPrice` "
                + "from `goodsin` "
                + "where `goodsin`.`G_ID` =`" + G_ID + "`"
                + "order by G_ID";
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader();
            if (odbcDataReader.HasRows)
            {
                List<GoodsIn> list = GoodsIn.getList(odbcDataReader);
                odbcConnection.Close();
                return list;
            }
            odbcConnection.Close();
            return null;
        }
    }
}