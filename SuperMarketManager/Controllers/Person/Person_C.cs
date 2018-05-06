using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMarketManager.Controllers.Person
{
    public class Person_C
    {
        //员工只具有修改个人信息的权利
        public static bool alterById(Employee employee)
        {
            return Employee_C.AlterByID(employee);
        }
    }
}