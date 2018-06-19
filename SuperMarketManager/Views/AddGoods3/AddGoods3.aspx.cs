using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMarketManager.Views.AddGoods3
{
    public partial class AddGoods3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = Goods_C.AddGoods(gid.Value, gname.Value, Convert.ToInt32(gcategory.Value), gunit.Value, Convert.ToInt32(gexpirationdate.Value), Convert.ToDouble(price.Value));

                if (result)
                {
                    Response.Write("<script language=javascript>window.alert('添加成功');</script>");
                }
                else
                {
                    Response.Write("<script language=javascript>window.alert('添加失败！');</script>");
                }
            }
            catch (Exception en)
            {
                Response.Write("<script language=javascript>window.alert('商品信息列表已有该商品，添加失败！');</script>");
            }

        }
    }
}