﻿using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuperMarketManager.Views.SupplierManager
{
     public partial class SupplierManager : System.Web.UI.Page
     {
        protected List<Supplier_List_Goods> supplierlist = null;
        protected List<Supplier> supplierdetail = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            supplierlist = SupplierList_C.GetSupplylistsByS_Name("");
        }
        protected void Search_Click(object sender, EventArgs e)
        {
            String content = search_content.Value.ToString();
            supplierlist = SupplierList_C.GetSupplylistsByS_Name(content);
        }
        protected void Manage_Click(object sender, EventArgs e)
        {
            /*String content = search_content.Value.ToString();
            if (content.Length != 8)
            {
                Response.Write("<script language=javascript>window.alert('请输入完整工号！');</script>");
             }
            else
            {
                 Boolean del_result = Employee_C.DeleteByID(content);
                 if (del_result)
                 {
                       Response.Write("<script language=javascript>window.alert('删除成功！');</script>");
                       employees = Employee_C.SelectFuzzy("");
                 }
                 else
                 {
                     Response.Write("<script language=javascript>window.alert('删除失败！');</script>");
                  }
             }*/
        }

        protected void Addto_Click(object sender, EventArgs e)
        {
            /* Response.Redirect("/Views/EmployeeManager/Employee_add.aspx");*/
        }
        protected void Updateto_Click(object sender, EventArgs e)
        {
            /*Response.Redirect("/Views/EmployeeManager/Employee_update.aspx");*/
         }
      }
}