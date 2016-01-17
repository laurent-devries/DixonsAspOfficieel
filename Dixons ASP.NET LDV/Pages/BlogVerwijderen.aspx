<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="BlogVerwijderen.aspx.cs" Inherits="Dixons_ASP.NET_LDV.Pages.BlogVerwijderen" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Blog Verwijderen</h2>
    <div class="row">
        <div class="col-md-5">
            <form class="form-horizontal" role="form" runat="server">
                <div class="form-group">
                    <label class="control-label col-sm-4" for="pwd">Blogs:</label>
                    <div class="col-sm-8">
                        <asp:ListBox CssClass="list-group" ID="lbBlogs" runat="server" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-4 col-sm-10">
                        <asp:Button type="submit" CssClass="btn btn-default" runat="server" Text="Verwijder" OnClick="OnClick" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
