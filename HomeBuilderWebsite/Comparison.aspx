<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Comparison.aspx.vb" Inherits="HomeBuilderWebsite_master_Comparison" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<%--<!DOCTYPE html>--%>

<%--<html xmlns="http://www.w3.org/1999/xhtml">--%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <%--<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>
    <div style="text-align: left">
    
        <div style="text-align: center">
    
        <span style="font-size: xx-large"><strong>Welcome To The Comparison Page!</strong></span><br style="font-size: x-large" />
            <br style="font-size: x-large" />
        <br />


            <table style="margin:0px auto; width: 800px;"">
                <tr>
                    <td style="width: 349px">
                        <asp:Chart ID="Chart1" runat="server" align="center" style="font-size: large">
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
                    </td>
                    <td style="width: 15px">

                    </td>
                    <td style="vertical-align: top; width: 441px;" align="left">
                        <span style="font-size: x-large">Filter Price Limit:
        <asp:DropDownList ID="DropDownList1" runat="server" autopostback ="true" align="center" Font-Size="X-Large" style="font-size: large">
            <asp:ListItem Value="100000">$100000</asp:ListItem>
            <asp:ListItem Value="200000">$200000</asp:ListItem>
            <asp:ListItem Value="300000">$300000</asp:ListItem>
            <asp:ListItem Value="400000">$400000</asp:ListItem>
            <asp:ListItem Value="500000">$500000</asp:ListItem>
            <asp:ListItem Value="600000">$600000</asp:ListItem>
            <asp:ListItem Value="700000">$700000</asp:ListItem>
            <asp:ListItem Value="800000">$800000</asp:ListItem>
            <asp:ListItem Value="900000">$900000</asp:ListItem>
            <asp:ListItem Value="1000000">$1000000</asp:ListItem>
            <asp:ListItem Value="1500000">$1500000</asp:ListItem>
            <asp:ListItem Selected="True" Value="2000000">$2000000</asp:ListItem>
        </asp:DropDownList>
                        <br />
                        <br />
                        Saved Scenarios are below, please select which
                        ones you&#39;d like to compare on the next page.</span><br />
        <br style="font-size: x-large" />
            <span style="font-size: x-large">You can also press &quot;Select&quot; to see a cost break 
                        down for feature each on the chart <br />
                        above.</span><br style="font-size: x-large" />
            <br />
        <asp:GridView ID="GridView1" align="center" runat="server" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" SelectedIndex="0" Font-Size="Large">
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
    
        <div style="text-align: center">
            <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="43px" Text="Compare" align="center" Width="140px" Font-Size="X-Large" />
            
                    </td>
                </tr>
            </table>
        
            <br />
        <br />
            
    
        <asp:Button ID="btnBack" runat="server" Height="43px" Text="Back" align="center" Width="140px" Font-Size="X-Large" />
            
            <br />
    
            <br />
        </div>
    
    </div>
      </asp:Content>
      
<%--    </form>
</body>--%>
<%--</html>--%>

  
