using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMarketManager.Views
{
    public partial class DiscountManager : System.Web.UI.Page
    {
        protected List<Discount> discountslist = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            discountslist = Discount_C.SelectAll();
        }

        protected void searchbutton_Click(object sender, EventArgs e)
        {
            if (dgoodsid.Text.ToString() !="")
            {    
                if(disdate.Text.ToString() == "")
                {
                    discountslist = Discount_C.SelectByG_ID(dgoodsid.Text.ToString());
                }
                else
                {
                    discountslist = Discount_C.SelectByIDAndDate(dgoodsid.Text.ToString(),disdate.Text.ToString());
                }
            }          
            else if (disstart.Text.ToString() != "" && disend.Text.ToString() != "")
            {              
                discountslist = Discount_C.SelectDiscountByDate(disstart.Text.ToString(),disend.Text.ToString());
            }
            else
            {
                Response.Write("<script language=javascript>window.alert('请至少输入id或date和id或起止日期！');</script>");
            }
        }

        protected void addbutton_Click(object sender, EventArgs e)
        {
            bool result = Discount_C.AddDiscount(new Discount("",sdgoodsid.Text.ToString(),disprice.Text.ToString(),sdisstart.Text.ToString(),sdisend.Text.ToString()));
            if (result)
            {
                Response.Write("<script language=javascript>window.alert('插入成功！');</script>");
                Response.Redirect("../../Views/DiscountManage/DiscountManager.aspx");
            }
           else
           {
               Response.Write("<script language=javascript>window.alert('插入失败！');</script>");
           }
        }
    }
}