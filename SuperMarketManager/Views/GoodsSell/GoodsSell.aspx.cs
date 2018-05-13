using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMarketManager.Views.GoodsSell
{
    public partial class GoodsSell : System.Web.UI.Page
    {
        protected List<StaticGoods> staticgoodslist = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            staticgoodslist = StatisticGoods_C.GetDays("2017/5/1 19:23:45", "2018/5/20 19:23:45");
        }
        protected void Search_Click(object sender, EventArgs e)
        {
            string goodsid = search_id.Value.ToString();
            string sellstart = search_start.Value.ToString();
            string sellend = search_end.Value.ToString();
            string selldate = search_date.Value.ToString();
            if (goodsid == "")
            {
                if (selldate!="")
                    staticgoodslist = StatisticGoods_C.GetDays(selldate);
                else if (sellstart == "" && sellend != "")
                {
                    Response.Write("<script language=javascript>window.alert('请输入起始日期');</script>");
                }
                else if (sellstart != "" && sellend == "")
                {
                    Response.Write("<script language=javascript>window.alert('请输入结束日期');</script>");
                }
                else if (sellstart != "" && sellend != "")
                {
                    staticgoodslist = StatisticGoods_C.GetDays(sellstart, sellend);
                }
                else if (sellstart == "" && sellend == "" && selldate == "")
                {
                    staticgoodslist = StatisticGoods_C.GetDays("2017/5/1 19:23:45", "2018/5/20 19:23:45");
                }

            }
            else 
            {
                if (selldate != "")
                    staticgoodslist = StatisticGoods_C.GetDaysData(goodsid, selldate);
                else if (sellstart == "" && sellend != "")
                {
                    Response.Write("<script language=javascript>window.alert('请输入起始日期');</script>");
                }
                else if (sellstart != "" && sellend == "")
                {
                    Response.Write("<script language=javascript>window.alert('请输入结束日期');</script>");
                }
                else if (sellstart != "" && sellend != "")
                {
                    staticgoodslist = StatisticGoods_C.GetDaysData(goodsid, sellstart, sellend);
                }
                else if (sellstart == "" && sellend == "" && selldate == "")
                {
                    staticgoodslist = StatisticGoods_C.GetDaysData(goodsid, "2000/2/2 00:00:00", "3000/2/2 00:00:00");
                }
            }
        }

    }
}