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
    public partial class SupplierManager : System.Web.UI.Page
    {
        protected List<Supplier_List_Goods> supplierlist = null;
        protected List<Supplier> supplierdetail = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            supplierlist = SupplierList_C.GetSupplylistsByS_Name("");
        }
        //protected void Search_Click(object sender, EventArgs e)
        //{
            //String content = search_content.Value.ToString();
            //supplierlist = SupplierList_C.GetSupplylistsByS_Name(content);
       // }
    }
}