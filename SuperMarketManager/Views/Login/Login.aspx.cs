using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMarketManager.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_button_Click(object sender, EventArgs e)
        {
            string id = userid.Value.ToString();
            string pwd = password.Value.ToString();
            Session.Add("id", id);
            Session.Add("pwd", pwd);
            Employee employee = Login_C.Login(id, pwd);
            if (employee != null)
            {
                Session["employee"] = employee;
                if (employee.Position == 1)//管理员跳转的网页
                    Response.Redirect("/Views/Index/Manager_Index.aspx");
                else if (employee.Position == 2)//
                    Response.Redirect("/Views/Index/inventory_manager_index.aspx");
            }
            else
                Response.Write("<script language=javascript>window.alert('账号或密码错误，请重新输入！');</script>");

        }
    }
}