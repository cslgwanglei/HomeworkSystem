using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Bll;
using Mod;
public partial class Admin_TeacherAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (this.DropDownList1.SelectedValue == "教师")
        {
            BTeacher bll = new BTeacher();
            Teacher t = new Teacher(
               Convert.ToString(TextBox1.Text),
               Convert.ToString(TextBox2.Text),
               Convert.ToString(TextBox3.Text)
               );
            if (Page.IsValid)
            {

                bll.InsertTeacher(t);
                Response.Write("<script>alert('添加成功！');</script>");

            }
            else
            {
                Response.Write("<script>alert('添加失败！');</script>");
            }
        }
        if (this.DropDownList1.SelectedValue == "管理员")
        {
            BAdmin  bll = new BAdmin ();
            Admin  t = new Admin (
               Convert.ToString(TextBox1.Text),
               Convert.ToString(TextBox2.Text),
               Convert.ToString(TextBox3.Text)
               );
            if (Page.IsValid)
            {

                bll.InsertAdmin (t);
                Response.Write("<script>alert('添加成功！');</script>");

            }
            else
            {
                Response.Write("<script>alert('添加失败！');</script>");
            }
        }
    }
}