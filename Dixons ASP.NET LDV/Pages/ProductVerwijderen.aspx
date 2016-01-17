<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ProductVerwijderen.aspx.cs" Inherits="Dixons_ASP.NET_LDV.Pages.ProductVerwijderen" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Product Verwijderen</h2>
    <div class="row">
        <div class="col-md-5">
            <form class="form-horizontal" role="form" runat="server">
                <div class="form-group">
                    <label class="control-label col-sm-4" for="pwd">Categorie:</label>
                    <div class="col-sm-8">
                        <asp:DropDownList CssClass="form-control" ID="ddlCategorien" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategorien_OnSelectedIndexChanged" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="pwd">Subcategorie:</label><a href="ProductVerwijderen.aspx">ProductVerwijderen.aspx</a>
                    <div class="col-sm-8">
                        <asp:DropDownList CssClass="form-control" ID="ddlSubCategorien" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSubCategorien_OnSelectedIndexChanged"/>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="pwd">2e Subcategorie:</label>
                    <div class="col-sm-8">
                        <asp:DropDownList CssClass="form-control" ID="ddlSecondSubCategorien" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSecondSubCategorien_OnSelectedIndexChanged"/>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="pwd">Producten:</label>
                    <div class="col-sm-8">
                        <asp:ListBox CssClass="list-group" ID="lbProducten" runat="server"/>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-4 col-sm-10">
                        <asp:Button type="submit" CssClass="btn btn-default" runat="server" Text="Verwijder" OnClick="OnClick"/>
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>