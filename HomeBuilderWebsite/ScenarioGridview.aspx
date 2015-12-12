<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ScenarioGridview.aspx.vb" Inherits="ScenarioGridview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <br />
    <br />
      <div style="text-align:center">
      <table border="1" style="margin:0px auto; width: 1100px;">
            <tr>
                <td style="width: 250px"> 
                    <div style="text-align:center">
                          <h4> Filter Available Templates</h4>
                    </div>
                    

                </td>
                <td style="width: 632px">
                    <div style="text-align:center">
                          <h4> See Your Template Options</h4>
                    </div>
                  
                </td>
               
            <tr>
                <td style="width: 250px">
                      <div style="text-align:center">
                    <asp:Button ID="btnallhome" runat="server" Text="See All Templates" />
                          <br />
                      <br />
                      <b>OR</b>
                       
                           </div> 
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Select a Key Home Area: "></asp:Label>
    <br />
    <asp:ListBox ID="lbxhometype" runat="server" AutoPostBack="True" Height="56px">
     	<asp:ListItem>Exterior</asp:ListItem> 
        <asp:ListItem>Interior</asp:ListItem>
        <asp:ListItem>Kitchen</asp:ListItem>
         <asp:ListItem>Bedroom</asp:ListItem>
                    </asp:ListBox>

          <br />
         
<br />
                    <br />
                    <asp:Button ID="btnSeeHomeOptions" runat="server" Text="Find My New Home!" />
                     <br />
                    <br />
                    <asp:Label ID="lblexterior" runat="server" Text=" Includes: Roof, Garage, Landscaping"></asp:Label>
      
                    <asp:Label ID="lblinterior" runat="server" Text="Includes: Flooring, Fireplace"></asp:Label>
                    <asp:Label ID="lblkitchen" runat="server" Text="Includes: Cabinents, Countertops, Appliances"></asp:Label>
             <asp:Label ID="lblbedrooms" runat="server" Text="Includes: Bathrooms, Closet"></asp:Label>
            
                     </td>

                <td style="width: 1000px"> 
                     <asp:Label ID="lblnoinitialoptions" runat="server" Text="We apologize. We do not offer any homes that are that have that key home area within your budget. Please select another key home area."></asp:Label>
                    <asp:GridView ID="gvwalltypes" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
           <Columns>
               <asp:CommandField ShowSelectButton="True" />
               <asp:ButtonField CommandName="btnDetails" Text="View House Details" />
               <asp:BoundField DataField="TempID" HeaderText="Template ID" />
               <asp:BoundField DataField="TempName" HeaderText="Template Name" >
               <ItemStyle Font-Bold="True" ForeColor="#000066" />
               </asp:BoundField>
               <asp:ImageField DataImageUrlField="Picture" ControlStyle-Height="100" FooterStyle-VerticalAlign="Top" HeaderText="Picture">
<ControlStyle Height="100px"></ControlStyle>

<FooterStyle VerticalAlign="Top"></FooterStyle>
               </asp:ImageField>
               <asp:BoundField DataField="KeyArea" HeaderText="Key Home Area" />
               <asp:BoundField DataField="Bedrooms" HeaderText="Bedrooms" />
               <asp:BoundField DataField="Bathrooms" HeaderText="Bathrooms" />
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
     
                    <br />

     
                    <asp:Label ID="lblnooptions" runat="server" Text="We apologize. We do not offer any homes that fit your needs. Please select another key home area."></asp:Label>

                </td>
            

         
               </tr>
        </table>
           </div>


</asp:Content>

