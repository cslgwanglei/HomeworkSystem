<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sendwork.aspx.cs" Inherits="Admin_Sendwork" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style1" colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="※课程名："></asp:Label>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label3" runat="server" Text="※作业名称："></asp:Label>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label5" runat="server" Text="※开始时间"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="16px" 
                        ImageUrl="~/image/calendar.png" onclick="ImageButton1_Click" Width="16px" />
                    <asp:Calendar ID="Calendar1" runat="server" 
                        onselectionchanged="Calendar1_SelectionChanged" Visible="False">
                    </asp:Calendar>
                    <asp:Label ID="Label6" runat="server" Text="※结束时间"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Height="19px"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="16px" 
                        ImageUrl="~/image/calendar.png" onclick="ImageButton2_Click" Width="16px" />
                    <asp:Calendar ID="Calendar2" runat="server" 
                        onselectionchanged="Calendar2_SelectionChanged" Visible="False">
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>
                    ※按<asp:RadioButton ID="RadioButton1" runat="server" GroupName="send" 
                        Text="学号" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="send" Text="班级" />
                    分派</td>
                <td>
                    ※查询（学号或班号）<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="查询" />
                    <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="显示全部" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" DataSourceID="SqlDataSource2" GridLines="Vertical" 
                        onrowcommand="GridView1_RowCommand">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="sno" HeaderText="学号" SortExpression="sno" />
                            <asp:BoundField DataField="sname" HeaderText="姓名" SortExpression="sname" />
                            <asp:BoundField DataField="tname" HeaderText="评价教师" SortExpression="tname" />
                            <asp:BoundField DataField="classid" HeaderText="班级" SortExpression="classid" />
                            <asp:TemplateField HeaderText="取消分派">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" 
                                        CommandArgument='<%# Eval("sno", "{0}") %>' CommandName="cancel" 
                                        onclick="LinkButton1_Click">取消分派</asp:LinkButton>
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
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
                        SelectCommand="SELECT [sno], [sname], [tname], [classid] FROM [homework]">
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    ※评价教师<asp:DropDownList ID="DropDownList1" runat="server" 
                        DataSourceID="SqlDataSource1" DataTextField="tname" DataValueField="tname">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
                        SelectCommand="SELECT [tname] FROM [teacher]"></asp:SqlDataSource>
                </td>
                <td>
                    ※分派更新信息</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="分派" />
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="修改" />
                    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="取消" />
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Height="62px" Rows="2" Width="446px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
