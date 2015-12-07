<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FEOutdoor.aspx.vb" Inherits="FEOutdoor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style24 {
            width: 529px;
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
        .auto-style45 {
            width: 102px;
            height: 30px;
        }
        .auto-style46 {
            width: 146px;
            height: 30px;
        }
        .auto-style47 {
            width: 128px;
            height: 30px;
        }
        .auto-style33 {
            width: 128px;
        }
        .auto-style23 {
            width: 140px;
            height: 23px;
        }
        .auto-style51 {
            width: 151px;
            height: 23px;
        }
        .auto-style52 {
            width: 149px;
            height: 23px;
        }
        .auto-style53 {
            width: 137px;
            height: 23px;
        }
        .auto-style54 {
            width: 69px;
            height: 23px;
        }
        .auto-style55 {
            width: 90px;
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
    <h1>Exterior</h1>
        <br />
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Roof Type</h2>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style55"></td>
                <td class="auto-style51">Must Have</td>
                <td class="auto-style52">Love it</td>
                <td class="auto-style53">Like it</td>
                <td class="auto-style51">It&#39;s Okay</td>
                <td class="auto-style23">Dislike</td>
            </tr>
        </table>
        <asp:Panel ID="pnlAsphaltShingle" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Asphalt Shingle</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxAsphaltShingle" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltAsphaltShingle" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlWoodShingle" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Wood Shingle</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxWoodShingle" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltWoodShingle" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlMetalShingle" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Metal Shingle</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxMetalShingle" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltMetalShingle" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlSlateShingle" runat="server">
            <table>
                <tr>
                    <td class="auto-style45">Slate Shingle</td>
                    <td class="auto-style46"><asp:CheckBox ID="cbxSlateShingle" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style47">
                        <asp:RadioButtonList ID="rltSlateShingle" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                   
                    
                </tr>
            </table>
            <asp:Panel ID="pnlTileShingle" runat="server">
                <table>
                    <tr>
                        <td class="auto-style42">Tile Shingle</td>
                        <td class="auto-style30">
                            <asp:CheckBox ID="cbxTileShingle" runat="server" AutoPostBack="True" />
                        </td>
                        <td class="auto-style33">
                            <asp:RadioButtonList ID="rltTileShingle" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                                <asp:ListItem Value="3"></asp:ListItem>
                                <asp:ListItem Value="2"></asp:ListItem>
                                <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                                <asp:ListItem>0</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </asp:Panel>
    
    </div>
        <br />
    
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Garage</h2>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td class="auto-style55"></td>
                <td class="auto-style51">Must Have</td>
                <td class="auto-style52">Love it</td>
                <td class="auto-style53">Like it</td>
                <td class="auto-style51">It&#39;s Okay</td>
                <td class="auto-style23">Dislike</td>
            </tr>
        </table>
        <asp:Panel ID="pnlOneCar" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">One Car</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxOneCar" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltOneCar" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlTwoCar" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Two Car</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxTwoCar" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltTwoCar" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlThreeCar" runat="server" Height="40px">
            <table>
                <tr>
                    <td class="auto-style42">Three Car</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxThreeCar" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltThreeCar" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
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
    </form>

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
    </body>
</html>
