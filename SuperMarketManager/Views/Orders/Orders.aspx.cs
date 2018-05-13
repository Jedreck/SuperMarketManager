using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SuperMarketManager.Models;
using SuperMarketManager.Controllers;
namespace SuperMarketManager.Views.Orders
{
    public partial class Orders : System.Web.UI.Page
    {
        public static List<Orderlist> list = new List<Orderlist>();
        Orderlist s;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            s = new Orderlist();
            s.O_ID = "";
            s.G_ID = goodsId.Value;
            s.Price = 0;
            s.Num = Convert.ToInt32(goodsnum.Value);
            s.Discount = 0;
            list.Add(s);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ID = "";
            order.Price = 0;
            order.Time = Convert.ToDateTime("2015 - 12 - 21");
            order.E_ID = Convert.ToInt32(eid.Value);
            bool result=Order_C.AddOrder(order,list);
            if(result)
            {
                Response.Write("<script language=javascript>window.alert('出库成功');</script>");
            }
            else
                Response.Write("<script language=javascript>window.alert('出库失败');</script>");
        }
    }
}