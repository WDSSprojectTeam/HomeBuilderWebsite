<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FEInterior.aspx.vb" Inherits="FEInterior" %>

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
        .auto-style33 {
            width: 128px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Interior</h1>
        <br />
    
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Floors</h2>
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
        <asp:Panel ID="pnlCarpet" runat="server">
            <table>
                <tr>
                    <td class="auto-style48">Carpet</td>
                    <td class="auto-style49"><asp:CheckBox ID="cbxCarpet" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style50">
                        <asp:RadioButtonList ID="rltCarpet" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlTile" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Tile</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxTile" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltTile" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlHardwood" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Hardwood</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxHardwood" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltHardwood" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlTileShingle" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Tile Shingle</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxTileShingle" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style33">
                        <asp:RadioButtonList ID="rltTileShingle" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                   
                    
                </tr>
            </table>
        </asp:Panel>
    
        <br />
    
        <table>
            <tr>
                <td class="auto-style24">
                    <h2>Fireplace</h2>
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
        <asp:Panel ID="pnlBrick" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Brick Fireplace</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxBrick" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltBrick" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlManufactured" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Manufactured Stone Fireplace</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxManufactured" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltManufactured" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="4"></asp:ListItem>
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlNatural" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Natural Stone Fireplace</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxNatural" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltNatural" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
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
    
    </div>
    </form>
</body>
</html>
