<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="EditOptResults.aspx.vb" Inherits="EditOptResults" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        Choose which feature you would like to edit, or press save to save this home!<br />
    </p>
    <p>
        <asp:GridView ID="gvwEdit" runat="server">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="btnSave" runat="server" Text="Save" />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

