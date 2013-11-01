using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Mod;
using Bll;
public partial class Admin_CourseAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
       
        
      
            BCourse bll = new BCourse();
            Course a = new Course(TextBox1.Text, TextBox2.Text);
            if (Page.IsValid)
            {

                bll.InsertCourse(a);
                Response.Write("<script>alert('添加成功！');location='CourseAdd.aspx'</script>");

            }
            else
            {
                Response.Write("<script>alert('添加失败！');</script>");
            }


        }
    }
