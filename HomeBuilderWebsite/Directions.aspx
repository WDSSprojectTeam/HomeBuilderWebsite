<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Directions.aspx.vb" Inherits="Directions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

      <div style="text-align:center" >

    <h1>Building a custom home with us in just a few steps...</h1>



     <div style="text-align:left" >
         <table style="margin:0px auto; width: 702px; font-family: Corbel; font-size: large;">
            <tr>
                <td style="width: 81px">
                     <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/num1.png" Width="50px" />
                </td>
                <td>Choose a base home layout that fits your needs!</td>
                
            </tr>
             <tr>
                <td> </td>
       
                <td> </td>
            </tr>
              <tr>
                <td style="width: 81px">
                     <asp:Image ID="img2" runat="server" ImageUrl="~/Images/num2.png" Width="50px" />
                </td>
                <td>Tell us what areas of&nbsp;the house are most important to you! (get rid of this)</td>
                
            </tr>
             <tr>
                <td> </td>
       
                <td> </td>
            </tr>
            
            <tr>
                <td style="width: 81px; height: 23px;">
                     <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Num3.png" Width="50px" />
                </td>
                <td style="height: 23px"> Rate the upgrades we offer to let us know what you like!</td>
            </tr>
             <tr>
                <td> </td>
       
                <td> </td>
            </tr>
             <tr>
                <td style="width: 81px">  <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/Num4.png" Width="50px" /></td>
                <td> View our suggestions on how to best spend your money and edit details to make your perfect home!</td>
            </tr>
</table>
         </div>
         <br />
        
     <div style="text-align:center" >
         <table  style="margin:0px auto; width: 812px; font-family: Corbel; font-size: large;">
             <tr>
                <td colspan="2" style="font-size: x-large"> After you&#39;ve built a custom home you can save it to compare your favorites and choose your future home!</td>
      
            </tr>
        </table>
         <br />
    <asp:Button ID="btnback" runat="server"  Font-Names="Corbel" Text="Back" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
    <asp:Button ID="btnnext" runat="server"  Font-Names="Corbel" Text="Let's Get Started!" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />

         </div>

         
     

</asp:Content>

