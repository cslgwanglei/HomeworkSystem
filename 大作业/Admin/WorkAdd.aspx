<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="WorkAdd.aspx.cs" Inherits="Admin_WorkAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #TextArea1
        {
            height: 107px;
            width: 574px;
        }
        .style23
        {
            width: 102px;
            height: 36px;
        }
        .style24
        {
            height: 36px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <br />
        <table style="width:107%;">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="选择课程"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" 
                        DataSourceID="SqlDataSource1" DataTextField="cname" DataValueField="cname">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
                        SelectCommand="SELECT [cname] FROM [course]"></asp:SqlDataSource>
                </td>
                <td colspan="2">
                    <asp:Label ID="Label3" runat="server" Text="作业分值"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Width="49px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="是否开启附件上传功能"></asp:Label>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="fujian" 
                        Text="False" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="fujian" 
                        Text="True" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label5" runat="server" Text="作业名称："></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Width="186px"></asp:TextBox>
                </td>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="Label6" runat="server" Text="作业详情："></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox5" runat="server" Height="134px" Rows="2" Width="551px"></asp:TextBox>
                    <br />
                </td>
            </tr>
             <tr>
                <td colspan="4">
                    <asp:Button ID="Button1" runat="server" Text="暂存作业" onclick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="提交作业" onclick="Button2_Click" />
                 </td>
            </tr>
        </table>
    </p>
    <p style="height: 68px">
    </p>
</asp:Content>

