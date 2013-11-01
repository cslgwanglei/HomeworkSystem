<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="WorkManage.aspx.cs" Inherits="Admin_WorkManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style23
        {
            height: 20px;
        }
        .style24
        {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        <table style="width: 100%; height: 330px;">
            <tr>
                <td class="style24">
                    <asp:Label ID="Label2" runat="server" Text="❈选择课程："></asp:Label>
                </td>
                <td class="style24">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="121px" 
                        DataSourceID="SqlDataSource1" DataTextField="cname" DataValueField="cname">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
                        SelectCommand="SELECT [cname] FROM [course]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="style23" colspan="2" style="color: #000000">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="SqlDataSource2">
                        <Columns>
                            <asp:BoundField DataField="workname" HeaderText="workname" 
                                SortExpression="workname" />
                            <asp:BoundField DataField="starttime" HeaderText="starttime" 
                                SortExpression="starttime" />
                            <asp:CheckBoxField DataField="readOnly" HeaderText="readOnly" 
                                SortExpression="readOnly" />
                            <asp:TemplateField HeaderText="分发作业">
                                <ItemTemplate>
                                    <asp:HyperLink ID="HyperLink19" runat="server" 
                                        NavigateUrl='<%# string.Format("Sendwork.aspx?workname={0}",Eval("workname").ToString()) %>'>分发作业</asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" ShowHeader="True" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
                        SelectCommand="SELECT [workname], [starttime], [readOnly] FROM [work]">
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>

