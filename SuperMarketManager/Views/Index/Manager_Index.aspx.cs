using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMarketManager.Views.Index
{
    public partial class Manager_Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Employee employee = (Employee)Session["employee"];
            if (employee == null)
            {
                Response.Write("<script language=javascript>window.alert('请先登录！');window.location.href('/Views/Login/Login.aspx');</script>");
                return;
            }
        }
    }
}