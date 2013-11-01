using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Mod;
using Bll;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (this.DropDownList1.SelectedValue == "学生")
        {
            BStudent bll = new BStudent();
            bool affacted = bll.CheckUser(TextBox1.Text, TextBox2.Text);
            if (affacted)
            {
                Session["sname"] = TextBox1.Text.ToString();
                Response.Write("<script>alert('登陆成功！');location='Student/Studentlogin.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！请重试！');location='Login.aspx'</script>");
            }
        }
        if (this.DropDownList1.SelectedValue == "教师")
        {
            BTeacher bll = new BTeacher();
            bool affacted = bll.CheckUser(TextBox1.Text, TextBox2.Text);
            if (affacted)
            {
                Session["tname"] = TextBox1.Text.ToString();
                Response.Write("<script>alert('登陆成功！');location='Teacher/Tusercenter.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！请重试！');location='Login.aspx'</script>");
            }
        }
        if (this.DropDownList1.SelectedValue == "管理员")
        {
            BAdmin bll = new BAdmin();
            bool affacted = bll.CheckUser(TextBox1.Text, TextBox2.Text);
            if (affacted)
            {
                Session["aname"] = TextBox1.Text.ToString();
                Response.Write("<script>alert('登陆成功！');location='Admin/UserCentre.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！请重试！');location='Login.aspx'</script>");
            }

        }
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        DropDownList1.ClearSelection();

    }
}