<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ChooseHomeLayout.aspx.vb" Inherits="ChooseHomeLayout" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    <br />
      <div style="text-align:center">
      <table border="1">
            <tr>
                <td style="width: 191px"> 
                    <div style="text-align:center">
                          <h4> Customize Your Home</h4>
                    </div>
                    

                </td>
                <td style="width: 632px">
                    <div style="text-align:center">
                          <h4> See Your Options</h4>
                    </div>
                  
                </td>
               
            <tr>
                <td style="width: 191px">
                      <div style="text-align:center">
                    <asp:Button ID="btnallhome" runat="server" Text="See All Homes" />
                          <br />
                      <br />
                      <b>OR</b>
                       
                           </div> 
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Select a Home Type: "></asp:Label>
    <br />
    <asp:ListBox ID="lbxhometype" runat="server" AutoPostBack="True" Height="56px">
     	<asp:ListItem>Family</asp:ListItem> 
        <asp:ListItem>Luxury</asp:ListItem>
        <asp:ListItem>Starter Home</asp:ListItem>
                    </asp:ListBox>

          <br />
                    <br />
        <asp:Label ID="Label2" runat="server" Text="Number of Bedrooms"></asp:Label>
        <asp:DropDownList ID="ddlbedroom" runat="server" AutoPostBack="True">
            <asp:ListItem Value="0">All</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
        </asp:DropDownList>
          <br />
            
        <asp:Label ID="Label3" runat="server" Text="Number of Bathrooms"></asp:Label>
        <asp:DropDownList ID="ddlbathroom" runat="server" AutoPostBack="True">
            <asp:ListItem Value="0">All</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
        </asp:DropDownList>
<br />
                    <br />
                    <asp:Button ID="btnSeeHomeOptions" runat="server" Text="Find My New Home!" />
                     <br />
                    <br />
                    <asp:Label ID="lblluxury" runat="server" Text="A <b>Luxury Home</b>  is perfect for home buyers wanting a more lavish life style."></asp:Label>
                
                    <asp:Label ID="lblfamily" runat="server" Text="A <b>Family Home</b> is ideal for families looking for a little more space."></asp:Label>
                    <asp:Label ID="lblstarter" runat="server" Text="A <b>Starter Home</b> is great for first time home buyers or small families."></asp:Label>
                </td>

                <td style="width: 1000px"> 
                     <asp:Label ID="lblnoinitialoptions" runat="server" Text="We apologize. We do not offer any homes that are that style within your budget. Please select another home type."></asp:Label>
                    <asp:GridView ID="gvwalltypes" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
           <Columns>
               <asp:CommandField ShowSelectButton="True" />
               <asp:ButtonField CommandName="btnDetails" Text="View House Details" />
               <asp:BoundField DataField="ID" HeaderText="Home ID" />
               <asp:BoundField DataField="HouseName" HeaderText="House Name" >
               <ItemStyle Font-Bold="True" ForeColor="#000066" />
               </asp:BoundField>
               <asp:ImageField DataImageUrlField="Picture" ControlStyle-Height="100" FooterStyle-VerticalAlign="Top" HeaderText="Picture">
<ControlStyle Height="100px"></ControlStyle>

<FooterStyle VerticalAlign="Top"></FooterStyle>
               </asp:ImageField>
               <asp:BoundField DataField="Style" HeaderText="Style" />
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
                    <asp:GridView ID="gvwfiltered" runat="server" AutoGenerateColumns="False">
                        <Columns>
               <asp:CommandField ShowSelectButton="True" />
               <asp:ButtonField CommandName="btnDetails" Text="View House Details" />
               <asp:BoundField DataField="ID" HeaderText="Home ID" />
               <asp:BoundField DataField="HouseName" HeaderText="House Name" >
               <ItemStyle Font-Bold="True" ForeColor="#000066" />
               </asp:BoundField>
               <asp:ImageField DataImageUrlField="Picture" ControlStyle-Height="100" FooterStyle-VerticalAlign="Top" HeaderText="Picture">
<ControlStyle Height="100px"></ControlStyle>

<FooterStyle VerticalAlign="Top"></FooterStyle>
               </asp:ImageField>
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

     
                    <asp:Label ID="lblnooptions" runat="server" Text="We apologize. We do not offer any homes that fit your needs. Please select another home type or number of bed/bath."></asp:Label>

                </td>
            

         
               </tr>
        </table>
           </div>
    </asp:Content>

