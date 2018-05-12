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
            String insertSql = String.Format("insert into `marketmanage`.`goodsin`  (`GI_ID`, `G_ID`,`S_ID`,`GI_PriceIn`,`GI_Num`,`GI_Date`,`GI_OriginPrice`) " +
                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')"
                , goodsin.GI_ID, goodsin.G_ID, goodsin.S_ID, goodsin.PriceIn, goodsin.Num, goodsin.Date, goodsin.OriginPlace);
            return ExecuteSQL.ExecuteNonQuerySQL_GetBool(insertSql) ? goodsin : null;            
        }
    }
}