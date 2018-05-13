using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers
{
    public class Discount_C
    {
        //ADD
        public static bool AddDiscount(Discount dis)
        {
            dis.ID = IDFormat.getID_Date16();
            string sql = "INSERT INTO `discount`(`D_ID`,`G_ID`,`D_Discount`,`D_Start`,`D_End`)" +
                " VALUES('" + dis.ID + "','" + dis.G_ID + "','" + dis.DDiscount + "','" + dis.Start + "','" + dis.End + "')";
            return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
        }
        //Delete
        public static bool DeleteDisaccountByD_ID(string D_ID)
        {
            string sql = "DELETE FROM `marketmanage`.`discount` WHERE `D_ID`= " + D_ID;
            return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
        }

        //Alter
        public static bool AlterByD_ID(Discount ds)
        {
            string sql = "UPDATE `marketmanage`.`discount`"
                + "SET"
                + "`D_Discount`=" + ds.DDiscount.ToString()
                + " ,`D_Start`='" + ds.Start.ToString("yyyy-MM-dd") + "'"
                + " ,`D_End`='" + ds.End.ToString("yyyy-MM-dd") + "'"
                + "WHERE"
                + "`D_ID`='" + ds.ID + "'";
            return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
        }

        //Select
        public static List<Discount> SelectByD_ID(string D_ID)
        {
            string sql = "SELECT * FROM `discount` WHERE `D_ID` LIKE '"+D_ID + "'";
            return getList(sql);
        }
        public static List<Discount> SelectByG_ID(string G_ID)
        {
            string sql = "SELECT * FROM `discount` WHERE `G_ID` LIKE '" + G_ID + "'";
            return getList(sql);
        }

        public static List<Discount> SelectAll()
        {
            string sql = "SELECT * FROM `discount`";
            return getList(sql);
        }

        public static List<Discount> SelectDiscountByDate(string startDate = "", string endDate = "")
        {
            string sql = "";
            if (startDate == "" && endDate == "")
                return null;
            else if (startDate == "" && endDate != "")
                sql = "SELECT* FROM `discount` WHERE `D_End`= '" + endDate + "'";
            else if (startDate != "" && endDate == "")
                sql = "SELECT* FROM `discount` WHERE `D_Start`= '" + startDate + "'";
            else
                sql = "SELECT * FROM `discount` WHERE `D_Start`='" + startDate + "' AND `D_End`='" + endDate + "'";
            return getList(sql);
        }

        public static List<Discount> SelectByIDAndDate(string G_ID,string date)
        {
            string sql = "SELECT * FROM `discount` WHERE `G_ID`='"+G_ID+"' AND '"+date+"' BETWEEN `D_Start` AND `D_End`";
            return getList(sql);
        }


        private static List<Discount> getList(string sql)
        {
            OdbcConnection connection = DBManager.GetOdbcConnection();
            connection.Open();
            OdbcCommand command = new OdbcCommand(sql, connection);
            OdbcDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                List<Discount> list = Discount.getList(reader);
                connection.Close();
                return list;
            }
            connection.Close();
            return null;
        }
    }
}