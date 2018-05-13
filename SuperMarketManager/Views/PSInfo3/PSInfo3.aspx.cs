using SuperMarketManager.Controllers;
using SuperMarketManager.Models;
using System;
using System.Data.Odbc;


namespace SuperMarketManager.Views.PSInfo3
{
    public partial class PSInfo3 : System.Web.UI.Page
    {
        Employee em;
        protected void Page_Load(object sender, EventArgs e)
        {
            massage();
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Views/PSInfo/PSInfo.aspx");
        }
        protected void massage()
        {
            em = (Employee)Session["employee"];
            if (em == null)
            {
                Response.Write("<script language=javascript>window.alert('请登录！！');window.location.href('/Views/Login/Login.aspx');</script>");
                return;
            }
            id.Text = em.ID;
            name.Text = em.Name;
            if (em.Sex == "男")
                this.sex.SelectedIndex = 0;
            else
                this.sex.SelectedIndex = 1;
            phone.Text = em.Phone;
            birth.Text = em.Birth.ToString("yyyy-MM-dd");
            bankaccount.Text = em.BankAccount;
            email.Text = em.Email;
            position.Text = em.Position.ToString();
            password.Text = em.PassWord;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            em.Name = Request.Form["name"];
            System.Diagnostics.Debug.WriteLine(Request.Form["sex"]);
            em.Sex = Request.Form["sex"];
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