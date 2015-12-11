<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="FEBedroom.aspx.vb" Inherits="FEBedroom" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <style type="text/css">

        .auto-style24 {
            width: 529px;
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
        .auto-style52 {
            width: 146px;
            height: 42px;
        }
        .auto-style53 {
            width: 129px;
            height: 42px;
        }
        .auto-style49 {
            width: 146px;
            height: 31px;
        }
        .auto-style50 {
            width: 129px;
            height: 31px;
        }
        .auto-style70 {
            width: 1151px;
        }
        .auto-style71 {
            width: 124px;
        }
        .auto-style72 {
            width: 198px;
            height: 23px;
        }
        .auto-style77 {
            width: 96px;
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
        .auto-style82 {
            width: 102px;
            height: 23px;
        }
        .auto-style80 {
            width: 62px;
            height: 23px;
        }
        .auto-style87 {
            width: 65px;
            height: 23px;
        }
        .auto-style88 {
            width: 25px;
        }
        .auto-style89 {
            width: 81px;
        }
        </style>

    <table>
        <tr>
            <td class="auto-style70">

                <table>
                    <tr>
                        <td>
                          
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
                                <td class="auto-style72"></td>
                                <td class="auto-style77">Must Have</td>
                                <td class="auto-style84">Love it</td>
                                <td class="auto-style85">Like it</td>
                                <td class="auto-style82">It&#39;s Okay</td>
                                <td class="auto-style80">Dislike</td>
                            </tr>
                        </table>
                                    <asp:Panel ID="pnlBathShower" runat="server">
                                        <table>
                                            <tr>
                                                <td class="auto-style71">Bath/Shower Combination</td>
                                                <td class="auto-style87">$1,100</td>
                                                <td class="auto-style88"></td>
                                                <td class="auto-style89">
                                                    <asp:CheckBox ID="cbxBathShower" runat="server" AutoPostBack="True" />
                                                </td>
                                                <td class="auto-style7">
                                                    <asp:RadioButtonList ID="rltBathShower" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                                        <asp:ListItem Value="3"></asp:ListItem>
                                                        <asp:ListItem Value="2"></asp:ListItem>
                                                        <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                    <asp:Panel ID="pnlWalkinShower" runat="server">
                                        <table>
                                            <tr>
                                                <td class="auto-style71">Walk-in-shower</td>
                                                <td class="auto-style87">$2,400</td>
                                                <td class="auto-style88"></td>
                                                <td class="auto-style89">
                                                    <asp:CheckBox ID="cbxWalkinShower" runat="server" AutoPostBack="True" />
                                                </td>
                                                <td class="auto-style7">
                                                    <asp:RadioButtonList ID="rltWalkinShower" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                                        <asp:ListItem Value="3"></asp:ListItem>
                                                        <asp:ListItem Value="2"></asp:ListItem>
                                                        <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                    <asp:Panel ID="pnlRainfall" runat="server">
                                        <table>
                                            <tr>
                                                <td class="auto-style71">Luxry rainfall shower</td>
                                                <td class="auto-style87">$10,000</td>
                                                <td class="auto-style88"></td>
                                                <td class="auto-style89">
                                                    <asp:CheckBox ID="cbxRainfall" runat="server" AutoPostBack="True" />
                                                </td>
                                                <td class="auto-style32">
                                                    <asp:RadioButtonList ID="rltRainfall" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
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
                                            <td class="auto-style43">
                                                <h2>Closets</h2>
                                            </td>
                                        </tr>
                                    </table>
                        <table>
                            <tr>
                                <td class="auto-style72"></td>
                                <td class="auto-style77">Must Have</td>
                                <td class="auto-style84">Love it</td>
                                <td class="auto-style85">Like it</td>
                                <td class="auto-style82">It&#39;s Okay</td>
                                <td class="auto-style80">Dislike</td>
                            </tr>
                        </table>
                                    <asp:Panel ID="pnlWardrobe" runat="server">
                                        <table>
                                            <tr>
                                                <td class="auto-style71">Wardrobe Closet</td>
                                                <td class="auto-style87">$1,200</td>
                                                <td class="auto-style88"></td>
                                                <td class="auto-style89">
                                                    <asp:CheckBox ID="cbxWardrobe" runat="server" AutoPostBack="True" />
                                                </td>
                                                <td class="auto-style53">
                                                    <asp:RadioButtonList ID="rltWardrobe" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                                        <asp:ListItem Value="3"></asp:ListItem>
                                                        <asp:ListItem Value="2"></asp:ListItem>
                                                        <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                                        <asp:ListItem>0</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                                    <asp:Panel ID="pnlWalkinCloset" runat="server">
                                        <table>
                                            <tr>
                                                <td class="auto-style71">Walk-in-closet</td>
                                                <td class="auto-style87">$5,040</td>
                                                <td class="auto-style88"></td>
                                                <td class="auto-style89">
                                                    <asp:CheckBox ID="cbxWalkinCloset" runat="server" AutoPostBack="True" />
                                                </td>
                                                <td class="auto-style50">
                                                    <asp:RadioButtonList ID="rltWalkinCloset" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
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
                                        <br />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="btnNext" runat="server" Height="30px" Text="Next" Width="105px" />
                                    </div>
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
                    
                 </td>
            </tr>
        </table> 
                <asp:Panel ID="pnlydynamichart" runat="server">
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </td>

        </tr>
    </table>
    
        </asp:Content>