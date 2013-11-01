<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teacher.master" AutoEventWireup="true" CodeFile="Remarking.aspx.cs" Inherits="Teacher_Remark" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style23
        {
            height: 20px;
        }
        #TextArea1
        {
            height: 189px;
            width: 485px;
        }
        .style24
        {
            height: 276px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%; height: 493px;">
        <tr>
            <td align="left" bgcolor="#99FFCC" style="color: #000000">
                作业题目：<asp:Label ID="Label2" runat="server"></asp:Label>
                （<asp:Label ID="Label3" runat="server"></asp:Label>
                ）分</td>
        </tr>
        <tr>
            <td align="left" style="color: #000000">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left" bgcolor="#99FFCC" style="color: #000000">
                学生回答：</td>
        </tr>
        <tr>
            <td align="left" style="color: #000000">
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left" bgcolor="#99FFCC" style="color: #000000">
                作业材料下载</td>
        </tr>
        <tr>
            <td align="left" style="color: #000000">
                <asp:HyperLink ID="HyperLink21" runat="server" ForeColor="#0066FF">作业材料下载</asp:HyperLink>
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left" bgcolor="#99FFCC" class="style23" style="color: #000000">
                得分：<asp:TextBox ID="TextBox1" runat="server" Width="25px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="请输入得分！" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left" class="style24" style="color: #000000">
                评语：<br />
                <asp:TextBox ID="TextBox2" runat="server" Height="189px" Rows="10" 
                    Width="477px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td align="center" style="color: #000000">
                <asp:Button ID="Button1" runat="server" Text="批阅完成" onclick="Button1_Click" 
                    style="height: 21px" />
            </td>
        </tr>
    </table>
</asp:Content>

