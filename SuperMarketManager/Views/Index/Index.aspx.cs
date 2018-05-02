using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestMysql.Models;

namespace TestMysql.Views.Index
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("id:" + Session["id"]);
            //Response.Write("<br/>")
            //Response.Write("pwd:" + Session["pwd"]);
            Employee employee = (Employee)Session["employee"];
            if (employee == null)
            {
                Response.Write("<script language=javascript>window.alert('请先登录！');window.location.href('/Views/Login/Login.aspx');</script>");
                return;
            }
            id.Text = employee.ID;
            name.Text = employee.Name;
            Birth.Text = employee.Birth.ToString("yyyy-MM-dd");
            position.Text = employee.Position.ToString();
        }
    }
}