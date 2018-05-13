using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMarketManager.Views.Businessstatistics
{
    public partial class Businessstatistics : System.Web.UI.Page
    {
        protected List<StatisticDay> statisticdayslist = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            statisticdayslist = StatisticDay_C.GetDaysData("2018/1/1", "2018/12/31");
        }
    }
}