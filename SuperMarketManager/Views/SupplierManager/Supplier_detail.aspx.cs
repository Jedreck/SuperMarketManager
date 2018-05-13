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
    public partial class Supplier_detail : System.Web.UI.Page
    {
        protected List<Supplier> supplierdetail = null;
        protected string sname=null;
        protected void Page_Load(object sender, EventArgs e)
        {
            sname = Request.QueryString["id"];
            supplierdetail = Supplier_C.GetSuppliers(sname);
            spname.Value = sname;
            spid.Value = supplierdetail[0].ID.ToString();
            spphone.Value = supplierdetail[0].Phone;
            spregion.Value = supplierdetail[0].Rigion;
        }
        protected void Add_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/SupplierManager/Supplier_detail_add.aspx");
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/SupplierManager/SupplierManager.aspx");
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier(int.Parse(Request.Form["spid.Value"]), Request.Form["spname.Value"], Request.Form["spphone.Value"] , Request.Form["spregion.Value"]);
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