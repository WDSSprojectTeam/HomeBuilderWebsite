<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="SeeHomeDetails.aspx.vb" Inherits="SeeHomeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
  
     <table style="margin:0px auto; width: 891px;">
            <tr>
                <td >
                     <asp:Button ID="btnbacktochoosehome" runat="server" Text="See More Homes" />
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
   
         <tr>
                <td >
                     <asp:Button ID="btnFeatureEvaluation" runat="server"  Font-Names="Corbel" Text="Select This Home" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />

                    </td>
            </tr>
   
         </table>
   
    

</asp:Content>

