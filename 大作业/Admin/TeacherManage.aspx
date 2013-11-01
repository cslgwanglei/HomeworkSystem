<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="TeacherManage.aspx.cs" Inherits="Admin_TeacherManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="tno" 
            DataSourceID="SqlDataSource1" 
            onselectedindexchanged="Page_Load" 
            onrowdatabound="GridView1_RowDataBound" 
            onrowcommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="序号">
                    <ItemTemplate>
                        <asp:Label ID="Label" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="tno" HeaderText="教工编号" ReadOnly="True" 
                    SortExpression="tno" />
                <asp:BoundField DataField="tname" HeaderText="教工姓名" SortExpression="tname" />
                <asp:BoundField DataField="tpwd" HeaderText="密码" SortExpression="tpwd" />
                <asp:TemplateField HeaderText="重置密码">
                    <ItemTemplate>
                        <asp:Button ID="Button2" runat="server" CausesValidation="True" 
                            CommandName="reset" CommandArgument='<%# Eval("tno")%>' onclick="Button2_Click" oncommand="Button2_Command" 
                            Text="重置密码" />
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
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConflictDetection="CompareAllValues" 
            ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
            DeleteCommand="DELETE FROM [teacher] WHERE [tno] = @original_tno AND [tname] = @original_tname AND [tpwd] = @original_tpwd" 
            InsertCommand="INSERT INTO [teacher] ([tno], [tname], [tpwd]) VALUES (@tno, @tname, @tpwd)" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT [tno], [tname], [tpwd] FROM [teacher]" 
            UpdateCommand="UPDATE [teacher] SET [tname] = @tname, [tpwd] = @tpwd WHERE [tno] = @original_tno AND [tname] = @original_tname AND [tpwd] = @original_tpwd">
            <DeleteParameters>
                <asp:Parameter Name="original_tno" Type="String" />
                <asp:Parameter Name="original_tname" Type="String" />
                <asp:Parameter Name="original_tpwd" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="tno" Type="String" />
                <asp:Parameter Name="tname" Type="String" />
                <asp:Parameter Name="tpwd" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="tname" Type="String" />
                <asp:Parameter Name="tpwd" Type="String" />
                <asp:Parameter Name="original_tno" Type="String" />
                <asp:Parameter Name="original_tname" Type="String" />
                <asp:Parameter Name="original_tpwd" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>

