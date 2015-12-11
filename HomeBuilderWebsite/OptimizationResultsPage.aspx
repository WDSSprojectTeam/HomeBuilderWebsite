<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="OptimizationResultsPage.aspx.vb" Inherits="OptimizationResultsPage" MaintainScrollPositionOnPostback="true" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <div style="text-align:center" >
    
     <table style="margin:0px auto; width: 800px;">
         <tr>
             <td colspan="2">
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
             <tr>
             <td style="width: 632px">
                 <asp:GridView ID="gvwDetails" runat="server" Visible="False" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="625px">
             <Columns>
                 <asp:CommandField SelectText="Edit" ShowSelectButton="True" />
                 <asp:BoundField DataField="Feature" HeaderText="Feature" />
                 <asp:BoundField DataField="Name" HeaderText="Name">
                 <ItemStyle Font-Bold="True" ForeColor="#000066" />
                 </asp:BoundField>
                 <asp:BoundField DataField="Description" HeaderText="Description" />
                 <asp:BoundField DataField="Price" DataFormatString="{0:c}" HeaderText="Price" />
             </Columns>
                     <FooterStyle BackColor="White" ForeColor="#333333" />
                     <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                     <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                     <RowStyle BackColor="White" ForeColor="#333333" />
                     <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                     <SortedAscendingCellStyle BackColor="#F7F7F7" />
                     <SortedAscendingHeaderStyle BackColor="#487575" />
                     <SortedDescendingCellStyle BackColor="#E5E5E5" />
                     <SortedDescendingHeaderStyle BackColor="#275353" />
         </asp:GridView>
             </td>
             <td>
                 <asp:Label ID="lblFeatureName" align="left" runat="server" Visible="False" Font-Bold="True" Font-Size="Large"></asp:Label>
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
   
         <tr>
             <td colspan="2">
                 <br />
                 <asp:Button ID="btnSave" runat="server"  Font-Names="Corbel" Text="Save My Changes" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
               
             </td>
         </tr>

      </table>
         </div>
</asp:Content>

