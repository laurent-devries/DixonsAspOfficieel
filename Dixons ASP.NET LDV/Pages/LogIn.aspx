<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LogIn.aspx.cs" Inherits="Dixons_ASP.NET_LDV.Pages.LogIn" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <%--Op deze pagina kan er met bestaande gegevens ingelogd worden--%>
        <label>Email</label>
        <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox>
        <label>Wachtwoord</label>
        <asp:TextBox runat="server" ID="tbxWachtwoord"></asp:TextBox>
        <asp:Button id="btnBevestig" type="submit" Text="Log In" runat="server" OnClick="btnBevestig_OnClick"/>
    </form>
</asp:Content>