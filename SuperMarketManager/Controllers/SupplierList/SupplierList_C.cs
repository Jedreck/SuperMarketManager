using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers
{
    public class SupplierList_C
    {
        private static List<Supplylist> GetSupplylists(string sql)
        {
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader();
            if (odbcDataReader.HasRows)
            {
                List<Supplylist> list = Supplylist.getList(odbcDataReader);
                odbcConnection.Close();
                return list;
            }
            odbcConnection.Close();
            return null;
        }
        
        public static List<Supplylist> GetSupplylistsByS_ID(string S_ID)
        {
            string sql = "SELECT * FROM `marketmanage`.`supplylist` WHERE `S_ID` LIKE '%" + S_ID + "%'";
            return GetSupplylists(sql);
        }

        public static List<Supplylist> GetSupplylistsByG_ID(string G_ID)
        {
            string sql = "SELECT * FROM `marketmanage`.`supplylist` WHERE `G_ID` LIKE '%" + G_ID + "%'";
            return GetSupplylists(sql);
        }

        public static List<Supplier_List_Goods> GetSupplylistsByS_Name(string S_Name = "")
        {
            string sql = "select `supplylist`.`S_ID`,`supplier`.`S_Name`,`supplylist`.`G_ID`,`goods`.`G_Name`,`supplylist`.`SL_Price`,`goods`.`G_Price`,`goods`.`G_Store` "
                + "from `supplier`,`supplylist`,`goods` "
                +"where `supplier`.`S_Name` like '%"+S_Name+"%'"
                +"and `supplier`.`S_ID`=`supplylist`.`S_ID`"
                +"and `supplylist`.`G_ID`=`goods`.`G_ID`";
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader();
            if (odbcDataReader.HasRows)
            {
                List<Supplier_List_Goods> list = Supplier_List_Goods.GetSupplierAndLists(odbcDataReader);
                odbcConnection.Close();
                return list;
            }
            odbcConnection.Close();
            return null;
        }

        public static bool DeleteSupplylist(string S_ID="", string G_ID = "")
        {
            string sql;
            if (S_ID == "" && G_ID == "")//两个为空，直接返回false
                return false;
            else if (S_ID == "" && G_ID != "")//只有S_ID为空
                sql = "DELETE FROM `marketmanage`.`supplylist` WHERE `G_ID`='"+G_ID+"'";
            else if (G_ID == "" && S_ID != "")//只有G_ID为空
                sql = "DELETE FROM `marketmanage`.`supplylist` WHERE `S_ID`='" + S_ID + "'";
            else
                sql = "DELETE FROM `marketmanage`.`supplylist` WHERE `G_ID`='" + G_ID+"' AND `S_ID`='"+S_ID+"'";
            Console.WriteLine("sql:"+sql);
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            int i = odbcCommand.ExecuteNonQuery();
            odbcConnection.Close();
            return (i > 0) ? true : false;
        }

        public static bool AddSupplylist(string S_ID,string G_ID,string price)
        {
            Supplylist sl = new Supplylist();
            sl.G_ID = G_ID;
            sl.S_ID = Int32.Parse(S_ID);
            sl.SL_Price = Double.Parse(price);
            return AddSupplylist(sl);
        }

        public static bool AddSupplylist(Supplylist sl)
        {
            string sql = "INSERT INTO `supplylist`(`S_ID`,`G_ID`,`SL_Price`) VALUES(" + sl.S_ID + ",'" + sl.G_ID + "','" + sl.SL_Price + "')";
            return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
        }
    }
}