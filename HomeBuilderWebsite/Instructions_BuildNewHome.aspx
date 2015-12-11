<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" MaintainScrollPositionOnPostback="true" CodeFile="Instructions_BuildNewHome.aspx.vb" Inherits="Instructions_BuildNewHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
      <div style="text-align:center; font-size: large;" >
     <h2>Tell us a little bit about yourself so we can help you find the perfect home!</h2>

    <p>
    <h3>1) How much would you like to spend?</h3>
          $<asp:TextBox ID="tbxBudget" runat="server"></asp:TextBox>

            </p>

  
   
        <table style="margin:0px auto; width: 891px;">
            <tr>
                <td colspan="3">
                    <h3>2) Select a Home Style Below</h3>
                    </td>
                
               
            </tr>

            <tr>
                <td colspan="3">
                  
                    <asp:RadioButtonList ID="rdbhomestyle" runat="server" RepeatDirection="Horizontal" align="center" CellPadding="30" Height="16px" Font-Names="Corbel" Width="600px" >
                        <asp:ListItem>Luxury</asp:ListItem>
                        <asp:ListItem Selected="True">Family</asp:ListItem>
                        <asp:ListItem>Starter Home</asp:ListItem>
                    </asp:RadioButtonList>
                         
                    </td>
              
               
            </tr>
            
            <tr>
                <td colspan="3">
                    <h4>  Which style is best for me?...</h4>
                   

                </td>
                
               
            </tr>
            <tr>
                <td style="width: 634px"> 
                   <asp:Image ID="img1" runat="server" ImageUrl="~/Images/3.png" Width="200px" />
                    <br />
                    Do you have a big family or enjoy hosting guests? If so, our Luxury homes are perfect for you! Our luxury homes range from _ to _ and have</td>
                <td style="width: 624px"> 
                     <asp:Image ID="img2" runat="server" ImageUrl="~/Images/7.png" Width="200px" />
                    <br />
                    blahhh 
                </td>
                
                 
                <td style="width: 678px"> 
                    <asp:Image ID="img3" runat="server" ImageUrl="~/Images/6.png" Width="200px" />
                       <br />
                    blahhh
                </td>
            </tr>
           
        </table>


    <br />
    <asp:Button ID="btnBegin" runat="server"  Font-Names="Corbel" Text="Start building your new home!" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
    <br />
          <br />
<asp:Label runat="server" Text="You must enter a budget first." ID="lblbudgetvalidation" Font-Bold="True" Font-Size="X-Large"></asp:Label>
</div>
</asp:Content>

