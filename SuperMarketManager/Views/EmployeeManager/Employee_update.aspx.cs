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
            
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/EmployeeManager/EmployeeManager.aspx");
        }

        protected void Update_Click(object sender, EventArgs e)
        {           
            String sex = null;
            int pos = 0;
            if (sex_male.Checked)
            {
                sex = "男";
            }
            else if (sex_female.Checked)
            {
                sex = "女";
            }
            if (position.Value.ToString() == "管理员")
            {
                pos = 1;
            }
            else if (position.Value.ToString() == "仓库管理员")
            {
                pos = 2;
            }
            if (position.Value.ToString() == "销售员")
            {
                pos = 1;
            }
            bool up_result = Employee_C.AlterByID(new Employee(up_name.Value.ToString(), sex, phone.Value.ToString(), births.Value.ToString(),
                pos, bankaccount.Value.ToString(), email.Value.ToString()));                      
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
