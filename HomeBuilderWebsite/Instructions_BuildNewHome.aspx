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
                <td>
                    <h3>Home Styles </h3>
                    </td>
                <td>
                    <h4>  Is this Style for me?...</h4>
                   

                </td>
               
            </tr>
            
            <tr>
                <td> <asp:RadioButton ID="rdbluxury" runat="server" Text="Luxury Home" /></td>
                <td> Do you have a big family or enjoy hosting guests? If so, our Luxury homes are perfect for you! Our luxury homes range from _ to _ and have  </td>
            </tr>
            <tr>
                <td> <asp:RadioButton ID="rdbfamily" runat="server" Text="Family Home" /></td>
                <td> blahhh </td>
            </tr>
            <tr>
                <td> <asp:RadioButton ID="rdbstarter" runat="server" Text="Starter Home" /></td>
                <td> blahhh </td>
            </tr>

        </table>

</div>
    <asp:Button ID="btnBegin" runat="server" Text="Start building your new home!" />


</asp:Content>

