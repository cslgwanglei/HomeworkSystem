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
public partial class Admin_StudentManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string StudentID = TextBox1.Text.ToString().Trim();
        string StudentName = TextBox2.Text.ToString().Trim();
        string Class = TextBox3.Text.ToString().Trim();



        string sql = "SELECT [sno], [sname], [classid], [spwd] FROM [Student] where sno like '%" + StudentID + "%' and sname like '%" + StudentName + "%' and classid like '%" + Class + "%'";
        this.SqlDataSource1.SelectCommand = sql;
        GridView1.DataBind();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        string sql = "select * from Student";
        this.SqlDataSource1.SelectCommand = sql;
        GridView1.DataBind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label myLabel = (Label)e.Row.Cells[0].FindControl("Label5");
            myLabel.Text = Convert.ToString(e.Row.RowIndex + 1);
        }
    }
}