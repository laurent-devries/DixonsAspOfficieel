<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/WebshopMasterpage.Master" CodeBehind="Winkelwagen.aspx.cs" Inherits="Dixons_ASP.NET_LDV.Pages.Winkelwagen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <h2>Winkelwagen</h2>
    <div class="wrapper">
        <div class="container">
            <div class="row">
                <form class="form-control" runat="server">
                    <asp:Table ID="Table1"
                        GridLines="Both"
                        HorizontalAlign="Left"
                        CellPadding="15"
                        CellSpacing="0"
                        runat="server" />
                    <asp:Button ID="btnBestel" CssClass="btn btn-default" Text="Bestel" runat="server" OnClick="btnBestel_OnClick" />
                </form>
            </div>
        </div>
    </div>
</asp:Content>

