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
        //    ol.id = IDFormat.getID_Date16(); 
        //    string sql = "insert into `marketmanage`.`order` (`o_id`, `o_price`, `o_time`, `e_id`) " +
        //        "values" +
        //        " ('" + order.id + "', '" + order.price + "', '" + order.time.tostring("yyyy-mm-dd hh:mm:ss") + "', '" + order.e_id + "')";
        //    return executesql.executenonquerysql_getbool(sql);
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