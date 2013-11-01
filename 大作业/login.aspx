<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            height: 344px;
        }
        .style3
        {
            width: 422px;
            height: 315px;
        }
        .style4
        {
            height: 344px;
            width: 221px;
        }
        .style7
        {
            height: 32px;
        }
        .style8
        {
            height: 28px;
        }
    </style>
</head>
<body style="width:1024px; margin-left:auto; margin-right:auto;">
    <form id="form1" runat="server">
    <div>
    
    &nbsp;
        <br />
&nbsp;&nbsp;
        <br />
        <table style="width:88%; height: 399px;">
        <tr>
        <td align="center" bgcolor="#3399FF" colspan="2" class="style8">
            <asp:Label ID="Label4" runat="server" Text="作业管理系统"></asp:Label>
        </td>
        </tr>
            <tr>
                <td align="right" class="style4">
                    <img align="left" class="style3" src="image/login_left.jpg" dir="ltr" /></td>
                <td class="style2">
                    <asp:Panel ID="Panel2" runat="server" BackImageUrl="~/image/login_right.jpg" 
                        Height="328px">
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <table style="width:84%; height: 146px;">
                            <tr>
                                <td align="center">
                                    <asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" class="style7">
                                    <asp:Label ID="Label2" runat="server" Text="密码："></asp:Label>
                                </td>
                                <td class="style7">
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Label ID="Label3" runat="server" Text="用户类型："></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" 
                        style="margin-bottom: 0px; margin-top: 9px;">
                                        <asp:ListItem>--选择用户类型--</asp:ListItem>
                                        <asp:ListItem>学生</asp:ListItem>
                                        <asp:ListItem>教师</asp:ListItem>
                                        <asp:ListItem>管理员</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="确定" />
                                </td>
                                <td>
                                    <asp:Button ID="Button2" runat="server" Text="取消" onclick="Button2_Click1" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
        <td align="center" bgcolor="#0099FF" colspan="2">
            <asp:Label ID="Label5" runat="server" Text="Copyright@王磊 1992-2012"></asp:Label>
        </td>
        </tr>

        </table>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;
            
    </div>
    </form>
</body>
</html>

