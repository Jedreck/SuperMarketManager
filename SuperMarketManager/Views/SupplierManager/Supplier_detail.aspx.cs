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
        protected int sid;
        protected string phone=null;
        protected string region = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            sname = Request.QueryString["id"];
            supplierdetail = Supplier_C.GetSuppliers(sname);
            sid = supplierdetail[0].ID;
            phone = supplierdetail[0].Phone;
            region = supplierdetail[0].Rigion;
            spname.Value = sname;
            spid.Value = sid.ToString();
            spphone.Value = phone;
            spregion.Value = region;

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
            Supplier s = new Supplier(int.Parse(spid.Value), spname.Value, spphone.Value, spregion.Value);
            Response.Write("<script language=javascript>window.alert('"+s.ID+"  "+s.Name+"');</script>");
            bool result = Supplier_C.AlterByID(s);
            if (result)
            {
                Response.Write("<script language=javascript>window.alert('修改成功');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>window.alert('修改失败');</script>");
            }
        }      
    }
    
}