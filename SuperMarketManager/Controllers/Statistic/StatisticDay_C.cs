using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace SuperMarketManager.Controllers
{
    public class StatisticDay_C
    {
        public static bool AddData(double price)
        {
            string sql_CheckDate = "SELECT * FROM `marketmanage`.`statisticday` WHERE `SD_Date`='"+DateTime.Now.ToString("yyyy-MM-dd")+"'";
            string sql_Insert = "INSERT INTO `marketmanage`.`statisticday`(`SD_Date`,`SD_Price`) " +
                "VALUES ('"+ DateTime.Now.ToString("yyyy-MM-dd") + "','"+price+"')";
            string sql_Update = "UPDATE `marketmanage`.`statisticday`" +
                "SET `SD_Price`= `SD_Price`+'"+price+"'" +
                "WHERE `SD_Date`=" + DateTime.Now.ToString("yyyy-MM-dd");
            if (ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql_CheckDate))
            {
                return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql_Update);
            }
            else
            {
                return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql_Insert);
            }
        }
        public static List<StatisticDay> GetDaysData(string startDay,string endDay)
        {
            string sql = "SELECT * FROM `marketmanage`.`statisticday` WHERE `SD_Date` BETWEEN '"+startDay+"' AND '"+endDay+"'";
            return getList(sql);
        }

        public static List<StatisticDay> getDaysData(string date)
        {
            string sql = "SELECT * FROM `marketmanage`.`statisticday` WHERE `SD_Date`='" + date + "'";
            return getList(sql);
        }

        private static List<StatisticDay> getList(string sql)
        {
            OdbcConnection connection = DBManager.GetOdbcConnection();
            connection.Open();
            OdbcCommand command = new OdbcCommand(sql, connection);
            OdbcDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                List<StatisticDay> list = StatisticDay.getList(reader);
                connection.Close();
                return list;
            }
            connection.Close();
            return null;
        }
    }
}