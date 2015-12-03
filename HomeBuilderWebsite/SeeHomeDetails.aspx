<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="SeeHomeDetails.aspx.vb" Inherits="SeeHomeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Button ID="btnbacktochoosehome" runat="server" Text="See More Homes" />

    <asp:DetailsView ID="dvwHomeDetails" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" BorderStyle="None">
        <Fields>
            <asp:ImageField DataImageUrlField="Details" ControlStyle-Width="800">
            </asp:ImageField>
        </Fields>
    </asp:DetailsView>

    <asp:Button ID="btnFeatureEvaluation" runat="server" Text="Select Home and Customize Features" />
    

</asp:Content>

