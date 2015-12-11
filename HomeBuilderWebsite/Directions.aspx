<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Directions.aspx.vb" Inherits="Directions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

     <div style="text-align:center" >

    <h1>Building a custom home with us is as easy as 1, 2, 3 ...</h1>

         <table style="margin:0px auto; width: 500px;">
            <tr>
                <td style="width: 81px">Step 1 </td>
                <td>step 1 directions</td>
                
            </tr>
            
            <tr>
                <td style="width: 81px"> Step 2</td>
                <td> step 2 directions </td>
            </tr>

             <tr>
                <td style="width: 81px"> Step 3</td>
                <td> step 3 directions </td>
            </tr>

        </table>

         <asp:button runat="server" text="Start To Build My Home!" ID="btnnext" />

         </div>

</asp:Content>

