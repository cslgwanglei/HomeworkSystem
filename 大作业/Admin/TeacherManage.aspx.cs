using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public partial class Admin_TeacherManage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
    if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label myLabel = (Label)e.Row.Cells[0].FindControl("Label");
            myLabel.Text = Convert.ToString(e.Row.RowIndex + 1);
        }
    
    }

    protected void Button2_Command(object sender, CommandEventArgs e)
    {
         
   
    }
  
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "reset")
        {
            string tno = e.CommandArgument.ToString();

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update teacher set tpwd='" + tno + "' where tno='" + tno + "'";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Label2.Text = tno + "的密码已被重置为工号！";

            }
            finally
            {
                con.Close();
            }
            string sql = "SELECT [tno], [tname],[tpwd] FROM [teacher]";
            this.SqlDataSource1.SelectCommand = sql;
            GridView1.DataBind();
         
        }

    }
}
  