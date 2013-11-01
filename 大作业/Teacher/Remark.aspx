<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teacher.master" AutoEventWireup="true" CodeFile="Remark.aspx.cs" Inherits="Teacher_Remark" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style23
        {
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td align="left" style="color: #000000">
                输入学号或班级</td>
        </tr>
        <tr>
            <td align="left" class="style23" style="color: #000000">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="查询" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="显示全部" />
            </td>
        </tr>
        <tr>
            <td align="left" style="color: #000000">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="4" DataKeyNames="workname" DataSourceID="SqlDataSource1" 
                    onrowcommand="GridView1_RowCommand" onrowdatabound="GridView1_RowDataBound" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="序号">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="cname" HeaderText="课程名" SortExpression="cname" />
                        <asp:BoundField DataField="workname" HeaderText="作业名" ReadOnly="True" 
                            SortExpression="workname" />
                        <asp:BoundField DataField="sno" HeaderText="学号" SortExpression="sno" />
                        <asp:TemplateField HeaderText="评价作业">
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink21" runat="server" 
                                    NavigateUrl='<%# string.Format("Remarking.aspx?sno={0}&cname={1}&workname={2}",Eval("sno").ToString(),Eval("cname").ToString(),Eval("workname").ToString() ) %>' 
                                    Text="批阅作业"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="下载">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" 
                                    CommandArgument='<%# Eval("cname") + "," + Eval("sno") + "," + Eval("workname") %>' 
                                    CommandName="download">下载</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="发回重做">
                            <ItemTemplate>
                                <asp:Button ID="Button3" runat="server" 
                                    CommandArgument='<%# Eval("sno") + "," + Eval("cname") + "," + Eval("workname") %>' 
                                    CommandName="back" Text="发回重做" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
                    
                    SelectCommand="SELECT [cname], [sno], [workname] FROM [grade] WHERE (([done] = @done) AND ([remark] = @remark))">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="true" Name="done" Type="Boolean" />
                        <asp:Parameter DefaultValue="false" Name="remark" Type="Boolean" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

