using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace TestMysql.Controllers.DBManager
{
    public class DBManager
    {
        public static OdbcConnection GetOdbcConnection()
        {
            return new OdbcConnection("Dsn=MySql;uid=root;");
        }
    }
}