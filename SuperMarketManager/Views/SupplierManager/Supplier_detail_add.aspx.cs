using SuperMarketManager.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMarketManager.Views.SupplierManager
{
    public partial class Supplier_detail_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_Click(object sender, EventArgs e)
        {
            bool result = Supplier_C.Insert(spname.Value, spphone.Value, spregion.Value);

            if (result)
            {
                Response.Write("<script language=javascript>window.alert('添加成功');</script>");
                spname.Value = "";
                spphone.Value = "";
                spregion.Value = "";
            }
            else
            {
                Response.Write("<script language=javascript>window.alert('添加失败！');</script>");
            }
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/SupplierManager/SupplierManager.aspx");
        }
    }
}