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

        public static string getID_Date16()
        {
            string id = DateTime.Now.Year.ToString() +
                DateTime.Now.Month.ToString()+
                DateTime.Now.Day.ToString() +
                DateTime.Now.Hour.ToString()+
                DateTime.Now.Minute.ToString()+
                DateTime.Now.Second.ToString();
            return id;
        }
    }
}