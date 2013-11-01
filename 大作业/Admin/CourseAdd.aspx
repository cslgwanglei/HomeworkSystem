<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CourseAdd.aspx.cs" Inherits="Admin_CourseAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <table style="width:100%; height: 301px;">
    <tr>
        <td>
            <asp:Label ID="Label6" runat="server" Text="课程名称："></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="196px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="课程名不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td align="left">
            <asp:Label ID="Label7" runat="server" Text="课程简介："></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Height="160px" Rows="2" Width="201px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/btnAdd.PNG" 
                onclick="ImageButton1_Click" style="height: 21px" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

