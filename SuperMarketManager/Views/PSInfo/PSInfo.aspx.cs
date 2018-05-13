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
            OdbcCommand cmd = new OdbcCommand("select * from employee where E_ID='"+id.Text+"'", odbcConnection);
            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                  name.Text = dr["E_Name"].ToString();
                sex.Text = dr["E_Sex"].ToString();
                phone.Text = dr["E_Phone"].ToString();
               birth.Text = dr["E_Birth"].ToString();
                bankaccount.Text = dr["E_BankAccount"].ToString();
                email.Text = dr["E_Email"].ToString();
                position.Text =dr["E_Position"].ToString();

            }
            dr.Close();
            dr.Close();

        }
       
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/PSInfo/PSInfo.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Name = name.Text;
            em.Sex = sex.SelectedValue.ToString();
            em.Phone = phone.Text;
            em.Birth = Convert.ToDateTime(birth.Text);
            em.BankAccount = bankaccount.Text;
            em.Position = Convert.ToInt32(position.Text);
            em.PassWord = password.Text;
            bool up_result = Employee_C.AlterByID(em);
            if (up_result)
            {
                Response.Write("<script language=javascript>window.alert('修改成功！');</script>");
                Response.Redirect("/Views/PSInfo/PSInfo.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>window.alert('修改失败，请重新检查输入信息是否正确！');</script>");
            }

        }
    }
        
}