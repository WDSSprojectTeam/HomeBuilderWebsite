<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Home.aspx.vb" Inherits="Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <div style="text-align:center" >
    <h1>
       WELCOME!
   </h1>

    <h3>Where would you like to start?</h3>
    
   <asp:Button ID="btnBuildHome" runat="server"  Font-Names="Corbel" Text="Build My New Home" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
    

     <br />
  <br />
     
    <asp:Button ID="btnLoadScenario" runat="server"  Font-Names="Corbel" Text="Compare My Saved Homes" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
         
      
      <br />
                <br />
          <asp:Button ID="btnEditTemplate" runat="server"  Font-Names="Corbel" Text="Start From A Template" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
         
            <br />
       
    
    
        <br />
    </section>

    &nbsp
          </div>

    </asp:Content>

