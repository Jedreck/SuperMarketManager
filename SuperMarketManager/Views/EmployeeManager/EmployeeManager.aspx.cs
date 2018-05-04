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
        protected String ID;
        protected String Name;
        protected String Sex;
        protected String Phone;
        protected DateTime Birth;
        protected String BankAccount;
        protected String Email;
        protected int Position;
        protected String PassWord;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> employees = Employee_C.SelectFuzzy("11");
            int count = employees.Count;            
            for(int i = 0; i < count; i++)
            {
                ID = employees[i].ID;
                Name = employees[i].Name;
                Sex = employees[i].Sex;
                Phone = employees[i].Phone;
                Birth = employees[i].Birth;
                BankAccount = employees[i].BankAccount;
                Email = employees[i].Email;
                Position = employees[i].Position;
                PassWord = employees[i].PassWord;
            }                      
        }
    }
}