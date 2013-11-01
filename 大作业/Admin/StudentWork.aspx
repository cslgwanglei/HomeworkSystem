<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="StudentWork.aspx.cs" Inherits="Admin_StudentWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style23
        {
            height: 37px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        <table style="width: 100%; height: 325px;">
            <tr>
                <td class="style23">
                    <asp:Label ID="Label2" runat="server" Text="❈输入学号或班号："></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="style23">
                    <asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="显示全部" onclick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" DataKeyNames="workname" DataSourceID="SqlDataSource1" 
                        GridLines="Vertical" onrowcommand="GridView1_RowCommand" 
                        onrowdatabound="GridView1_RowDataBound">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:TemplateField HeaderText="序号">
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="sno" HeaderText="学号" SortExpression="sno" />
                            <asp:BoundField DataField="cname" HeaderText="课程名" SortExpression="cname" />
                            <asp:BoundField DataField="workname" HeaderText="作业名" ReadOnly="True" 
                                SortExpression="workname" />
                            <asp:TemplateField HeaderText="查阅作业材料">
                                <ItemTemplate>
                                    <asp:HyperLink ID="HyperLink19" runat="server" 
                                        NavigateUrl='<%# string.Format("Workdetals.aspx?sno={0}&cname={1}&workname={2}",Eval("sno").ToString(),Eval("cname").ToString(),Eval("workname").ToString() ) %>'>查阅作业材料</asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="发回重做">
                                <ItemTemplate>
                                    <asp:Button ID="Button3" runat="server" 
                                        CommandArgument='<%# Eval("sno") + "," + Eval("cname") + "," + Eval("workname") %>' 
                                        CommandName="back" Text="发回重做" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="下载">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton2" runat="server" 
                                        CommandArgument='<%# Eval("cname") + "," + Eval("sno") + "," + Eval("workname") %>' 
                                        CommandName="download">下载</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
                        SelectCommand="SELECT [workname], [sno], [cname] FROM [grade] WHERE ([done] = @done)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="True" Name="done" Type="Boolean" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>

