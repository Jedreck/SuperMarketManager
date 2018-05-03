using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers
{
    public class IDFormat
    {
        public static string getID_8()
        {
            return new Random().Next(11111111, 99999999).ToString();
        }
    }
}