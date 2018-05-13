using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMarketManager.Views.DiscountManage
{
    public partial class Discount_delete : System.Web.UI.Page
    {
        protected List<Discount> discountslist = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string discountid = Request.QueryString["id"];
            if (discountid !=null) { 
                discountslist = Discount_C.SelectByD_ID(discountid);
                disid.Value = discountslist[0].ID;
                dgoodsid.Value = discountslist[0].G_ID;
                discount.Value = discountslist[0].DDiscount.ToString();
                disstart.Value = discountslist[0].Start.ToString();
                disend.Value = discountslist[0].End.ToString();
            }
        }
        protected void Delete_Click(object sender,EventArgs e)
        {
            bool result = Discount_C.DeleteDisaccountByD_ID(disid.Value);
            if (result)
            {
                Response.Write("<script language=javascript>window.alert('删除成功！');</script>");
                //Response.Redirect("../../Views/DiscountManage/DiscountManager.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>window.alert('删除失败！');</script>");
            }
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Views/DiscountManage/DiscountManager.aspx");
        }
    }
}