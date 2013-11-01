using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;
using Bll;
using Mod;

public partial class Teacher_Remark : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string num = TextBox1.Text.ToString().Trim();
        string sql = "SELECT [workname], [cname], [sno] FROM [grade] where sno like '%" + num + "%'and done ='" + true + "' and remark = '" + false + "'or classid like '%" + num + "%'and done ='" + true + "'and remark = '" + false + "' ";
        this.SqlDataSource1.SelectCommand = sql;
        GridView1.DataBind();
        TextBox1.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string sql = "SELECT [workname], [cname], [sno] FROM [grade] where done ='" + true + "'and remark = '"+false +"'";
         this.SqlDataSource1.SelectCommand = sql;
        GridView1.DataBind();
        TextBox1.Text = "";
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label myLabel = (Label)e.Row.Cells[0].FindControl("Label2");
            myLabel.Text = Convert.ToString(e.Row.RowIndex + 1);
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "back")
        {


            string[] CommandArgumentValue = e.CommandArgument.ToString().Split(',');
            string  sno= CommandArgumentValue[0];
            string cname = CommandArgumentValue[1];
            string workname = CommandArgumentValue[2];
            BGrade bg = new BGrade();
            Grade G = new Grade(workname,sno,cname,false);
            bg.UpdateGrade2(G);
             BHomework bh = new BHomework();
            Homework h = new Homework(sno, false);
            
            if (Page.IsValid)
            {
                bh.UpdateHomework2(h);
               
                Response.Write("<script>alert('发回成功！');location='RemarkDone.aspx'</script>");

            }
            else
            {
                Response.Write("<script>alert('发回失败！');</script>");
            }
          
            
        }

        if (e.CommandName == "download")
        {
            string[] CommandArgumentValue = e.CommandArgument.ToString().Split(',');
            string cname  = CommandArgumentValue[0];
            string sname = CommandArgumentValue[1];
            string workname = CommandArgumentValue[2];

            string fileName = cname   + sname  + workname  + ".rar";
            string filePath = Server.MapPath("..//Student/upload/" + cname  + sname + workname + ".rar");
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);
            if (fileInfo.Exists == true)
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                byte[] bytes = new byte[(int)fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Disposition", "attachment;   filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
                Response.BinaryWrite(bytes);
                Response.Flush();
                Response.End();
            }
            else
            {
                Response.Write("<script>alert('下载失败，该学生(" + cname + sname + workname + ")未上传作业材料')</script>");

            }

        }
    }

}