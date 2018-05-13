using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Data.Odbc;
namespace SuperMarketManager.Views.PSInfo

{
    public partial class PSInfo : System.Web.UI.Page
    {
        Employee em = new Employee();
        protected void Page_Load(object sender, EventArgs e)
        {
            massage();
        }
        protected void massage()
        {
            em = (Employee)Session["employee"];
            id.Text = em.ID;
            name.Text = em.Name;
            sex.Text = em.Sex;
            phone.Text = em.Phone;
            birth.Text = em.Birth.ToString("yyyy-MM-dd");
            bankaccount.Text = em.BankAccount;
            email.Text = em.Email;
            position.Text = em.Position.ToString();
            password.Text = em.PassWord;
            //id.Text = Session["employee"].ToString();
            //OdbcConnection odbcConnection = DBManager.GetOdbcConnection();
            //odbcConnection.Open();
            ////从员工表中提取和登录号一致的员工信息
            //OdbcCommand cmd = new OdbcCommand("select * from employee where E_ID='" + id.Text + "'", odbcConnection);
            //OdbcDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{

            //    name.Text = dr["E_Name"].ToString();
            //    sex.Text = dr["E_Sex"].ToString();
            //    phone.Text = dr["E_Phone"].ToString();
            //    birth.Text = dr["E_Birth"].ToString();
            //    bankaccount.Text = dr["E_BankAccount"].ToString();
            //    email.Text = dr["E_Email"].ToString();
            //    position.Text = dr["E_Position"].ToString();
            //    password.Text = dr["E_Password"].ToString();

            //}
            //dr.Close();
            //dr.Close();

        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/PSInfo/PSInfo.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            em.Name = Request.Form["name"];
            em.Sex = sex.SelectedItem.ToString();
            em.Phone = Request.Form["phone"];
            em.Birth = Convert.ToDateTime(Request.Form["birth"]);
            em.BankAccount = Request.Form["bankaccount"];
            em.Email = Request.Form["email"];
            em.Position = Convert.ToInt32(Request.Form["position"]);
            string pwd = Request.Form["password"];
            if (pwd != "")
                em.PassWord = pwd;
            bool up_result = Employee_C.AlterByID(em);
            if (up_result)
            {
                Response.Write("<script language=javascript>window.alert('修改成功！');window.location.href('/Views/Login/Login.aspx');</script>");
                //Response.Redirect("/Views/PSInfo/PSInfo.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>window.alert('修改失败，请重新检查输入信息是否正确！');</script>");
            }

        }
    }

}