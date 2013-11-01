<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CourseManage.aspx.cs" Inherits="Admin_CourseManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="cno" 
            DataSourceID="SqlDataSource1" Width="368px">
            <Columns>
                <asp:BoundField DataField="cno" HeaderText="题库编号" InsertVisible="False" 
                    ReadOnly="True" SortExpression="cno" />
                <asp:BoundField DataField="cname" HeaderText="题库名称" SortExpression="cname" />
                <asp:BoundField DataField="cinfo" HeaderText="题库信息" SortExpression="cinfo" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" ShowHeader="True" />
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
            DeleteCommand="DELETE FROM [course] WHERE [cno] = @cno" 
            InsertCommand="INSERT INTO [course] ([cname], [cinfo]) VALUES (@cname, @cinfo)" 
            SelectCommand="SELECT * FROM [course]" 
            UpdateCommand="UPDATE [course] SET [cname] = @cname, [cinfo] = @cinfo WHERE [cno] = @cno">
            <DeleteParameters>
                <asp:Parameter Name="cno" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="cname" Type="String" />
                <asp:Parameter Name="cinfo" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="cname" Type="String" />
                <asp:Parameter Name="cinfo" Type="String" />
                <asp:Parameter Name="cno" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>

