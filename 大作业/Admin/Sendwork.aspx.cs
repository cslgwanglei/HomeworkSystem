using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public partial class Admin_Sendwork : System.Web.UI.Page
{
    string workname;
    string cname;
    string comment;
    string starttime;
    string endtime;
    string tname;
    string sno;
    string sname;
    string score;
    int Number = 0;
    int flag = 0;
    string classid;
    string classid1;
    string sno2;
    string sname1;
    protected void Page_Load(object sender, EventArgs e)
    {
        workname = Request.QueryString["workname"];

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        con.ConnectionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;
        cmd = new SqlCommand();
        cmd.Connection = con;
        con.Open();
        string sql = "Select cname,comment ,score from work Where workname='" + workname + "'";
        DataTable dt = new DataTable();
        using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
        {
            try
            {
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cname = dr[0].ToString();
                    comment = dr[1].ToString();
                    score = dr[2].ToString();
                }

            }
            finally
            {
                con.Close();
            }
            Label2.Text = cname;
            Label3.Text = workname;


        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        starttime = TextBox1.Text.ToString();
        endtime = TextBox2.Text.ToString();
        sno = TextBox5.Text.ToString();
        tname = DropDownList1.SelectedItem.ToString();


          
        if (RadioButton1.Checked == true)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;
            cmd = new SqlCommand();
            cmd.Connection = con;
            string sql = "select classid,sname from student where sno ='" + sno + "'";
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
            {
                try
                {
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                         classid = dr[0].ToString();
                         sname = dr[1].ToString();


                    }

                }
                finally
                {
                    con.Close();
                }

            }
            con.Open();
            cmd.CommandText = "Select classid from student where sno='" + sno  + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                cmd.CommandText = "select * from homework where sno='"+sno +"'and cname='" + cname  + "' and workname='" + workname + "'";
                try
                {
                    con.Open();
                    reader=cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        TextBox4.Text = "-----------------------------------\n" + "该学生的作业已存在，请勿重复分发！";
                    }
                    else
                    {
                        con.Close();
                        cmd.CommandText = "insert into homework(classid,sno,comment,score,workname,cname,starttime,endtime,sname,tname) values('" + classid  + "','" + sno  + "','" + comment + "','" + score + "','" + workname + "','" + cname + "','" + starttime + "','" + endtime + "','" + sname + "','" + tname + "')";
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            flag = 1;

                            TextBox4.Text = "分发成功！！！！！！！！！！";

                        }
                        finally
                        {
                            con.Close();

                        }
                    }

                }
                finally
                {
                    con.Close();
                }


            }
            else
            {
                TextBox4.Text = "------------------------\n 无此学生信息，分派失败！";
            }
          

        }
        if (RadioButton2.Checked == true) {


            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader = null;
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;
            cmd = new SqlCommand();
            cmd.Connection = con;
            string sql = "select sno,sname from student where classid ='" + sno + "'";
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
            {
                try
                {
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        sno2  = dr[0].ToString();
                        sname1  = dr[1].ToString();


                    }

                }
                finally
                {
                    con.Close();
                }

            }
            con.Open();
            cmd.CommandText = "Select sno from student where classid='" + sno + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                con.Close();
                cmd.CommandText = "select * from homework where classid='" + sno + "'and cname='" + cname + "' and workname='" + workname + "'";
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        TextBox4.Text = "-----------------------------------\n" + "该班级的作业已存在，请勿重复分发！";
                    }
                    else
                    {
                        con.Close();
                        cmd.CommandText = "insert into homework(classid,sno,comment,score,workname,cname,starttime,endtime,sname,tname) values('" + sno  + "','" + sno2 + "','" + comment + "','" + score + "','" + workname + "','" + cname + "','" + starttime + "','" + endtime + "','" + sname1 + "','" + tname + "')";
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            flag = 1;

                            TextBox4.Text = "分发成功！！！！！！！！！！";

                        }
                        finally
                        {
                            con.Close();

                        }
                    }

                }
                finally
                {
                    con.Close();
                }


            }
            else
            {
                TextBox4.Text = "------------------------\n 无此班级信息，分派失败！";
            }

        }

       
        }

    
        
    
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
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
    protected void Button2_Click(object sender, EventArgs e)
    {

        {
            starttime = TextBox1.Text.ToString();
            endtime = TextBox2.Text.ToString();
            sno = TextBox5.Text.ToString();
            tname = DropDownList1.SelectedItem.ToString();


            if (RadioButton1.Checked == true)
            {
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader = null;
                con.ConnectionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;
                cmd = new SqlCommand();
                cmd.Connection = con;
                string sql = "Select sno,sname from student Where classid='" + sno + "'";
                DataTable dl = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
                {
                    try
                    {
                        adapter.Fill(dl);
                        foreach (DataRow dr in dl.Rows)
                        {
                            classid1 = dr[0].ToString();
                            sname = dr[1].ToString();
                        }
                    }

                    finally
                    {
                        con.Close();
                    }

                }
                con.Close();
                cmd.CommandText = "select * from homework where sno='" + sno + "' and cname='" + cname + "' and workname='" + workname + "'";
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                       
                    }
                    else
                    {
                        con.Close();
                        cmd.CommandText = "update homework set classid='" + classid + "',sno='" + sno + "', comment='" + comment + "', score='" + score + "',workname='" + workname + "',cname='" + cname + "',starttime='" + starttime + "',endtime='" + endtime + "',sname='" + sname + "',tname='" + tname + "'";
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            flag = 1;

                            TextBox4.Text = "修改成功！";

                        }
                        finally
                        {
                            con.Close();

                        }
                    }

                }
                finally
                {
                    con.Close();
                }


            }
            else
            {
                TextBox4.Text = "------------------------\n 无此学生信息，修改失败！";
            }
            if (RadioButton2.Checked == true)
            {
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader = null;
                con.ConnectionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;
                cmd = new SqlCommand();
                cmd.Connection = con;
                string sql = "Select classid,sname from student Where sno='" + sno + "'";
                DataTable dl = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
                {
                    try
                    {
                        adapter.Fill(dl);
                        foreach (DataRow dr in dl.Rows)
                        {
                            classid1 = dr[0].ToString();
                            sname = dr[1].ToString();
                        }
                    }

                    finally
                    {
                        con.Close();
                    }

                }
                con.Close();
                cmd.CommandText = "update homework set classid='" + sno  + "',sno='" + classid1  + "', comment='" + comment + "', score='" + score + "',workname='" + workname + "',cname='" + cname + "',starttime='" + starttime + "',endtime='" + endtime + "',sname='" + sname + "',tname='" + tname + "'";
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                       
                    }
                    else
                    {
                        con.Close();
                        cmd.CommandText = "insert into homework(classid,sno,comment,score,workname,cname,starttime,endtime,sname,tname) values('" + sno + "','" + classid1 + "','" + comment + "','" + score + "','" + workname + "','" + cname + "','" + starttime + "','" + endtime + "','" + sname + "','" + tname + "')";
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            flag = 1;

                            TextBox4.Text = "修改成功！";

                        }
                        finally
                        {
                            con.Close();

                        }
                    }

                }
                finally
                {
                    con.Close();
                }


            }
            else
            {
                TextBox4.Text = "------------------------\n 无此班级信息，修改失败！";
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cancel")
        {
            sno2  = e.CommandArgument.ToString();
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from homework  where sno ='" + sno2  + "' and workname='" + workname  + "'";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                TextBox4.Text = " 取消分派成功！";
            }
            finally
            {
                con.Close();
            }

        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string t3 = TextBox3.Text.ToString();
        this.SqlDataSource2.SelectCommand = "select sno,sname,tname,classid from homework where workname = '"+workname +"'and sno='"+ t3 +"'or classid = '"+t3 +"'";
            GridView1.DataBind();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        string t3 = TextBox3.Text.ToString();
        this.SqlDataSource2.SelectCommand = "select sno,sname,tname,classid from homework where workname ='"+workname +"'";
        GridView1.DataBind();
    }
}
   