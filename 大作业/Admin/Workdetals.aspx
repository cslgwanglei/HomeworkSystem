<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Workdetals.aspx.cs" Inherits="Admin_Workdetals" %>

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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%; height: 385px;">
        <tr>
            <td bgcolor="#99FFCC" class="style22">
                作业题目：<asp:Label ID="Label2" runat="server"></asp:Label>
                （<asp:Label ID="Label3" runat="server"></asp:Label>
                ）分</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td bgcolor="#99FFCC" class="style23">
                学生回答</td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label5" runat="server"></asp:Label>
             </td>
        </tr>
        <tr>
            <td bgcolor="#99FFCC" class="style23">
                作业材料下载</td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">作业材料下载</asp:LinkButton>
            </td>
        </tr>
         <tr>
            <td bgcolor="#99FFCC" class="style24">
                评阅教师：<asp:Label ID="Label6" runat="server"></asp:Label>
&nbsp;得分：<asp:Label ID="Label7" runat="server"></asp:Label>
             </td>
        </tr>
        <tr>
            <td bgcolor="#99FFCC" class="style25">
                教师评语：</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

