using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Mod;
using Bll;
using System.Data;
using System.IO;
public partial class Admin_WorkAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       
        BWork bll = new BWork();
        Work w = new Work(
            Convert.ToString(TextBox2.Text),
            Convert.ToDateTime(System.DateTime.Now),
           
            Convert.ToBoolean(RadioButton1.Text),
           Convert.ToString(TextBox5.Text),
            Convert.ToInt16(TextBox1.Text),
            false,
            Convert.ToString(DropDownList1.Text)
           );
        //BHomework bh = new BHomework();
        //Homework s = new Homework(
        //    Convert.ToString(DropDownList2.Text),
        //    Convert.ToString(TextBox5.Text),
        //    Convert.ToInt16(TextBox1.Text),
        //    Convert.ToString(TextBox2.Text),
        //    Convert.ToString(DropDownList1.Text),
        //    Convert.ToDateTime(TextBox3.Text),
        //    Convert.ToDateTime(TextBox4.Text),
        //   false 
        //    ); 
           
        if (Page.IsValid)
        {
            //bh.UpdateHomework(s);
            bll.InsertWork(w);
            Response.Write("<script>alert('提交成功！');location='WorkAdd.aspx'</script>");

        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
      
        BWork bll = new BWork();
        Work w = new Work(
            Convert.ToString(TextBox2.Text),
            Convert.ToDateTime(System.DateTime.Now),
            Convert.ToBoolean(RadioButton1.Text),
           Convert.ToString(TextBox5.Text),
            Convert.ToInt16 (TextBox1.Text),
            true ,
            Convert.ToString(DropDownList1.Text )
          
             );
        //    BHomework bh= new BHomework();
        //    Homework s = new Homework(
        //    Convert.ToString(DropDownList2.Text),
        //    Convert.ToString(TextBox5.Text),
        //    Convert.ToInt16(TextBox1.Text),
        //    Convert.ToString(TextBox2.Text),
        //    Convert.ToString(DropDownList1.Text ),
        //    Convert.ToDateTime(TextBox3.Text),
        //    Convert.ToDateTime(TextBox4.Text),
        //    false
        //    ); 

        if (Page.IsValid)
        {
            //bh.UpdateHomework (s);
            bll.InsertWork(w);
            Response.Write("<script>alert('暂存成功！');location='WorkAdd.aspx'</script>");

        }
    }
}