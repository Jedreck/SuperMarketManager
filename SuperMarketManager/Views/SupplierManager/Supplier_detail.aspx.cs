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
            Session["update_id"] = spid.Value;
            Response.Redirect("/Views/SupplierManager/Supplier_detail_update.aspx");

        }      
    }
    
}