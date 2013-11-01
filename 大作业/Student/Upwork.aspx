<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="Upwork.aspx.cs" Inherits="Student_Upwork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style23
        {
            height: 20px;
        }
        .style24
        {
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td align="left" bgcolor="#CCFFFF">
                ❈作业主题:<asp:Label ID="Label2" runat="server"></asp:Label>
                <asp:Label ID="Label4" runat="server"></asp:Label>
                （<asp:Label ID="Label3" runat="server"></asp:Label>
                ）分</td>
        </tr>
        <tr>
            <td align="left">
                <asp:TextBox ID="TextBox1" runat="server" Rows="2" Width="628px" Height="115px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="left" class="style23">
                输入作业材料：</td>
        </tr>
         <tr>
            <td align="left">
                <asp:TextBox ID="TextBox2" runat="server" Height="234px" Rows="2" Width="631px"></asp:TextBox>
             </td>
        </tr>
         <tr>
            <td align="left" class="style24">
                上传作业材料（请压缩成rar格式）<asp:FileUpload ID="FileUpload1" runat="server" 
                    Width="218px" />
                <asp:Button ID="Button1" runat="server" Text="上传" onclick="Button1_Click" 
                    style="height: 21px" />
                <asp:Label ID="Label6" runat="server"></asp:Label>
             </td>
        </tr>
         <tr>
            <td align="center">
                <asp:Button ID="Button2" runat="server" Height="21px" onclick="Button2_Click" 
                    Text="暂存作业" />
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="提交作业" />
             </td>
        </tr>
    </table>
</asp:Content>

