using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SuperMarketManager.Controllers;
using SuperMarketManager.Models;

namespace SuperMarketManager.Views
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
            String s = TextBox1.Text.Trim();
            goods = Goods_C.SelectFuzzy(s);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ;
        }
    }
}