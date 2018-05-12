using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
namespace SuperMarketManager.Views.PSInfo
  
{
    public partial class PSInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            massage();
        }
        protected void massage()
        {
            id.Text = Session["E_ID"].ToString();
            OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
           odbcConnection.Open();
            //从员工表中提取和登录号一致的员工信息
            OdbcCommand cmd = new OdbcCommand("select * from employee where E_ID='"+id+"'", odbcConnection);
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                  name.Text = dr["E_Name"].ToString();
                sex.Text = dr["E_Sex"].ToString();
                phone.Text = dr["E_Phone"].ToString();
               birth.Text = dr["E_Birth"].ToString();
                bankaccount.Text = dr["E_BankAccount"].ToString();
                email.Text = dr["E_E-mail"].ToString();
                position.Text =dr["E_Position"].ToString();

            }
            dr.Close();
            dr.Close();

        }
        protected void Save_Click()
        {
            
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/EmployeeManager/PSInfo.aspx");
        }
    }
        
}