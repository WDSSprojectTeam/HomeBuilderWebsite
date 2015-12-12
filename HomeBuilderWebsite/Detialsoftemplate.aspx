<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Detialsoftemplate.aspx.vb" Inherits="Detialsoftemplate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <div style="text-align:center" >
     <table style="margin:0px auto; width: 891px;">
            <tr>
                <td >
                    <br />
                    <asp:Button ID="btnbacktochoosehome" runat="server"  Font-Names="Corbel" Text="See More Templates" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
                    <br />
                    <br />
                                         <asp:Button ID="btnFeatureEvaluation" runat="server"  Font-Names="Corbel" Text="Edit This Home" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />

                    <br />
                          <br />
                    </td>
            </tr>
         <tr>
                <td >
                     <asp:DetailsView ID="dvwHomeDetails" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" BorderStyle="None">
        <Fields>
            <asp:ImageField DataImageUrlField="Details" ControlStyle-Width="800">
            </asp:ImageField>
        </Fields>
    </asp:DetailsView>
                    </td>
            </tr>
   
        
   
         </table>
   
    </div>


</asp:Content>

