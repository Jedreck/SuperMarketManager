using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers.OrderList
{
    public class OrderList_C
    {
        //////ADD
        //public static bool addorder(orderlist ol)
        //{
        //    string sql = "INSERT INTO `marketmanage`.`orderlist` (`O_ID`, `G_ID`, `OL_Price`, `OL_Num`, `OL_Discount`)" +
        //        " VALUES " +
        //        "('"+ol.O_ID+"', '"+ol.G_ID+"', '"+ol.Price+"', '"+ol.Num+"', '"+ol.Discount+"')";
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