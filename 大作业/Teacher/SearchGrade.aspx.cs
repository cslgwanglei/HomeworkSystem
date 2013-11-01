using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Teacher_SearchGrade : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Calendar2.Visible = true;
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar2.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string cname = DropDownList1.Text;
        string starttime = TextBox1.Text;
        string endtime = TextBox2.Text;
        string workname = CheckBoxList1.Text;
        string sc = TextBox3.Text;
        string sql = "select sno,workname,tname,cname,grade from grade where cname ='" + cname + "'and workname ='" + workname + "'and remark = '" + true + "'and  classid like '%" + sc + "%'or sno like '%" + sc + "%'and remark = '" + true + "' ";
        this.SqlDataSource3.SelectCommand = sql;
        GridView1.DataBind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label myLabel = (Label)e.Row.Cells[0].FindControl("Label6");
            myLabel.Text = Convert.ToString(e.Row.RowIndex + 1);
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}