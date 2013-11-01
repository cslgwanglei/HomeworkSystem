<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="StudentAdd.aspx.cs" Inherits="Admin_StudentAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style23
        {
            height: 21px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" Height="379px">
        <div style="border: thin ridge #C0C0C0">
            <br />
            <br />
            <br />
            <table style="border-color: #C0C0C0; border-style: inset; width:100%;">
                <tr>
                    <td align="left">
                        <asp:Label ID="Label2" runat="server" Text="学号："></asp:Label>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="TextBox1" ErrorMessage="学号不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="Label3" runat="server" Text="姓名："></asp:Label>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TextBox2" ErrorMessage="姓名不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="style23">
                        <asp:Label ID="Label4" runat="server" Text="班级："></asp:Label>
                    </td>
                    <td align="left" class="style23">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="TextBox3" ErrorMessage="班级不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="Label5" runat="server" Text="密码："></asp:Label>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="TextBox4" ErrorMessage="密码不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style22" colspan="2">
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/btnAdd.PNG" 
                            onclick="ImageButton1_Click" />
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            <asp:Panel ID="Panel2" runat="server">
                学生信息批量上传：<br /> 
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="上传" />
                <br />
                <a href="学生信息模板.xlsx" 
                    style="color:Red;font-weight:bold;text-decoration:underline;">学生信息模板.xlsx</a>
            </asp:Panel>
            <br />
        </div>
</asp:Panel>
</asp:Content>

