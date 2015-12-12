<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="FEOutdoor.aspx.vb" Inherits="FEOutdoor" MaintainScrollPositionOnPostback="true" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
                
           

    <style type="text/css">


        .auto-style24 {
            width: 529px;
        }
        .auto-style69 {
            width: 124px;
        }
        .auto-style71 {
            width: 65px;
        }
        .auto-style72 {
            width: 198px;
            height: 23px;
        }
        .auto-style74 {
            width: 81px;
        }
        .auto-style75 {
            width: 25px;
        }
        .auto-style80 {
            width: 62px;
            height: 23px;
        }
        .auto-style82 {
            width: 102px;
            height: 23px;
        }
        .auto-style84 {
            width: 104px;
            height: 23px;
        }
        .auto-style85 {
            width: 95px;
            height: 23px;
        }
        </style>


    <table style="margin:0px auto; width: 1100px;">
        <tr>
            <td>
             
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
                                <td class="auto-style72"></td>
                                <td class="auto-style84">Love it</td>
                                <td class="auto-style85">Like it</td>
                                <td class="auto-style82">It&#39;s Okay</td>
                                <td class="auto-style80">Dislike</td>
                            </tr>
                        </table>
                        <asp:Panel ID="pnlAsphaltShingle" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style69">Asphalt Shingle</td>
                                    <td class="auto-style71">$5/sqr. ft</td>
                                    <td class="auto-style75"></td>
                                    <td class="auto-style7">
                                        <asp:RadioButtonList ID="rltAsphaltShingle" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="16px" RepeatDirection="Horizontal" style="margin-left: 0px; margin-bottom: 0px;" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="pnlWoodShingle" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style69">Wood Shingle</td>
                                    <td class="auto-style71">$6/sqr. ft</td>
                                    <td class="auto-style75"></td>
                                    <td class="auto-style7">
                                        <asp:RadioButtonList ID="rltWoodShingle" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="16px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="pnlMetalShingle" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style69">Metal Shingle</td>
                                    <td class="auto-style71">$8/sqr. ft</td>
                                    <td class="auto-style75"></td>
                                    <td class="auto-style32">
                                        <asp:RadioButtonList ID="rltMetalShingle" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="16px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="pnlSlateShingle" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style69">Slate Shingle</td>
                                    <td class="auto-style71">$15/sqr. ft</td>
                                    <td class="auto-style75"></td>
                                    <td class="auto-style47">
                                        <asp:RadioButtonList ID="rltSlateShingle" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="16px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                            <asp:Panel ID="pnlTileShingle" runat="server">
                                <table>
                                    <tr>
                                        <td class="auto-style69">Tile Shingle</td>
                                        <td class="auto-style71">$10/sqr. ft</td>
                                        <td class="auto-style75"></td>
                                        <td class="auto-style33">
                                            <asp:RadioButtonList ID="rltTileShingle" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="16px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                                <asp:ListItem Value="3"></asp:ListItem>
                                                <asp:ListItem Value="2"></asp:ListItem>
                                                <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                                <asp:ListItem>0</asp:ListItem>
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
                                <td class="auto-style72"></td>
                                <td class="auto-style84">Love it</td>
                                <td class="auto-style85">Like it</td>
                                <td class="auto-style82">It&#39;s Okay</td>
                                <td class="auto-style80">Dislike</td>
                            </tr>
                        </table>
                    
                        <asp:Panel ID="pnlOneCar" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style69">One Car</td>
                                    <td class="auto-style71">$7,000</td>
                                    <td class="auto-style75"></td>
                                    <td class="auto-style7">
                                        <asp:RadioButtonList ID="rltOneCar" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                <asp:Panel ID="pnlTwoCar" runat="server">
                        <table>
                            <tr>
                                <td class="auto-style69">Two Car</td>
                                <td class="auto-style71">$13,000</td>
                                <td class="auto-style75"></td>
                                <td class="auto-style7">
                                    <asp:RadioButtonList ID="rltTwoCar" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                        <asp:ListItem Value="3"></asp:ListItem>
                                        <asp:ListItem Value="2"></asp:ListItem>
                                        <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                        <asp:ListItem>0</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="pnlThreeCar" runat="server" Height="40px">
                        <table>
                            <tr>
                                <td class="auto-style69">Three Car</td>
                                <td class="auto-style71">$20,000</td>
                                <td class="auto-style75"></td>
                                <td class="auto-style32">
                                    <asp:RadioButtonList ID="rltThreeCar" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                        <asp:ListItem Value="3"></asp:ListItem>
                                        <asp:ListItem Value="2"></asp:ListItem>
                                        <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                        <asp:ListItem>0</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                    </asp:Panel>
                <br />
                    <table>
                        <tr>
                            <td class="auto-style24">
                                <h2>Landscaping</h2>
                            </td>
                        </tr>
                    </table>
                        <table>
                            <tr>
                                <td class="auto-style72"></td>
                                <td class="auto-style84">Love it</td>
                                <td class="auto-style85">Like it</td>
                                <td class="auto-style82">It&#39;s Okay</td>
                                <td class="auto-style80">Dislike</td>
                            </tr>
                        </table>
                    
                        <asp:Panel ID="pnlCurb" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style69">Basic Curb Appeal</td>
                                    <td class="auto-style71">$5,000</td>
                                    <td class="auto-style75"></td>
                                    <td class="auto-style7">
                                        <asp:RadioButtonList ID="rltCurb" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                <asp:Panel ID="pnlCurbPlus" runat="server">
                        <table>
                            <tr>
                                <td class="auto-style69">Curb Appeal Plus</td>
                                <td class="auto-style71">$10,000</td>
                                <td class="auto-style75"></td>
                                <td class="auto-style7">
                                    <asp:RadioButtonList ID="rltCurbPlus" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                        <asp:ListItem Value="3"></asp:ListItem>
                                        <asp:ListItem Value="2"></asp:ListItem>
                                        <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                        <asp:ListItem>0</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="pnlPremium" runat="server" Height="40px">
                        <table>
                            <tr>
                                <td class="auto-style69">Premium Landscaping</td>
                                <td class="auto-style71">$15,000</td>
                                <td class="auto-style75"></td>
                                <td class="auto-style32">
                                    <asp:RadioButtonList ID="rltPremium" runat="server" AutoPostBack="True" ForeColor="#EBFAFA" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                        <asp:ListItem Value="3"></asp:ListItem>
                                        <asp:ListItem Value="2"></asp:ListItem>
                                        <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                        <asp:ListItem>0</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                    </asp:Panel>
                    <div>
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Button ID="btnBack" runat="server" Text="Back" Width="105px" Height="30px" />
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
 
</asp:Content>