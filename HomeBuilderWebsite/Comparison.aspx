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
        <span style="font-size: x-large">Below you will find saved scenarios that you have already completed that you can select to compare.</span><br style="font-size: x-large" />
        <br style="font-size: x-large" />
        <br style="font-size: x-large" />
        <span style="font-size: x-large">Please choose what your price limit you would like to set for your scenarios.</span><br style="font-size: x-large" />
        <br style="font-size: large" />
        <br />
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
        <br />
            <span style="font-size: x-large">Set Price Limit<br />
            <br />
            </span><br />
        <asp:DropDownList ID="DropDownList1" runat="server" autopostback ="true" align="center" Font-Size="X-Large" style="font-size: large">
            <asp:ListItem>100000</asp:ListItem>
            <asp:ListItem>200000</asp:ListItem>
            <asp:ListItem>300000</asp:ListItem>
            <asp:ListItem>400000</asp:ListItem>
            <asp:ListItem>500000</asp:ListItem>
            <asp:ListItem Selected="True">600000</asp:ListItem>
            <asp:ListItem>700000</asp:ListItem>
            <asp:ListItem>800000</asp:ListItem>
            <asp:ListItem>900000</asp:ListItem>
            <asp:ListItem>1000000</asp:ListItem>
            <asp:ListItem>1500000</asp:ListItem>
            <asp:ListItem>2000000</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
        </asp:DropDownList>
            <br />
        <br />
        <br />
            <span style="font-size: x-large">Saved Scenarios are below, please select which ones you&#39;d like to compare on the next page.
        </span>
        <br style="font-size: x-large" />
            <span style="font-size: x-large">You can also press &quot;Select&quot; to see a cost break down for each on the chart above.</span><br style="font-size: x-large" />
            <br />
        <br />
        </div>
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
    
            <br />
        </div>
    
    </div>
      </asp:Content>
      
<%--    </form>
</body>--%>
<%--</html>--%>

  
