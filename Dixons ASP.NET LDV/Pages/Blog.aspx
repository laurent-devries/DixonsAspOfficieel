<%@ Page Language="C#" Title="Blog" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="Dixons_ASP.NET_LDV.Pages.Blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <div class="container">
            <%--Een panel om de blogs in te laden--%>
            <asp:Panel ID="pnlBlogs" runat="server"></asp:Panel>
            <div class="container">
                <div style="clear: both"></div>
            </div>
        </div>
    </form>
</asp:Content>
