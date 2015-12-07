<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Instructions_BuildNewHome.aspx.vb" Inherits="Instructions_BuildNewHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <p>
    
    <asp:Label ID="Label1" runat="server" Text="How much would you like to spend?      "></asp:Label>
    <asp:TextBox ID="tbxBudget" runat="server"></asp:TextBox>
    <asp:Button ID="btnBegin" runat="server" Text="Start building your new home!" />
        </p>


</asp:Content>

