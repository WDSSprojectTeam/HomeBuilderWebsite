<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="OptimizationResultsPage.aspx.vb" Inherits="OptimizationResultsPage" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <div style="text-align:center" >
    
     <table>
         <tr>
             <td>
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
             </td>
         </tr>
         </table>
     <table>
         <tr>
             <td>
                 <asp:GridView ID="gvwDetails" runat="server" Visible="False">
             <Columns>
                 <asp:CommandField SelectText="Edit" ShowSelectButton="True" />
             </Columns>
         </asp:GridView>
             </td>
             <td>
                 <asp:Label ID="lblFeatureName" align="left" runat="server" Visible="False" Font-Bold="True" Font-Size="Large"></asp:Label>
                 <br /> 
                 <br /> 
         
         <asp:RadioButton ID="rdb1" alight="left" runat="server" Autopostback =" true" GroupName="1" Visible="False" />
              
      
                 <br />
              
      
        <asp:RadioButton ID="rdb2" runat="server" Autopostback=" true" GroupName="1" Visible="False" />
                     
     
                 <br />
                     
     
        <asp:RadioButton ID="rdb3" runat="server" Autopostback=" true" GroupName="1" Visible="False" />
        
                 <br />
        
        <asp:RadioButton ID="rdb4" runat="server" Autopostback=" true" GroupName="1" Visible="False" />
        
                 <br />
        
        <asp:RadioButton ID="rdb5" runat="server" Autopostback=" true" GroupName="1" Visible="False" />
                  
        
         

        
         <br />
         <asp:Button ID="btnSave" runat="server" style="margin-left: 69px" Text="Save" Width="78px" />
         <br />
     
     <br />
     
         </div>
</asp:Content>

