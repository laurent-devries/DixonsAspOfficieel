<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/WebshopMasterpage.master" CodeBehind="ProductPage.aspx.cs" Inherits="Dixons_ASP.NET_LDV.Pages.ProductPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="row">
        <form class="form-horizontal" role="form" runat="server">
            <div class="col-md-6">
                <asp:Image ID="imgProduct" CssClass="productPaginaImage" runat="server" />
            </div>
            <div class="col-md-6">
                <asp:Label ID="lblTitle" CssClass="productPaginaTitel" runat="server"></asp:Label>
                <hr/>
                <asp:Label ID="lblDescription" CssClass="productPaginaDescription" runat="server"></asp:Label>
                <hr/>
                <asp:Label ID="lblPrice" CssClass="productPaginaPrijs" runat="server"></asp:Label>
                <asp:Button id="btnBestel" Text="Voeg toe aan Winkelmand" CssClass="productPaginaBestelButton" runat="server" OnClick="btnBestel_OnClick" />
            </div>
            <div class="col-md-offset-7">
            </div>
        </form>
    </div>
</asp:Content>
