using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers
{
    public class Order_C
    {
        //ADD
        public static bool AddOrder(Order order, List<Orderlist> ol)//order属性E_ID传递进来，其他不用
        {
            //系统自动生成订单号
            order.ID = IDFormat.getID_Date16();
            double o_price=0;
            order.Time = DateTime.Now.Date;
            //先行插入order
            string sqlorder = String.Format("insert into `marketmanage`.`order` (`O_ID`, `O_Price`, `O_time`, `E_ID`) " +
                "values ('{0}','{1}','{2}','{3}')", order.ID, o_price, order.Time, order.E_ID);
            ExecuteSQL.ExecuteNonQuerySQL_GetBool(sqlorder);
            //插入订单列表
            foreach (Orderlist orderlist in ol)
            {
                //根据ID查询商品价格
                string sql1 = "select G_Price from Goods where G_ID='"+orderlist.G_ID+"'";
                OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
                odbcConnection.Open();
                OdbcCommand odbcCommand = new OdbcCommand(sql1, odbcConnection);
                OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader(CommandBehavior.CloseConnection);
                odbcDataReader.Read();
                orderlist.Price = odbcDataReader.GetDouble(0);
                odbcConnection.Close();
                //orderlist
                string sql = "INSERT INTO `marketmanage`.`orderlist` (`O_ID`, `G_ID`, `OL_Price`, `OL_Num`, `OL_Discount`) " +
                "VALUES" +
                " ('" + order.ID + "', '" + orderlist.G_ID+ "','"+ orderlist.Price + "', '" + orderlist.Num + "', '" + orderlist.Discount + "')";
                ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
                //更新商品表库存
                string sql_goods = "update goods set G_Store=G_Store-" +orderlist.Num+" where G_ID='"+orderlist.G_ID+"'";
                ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql_goods);
                //更新库存表
                string sql_store = "select * from storelist where G_ID='" + orderlist.G_ID + "'";// order by SL_ProduceDate desc";//升序输出结果集
                odbcConnection = DBManager.GetOdbcConnection();
                odbcConnection.Open();
                odbcCommand = new OdbcCommand(sql_store, odbcConnection);
                odbcDataReader = odbcCommand.ExecuteReader();
                odbcDataReader.Read();
                string gi_id = odbcDataReader.GetString(1);
                string sql_storee = "update storelist set SL_Num=SL_Num-"+orderlist.Num+" where G_ID='"+orderlist.G_ID+"' and GI_ID='"+gi_id+"'";
                odbcCommand = new OdbcCommand(sql_storee, odbcConnection);
                odbcConnection.Close();
                //更新商品统计表
                StatisticGoods_C.AddData(orderlist.G_ID, orderlist.Num, orderlist.Price);
                //订单金额
                o_price += orderlist.Price;
            }
            //更新销售统计表
  
            StatisticDay_C.AddData(o_price);
            //更新订单价格（whole）
            string sqlorder_p = "update `marketmanage`.`order` set `O_Price`="+o_price+" where O_ID='"+order.ID+"'";
            return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sqlorder_p);
        }


        //Select
        public static List<Order> SelectOrderByO_ID(string O_ID)
        {
            string sql = "SELECT * FROM `marketmanage`.`order` WHERE `O_ID`='"+O_ID+"'";
            return getList(sql);
        }

        public static List<Order> SelectOrderByDate(string Date)
        {
            string sql = "SELECT * FROM `marketmanage`.`order` WHERE `O_time` LIKE '%"+Date+"%'";
            return getList(sql);
        }

        public static List<Order> SelectAll()
        {
            string sql = "SELECT * FROM `marketmanage`.`order`";
            return getList(sql);
        }


        private static List<Order> getList(string sql)
        {
            OdbcConnection connection = DBManager.GetOdbcConnection();
            connection.Open();
            OdbcCommand command = new OdbcCommand(sql, connection);
            OdbcDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                List<Order> list = Order.getList(reader);
                connection.Close();
                return list;
            }
            connection.Close();
            return null;
        }

        ////Delete
        //public static bool DeleteDisaccountByD_ID(string D_ID)
        //{
        //    string sql = "DELETE FROM `marketmanage`.`discount` WHERE `D_ID`= " + D_ID;
        //    return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
        //}

        ////Alter
        //public static bool AlterByD_ID(Discount ds)
        //{
        //    string sql = "UPDATE `marketmanage`.`discount`"
        //        + "SET"
        //        + "`D_Discount`=" + ds.DDiscount.ToString()
        //        + " ,`D_Start`='" + ds.Start.ToString("yyyy-MM-dd") + "'"
        //        + " ,`D_End`='" + ds.End.ToString("yyyy-MM-dd") + "'"
        //        + "WHERE"
        //        + "`D_ID`='" + ds.ID + "'";
        //    return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
        //}
    }
}