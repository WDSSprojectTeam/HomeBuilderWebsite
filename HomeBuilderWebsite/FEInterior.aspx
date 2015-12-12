<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="FEInterior.aspx.vb" Inherits="FEInterior" MaintainScrollPositionOnPostback="true" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <style type="text/css">


        .auto-style24 {
            width: 529px;
        }
        .auto-style48 {
            width: 124px;
            height: 31px;
        }
        .auto-style50 {
            width: 129px;
            height: 31px;
        }
        .auto-style7 {
            width: 129px;
        }
        .auto-style32 {
            width: 128px;
            height: 23px;
        }
        .auto-style65 {
            width: 124px;
        }
        .auto-style68 {
            width: 65px;
            height: 23px;
        }
        .auto-style69 {
            width: 25px;
        }
        .auto-style84 {
            width: 104px;
            height: 23px;
        }
        .auto-style85 {
            width: 95px;
            height: 23px;
        }
        .auto-style82 {
            width: 102px;
            height: 23px;
        }
        .auto-style80 {
            width: 62px;
            height: 23px;
        }
        .auto-style89 {
            width: 216px;
            height: 23px;
        }
        </style>
    
  
    <div>
    <table style="margin:0px auto; width: 1100px;">
        <tr>
            <td>

                <table>
                    <tr>
                        <td>
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
                                <td class="auto-style89"></td>
                                <td class="auto-style84">Love it</td>
                                <td class="auto-style85">Like it</td>
                                <td class="auto-style82">It&#39;s Okay</td>
                                <td class="auto-style80">Dislike</td>
                            </tr>
                        </table>
                            <asp:Panel ID="pnlCarpet" runat="server">
                                <table>
                                    <tr>
                                        <td class="auto-style48">Carpet</td>
                                        <td class="auto-style68">$2/sqr. ft</td>
                                        <td class="auto-style69"></td>
                                        <td class="auto-style50">
                                            <asp:RadioButtonList ID="rltCarpet" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                                <asp:ListItem Value="3"></asp:ListItem>
                                                <asp:ListItem Value="2"></asp:ListItem>
                                                <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                                <asp:ListItem>0</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel ID="pnlTile" runat="server">
                                <table>
                                    <tr>
                                        <td class="auto-style48">Tile</td>
                                        <td class="auto-style68">$6/sqr. ft</td>
                                        <td class="auto-style69"></td>
                                        <td class="auto-style7">
                                            <asp:RadioButtonList ID="rltTile" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                                <asp:ListItem Value="3"></asp:ListItem>
                                                <asp:ListItem Value="2"></asp:ListItem>
                                                <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                                <asp:ListItem>0</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel ID="pnlHardwood" runat="server">
                                <table>
                                    <tr>
                                        <td class="auto-style48">Hardwood</td>
                                        <td class="auto-style68">$8/sqr. ft</td>
                                        <td class="auto-style69"></td>
                                        <td class="auto-style32">
                                            <asp:RadioButtonList ID="rltHardwood" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                                <asp:ListItem Value="3"></asp:ListItem>
                                                <asp:ListItem Value="2"></asp:ListItem>
                                                <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                                <asp:ListItem>0</asp:ListItem>
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
                                <td class="auto-style89"></td>
                                <td class="auto-style84">Love it</td>
                                <td class="auto-style85">Like it</td>
                                <td class="auto-style82">It&#39;s Okay</td>
                                <td class="auto-style80">Dislike</td>
                            </tr>
                        </table>
                            <asp:Panel ID="pnlBrick" runat="server">
                                <table>
                                    <tr>
                                        <td class="auto-style65">Brick Fireplace</td>
                                        <td class="auto-style68">$8,000</td>
                                        <td class="auto-style69"></td>
                                        <td class="auto-style7">
                                            <asp:RadioButtonList ID="rltBrick" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="16px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                                <asp:ListItem Value="3"></asp:ListItem>
                                                <asp:ListItem Value="2"></asp:ListItem>
                                                <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                                <asp:ListItem>0</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel ID="pnlManufactured" runat="server">
                                <table>
                                    <tr>
                                        <td class="auto-style65">Manufactured Stone Fireplace</td>
                                        <td class="auto-style68">$11.500</td>
                                        <td class="auto-style69"></td>
                                        <td class="auto-style7">
                                            <asp:RadioButtonList ID="rltManufactured" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="16px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                                <asp:ListItem Value="3"></asp:ListItem>
                                                <asp:ListItem Value="2"></asp:ListItem>
                                                <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                                <asp:ListItem>0</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <asp:Panel ID="pnlNatural" runat="server">
                                <table>
                                    <tr>
                                        <td class="auto-style65">Natural Stone Fireplace</td>
                                        <td class="auto-style68">$15,000</td>
                                        <td class="auto-style69"></td>
                                        <td class="auto-style32">
                                            <asp:RadioButtonList ID="rltNatural" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="16px" RepeatDirection="Horizontal" style="margin-left: 0px; margin-top: 1px;" Width="420px">
                                                <asp:ListItem Value="3"></asp:ListItem>
                                                <asp:ListItem Value="2"></asp:ListItem>
                                                <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                                <asp:ListItem>0</asp:ListItem>
                                            </asp:RadioButtonList>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <div>
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnBack" runat="server" Height="30px" Text="Back" Width="105px" />
                                &nbsp;&nbsp;
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
                             <br />
                            <br />
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
    
    </asp:Content>