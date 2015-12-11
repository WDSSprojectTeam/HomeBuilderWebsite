<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="FEKitchen.aspx.vb" Inherits="FEKitchen" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <style type="text/css">


        .auto-style24 {
            width: 529px;
        }
        .auto-style65 {
            width: 123px;
        }
        .auto-style66 {
            width: 125px;
        }
        .auto-style67 {
            width: 43px;
        }
        .auto-style68 {
            width: 103px;
        }
        .auto-style69 {
            width: 90px;
        }
        .auto-style70 {
            width: 91px;
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
        .auto-style86 {
            width: 124px;
        }
        .auto-style87 {
            height: 43px;
        }
        .auto-style88 {
            width: 65px;
        }
        .auto-style89 {
            width: 25px;
        }
        .auto-style90 {
            width: 81px;
        }
        </style>
    <table style="margin:0px auto; width: 1100px;">
        <tr>
            <td>
                
                    <div>
                        <h1>Kitchen</h1>
                        <br />
                        <table>
                            <tr>
                                <td class="auto-style24">
                                    <h2>Appliances</h2>
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
                        <asp:Panel ID="pnlStandardBeige" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style86">Standard Beige</td>
                                    <td class="auto-style88">$3,000</td>
                                    <td class="auto-style89"></td>
                                    <td class="auto-style90">
                                        <asp:CheckBox ID="cbxStandardBeige" runat="server" AutoPostBack="True" />
                                    </td>
                                    <td class="auto-style7">
                                        <asp:RadioButtonList ID="rltStandardBeige" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="pnlBlack" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style86">Black</td>
                                    <td class="auto-style88">$7,000</td>
                                    <td class="auto-style89"></td>
                                    <td class="auto-style90">
                                        <asp:CheckBox ID="cbxBlack" runat="server" AutoPostBack="True" />
                                    </td>
                                    <td class="auto-style7">
                                        <asp:RadioButtonList ID="rltBlack" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="pnlStainlessSteel" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style86">Stainless Steel</td>
                                    <td class="auto-style88">$8,200</td>
                                    <td class="auto-style89"></td>
                                    <td class="auto-style90">
                                        <asp:CheckBox ID="cbxStainlessSteel" runat="server" AutoPostBack="True" />
                                    </td>
                                    <td class="auto-style32">
                                        <asp:RadioButtonList ID="rltStainlessSteel" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="pnlProfessional" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style86">Professional Grade</td>
                                    <td class="auto-style88">$24,000</td>
                                    <td class="auto-style89"></td>
                                    <td class="auto-style90">
                                        <asp:CheckBox ID="cbxProfessional" runat="server" AutoPostBack="True" />
                                    </td>
                                    <td class="auto-style87">
                                        <asp:RadioButtonList ID="rltProfessional" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
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
                                    <h2>Countertops</h2>
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
                        <asp:Panel ID="pnlQuartz" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style86">Quartz</td>
                                    <td class="auto-style88">$10,500</td>
                                    <td class="auto-style89"></td>
                                    <td class="auto-style90">
                                        <asp:CheckBox ID="cbxQuartz" runat="server" AutoPostBack="True" />
                                    </td>
                                    <td class="auto-style7">
                                        <asp:RadioButtonList ID="rltQuartz" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="PanelGranite" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style86">Granite</td>
                                    <td class="auto-style88">$9,300</td>
                                    <td class="auto-style89"></td>
                                    <td class="auto-style90">
                                        <asp:CheckBox ID="cbxGranite" runat="server" AutoPostBack="True" />
                                    </td>
                                    <td class="auto-style7">
                                        <asp:RadioButtonList ID="rltGranite" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="PanelLaminate" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style86">Laminate</td>
                                    <td class="auto-style88">$4,200</td>
                                    <td class="auto-style89"></td>
                                    <td class="auto-style90">
                                        <asp:CheckBox ID="cbxLaminate" runat="server" AutoPostBack="True" />
                                    </td>
                                    <td class="auto-style7">
                                        <asp:RadioButtonList ID="rltLaminate" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="PanelWood" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style86">Wood</td>
                                    <td class="auto-style88">$7,800</td>
                                    <td class="auto-style89"></td>
                                    <td class="auto-style90">
                                        <asp:CheckBox ID="cbxWood" runat="server" AutoPostBack="True" />
                                    </td>
                                    <td class="auto-style32">
                                        <asp:RadioButtonList ID="rltWood" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
                                            <asp:ListItem Value="3"></asp:ListItem>
                                            <asp:ListItem Value="2"></asp:ListItem>
                                            <asp:ListItem Selected="True" Value="1"></asp:ListItem>
                                            <asp:ListItem>0</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="PanelMarble" runat="server">
                            <table>
                                <tr>
                                    <td class="auto-style86">Marble</td>
                                    <td class="auto-style88">$11,700</td>
                                    <td class="auto-style89"></td>
                                    <td class="auto-style90">
                                        <asp:CheckBox ID="cbxMarble" runat="server" AutoPostBack="True" />
                                    </td>
                                    <td class="auto-style33">
                                        <asp:RadioButtonList ID="rltMarble" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="420px">
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