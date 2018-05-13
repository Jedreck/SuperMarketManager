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
    public partial class Supplier_Goods_detail : System.Web.UI.Page
    {
        protected List<Supplier_List_Goods> supplierlist = null; 
        protected string sname = null;
        protected string gname = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            sname = Request.QueryString["sname"];
            gname= Request.QueryString["gname"];
            supplierlist = SupplierList_C.GetSupplylistsByS_Name(sname);
            for(int i = 0; i < supplierlist.Count; i++)
            {
                if (supplierlist[i].G_Name == gname)
                {
                    ssid.Value = supplierlist[i].S_ID.ToString();
                    ssname.Value= supplierlist[i].S_Name.ToString();
                    ggid.Value = supplierlist[i].G_ID.ToString();
                    ggname.Value = supplierlist[i].G_Name;
                    gsprice.Value = supplierlist[i].SL_Price.ToString();
                    break;
                }
            }

        }
        protected void Add_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/SupplierManager/Supplier_Goods_add.aspx");          
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/SupplierManager/SupplierManager.aspx");
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            Response.Write("<script language=javascript>window.alert('"+ ssid.Value + "--"+ ggid.Value + "');</script>");
            bool result = SupplierList_C.DeleteSupplylist(ssid.Value,ggid.Value);
            if (result)
            {
                Response.Write("<script language=javascript>window.alert('删除成功');</script>");
                Response.Redirect("/Views/SupplierManager/SupplierManager.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>window.alert('删除失败');</script>");
            }       
        }
    }
}