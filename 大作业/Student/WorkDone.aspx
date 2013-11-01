<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="WorkDone.aspx.cs" Inherits="Student_WorkDone" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="left">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="workname" DataSourceID="SqlDataSource1" 
            onrowdatabound="GridView1_RowDataBound" Height="136px" BackColor="White" 
            BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:TemplateField HeaderText="序号">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="workname" HeaderText="作业名" ReadOnly="True" 
                    SortExpression="workname" />
                <asp:BoundField DataField="cname" HeaderText="课程名" SortExpression="cname" />
                <asp:CheckBoxField DataField="remark" HeaderText="是否批阅" 
                    SortExpression="remark" />
                <asp:BoundField DataField="grade" HeaderText="成绩" SortExpression="grade" />
                <asp:TemplateField HeaderText="查阅作业材料">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink23" runat="server" 
                            NavigateUrl='<%# string.Format("WorkDetails.aspx?cname={0}&workname={1}",Eval("cname").ToString(),Eval("workname").ToString() ) %>'>查阅作业材料</asp:HyperLink>
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
            DeleteCommand="DELETE FROM [grade] WHERE [workname] = @workname" 
            InsertCommand="INSERT INTO [grade] ([workname], [cname], [remark], [grade]) VALUES (@workname, @cname, @remark, @grade)" 
            SelectCommand="SELECT workname, cname, remark, grade FROM grade WHERE (sno = @sname)" 
            
            
            UpdateCommand="UPDATE [grade] SET [cname] = @cname, [remark] = @remark, [grade] = @grade WHERE [workname] = @workname">
            <DeleteParameters>
                <asp:Parameter Name="workname" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="workname" Type="String" />
                <asp:Parameter Name="cname" Type="String" />
                <asp:Parameter Name="remark" Type="Boolean" />
                <asp:Parameter Name="grade" Type="Decimal" />
            </InsertParameters>
            <SelectParameters>
                <asp:SessionParameter Name="sname" SessionField="sname" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="cname" Type="String" />
                <asp:Parameter Name="remark" Type="Boolean" />
                <asp:Parameter Name="grade" Type="Decimal" />
                <asp:Parameter Name="workname" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
</asp:Content>

