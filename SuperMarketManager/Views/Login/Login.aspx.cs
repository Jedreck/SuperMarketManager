using SuperMarketManager.Controllers.Login;
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
             Employee employee = Employee_C.Login(id, pwd);
             if (employee != null)
             {
                 Session["employee"] = employee;
                 Response.Redirect("/Views/Index/Manager_Index.aspx");
             }
             else
                 Response.Write("登录失败！！");
            
        }
    }
}