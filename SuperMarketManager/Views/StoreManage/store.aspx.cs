using SuperMarketManager.Controllers.StoreList;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SuperMarketManager.Controllers;

namespace SuperMarketManager.Views.StoreManage
{
    public partial class store : System.Web.UI.Page
    {
        protected List<Storelist> storelist1 = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            storelist1 = StoreList_C.SelectFuzzy("");
    }
    }
}