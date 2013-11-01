<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teacher.master" AutoEventWireup="true" CodeFile="Tusercenter.aspx.cs" Inherits="Teacher_Tusercenter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td align="right" style="color: #000000">
                <asp:Label ID="Label3" runat="server" Text="原密码："></asp:Label>
            </td>
            <td align="left" style="color: #000000">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right" style="color: #000000">
                <asp:Label ID="Label2" runat="server" Text="新密码："></asp:Label>
            </td>
            <td align="left" style="color: #000000">
                <asp:TextBox ID="TextBox2" runat="server" Height="19px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="right" style="color: #000000">
                <asp:Label ID="Label4" runat="server" Text="确认密码："></asp:Label>
            </td>
            <td align="left" style="color: #000000">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="两次密码不一致" 
                    ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td align="right" style="color: #000000">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="修改" />
            </td>
            <td align="left" style="color: #000000">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="重置 " />
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

