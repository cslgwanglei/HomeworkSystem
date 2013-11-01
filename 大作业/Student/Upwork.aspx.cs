using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;
using Mod;
using Bll;
using Dal;
public partial class Student_Upwork : System.Web.UI.Page
{
    string workname;
    string sname;
    string classid;
    string cname;

    protected void Page_Load(object sender, EventArgs e)
    {

        {workname = Request.QueryString["workname"];
        sname = Session["sname"].ToString();
        
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        con.ConnectionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;
        cmd = new SqlCommand();
        cmd.Connection = con;
        string sql = "select comment,score,cname,classid from homework where workname ='" + workname + "'";
        DataTable dt = new DataTable();    
        using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
        {
            try
            {
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string comment = dr[0].ToString();
                    string score = dr[1].ToString();
                    
                    string cname =dr[2].ToString();
                    string Classid = dr[3].ToString();
                        Label2.Text = workname;
                        Label3.Text = score;
                        TextBox1.Text = comment;
                        Label4.Text = cname;
                        classid = Classid;
                    }

                }
                finally
                {
                    con.Close();
                }

            }

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {   
                BGrade bll = new BGrade();
               
                 Grade ge =new Grade  (
                Convert.ToString (workname),
                Convert.ToString(sname),
                Convert.ToString(Label4.Text),
                Convert.ToString (Label3.Text),
                Convert.ToString(TextBox1.Text),
                Convert.ToString(TextBox2.Text),
                false ,false,false,false,classid   );
                 if (Page.IsValid)
                 {

                     bll.InsertGrade(ge);
                     Response.Write("<script>alert('暂存成功！');location='Upwork.aspx'</script>");

                 }
                 else
                 {
                     Response.Write("<script>alert('暂存失败！');</script>");
                 }
                }

    protected void Button3_Click(object sender, EventArgs e)
    {
        BHomework bh=new BHomework() ;
        Homework s = new Homework(
            sname,
            true 
            );
        bh.UpdateHomework2(s);
        BGrade bll = new BGrade();
        bll.DeleteGrade(workname);
        Grade ge = new Grade(
       Convert.ToString(workname),
       Convert.ToString(sname),
       Convert.ToString(Label4.Text),
       Convert.ToString(Label3.Text),
       Convert.ToString(TextBox1.Text),
       Convert.ToString(TextBox2.Text),
       true , true, true, false, classid);
        if (Page.IsValid)
        {

            bll.InsertGrade(ge);
            Response.Write("<script>alert('提交成功！');location='Upwork.aspx'</script>");

        }
        else
        {
            Response.Write("<script>alert('提交失败！');</script>");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string fullFileName = this.FileUpload1.PostedFile.FileName;
        string fileName = fullFileName.Substring(fullFileName.LastIndexOf(@"/") + 1);
        string typeName = (fullFileName.Substring(fullFileName.LastIndexOf(".") + 1)).ToLower();
        if (typeName == "rar")
        {
            string fn = FileUpload1.FileName;
            fn = Label4.Text + sname + workname + ".rar";
            FileUpload1.SaveAs(Server.MapPath("upload\\" + fn));
            Label6.Text = "上传成功！";
        }
        else
        {
            Response.Write("<script languge='javascript'>alert('请先压缩成rar格式!');</script>");
        }
    }
}
         
        
    
