<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="TemplateEdit.aspx.vb" Inherits="TemplateEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        <table>
             <tr>
             <td style="width: 632px">
                 <asp:GridView ID="gvwEditTemplate" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="630px">
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

             <td style="border-style: none; border-width: thin; width: 375px" >
                 <div style="text-align:left">
                 <asp:Panel ID="Panel1" runat="server" BorderColor="Black" BorderStyle="Solid" Width="140px">
                     <asp:Label ID="lblFeatureEdit" runat="server" align="left" Font-Bold="True" Font-Size="Large" Visible="False">Edit Feature:</asp:Label>
                     <br />
                     <br />
                     <asp:Label ID="lblFeatureName" align="left" runat="server" Visible="False" Font-Bold="True" Font-Size="Large"></asp:Label>
                 <br /> 
    
         
         <asp:RadioButton ID="rdb1" alight="left" runat="server" Autopostback =" false" GroupName="1" Visible="False" />
              
      
                 <br />
              
      
        <asp:RadioButton ID="rdb2" runat="server" Autopostback=" false" GroupName="1" Visible="False" />
                     
     
                 <br />
                     
     
        <asp:RadioButton ID="rdb3" runat="server" Autopostback=" false" GroupName="1" Visible="False" />
        
                 <br />
        
        <asp:RadioButton ID="rdb4" runat="server" Autopostback=" false" GroupName="1" Visible="False" />
        
                 <br />
        
        <asp:RadioButton ID="rdb5" runat="server" Autopostback=" false" GroupName="1" Visible="False" />
                 </asp:Panel>
   </div>
         <tr>
             <td colspan="3"  >
                 <br />
                 <asp:Button ID="btnBack" runat="server"  Font-Names="Corbel" Text="Back" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="200px" />
                 &nbsp;
                 <asp:Button ID="btnSave" runat="server"  Font-Names="Corbel" Text="Save My Changes" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="200px" />
               
                 <asp:Button ID="btnEdit" runat="server" Text="Edit" />
               
             </td>
         </tr>

      </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

