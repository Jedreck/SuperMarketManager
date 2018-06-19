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
    public partial class Employee_update : System.Web.UI.Page
    {
        protected List<Employee> employees = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            String eid = Request.QueryString["id"];
            employees = Employee_C.SelectFuzzy(eid);          
            id.Value = employees[0].ID;
            up_name.Value = employees[0].Name;
            if (employees[0].Sex == "男")
                this.sex.SelectedIndex = 0;
            else
                this.sex.SelectedIndex = 1;
            births.Text = employees[0].Birth.ToString("yyyy-MM-dd");
            passwords.Text = employees[0].PassWord;
            email.Value = employees[0].Email;
            phone.Value = employees[0].Phone;

            if (employees[0].Position ==1)
            {
                position.Value ="管理员";
            }
            else if (employees[0].Position == 2)
            {
                position.Value = "仓库管理员";
            }
            if (employees[0].Position == 3)
            {
                position.Value = "销售员";
            }
            bankaccount.Value = employees[0].BankAccount;
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/EmployeeManager/EmployeeManager.aspx");
        }

        protected void Update_Click(object sender, EventArgs e)
        {           
            employees[0].Name = Request.Form["up_name"];
            employees[0].Sex = Request.Form["sex"];
            employees[0].Phone = Request.Form["phone"];
            employees[0].Birth = Convert.ToDateTime(Request.Form["births"]);
            employees[0].BankAccount = Request.Form["bankaccount"];
            employees[0].Email = Request.Form["email"];
            bool up_result = Employee_C.AlterByID(employees[0]);                      
            if (up_result)
            {
                Response.Write("<script language=javascript>window.alert('修改成功！');</script>");
                Response.Redirect("/Views/EmployeeManager/EmployeeManager.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>window.alert('修改失败，请重新检查输入信息是否正确！');</script>");
            }
        }
    }
}
