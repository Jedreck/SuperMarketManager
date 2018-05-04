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
            string sql = "SELECT * FROM `marketmanage`.`supplier` " +
                "WHERE CONCAT(`S_ID`,`S_Name`,`S_Phone`,`S_Region`) " +
                "LIKE '%" + info + "%'";
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
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            string sql = "insert into `marketmanage`.`supplier` (`S_Name`, `S_Phone`, `S_Region`) " +
                "values('" + name + "', '" + phone + "', '" + region + "')";
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            int i = odbcCommand.ExecuteNonQuery();
            odbcConnection.Close();
            return (i > 0) ? true : false;
        }

        //删
        public static bool DeleteByID(string id)
        {
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            odbcConnection.Open();
            string sql = "DELETE FROM `marketmanage`.`supplier` WHERE S_ID=" + id;
            OdbcCommand odbcCommand = new OdbcCommand(sql, odbcConnection);
            int i = odbcCommand.ExecuteNonQuery();
            odbcConnection.Close();
            return (i > 0) ? true : false;
        }

        ////改
        //public static bool AlterByID(string info)
        //{

        //}
    }
}