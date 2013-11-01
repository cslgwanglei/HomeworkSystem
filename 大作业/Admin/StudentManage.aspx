<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="StudentManage.aspx.cs" Inherits="Admin_StudentManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style23
        {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <table style="width:100%;">
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="❈学号："></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="79px"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="Label3" runat="server" Text="❈姓名："></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="79px"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="Label4" runat="server" Text="❈班级："></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Width="79px"></asp:TextBox>
        </td>
        <td>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/search.PNG" 
                onclick="ImageButton1_Click" />
            <asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl="~/image/return.PNG" onclick="ImageButton2_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="4" class="style23">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="sno" DataSourceID="SqlDataSource1" BackColor="White" 
                BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                onrowdatabound="GridView1_RowDataBound">
                <Columns>
                    <asp:TemplateField HeaderText="序号">
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sno" HeaderText="学号" ReadOnly="True" 
                        SortExpression="sno" />
                    <asp:BoundField DataField="sname" HeaderText="姓名" SortExpression="sname" />
                    <asp:BoundField DataField="classid" HeaderText="班级" 
                        SortExpression="classid" />
                    <asp:BoundField DataField="spwd" HeaderText="密码" SortExpression="spwd" />
                    <asp:CommandField HeaderText="编辑" ShowEditButton="True" ShowHeader="True" />
                    <asp:CommandField HeaderText="删除" ShowDeleteButton="True" ShowHeader="True" />
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
                DeleteCommand="DELETE FROM [student] WHERE [sno] = @sno" 
                InsertCommand="INSERT INTO [student] ([sno], [sname], [classid], [spwd]) VALUES (@sno, @sname, @classid, @spwd)" 
                SelectCommand="SELECT * FROM [student]" 
                UpdateCommand="UPDATE [student] SET [sname] = @sname, [classid] = @classid, [spwd] = @spwd WHERE [sno] = @sno">
                <DeleteParameters>
                    <asp:Parameter Name="sno" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="sno" Type="String" />
                    <asp:Parameter Name="sname" Type="String" />
                    <asp:Parameter Name="classid" Type="Int32" />
                    <asp:Parameter Name="spwd" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="sname" Type="String" />
                    <asp:Parameter Name="classid" Type="Int32" />
                    <asp:Parameter Name="spwd" Type="String" />
                    <asp:Parameter Name="sno" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </td>
    </tr>
</table>
</asp:Content>

