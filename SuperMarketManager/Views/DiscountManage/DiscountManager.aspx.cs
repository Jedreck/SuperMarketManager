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
        int disid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            discountslist = Discount_C.SelectAll();
        }

        protected void searchbutton_Click(object sender, EventArgs e)
        {
            if (dgoodsid.Text.ToString() !="")
            {            
                    discountslist = Discount_C.SelectByG_ID(dgoodsid.Text.ToString());            
            }
            else if (disstart.Text.ToString() != "" && disend.Text.ToString() != "")
            {
                discountslist = Discount_C.SelectDiscountByDate(disstart.Text.ToString(),disend.Text.ToString());
            }
        }

        protected void addbutton_Click(object sender, EventArgs e)
        {
            //disid++;
            //bool result = Discount_C.AlterByD_ID(new Discount("123", "1000", 0.2, DateTime.Parse("2018/5/2 00:00:00"), DateTime.Parse("2018/5/3 00:00:00")));
            //bool result = Discount_C.AlterByD_ID(new Discount("123", sdgoodsid.Text.ToString(),
            // double.Parse(disprice.Text.ToString()), DateTime.Parse(sdisstart.Text.ToString()), 
            // DateTime.Parse(sdisend.Text.ToString())));
            //if (result)
            //{
                //Response.Write("<script language=javascript>window.alert('插入成功！');</script>");
           // }
           // else
           // {
               // Response.Write("<script language=javascript>window.alert('插入失败！');</script>");
           // }
        }
    }
}