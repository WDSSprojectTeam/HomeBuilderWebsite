<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="EditFeature.aspx.vb" Inherits="EditFeature" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <br />
        <asp:Label ID="lblFeatureName" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    </p>
    <asp:Panel ID="Panel3" runat="server">
        <asp:RadioButton ID="rdb1" runat="server" Autopostback =" false" GroupName="1" Visible="False"/>
        <br />
        <asp:RadioButton ID="rdb2" runat="server" Autopostback=" false" GroupName="1" Visible="False" />
        <br />
        <asp:RadioButton ID="rdb3" runat="server" Autopostback=" false" GroupName="1" Visible="False" />
        <br />
        <asp:RadioButton ID="rdb4" runat="server" Autopostback=" false" GroupName="1" Visible="False" />
        <br />
        <asp:RadioButton ID="rdb5" runat="server" Autopostback=" false" GroupName="1" Visible="False" />
    </asp:Panel>
    <p>
        &nbsp;</p>
    <p>
    <asp:Button ID="bntBack" runat="server" Text="Back to Home Scenario" />
    </p>
</asp:Content>

