﻿<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ChooseFeature.aspx.vb" Inherits="ChooseFeature" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 200px;
            height: 35px;
        }
        .auto-style4 {
            width: 159px;
            height: 35px;
        }
    </style>


        <table style="margin:0px auto; width: 1100px;">
            <tr>
                <td>

        <h1>Feature Preferences</h1><br />
    <table>
        <tr>
            <td class="auto-style1">
                <h3>Roof Type</h3>
            </td>
            <td class="auto-style4">

                <asp:DropDownList ID="ddlRoof" runat="server">
                    <asp:ListItem Value="5">Essential</asp:ListItem>
                    <asp:ListItem Value="4">High priority</asp:ListItem>
                    <asp:ListItem Value="3" Selected="True">Medium priority</asp:ListItem>
                    <asp:ListItem Value="2">Low priority</asp:ListItem>
                    <asp:ListItem Value="1">Not a priority</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <h3>Garage</h3>
            </td>
            <td class="auto-style4">

                <asp:DropDownList ID="ddlGarage" runat="server">
                    <asp:ListItem Value="5">Essential</asp:ListItem>
                    <asp:ListItem Value="4">High priority</asp:ListItem>
                    <asp:ListItem Value="3" Selected="True">Medium priority</asp:ListItem>
                    <asp:ListItem Value="2">Low priority</asp:ListItem>
                    <asp:ListItem Value="1">Not a priority</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <h3>Landscaping</h3>
            </td>
            <td class="auto-style4">

                <asp:DropDownList ID="ddlLandscaping" runat="server">
                    <asp:ListItem Value="5">Essential</asp:ListItem>
                    <asp:ListItem Value="4">High priority</asp:ListItem>
                    <asp:ListItem Value="3" Selected="True">Medium priority</asp:ListItem>
                    <asp:ListItem Value="2">Low priority</asp:ListItem>
                    <asp:ListItem Value="1">Not a priority</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <h3>Floor</h3>
            </td>
            <td class="auto-style4">

                <asp:DropDownList ID="ddlFloor" runat="server">
                    <asp:ListItem Value="5">Essential</asp:ListItem>
                    <asp:ListItem Value="4">High priority</asp:ListItem>
                    <asp:ListItem Value="3" Selected="True">Medium priority</asp:ListItem>
                    <asp:ListItem Value="2">Low priority</asp:ListItem>
                    <asp:ListItem Value="1">Not a priority</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <h3>Fireplace</h3>
            </td>
            <td class="auto-style4">

                <asp:DropDownList ID="ddlFireplace" runat="server">
                    <asp:ListItem Value="5">Essential</asp:ListItem>
                    <asp:ListItem Value="4">High priority</asp:ListItem>
                    <asp:ListItem Value="3" Selected="True">Medium priority</asp:ListItem>
                    <asp:ListItem Value="2">Low priority</asp:ListItem>
                    <asp:ListItem Value="1">Not a priority</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <h3>Appliances</h3>
            </td>
            <td class="auto-style4">

                <asp:DropDownList ID="ddlAppliances" runat="server">
                    <asp:ListItem Value="5">Essential</asp:ListItem>
                    <asp:ListItem Value="4">High priority</asp:ListItem>
                    <asp:ListItem Value="3" Selected="True">Medium priority</asp:ListItem>
                    <asp:ListItem Value="2">Low priority</asp:ListItem>
                    <asp:ListItem Value="1">Not a priority</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>

        <tr>
            <td class="auto-style1">
                <h3>Countertops</h3>
            </td>
            <td class="auto-style4">

                <asp:DropDownList ID="ddlCountertops" runat="server">
                    <asp:ListItem Value="5">Essential</asp:ListItem>
                    <asp:ListItem Value="4">High priority</asp:ListItem>
                    <asp:ListItem Value="3" Selected="True">Medium priority</asp:ListItem>
                    <asp:ListItem Value="2">Low priority</asp:ListItem>
                    <asp:ListItem Value="1">Not a priority</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <h3>Cabinets</h3>
            </td>
            <td class="auto-style4">

                <asp:DropDownList ID="ddlCabinets" runat="server">
                    <asp:ListItem Value="5">Essential</asp:ListItem>
                    <asp:ListItem Value="4">High priority</asp:ListItem>
                    <asp:ListItem Value="3" Selected="True">Medium priority</asp:ListItem>
                    <asp:ListItem Value="2">Low priority</asp:ListItem>
                    <asp:ListItem Value="1">Not a priority</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <h3>Bath</h3>
            </td>
            <td class="auto-style4">

                <asp:DropDownList ID="ddlBath" runat="server">
                    <asp:ListItem Value="5">Essential</asp:ListItem>
                    <asp:ListItem Value="4">High priority</asp:ListItem>
                    <asp:ListItem Value="3" Selected="True">Medium priority</asp:ListItem>
                    <asp:ListItem Value="2">Low priority</asp:ListItem>
                    <asp:ListItem Value="1">Not a priority</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <h3>Closets</h3>
            </td>
            <td class="auto-style4">

                <asp:DropDownList ID="ddlClosets" runat="server">
                    <asp:ListItem Value="5">Essential</asp:ListItem>
                    <asp:ListItem Value="4">High priority</asp:ListItem>
                    <asp:ListItem Value="3" Selected="True">Medium priority</asp:ListItem>
                    <asp:ListItem Value="2">Low priority</asp:ListItem>
                    <asp:ListItem Value="1">Not a priority</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
        </table>
        <br />
        <br />
                   
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   
                     <asp:Button ID="btnBack" runat="server" Height="28px" Text="Back" Width="105px" />
                
&nbsp;&nbsp;
                <%--  --%>
<asp:Button ID="btnNext" runat="server" Height="28px" Text="Next" Width="105px" />
           
                <td style="vertical-align: top">

                    <br />
                    <br />

                    <asp:Label ID="lblBudget" runat="server" Font-Size="X-Large"></asp:Label>
                    <br />
                    <br />
&nbsp;<br />
                    
                    <table>
                        <tr>
                            <td>
                                <asp:Table ID="tblBar" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Height="25px" Width="200px">
                        <asp:TableRow ID="TableRow1" runat="server">
                            <asp:TableCell ID="TableCell1" runat="server" BackColor="#009933" Width="5px"></asp:TableCell>
                            <asp:TableCell ID="TableCell2" runat="server"></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                            </td>
                            <td>
                                <asp:Label ID="lblpercent" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>
                    
                    <br />
                 </td>
            </tr>
        </table>
    
       </asp:Content>