using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers
{
    public class Goods_C
    {
        public static bool AddGoods(string id, string name, int category, string unit, int expirationdate,
            double price)
        {
            return AddGoods(new Goods(id, name, category, unit, expirationdate, price,0));
        }
        public static bool AddGoods(Goods goods)
        {
            String sql = String.Format("insert into `marketmanage`.`goods`  (`G_ID`, `G_Name`,`G_Class`,`G_Unit`,`G_ExpirationDate`,`G_Price`,`G_Store`) " +
                "values ('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6})"
                , goods.ID,goods.Name,goods.Category,goods.Unit,goods.ExpirationDate,goods.Price,goods.Store);
            return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
        }

        //删
        public static bool DeleteByID(string id)
        {
            string sql = "DELETE FROM goods WHERE G_ID='" + id + "'";
            return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
        }

        //改
        public static bool AlterByID(string id,string price)
        {
            double Price = Convert.ToDouble(price);
            string sql = "update goods set G_Price="+Price+" where G_ID='"+id+"'";
            return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql) ;
        }

        //查
        public static List<Goods> SelectFuzzy(string info)
        {
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            string sql = "SELECT * FROM goods "
                + "WHERE `G_ID` LIKE '%" + info + "%'"
                + "OR `G_Name` LIKE '%" + info + "%'"
                + "OR `G_Class` LIKE '%" + info + "%'"
                + "OR `G_Unit` LIKE '%" + info + "%'"
                + "OR `G_ExpirationDate` LIKE '%" + info + "%'"
                + "OR `G_Price` LIKE '%" + info + "%'"
                + "OR `G_Store` LIKE '%" + info + "%'";
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader(CommandBehavior.CloseConnection);

            if (odbcDataReader.HasRows)
            {
                List<Goods> list = Goods.getList(odbcDataReader);
                odbcConnection.Close();
                return list;
            }
            else
                odbcConnection.Close();
            return null;
        }
        //商品是否存在
        public static int isExit(string id)
        {
            string sql = "select * from goods where G_ID='"+id+"'";
            return ExecuteSQL.ExecuteNonQuerySQL_GetResult(sql);
        }
    }
}
