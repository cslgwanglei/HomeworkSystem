using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher_RemarkDone : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label myLabel = (Label)e.Row.Cells[0].FindControl("Label2");
            myLabel.Text = Convert.ToString(e.Row.RowIndex + 1);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string num = TextBox1.Text.ToString().Trim();
        string sql = "SELECT [workname], [cname], [sno],[grade] FROM [grade] where sno like '%" + num + "%' and remark = '" + true + "'or classid like '%" + num + "%'and remark = '" + true + "' ";
        this.SqlDataSource1.SelectCommand = sql;
        GridView1.DataBind();
        TextBox1.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string sql = "SELECT [workname], [cname], [sno],[grade] FROM [grade] where remark = '"+true +"'";
        this.SqlDataSource1.SelectCommand = sql;
        GridView1.DataBind();
        TextBox1.Text = "";
    }
}