<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ChooseHomeLayout.aspx.vb" Inherits="ChooseHomeLayout" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <br />
    <br />

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

                <td style="width: 632px"> 
                    <asp:GridView ID="gvwalltypes" runat="server">
           <Columns>
               <asp:CommandField ShowSelectButton="True" />
               <asp:ButtonField CommandName="btnDetails" Text="View House Details" />
               <asp:ImageField DataImageUrlField="Picture" ControlStyle-Height="100" FooterStyle-VerticalAlign="Top">
               </asp:ImageField>
           </Columns>
       </asp:GridView>

     
                    <asp:Label ID="lblnooptions" runat="server" Text="We apologize. We do not offer any homes that fit your needs. Please select another home type or number of bed/bath."></asp:Label>

                </td>
            

         
               </tr>
        </table>

    </asp:Content>

