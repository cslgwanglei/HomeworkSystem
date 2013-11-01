<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="TeacherAdd.aspx.cs" Inherits="Admin_TeacherAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style25
        {
            height: 17px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%; height: 379px;">
        <tr>
            <td align="right">
                <asp:Label ID="Label2" runat="server" Text="工号："></asp:Label>
            </td>
            <td align="center">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="工号不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label3" runat="server" Text="姓名："></asp:Label>
            </td>
            <td align="center">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="姓名不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label4" runat="server" Text="密码："></asp:Label>
            </td>
            <td align="center">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBox3" ErrorMessage="密码不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label5" runat="server" Text="角色："></asp:Label>
            </td>
            <td align="center">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>教师</asp:ListItem>
                    <asp:ListItem>管理员</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style25" align="center" colspan="2">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/btnAdd.PNG" 
                    onclick="ImageButton1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

