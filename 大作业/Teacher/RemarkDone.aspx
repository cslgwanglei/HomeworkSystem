<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teacher.master" AutoEventWireup="true" CodeFile="RemarkDone.aspx.cs" Inherits="Teacher_RemarkDone" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td align="left" style="color: #000000">
                输入学号或班号<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="查询" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="查看全部" />
            </td>
        </tr>
        <tr>
            <td align="left" style="color: #000000">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" DataKeyNames="workname" DataSourceID="SqlDataSource1" 
                    GridLines="Vertical" onrowdatabound="GridView1_RowDataBound">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:TemplateField HeaderText="序号">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="sno" HeaderText="学号" SortExpression="sno" />
                        <asp:BoundField DataField="workname" HeaderText="作业名" ReadOnly="True" 
                            SortExpression="workname" />
                        <asp:BoundField DataField="cname" HeaderText="课程名" SortExpression="cname" />
                        <asp:BoundField DataField="grade" HeaderText="成绩" SortExpression="grade" />
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
                    DeleteCommand="DELETE FROM [grade] WHERE [workname] = @workname" 
                    InsertCommand="INSERT INTO [grade] ([workname], [cname], [sno], [grade]) VALUES (@workname, @cname, @sno, @grade)" 
                    SelectCommand="SELECT [workname], [cname], [sno], [grade] FROM [grade] WHERE ([remark] = @remark)" 
                    UpdateCommand="UPDATE [grade] SET [cname] = @cname, [sno] = @sno, [grade] = @grade WHERE [workname] = @workname">
                    <DeleteParameters>
                        <asp:Parameter Name="workname" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="workname" Type="String" />
                        <asp:Parameter Name="cname" Type="String" />
                        <asp:Parameter Name="sno" Type="String" />
                        <asp:Parameter Name="grade" Type="Decimal" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:Parameter DefaultValue="True" Name="remark" Type="Boolean" />
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="cname" Type="String" />
                        <asp:Parameter Name="sno" Type="String" />
                        <asp:Parameter Name="grade" Type="Decimal" />
                        <asp:Parameter Name="workname" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

