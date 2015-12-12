<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" MaintainScrollPositionOnPostback="true" CodeFile="Instructions_BuildNewHome.aspx.vb" Inherits="Instructions_BuildNewHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
      <div style="text-align:center; font-size: large;" >
     <h2>Tell us a little bit about yourself so we can help you find the perfect home!</h2>

    <p>
    <h3>1) How much would you like to spend?</h3>
          $<asp:TextBox ID="tbxBudget" runat="server"></asp:TextBox>
        <br />
            Dreamcather Custom Homes suggests you allocate between $50K to $150K for your features to produce meaningful results.
        <br />
        Our base homes range from $200K to $900K.

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
                    <meta charset="utf-8" />
                    <span id="docs-internal-guid-64ebf0f6-9426-de36-b389-3a27bced7002" style="font-size:14.666666666666666px;font-family:Arial;color:#000000;background-color:transparent;font-weight:400;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;">Do you have a big family or enjoy hosting guests? If so, our Luxury homes are perfect for you! You can count on our luxury homes having elite amenities for your pleasure.</span></td>
                <td style="width: 624px"> 
                     <asp:Image ID="img2" runat="server" ImageUrl="~/Images/7.png" Width="200px" />
                    <br />
                     <meta charset="utf-8" />
                     <span id="docs-internal-guid-64ebf0f6-9427-ae66-cc4d-46709eeb7509" style="font-size:14.666666666666666px;font-family:Arial;color:#000000;background-color:transparent;font-weight:400;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;">If you’re looking for a reliable home for your family’s needs, these are the plans for you! With space, quality and durability, you can ensure a safe environment for your family.</span></td>
                
                 
                <td style="width: 678px"> 
                    <asp:Image ID="img3" runat="server" ImageUrl="~/Images/6.png" Width="200px" />
                       <br />
                    <meta charset="utf-8" />
                    <span id="docs-internal-guid-64ebf0f6-9427-c309-05b7-a93888706103" style="font-size:14.666666666666666px;font-family:Arial;color:#000000;background-color:transparent;font-weight:400;font-style:normal;font-variant:normal;text-decoration:none;vertical-align:baseline;">Whether you’ve started a family or have no plans to grow, these homes are for you! With their unique designs, intrigue is ensured.<br />
                    </span>
                </td>
            </tr>
           
        </table>


    <br />
          <table style="margin:0px auto; width: 891px;">
             <tr>
                 <td>
                     <asp:Button ID="btnBack" runat="server"  Font-Names="Corbel" Text="Back" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
                 </td>
                 <td>
<asp:Button ID="btnBegin" runat="server"  Font-Names="Corbel" Text="Start building your new home!" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
                 </td>
             </tr>
         </table>
    
    <br />
          <br />
<asp:Label runat="server" Text="You must enter a budget first." ID="lblbudgetvalidation" Font-Bold="True" Font-Size="X-Large"></asp:Label>
</div>
</asp:Content>

