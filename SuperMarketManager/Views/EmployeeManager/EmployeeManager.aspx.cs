using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMarketManager.Views.EmployeeManager
{   
    public partial class EmployeeManager : System.Web.UI.Page
    {
        protected int count;
        protected String[] id;
        protected String[] name;
        protected String[] sex;
        protected String[] phone;
        protected DateTime[] birth;
        protected String[] bankaccount;
        protected String[] email;
        protected int[] position;
        protected List<Employee> employees; 
        protected void Page_Load(object sender, EventArgs e)
        {
            employees = Employee_C.SelectFuzzy("");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            employees = Employee_C.SelectFuzzy("1122");
        }
    }
}