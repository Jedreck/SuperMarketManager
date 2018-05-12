using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMarketManager.Views.SupplierManager
{
    public partial class Supplier_detail_update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            spid.Value = Session["update_id"].ToString();
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/SupplierManager/Supplier_detail.aspx");
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier(int.Parse(spid.Value), spname.Value, spphone.Value, spregion.Value);          
            bool result = Supplier_C.AlterByID(s);
            if (result)
            {
                Response.Write("<script language=javascript>window.alert('修改成功');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>window.alert('修改失败！请检查是否与之前信息不同！');</script>");
            }
        }
    }
}