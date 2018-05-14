using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace SuperMarketManager.Controllers
{
    public class StatisticGoods_C
    {
        public static bool AddData(string G_ID, double num, double price)
        {
            string sql_CheckDate = "SELECT * FROM `marketmanage`.`statisticgoods` " +
                "WHERE `SG_Date`='"+DateTime.Now.ToString("yyyy-MM-dd")+"' AND `G_ID`='"+G_ID+"'";

            string sql_Insert = "INSERT INTO `marketmanage`.`statisticgoods` (`G_ID`,`SG_Date`,`SG_Price`,`SG_Num`) "+
                "VALUES ('"+G_ID+"','"+DateTime.Now.ToString("yyyy-MM-dd") + "','"+price+"','"+num+"')";

            string sql_Update = "UPDATE `marketmanage`.`statisticgoods` " +
                "SET `SG_Price`='" + price + "', `SG_Num`='" + num + "' " +
                "WHERE `G_ID`='" + G_ID + "' AND `SG_Date`='" + DateTime.Now.ToString("yyyy-MM-dd") + "'";

            if (ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql_CheckDate))
            {
                return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql_Update);
            }
            else
            {
                return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql_Insert);
            }
        }
        public static List<StaticGoods> GetDaysData(string G_ID,string startDay, string endDay)
        {
            string sql = "SELECT * FROM `marketmanage`.`statisticgoods` " +
                "WHERE `G_ID`='"+G_ID+ "' AND `SG_Date` BETWEEN '" + startDay + "' AND '" + endDay + "'";
            return getList(sql);
        }
        public static List<StaticGoods> GetDays(string startDay, string endDay)
        {
            string sql = "SELECT * FROM `marketmanage`.`statisticgoods` " +
                "WHERE `SG_Date` BETWEEN '" + startDay + "' AND '" + endDay + "'";
            return getList(sql);
        }

        public static List<StaticGoods> GetDaysData(string G_ID, string date)
        {
            string sql = "SELECT * FROM `marketmanage`.`statisticgoods` " +
                "WHERE `G_ID`='"+G_ID+"' AND `SG_Date`='" + date + "'";
            return getList(sql);
        }
        public static List<StaticGoods> GetDays(string date)
        {
            string sql = "SELECT * FROM `marketmanage`.`statisticgoods` " +
                "WHERE `SG_Date`='" + date + "'";
            return getList(sql);
        }

        private static List<StaticGoods> getList(string sql)
        {
            OdbcConnection connection = DBManager.GetOdbcConnection();
            connection.Open();
            OdbcCommand command = new OdbcCommand(sql, connection);
            OdbcDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                List<StaticGoods> list = StaticGoods.getList(reader);
                connection.Close();
                return list;
            }
            connection.Close();
            return null;
        }
    }
}