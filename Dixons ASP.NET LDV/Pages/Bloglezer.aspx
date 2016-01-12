<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Bloglezer.aspx.cs" Inherits="Dixons_ASP.NET_LDV.Pages.Bloglezer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <form class="form-horizontal" role="form" runat="server">
            <div class="col-md-6">
                <asp:Image ID="imgImage" CssClass="blogPaginablogImage" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblTitle" CssClass="blogPaginablogTitel" runat="server"></asp:Label>
                <hr/>
                <asp:Label ID="lblText" CssClass="blogPaginablogText" runat="server"></asp:Label>
                <asp:Label ID="lblDatum" CssClass="blogPaginablogDatum" runat="server"></asp:Label>
            </div>
            <div class="col-md-offset-7">
                
            </div>
        </form>
    </div>
</asp:Content>
