<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Winkelwagen.aspx.cs" Inherits="Dixons_ASP.NET_LDV.Pages.Winkelwagen" %>

<asp:content id="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <h2>Winkelwagen</h2>
    <div class="container">
    <form class="form-control" runat="server">
        <asp:Table id="Table1" 
        GridLines="Both" 
        HorizontalAlign="Center" 
        Font-Names="Verdana" 
        Font-Size="8pt" 
        CellPadding="15" 
        CellSpacing="0" 
        Runat="server"/>
        <asp:Button id="btnBestel" CssClass="btn btn-default" Text="Bestel" runat="server"/>
    </form>
   </div>
</asp:content>