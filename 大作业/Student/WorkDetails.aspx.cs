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
using System.IO;
public partial class Student_WorkDetrails : System.Web.UI.Page
{
    string workname;
    string sno;
    string classid;
    string cname;
    protected void Page_Load(object sender, EventArgs e)
    {
        workname = Request.QueryString["workname"];
        sno = Session["sname"].ToString();
        cname = Request.QueryString["cname"];
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        con.ConnectionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;
        cmd = new SqlCommand();
        cmd.Connection = con;
        string sql = "select score,comment,tname,grade,appraise,workdata from grade where workname ='" + workname + "'and sno = '"+sno +"'";
        DataTable dt = new DataTable();
        using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
        {
            try
            {
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string score = dr[0].ToString();
                    string comment = dr[1].ToString();

                    string tname = dr[2].ToString();
                    string grade = dr[3].ToString();
                    string appraise = dr[4].ToString();
                    string workdata = dr[5].ToString();
                    Label2.Text = workname;
                    Label3.Text = score;
                    Label4.Text = comment;
                    Label5.Text = workdata;
                    Label6.Text = tname;
                    Label7.Text = grade;
                    if (appraise == "")
                    { Label8.Text = "无评语！"; }
                    else {
                    Label8.Text = appraise;
                }}

            }
            finally
            {
                con.Close();
            }

        }
    }

    protected void LinkButton2_Click1(object sender, EventArgs e)
    {
        string fileName = cname + sno + workname + ".rar";
        string filePath = Server.MapPath("..//Student/upload/" + cname + sno + workname + ".rar");
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
            Response.Write("<script>alert('下载失败，该学生(" + cname + sno + workname + ")未上传作业材料')</script>");

        }
    }
}