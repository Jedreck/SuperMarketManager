using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
namespace SuperMarketManager.Views.GoodsManage2
{
    public partial class GoodsManager : System.Web.UI.Page
    {
        protected List<Goods> goods;
        public int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            goods = Goods_C.SelectFuzzy("");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String s = goodsId.Value.ToString();
            goods = Goods_C.SelectFuzzy(s);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String s = goodsId.Value.ToString();
            String p = price.Value.ToString();
            bool a = Goods_C.AlterByID(s, p);
            if (a == true)
            {
                Response.Write("<script language=javascript>window.alert('修改成功');</script>");
            }
            else
                Response.Write("<script language=javascript>window.alert('修改失败');</script>");
            goods = Goods_C.SelectFuzzy(s);
        }
    }
}