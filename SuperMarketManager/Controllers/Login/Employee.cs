using SuperMarketManager.Controllers.DBManager;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TestMysql.Models;

namespace SuperMarketManager.Controllers.Login
{
    public class Employee_C
    {
        public static Employee Login(string id, string pwd)
        {
            OdbcConnection sqlConnection1 = DBManager.DBManager.GetOdbcConnection();
            sqlConnection1.Open();
            OdbcCommand odbcCommand = new OdbcCommand("select * from employee where E_ID='" + id + "' and E_Password='" + pwd + "'", sqlConnection1);
            OdbcDataReader odbcDataReader = odbcCommand.ExecuteReader();

            if (odbcDataReader.HasRows)
            {
                List<Employee> list = Employee.getList(odbcDataReader);
                sqlConnection1.Close();
                return list[0];
            }
            else
                sqlConnection1.Close();
            return null;
        }
    }

}