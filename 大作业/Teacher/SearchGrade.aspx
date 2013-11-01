<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teacher.master" AutoEventWireup="true" CodeFile="SearchGrade.aspx.cs" Inherits="Teacher_SearchGrade" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style23
        {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 109%; height: 564px; color: #000000;">
        <tr>
            <td class="style23" align="left">
                <asp:Label ID="Label2" runat="server" Text="※课程"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                DataSourceID="SqlDataSource1" DataTextField="cname" DataValueField="cname">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
                SelectCommand="SELECT [cname] FROM [course]"></asp:SqlDataSource>
                <asp:Label ID="Label3" runat="server" Text="※开始时间"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="92px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="16px" 
                ImageUrl="~/image/calendar.png" onclick="ImageButton1_Click" Width="16px" />
                <asp:Calendar ID="Calendar1" runat="server" Height="65px" 
                onselectionchanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
                <asp:Label ID="Label4" runat="server" Text="※结束时间"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="92px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton2" runat="server" Height="16px" 
                ImageUrl="~/image/calendar.png" onclick="ImageButton2_Click" Width="16px" />
                <asp:Calendar ID="Calendar2" runat="server" Height="93px" 
                onselectionchanged="Calendar2_SelectionChanged" Visible="False" Width="261px">
                </asp:Calendar>
                <asp:Label ID="Label5" runat="server" Text="※学号或班号"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" Width="92px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style23" align="left">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="查询" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="导出" />
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
                SelectCommand="SELECT [workname] FROM [grade]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" 
                DataSourceID="SqlDataSource2" DataTextField="workname" 
                DataValueField="workname">
                </asp:CheckBoxList>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" DataKeyNames="workname" DataSourceID="SqlDataSource3" 
                GridLines="Vertical" onrowdatabound="GridView1_RowDataBound">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:TemplateField HeaderText="序号">
                            <ItemTemplate>
                                <asp:Label ID="Label6" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="sno" HeaderText="学号" SortExpression="sno" />
                        <asp:BoundField DataField="workname" HeaderText="作业名" ReadOnly="True" 
                        SortExpression="workname" />
                        <asp:BoundField DataField="tname" HeaderText="教师编号" SortExpression="tname" />
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
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                ConnectionString="<%$ ConnectionStrings:dazuoyeConnectionString %>" 
                SelectCommand="SELECT [workname], [tname], [cname], [grade], [sno] FROM [grade] WHERE ([remark] = @remark)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="true" Name="remark" Type="Boolean" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

