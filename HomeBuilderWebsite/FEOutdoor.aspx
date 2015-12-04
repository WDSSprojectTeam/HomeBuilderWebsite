<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FEOutdoor.aspx.vb" Inherits="FEOutdoor" %>

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
        </style>
</head>
<body>
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
                <td class="auto-style22"></td>
                <td class="auto-style23">Must Have</td>
                <td class="auto-style23">Very Important</td>
                <td class="auto-style23">Important</td>
                <td class="auto-style23">Indifferent</td>
                <td class="auto-style23">Not Important</td>
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
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
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
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
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
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
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
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                   
                    
                </tr>
            </table>
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
                <td class="auto-style22"></td>
                <td class="auto-style23">Must Have</td>
                <td class="auto-style23">Very Important</td>
                <td class="auto-style23">Important</td>
                <td class="auto-style23">Indifferent</td>
                <td class="auto-style23">Not Important</td>
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
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
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
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlThreeCar" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Three Car</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxThreeCar" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltThreeCar" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNext" runat="server" Height="30px" Text="Next" Width="105px" />
        </asp:Panel>
    </form>
</body>
</html>
