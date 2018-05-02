using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestMysql.Controllers.Login;
using TestMysql.Models;

namespace TestMysql.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_button_Click(object sender, EventArgs e)
        {
            string id = this.id.Text.Trim();
            string pwd = this.pwd.Text.Trim();
            //Session.Add("id", id);
            //Session.Add("pwd", pwd);
            Employee employee = Employee_C.Login(id, pwd);
            if (employee != null)
            {
                Session["employee"] = employee;
                Response.Redirect("/Views/Index/Index.aspx");
            }
            else
                Response.Write("登录失败！！");
        }
    }
}