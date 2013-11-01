using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Mod;
using Bll;

public partial class Student_WorkHaveDone : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //string a = (Master.FindControl("Label1") as Label).Text;
        string a = Session["sname"].ToString();
        string sql = "select cname ,workname,starttime,endtime from Homework where sno ='" +a  + "'and hand = 'false'";
        this.SqlDataSource1.SelectCommand = sql;
        GridView1.DataBind();
      
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label myLabel = (Label)e.Row.Cells[0].FindControl("Label4");
            myLabel.Text = Convert.ToString(e.Row.RowIndex + 1);
        }
       
    }
   
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("Upwork.aspx?workname=e.CommandArguement");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
      
     
    }
   
}