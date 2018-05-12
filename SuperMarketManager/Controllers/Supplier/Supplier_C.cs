using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers
{
    public class Supplier_C
    {
        //查
        public static List<Supplier> GetSuppliers(string info = "")
        {
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            string sql = "SELECT * FROM `marketmanage`.`supplier` "
                + "WHERE `S_ID` Like '%" + info + "%'"
                + "OR `S_Name` LIKE '%" + info + "%'"
                + "OR `S_Phone` LIKE '%" + info + "%'"
                + "OR `S_Region` LIKE '%" + info + "%'";
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader(CommandBehavior.CloseConnection);
            if (odbcDataReader.HasRows)
            {
                List<Supplier> list = Supplier.getList(odbcDataReader);
                odbcConnection.Close();
                return list;
            }
            odbcConnection.Close();
            return null;
        }

        //增
        public static bool Insert(string name, string phone, string region)
        {
            string sql = "insert into `marketmanage`.`supplier` (`S_Name`, `S_Phone`, `S_Region`) " +
                "values('" + name + "', '" + phone + "', '" + region + "')";
            return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
        }

        //删
        public static bool DeleteByID(string id)
        {
            string sql = "DELETE FROM `marketmanage`.`supplier` WHERE S_ID=" + id;
            return ExecuteSQL.ExecuteNonQuerySQL_GetBool(sql);
        }

        ////改
        //public static bool AlterByID(string info)
        //{

        //}
    }
}