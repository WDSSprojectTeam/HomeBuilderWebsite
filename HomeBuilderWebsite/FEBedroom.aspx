<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FEBedroom.aspx.vb" Inherits="FEBedroom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style24 {
            width: 529px;
        }
        .auto-style22 {
            width: 90px;
            height: 23px;
        }
        .auto-style23 {
            width: 140px;
            height: 23px;
        }
        .auto-style42 {
            width: 102px;
        }
        .auto-style30 {
            width: 146px;
        }
        .auto-style7 {
            width: 129px;
        }
        .auto-style32 {
            width: 128px;
            height: 23px;
        }
        .auto-style43 {
            width: 529px;
            height: 30px;
        }
        .auto-style51 {
            width: 102px;
            height: 42px;
        }
        .auto-style52 {
            width: 146px;
            height: 42px;
        }
        .auto-style53 {
            width: 129px;
            height: 42px;
        }
        .auto-style48 {
            width: 102px;
            height: 31px;
        }
        .auto-style49 {
            width: 146px;
            height: 31px;
        }
        .auto-style50 {
            width: 129px;
            height: 31px;
        }
        .auto-style44 {
            width: 149px;
            height: 23px;
        }
        .auto-style65 {
            width: 146px;
            height: 23px;
        }
        .auto-style66 {
            width: 142px;
            height: 23px;
        }
        .auto-style67 {
            width: 154px;
            height: 23px;
        }
        </style>
</head>
<body>
    <table>
        <tr>
            <td>

    <form id="form1" runat="server">
    <div>
    <h1>Bedrooms</h1>
        <br />
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Bath</h2>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style44">Must Have</td>
                <td class="auto-style65">Love it</td>
                <td class="auto-style66">Like it</td>
                <td class="auto-style67">It&#39;s Okay</td>
                <td class="auto-style23">Dislike</td>
            </tr>
        </table>
        <asp:Panel ID="pnlBathShower" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Bath/Shower Combination</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxBathShower" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltBathShower" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlWalkinShower" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Walk-in-shower</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxWalkinShower" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltWalkinShower" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlRainfall" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Luxry rainfall shower</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxRainfall" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltRainfall" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <br />
    
        <table>
            <tr>
                <td class="auto-style43">
                    <h2>Closets</h2>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style22"></td>
                <td class="auto-style44">Must Have</td>
                <td class="auto-style65">Love it</td>
                <td class="auto-style66">Like it</td>
                <td class="auto-style67">It&#39;s Okay</td>
                <td class="auto-style23">Dislike</td>
            </tr>
        </table>
        <asp:Panel ID="pnlWardrobe" runat="server">
            <table>
                <tr>
                    <td class="auto-style51">Wardrobe Closet</td>
                    <td class="auto-style52"><asp:CheckBox ID="cbxWardrobe" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style53">
                        <asp:RadioButtonList ID="rltWardrobe" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlWalkinCloset" runat="server">
            <table>
                <tr>
                    <td class="auto-style48">Walk-in-closet</td>
                    <td class="auto-style49"><asp:CheckBox ID="cbxWalkinCloset" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style50">
                        <asp:RadioButtonList ID="rltWalkinCloset" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
            </asp:Panel>
            <div>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNext" runat="server" Height="30px" Text="Next" Width="105px" />
            </div>
    </td>
            <td style="vertical-align: top">
                <table>
                    <tr>
                        <td>
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
                    
                            <asp:Panel ID="pnlydynamichart" runat="server">
                            </asp:Panel>
                    
                    <br />
                 </td>
            </tr>
        </table> 
                        </td>
                    </tr>
                </table>
            </td>

        </tr>
    </table>
    </div>
    </form>

            
    </body>
</html>
