<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ScenarioInfo.aspx.vb" Inherits="ScenarioInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <div style="text-align:center; font-size: large;" >
     <h2>Tell us a little bit about yourself so we can help you find the perfect home!</h2>

    <p>
    <h3>1) How much would you like to spend?</h3>
          $<asp:TextBox ID="tbxBudget" runat="server"></asp:TextBox>

            </p>

  
   
        <table style="margin:0px auto; width: 891px;">
            <tr>
                <td colspan="4">
                    <h3>2) What area of the house is most improtant to you?</h3>
                    </td>
                
               
            </tr>

            <tr>
                <td colspan="4">
                  
                    <asp:RadioButtonList ID="rdbhomestyle" runat="server" RepeatDirection="Horizontal" align="center" CellPadding="30" Height="16px" Font-Names="Corbel" Width="600px" >
                        <asp:ListItem>Exterior</asp:ListItem>
                        <asp:ListItem Selected="True">Interior</asp:ListItem>
                        <asp:ListItem>Kitchen</asp:ListItem>
                         <asp:ListItem>Bedroom</asp:ListItem>
                    </asp:RadioButtonList>
                         
                    </td>
              
               
            </tr>
            
            <tr>
                <td colspan="4">
                    <h4>  What features are in each home area?...</h4>
                   

                </td>
                
               
            </tr>
            <tr>
                <td style="width: 634px"> 
                     Exterior:
                    <br />
                                  <asp:Image ID="img1" runat="server" ImageUrl="~/Images/3.png" Width="200px" />
                    <br />
                   Roof
                     <br />
                    Garage
                    <br />
                    Landscaping
                </td>
                <td style="width: 624px"> 
                    Interior:
                    <br />
                     <asp:Image ID="img2" runat="server" ImageUrl="~/Images/7.png" Width="200px" />
                    <br />
                   Flooring
                     <br />
                    Fireplace
                    <br />
            <br />
                </td>
                 <td style="width: 624px"> 
                     Kitchen:
                    <br />
                     <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/7.png" Width="200px" />
                    <br />
                   Cabinents
                     <br />
                    Countertops
                     <br />
                     Appliances
                 
                </td>
                
                 
                <td style="width: 678px"> 
                      Bedroom:
                    <br />
                     <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/7.png" Width="200px" />
                    <br />
                   Bathroom
                     <br />
                    Closets
                     <br />
                  <br />
                </td>
            </tr>
           
        </table>


    <br />
    <asp:Button ID="btnBegin" runat="server"  Font-Names="Corbel" Text="See what templates we have to offer!" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="395px" />
    <br />
          <br />
<asp:Label runat="server" Text="You must enter a budget first." ID="lblbudgetvalidation" Font-Bold="True" Font-Size="X-Large"></asp:Label>
</div>

</asp:Content>

