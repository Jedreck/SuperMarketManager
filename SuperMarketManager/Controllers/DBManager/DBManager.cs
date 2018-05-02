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
            //自己的MySql连接方式，每个人不同，所以需要自己写
            return new OdbcConnection("Dsn=MySql;uid=root;");
        }
    }
}