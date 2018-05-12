using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace SuperMarketManager.Views.GoodsInManage
{
    public partial class GoodsInManage : System.Web.UI.Page
    {
        protected GoodsIn goodsIn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            goodsIn = new GoodsIn("123", gid.Value, Convert.ToInt32(sid.Value), Convert.ToDouble(gprice.Value), Convert.ToDouble(gnum.Value), DateTime.Now, gplace.Value);
            DateTime s=Convert.ToDateTime(gdate.Value);
            bool result=GoodsIn_C.AddGoods(goodsIn,s);
            if (result)
            {
                Response.Write("<script language=javascript>window.alert('入库成功');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>window.alert('入库失败！');</script>");
            }
        }
    }
}