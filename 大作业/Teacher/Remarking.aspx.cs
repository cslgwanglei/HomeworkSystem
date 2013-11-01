using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using Mod;
using Bll;
using System.Data;
using System.IO;
public partial class Teacher_Remark : System.Web.UI.Page
{
    string workname; 
       string cname; 
       string sno;
       string tname;


       
 
  
    protected void Page_Load(object sender, EventArgs e)
    {
       
        workname =Request.QueryString["workname"];
        cname = Request.QueryString["cname"];
       sno = Request.QueryString["sno"];
       SqlConnection con = new SqlConnection();
       SqlCommand cmd = new SqlCommand();

       con.ConnectionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;
       cmd = new SqlCommand();
       cmd.Connection = con;
        string sql="select comment,score,workdata from grade where sno = '"+sno +"' and workname = '"+workname +"' and cname = '"+cname+"'";
        DataTable dt = new DataTable();

        using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con)) {
        try
            {
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                  string   Comment = dr[0].ToString();
                    string  score = dr[1].ToString();
                    string workdata = dr[2].ToString();
                   
                   Label2.Text=workname;
                    Label4.Text=Comment;
                    Label3.Text=score;
                    Label5.Text=workdata;
                }

            }
            finally
            {
                con.Close();
            }
          
        }
        }
   
    protected void Button1_Click(object sender, EventArgs e)
    {

        string tname = Session["tname"].ToString();
       //string  tname = Session ["tname"].ToString();
        BGrade b = new BGrade();
        Grade s = new Grade(
            workname,sno,cname,
            Convert.ToUInt32 (TextBox1.Text ),
            Convert.ToString(TextBox2.Text ),
            true,tname 
            );
        if (Page.IsValid)
        {

            b.UpdateGrade (s );
            Response.Write("<script>alert('批阅成功！');location='RemarkDone.aspx'</script>");

        }
        else
        {
            Response.Write("<script>alert('批阅失败！');</script>");
        }
    }
}