<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="WorkHaveDone.aspx.cs" Inherits="Student_WorkHaveDone" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style23
    {
        height: 20px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td align="left" class="style23">
                <asp:Label ID="Label3" runat="server" Text="❈未做作业"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" DataSourceID="SqlDataSource1" 
                    onrowdatabound="GridView1_RowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="序号">
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="workname" HeaderText="作业名" 
                            SortExpression="workname" />
                        <asp:BoundField DataField="cname" HeaderText="课程名" SortExpression="cname" />
                        <asp:BoundField DataField="starttime" HeaderText="开始时间" 
                            SortExpression="starttime" />
                        <asp:BoundField DataField="endtime" HeaderText="结束时间" 
                            SortExpression="endtime" />
                        <asp:TemplateField HeaderText="提交材料">
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink23" runat="server" 
                                    
                                    NavigateUrl='<%# string.Format("Upwork.aspx?workname={0}&cname",Eval("workname").ToString(),Eval("cname").ToString() ) %>'>提交材料</asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
                    
                    
                    SelectCommand="SELECT [workname], [cname], [starttime], [endtime] FROM [homework] WHERE ([hand] = @hand)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="false" Name="hand" Type="Boolean" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
       
    </table>
</asp:Content>

