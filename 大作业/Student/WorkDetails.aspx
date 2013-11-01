<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="WorkDetails.aspx.cs" Inherits="Student_WorkDetrails" %>

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
        .style25
        {
            height: 23px;
        }
        .style26
        {
            height: 24px;
        }
        .style27
        {
            height: 36px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%; height: 521px;" align="left">
        <tr>
            <td bgcolor="#99FFCC" class="style26" align="left">
                作业题目：<asp:Label ID="Label2" runat="server"></asp:Label>
                （<asp:Label ID="Label3" runat="server"></asp:Label>
                ）分</td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td bgcolor="#99FFCC" class="style23" align="left">
                我的回答</td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td bgcolor="#99FFCC" class="style23" align="left">
                作业材料下载</td>
        </tr>
        <tr>
            <td align="left" class="style27">
                <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click1">作业材料下载</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td bgcolor="#99FFCC" class="style24" align="left">
                评阅教师：<asp:Label ID="Label6" runat="server"></asp:Label>
&nbsp;得分：<asp:Label ID="Label7" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td bgcolor="#99FFCC" class="style25" align="left">
                教师评语：</td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

