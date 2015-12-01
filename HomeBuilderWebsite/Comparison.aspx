<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Comparison.aspx.vb" Inherits="HomeBuilderWebsite_master_Comparison" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Welcome To The Comparison Page!<br />
        <br />
        Below you will find saved scenarios that you have already completed that you can select to compare.<br />
        <br />
        <br />
        Please choose what your price limit you would like to set for your scenarios.<br />
        <br />
        <br />
        <asp:Chart ID="Chart1" runat="server">
            <series>
                <asp:Series Name="Series1" ChartType="Pie">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <br />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>100000</asp:ListItem>
            <asp:ListItem Value="200000">200000</asp:ListItem>
            <asp:ListItem>300000</asp:ListItem>
            <asp:ListItem>400000</asp:ListItem>
            <asp:ListItem>500000</asp:ListItem>
            <asp:ListItem>600000</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" SelectedIndex="0">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="43px" Text="Compare" Width="140px" />
    
    </div>
    </form>
</body>
</html>
