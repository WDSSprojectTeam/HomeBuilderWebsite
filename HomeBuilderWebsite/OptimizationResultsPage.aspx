<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="OptimizationResultsPage.aspx.vb" Inherits="OptimizationResultsPage" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">


     <asp:Chart ID="chtCompareBudgets" runat="server">
         <series>
             <asp:Series Name="Series1">
             </asp:Series>
         </series>
         <chartareas>
             <asp:ChartArea Name="ChartArea1">
             </asp:ChartArea>
         </chartareas>
     </asp:Chart>
     
     <asp:Panel ID="pnlGVW" runat="server" Visible="False">
         <asp:GridView ID="gvwDetails" runat="server">
         </asp:GridView>
         <br />
         <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="78px" />
         <asp:Button ID="btnSave" runat="server" style="margin-left: 69px" Text="Save" Width="78px" />
         <br />
     </asp:Panel>
     <br />
     
</asp:Content>

