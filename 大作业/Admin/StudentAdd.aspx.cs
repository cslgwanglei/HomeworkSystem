using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mod;
using Bll;
using System.IO;
using System.Data;
using System.Text;
using Dal;
using System.Reflection;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_StudentAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        BStudent bll = new BStudent();
        Student st = new Student(
            Convert.ToString(TextBox1.Text),
            Convert.ToString(TextBox2.Text),
            Convert.ToString(TextBox3.Text),
            Convert.ToString(TextBox4.Text)
            );
        //BHomework HLL = new BHomework();
        //Homework h = new Homework(
        //    Convert.ToString(TextBox3.Text),
        //     Convert.ToString(TextBox1.Text)

        //    );
        

        if (Page.IsValid)
        {

            bll.InsertStudent(st);
            //HLL.InsertHomework(h);
            Response.Write("<script>alert('添加成功！');location='StudentAdd.aspx'</script>");

        }
        else
        {
            Response.Write("<script>alert('添加失败！');</script>");
        }
    }
    private void MessageBox(string strKey, string strInfo)
    {
        if (!ClientScript.IsClientScriptBlockRegistered(strKey))
        {
            string strjs = "function window.onload(){alert('" + strInfo + "');}";

            //window.location='happytalk.aspx';这句大家可以去掉，我是用来重定向的，效果不好。


            ClientScript.RegisterClientScriptBlock(this.GetType(), strKey, strjs, true);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile == false)
        {
            MessageBox(this.GetType().ToString(), "请选择Excel文件");
            return;
        }

        string IsXls = System.IO.Path.GetExtension(FileUpload1.FileName).ToString().ToLower();//System.IO.Path.GetExtension获得文件的扩展名

        if (IsXls != ".xlsx")
        {
            MessageBox(this.GetType().ToString(), "只可以选择Excel文件");
            return;

        }
        string filename = FileUpload1.FileName;              //获取Execle文件名  DateTime日期函数
        string savePath = Server.MapPath((".\\upfiles\\") + filename);//Server.MapPath 获得虚拟服务器相对路径

        FileUpload1.SaveAs(savePath);                        //SaveAs 将上传的文件内容保存在服务器上

        DataSet ds = ExcelSqlConnection(savePath, filename);
        DataRow[] dr = ds.Tables[0].Select();

        int row = ds.Tables[0].Rows.Count;

        if (row == 0)
        {
            MessageBox(this.GetType().ToString(), "Excel为空表，无数据！");
            return;
        }

        else
        {
            for (int i = 0; i < dr.Length; i++)
            {
                string sno = dr[i]["sno"].ToString();
                string sname = dr[i]["sname"].ToString();
                string classid = dr[i]["classid"].ToString();
                string spwd = dr[i][3].ToString();
               

                string select = "select * from Student where sno='" + sno + "'";
                string insert = "insert into student values('" + sno  + "','" + sname + "','" + classid  + "','" + spwd + "')";
                Insert_DataBase(sno , select, insert);



            }
            MessageBox(this.GetType().ToString(), "添加成功！");
            HttpContext.Current.Response.AddHeader("RefResh", "0");
            return;
        }

    }

    //public static DataTable ExcelToTable(string Path)
    //{
    //    string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" +
    //        "Data Source='" + Path + "';" + "Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
    //    OleDbConnection conn = new OleDbConnection(strConn);
    //    conn.Open();
    //    string strExcel = "";
    //    OleDbDataAdapter myCommand = null;
    //    DataSet ds = null;
    //    strExcel = "select * from [sheet1$]";//EXCEL表名（不是文件名）
    //    myCommand = new OleDbDataAdapter(strExcel, strConn);
    //    ds = new DataSet();
    //    myCommand.Fill(ds, "student");
    //    conn.Dispose();
    //    return ds.Tables[0];

    //}
    #region 连接Excel  读取Excel数据   并返回DataSet数据集合
    /// <summary>
    /// 连接Excel  读取Excel数据   并返回DataSet数据集合
    /// </summary>
    /// <param name="filepath">Excel服务器路径</param>
    /// <param name="tableName">Excel表名称</param>
    /// <returns></returns>
    public static DataSet ExcelSqlConnection(string filepath, string tableName)
    {
        string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'";
        OleDbConnection ExcelConn = new OleDbConnection(strCon);

        try
        {
            string strCom = "SELECT * FROM [Sheet1$]";
            ExcelConn.Open();
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, ExcelConn);
            DataSet ds = new DataSet();
            myCommand.Fill(ds, tableName);
            ExcelConn.Close();

            return ds;
        }
        catch (Exception e)
        {
            ExcelConn.Close();
            return null;
        }
    }
    #endregion
    public void Insert_DataBase(string sno , string cmd_select, string cmd_insert)
    {
        string constr = ConfigurationManager.ConnectionStrings["dazuoyeConnectionString"].ConnectionString;

        using (SqlConnection con = new SqlConnection(constr))
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = cmd_select;
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                reader.Close();
                cmd.CommandText = cmd_insert;
                cmd.ExecuteNonQuery();
              
            }
            else
            {
                //HttpContext.Current.Response.Write("<script>alert('用户已存在！')</script>");
                MessageBox(this.GetType().ToString(), "用户:" + sno  + "已存在！");
                HttpContext.Current.Response.AddHeader("RefResh", "0");

            }

        }
    }
}