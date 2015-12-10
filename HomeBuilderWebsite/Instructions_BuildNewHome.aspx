<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Instructions_BuildNewHome.aspx.vb" Inherits="Instructions_BuildNewHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <h2>Tell us a little bit about yourself so we can help you find the perfect home!</h2>

    <p>
    
    <asp:Label ID="Label1" runat="server" Text="How much would you like to spend?">   </asp:Label>
    <asp:TextBox ID="tbxBudget" runat="server"></asp:TextBox>
            </p>

        <br />
     <div style="text-align:center" >
        <table border="1" >
            <tr>
                <td colspan="3">
                    <h3>Home Styles </h3>
                    </td>
                
               
            </tr>

            <tr>
                <td colspan="3">
                  
                    <asp:RadioButtonList ID="rdbhomestyle" runat="server" RepeatDirection="Horizontal" Width="813px">
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
                <td style="width: 634px"> Do you have a big family or enjoy hosting guests? If so, our Luxury homes are perfect for you! Our luxury homes range from _ to _ and have</td>
                <td style="width: 624px"> blahhh </td>
                <td style="width: 621px"> blahhh </td>
            </tr>
           
        </table>

</div>
    <asp:Button ID="btnBegin" runat="server" Text="Start building your new home!" />


</asp:Content>

