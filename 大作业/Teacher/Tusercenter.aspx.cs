using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public partial class Teacher_Tusercenter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Session["tname"].ToString();

        string oldpassword = TextBox1.Text.ToString();
        string newpassword = TextBox3.Text.ToString();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader = null;
        con.ConnectionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select * from teacher where tno=" + id + "and tpwd=" + oldpassword;

        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                cmd.CommandText = "update teacher set tpwd=@apwd where tno=" + id;
                cmd.Parameters.Add("@apwd", newpassword);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Label5.Text = "成功修改密码";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                }
                catch (Exception e2)
                {
                    Response.Write(e2);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                Label5.Text = "原密码错误，请重新输入！";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
            }
        }
        finally
        {
            con.Close();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
    }
}