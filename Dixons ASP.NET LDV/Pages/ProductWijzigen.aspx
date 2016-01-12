<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ProductWijzigen.aspx.cs" Inherits="Dixons_ASP.NET_LDV.Pages.ProductWijzigen" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Product Toevoegen</h2>
    <div class="row">
        <div class="col-md-5">
            <form class="form-horizontal" role="form" runat="server">
                <div class="form-group">
                    <label class="control-label col-sm-4" for="email">Naam:</label>
                    <div class="col-sm-8">
                        <asp:TextBox type="text" CssClass="form-control" ID="tbxNaam" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="pwd">Categorie:</label>
                    <div class="col-sm-8">
                        <asp:DropDownList CssClass="form-control" ID="ddlCategorien" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategorien_OnSelectedIndexChanged"/>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="pwd">Subcategorie:</label>
                    <div class="col-sm-8">
                        <asp:DropDownList CssClass="form-control" ID="ddlSubCategorien" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSubCategorien_OnSelectedIndexChanged"/>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="pwd">2e Subcategorie:</label>
                    <div class="col-sm-8">
                        <asp:DropDownList CssClass="form-control" ID="ddlSecondSubCategorien" runat="server" AutoPostBack="True"/>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4">Prijs:</label>
                    <div class="col-sm-8">
                        <asp:TextBox type="number" CssClass="form-control" ID="tbxPrijs" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4">Beschrijving:</label>
                    <div class="col-sm-8">
                        <asp:TextBox style="height: 200px; resize: none;}" TextMode="MultiLine" type="text" CssClass="form-control" ID="tbxBeschrijving" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4">Bezorgtijd</label>
                    <div class="col-sm-8">
                        <asp:DropDownList CssClass="form-control" ID="ddlBezorgtijd" runat="server"/>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4">Afbeelding:</label>
                    <div class="col-sm-8">
                        <asp:TextBox type="text" CssClass="form-control" ID="tbxAfbeeldingpath" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-4 col-sm-10">
                        <asp:Button type="submit" CssClass="btn btn-default" runat="server" Text="Bevestigen" OnClick="OnClick" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
