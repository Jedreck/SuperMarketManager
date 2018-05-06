using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers.OrderList
{
    public class OrderList_C
    {
        ////ADD
        //public static bool AddOrder(Orderlist ol)
        //{
        //    ol.ID = IDFormat.getID_Date16();
        //    string sql = "INSERT INTO `marketmanage`.`order` (`O_ID`, `O_Price`, `O_time`, `E_ID`) " +
        //        "VALUES" +
        //        " ('" + order.ID + "', '" + order.Price + "', '" + order.Time.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + order.E_ID + "')";
        //    return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
        //}


        ////Select
        //public static List<Order> SelectOrderByO_ID(string O_ID)
        //{
        //    string sql = "SELECT * FROM `marketmanage`.`order` WHERE `O_ID`='" + O_ID + "'";
        //    return getList(sql);
        //}

        //public static List<Order> SelectOrderByDate(string Date)
        //{
        //    string sql = "SELECT * FROM `marketmanage`.`order` WHERE `O_time` LIKE '%" + Date + "%'";
        //    return getList(sql);
        //}

        //public static List<Order> SelectAll()
        //{
        //    string sql = "SELECT * FROM `marketmanage`.`order`";
        //    return getList(sql);
        //}


        //private static List<Order> getList(string sql)
        //{
        //    OdbcConnection connection = DBManager.GetOdbcConnection();
        //    connection.Open();
        //    OdbcCommand command = new OdbcCommand(sql, connection);
        //    OdbcDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        //    if (reader.HasRows)
        //    {
        //        List<Order> list = Order.getList(reader);
        //        connection.Close();
        //        return list;
        //    }
        //    connection.Close();
        //    return null;
        //}
    }
}