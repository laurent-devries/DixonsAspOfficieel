<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/WebshopMasterpage.master" CodeBehind="CategoriePage.aspx.cs" Inherits="Dixons_ASP.NET_LDV.Pages.CategoriePage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">
            <div class="container">
                <div class="row">
                    <div class="col-md-3" id="leftCol">
                        <div class="well">
                            <ul class="nav nav-stacked" id="sidebar">
                                <asp:ListBox CssClass="list-group"  ID="lbCategorien" runat="server" AutoPostBack="False">
                                    <asp:ListItem Text="Test1" />
                                    <asp:ListItem Text="Test2" /> 
                                </asp:ListBox>
                                <asp:Button ID="btnBevestigCategorie" Text="Ga naar categorie" runat="server" OnClick="btnBevestigCategorie_OnClick"/>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-9">
                        <a href="http://www.surface.com">
                            <img src="/Images/windowsad.jpg" alt="image" style="width: 100%; height: 150px"/>
                        </a>
                        <hr/>
                        <div class="row">
                            <asp:Panel ID="pnlProducts" runat="server"></asp:Panel>
                            <div class="container">
                                <div style="clear: both"></div>
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
        </form>
</asp:Content>
