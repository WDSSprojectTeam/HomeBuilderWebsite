<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FEKitchen.aspx.vb" Inherits="FEKitchen" %>

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
        .auto-style33 {
            width: 128px;
        }
        .auto-style43 {
            width: 151px;
            height: 23px;
        }
        .auto-style44 {
            width: 149px;
            height: 23px;
        }
        .auto-style45 {
            width: 136px;
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
                <td class="auto-style22"></td>
                <td class="auto-style43">Must Have</td>
                <td class="auto-style44">Love it</td>
                <td class="auto-style45">Like it</td>
                <td class="auto-style43">It&#39;s Okay</td>
                <td class="auto-style23">Dislike</td>
            </tr>
        </table>
        <asp:Panel ID="pnlStandardBeige" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Standard Beige</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxStandardBeige" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltStandardBeige" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlBlack" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Black</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxBlack" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style7">
                        <asp:RadioButtonList ID="rltBlack" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlStainlessSteel" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Stainless Steel</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxStainlessSteel" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style32">
                        <asp:RadioButtonList ID="rltStainlessSteel" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                            <asp:ListItem Value="3"></asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                            <asp:ListItem>0</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlProfessional" runat="server">
            <table>
                <tr>
                    <td class="auto-style42">Professional Grade</td>
                    <td class="auto-style30"><asp:CheckBox ID="cbxProfessional" runat="server" AutoPostBack="True" />
                    </td>
                    <td class="auto-style33">
                        <asp:RadioButtonList ID="rltProfessional" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
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
                    <td class="auto-style24">
                        <h2>Countertops</h2>
                    </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td class="auto-style22"></td>
                    <td class="auto-style43">Must Have</td>
                    <td class="auto-style44">Love it</td>
                    <td class="auto-style45">Like it</td>
                    <td class="auto-style43">It&#39;s Okay</td>
                    <td class="auto-style23">Dislike</td>
                </tr>
            </table>
            <asp:Panel ID="pnlQuartz" runat="server">
                <table>
                    <tr>
                        <td class="auto-style42">Quartz</td>
                        <td class="auto-style30">
                            <asp:CheckBox ID="cbxQuartz" runat="server" AutoPostBack="True" />
                        </td>
                        <td class="auto-style7">
                            <asp:RadioButtonList ID="rltQuartz" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                                <asp:ListItem Value="3"></asp:ListItem>
                                <asp:ListItem Value="2"></asp:ListItem>
                                <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                                <asp:ListItem>0</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="PanelGranite" runat="server">
                <table>
                    <tr>
                        <td class="auto-style42">Granite</td>
                        <td class="auto-style30">
                            <asp:CheckBox ID="cbxGranite" runat="server" AutoPostBack="True" />
                        </td>
                        <td class="auto-style7">
                            <asp:RadioButtonList ID="rltGranite" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                                <asp:ListItem Value="3"></asp:ListItem>
                                <asp:ListItem Value="2"></asp:ListItem>
                                <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                                <asp:ListItem>0</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="PanelLaminate" runat="server">
                <table>
                    <tr>
                        <td class="auto-style42">Laminate</td>
                        <td class="auto-style30">
                            <asp:CheckBox ID="cbxLaminate" runat="server" AutoPostBack="True" />
                        </td>
                        <td class="auto-style7">
                            <asp:RadioButtonList ID="rltLaminate" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                                <asp:ListItem Value="3"></asp:ListItem>
                                <asp:ListItem Value="2"></asp:ListItem>
                                <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                                <asp:ListItem>0</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="PanelWood" runat="server">
                <table>
                    <tr>
                        <td class="auto-style42">Wood</td>
                        <td class="auto-style30">
                            <asp:CheckBox ID="cbxWood" runat="server" AutoPostBack="True" />
                        </td>
                        <td class="auto-style32">
                            <asp:RadioButtonList ID="rltWood" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
                                <asp:ListItem Value="3"></asp:ListItem>
                                <asp:ListItem Value="2"></asp:ListItem>
                                <asp:ListItem Value="1" Selected="True"></asp:ListItem>
                                <asp:ListItem>0</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="PanelMarble" runat="server">
                <table>
                    <tr>
                        <td class="auto-style42">Marble</td>
                        <td class="auto-style30">
                            <asp:CheckBox ID="cbxMarble" runat="server" AutoPostBack="True" />
                        </td>
                        <td class="auto-style33">
                            <asp:RadioButtonList ID="rltMarble" runat="server" AutoPostBack="True" ForeColor="White" Height="19px" RepeatDirection="Horizontal" style="margin-left: 0px" Width="600px">
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
