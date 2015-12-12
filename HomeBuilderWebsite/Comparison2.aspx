<%@  Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Comparison2.aspx.vb" Inherits="HomeBuilderWebsite_master_Comparison2" %>

<%--<!DOCTYPE html>--%>

<%--<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="font-size: x-large; text-align: center;">
    
        <br />
        <span style="font-size: xx-large"><strong>Multiple Scenario Comparison</strong></span><br />
        <br />
    
        <table style="margin:0px auto; width: 800px;"">
            <tr>
                <td>
                    <asp:Chart ID="Chart1" align="center" runat="server">
            <Series>
                <asp:Series Name="Series1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
                </td>
                <td style="vertical-align: top">
                    Select a scenario:&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" align="center" runat="server" AutoPostBack ="true" Font-Size="X-Large" style="font-size: large">
        </asp:DropDownList>
        <br />
        <br />
        Scenario Details<br />
        <asp:DetailsView ID="DetailsView1" runat="server" align="center" CellPadding="4" ForeColor="#333333" GridLines="None" Height="50px" Width="125px" Font-Size="Large">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
                </td>
            </tr>
            </table>
        <table style="margin:0px auto; width: 800px;"">
            <tr>
                <td>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;Select a graph:
        <asp:DropDownList ID="DropDownList2" align="center" runat="server" AutoPostBack ="true" Font-Size="X-Large" style="font-size: large">
            <asp:ListItem Value="Utility">Utility vs Price Comparison</asp:ListItem>
            <asp:ListItem Value="House" Selected="True">House Type Price Comparison</asp:ListItem>
            <asp:ListItem Value="FloorCost">Floor Price Comparison</asp:ListItem>
            <asp:ListItem Value="RoofCost">Roof Price Comparison</asp:ListItem>
            <asp:ListItem Value="Appliances">Appliance Price Comparison</asp:ListItem>
            <asp:ListItem Value="Garage">Garage Type Comparison</asp:ListItem>
            <asp:ListItem Value="Countertops">Countertop Price Comparison</asp:ListItem>
            <asp:ListItem Value="Bath">Bath Price Comparison</asp:ListItem>
            <asp:ListItem Value="Closets">Closet Price Comparison</asp:ListItem>
            <asp:ListItem Value="Fireplace">Fireplace Price Comparison</asp:ListItem>
            <asp:ListItem Value="Cabinets">Cabinets Price Comparison</asp:ListItem>
            <asp:ListItem Value="Landscaping">Landscaping Price Comparison</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Scenarios
        <br />
        <asp:GridView ID="GridView1" runat="server" align="center" ShowHeader="false" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Font-Size="Large">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <br />
        
    
        <br />
    

                </td>
            </tr>
        </table>
        
        <br />
            </div>
    <%--</form>
</body>
</html>--%>
    </asp:Content>