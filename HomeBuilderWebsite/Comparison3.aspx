<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Comparison3.aspx.vb" Inherits="Comparison3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="font-size: x-large; text-align: center;">
    
        <br />
        <span style="font-size: xx-large"><strong>Congratulations on Selecting Your New Home!<br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" align="center" CellPadding="4" ForeColor="#333333" GridLines="None" Height="50px" Width="330px" Font-Size="Large">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
                    </strong></span><br />
        </div>
</asp:Content>

