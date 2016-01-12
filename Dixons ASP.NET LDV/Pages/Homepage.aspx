﻿<%@ Page Title="Homepage" Language="C#" MasterPageFile="~/WebshopMasterpage.master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Dixons_ASP.NET_LDV.Homepage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">
            <div class="container">
                <div class="row">
                    <asp:Label id="lblIngelogd" runat="server"></asp:Label>
                    <div class="col-md-3" id="leftCol">
                        <div class="well">
                            <ul class="nav nav-stacked" id="sidebar">
                                <asp:ListBox CssClass="list-group"  ID="lbCategorien" runat="server">
                                    <asp:ListItem Text="Test1" />
                                    <asp:ListItem Text="Test2" />
                                </asp:ListBox>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-9">
                        <img src="/Images/20140427_094410.jpg" alt="niks" style="width: 100%; height: 120px"/>
                        <hr/>
                        <div class="row">
                            <div class="col-md-3">
                                <img src="//placehold.it/300x300" class="img-responsive">
                                <asp:Label CssClass="homepageCatTitle" ID="firstCategorieTitel" runat="server">First category</asp:Label>
                                <asp:ListBox CssClass="list-group" ID="lbSubCats1" runat="server"/>
                            </div>
                            <div class="col-md-3">
                                <img src="//placehold.it/300x300" class="img-responsive">
                                <asp:Label CssClass="homepageCatTitle" ID="secondCategorieTitel" runat="server">Second category</asp:Label>
                                <asp:ListBox CssClass="list-group" ID="lbSubCats2" runat="server"/>
                            </div>
                            <div class="col-md-3">
                                <img src="//placehold.it/300x300" class="img-responsive">
                                <asp:Label CssClass="homepageCatTitle" ID="thirdCategorieTitel" runat="server">Third category</asp:Label>
                                <asp:ListBox CssClass="list-group" ID="lbSubCats3" runat="server"/>
                            </div>
                            <div class="col-md-3">
                                <img src="//placehold.it/300x300" class="img-responsive">
                                <asp:Label CssClass="homepageCatTitle" ID="fourthCategorieTitel" runat="server">Fourth category</asp:Label>
                                <asp:ListBox CssClass="list-group" ID="lbSubCats4" runat="server"/>
                            </div>
                        </div>
                        <hr/>
                        <div class="col-md-4">
                            <img src="//placehold.it/300x300" class="img-responsive">
                            <asp:Label CssClass="homepageCatTitle" ID="Label1" runat="server">First product</asp:Label>
                        </div>
                        <div class="col-md-4">
                            <img src="//placehold.it/300x300" class="img-responsive">
                            <asp:Label CssClass="homepageCatTitle" ID="Label2" runat="server">Second product</asp:Label>
                        </div>
                        <div class="col-md-4">
                            <img src="//placehold.it/300x300" class="img-responsive">
                            <asp:Label CssClass="homepageCatTitle" ID="Label3" runat="server">Third product</asp:Label>
                        </div>
                        <h2 id="sec0">Content</h2>
                        At Bootply we like to build simple Bootstrap templates that utilize the code Bootstap CSS without a lot of customization. Sure you can 
              	find a lot of Bootstrap themes and inspiration, but these templates tend to be heavy on customization.
                        <hr class="col-md-12">Rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae 
                dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia cor magni dolores 
                eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, 
                sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. 
                Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut.              
              	Rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae 
                dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia cor magni dolores 
                eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, 
                sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. 
                Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut!
                        <h2 id="sec1">Content</h2>
                        <p>
                            Rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae 
                dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut.
                        </p>
                        <div class="row">
                            <div class="col-md-6">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3>Hello.</h3>
                                    </div>
                                    <div class="panel-body">
                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis pharetra varius quam sit amet vulputate. 
                      Quisque mauris augue, molestie tincidunt condimentum vitae, gravida a libero. Aenean sit amet felis 
                      dolor, in sagittis nisi. Sed ac orci quis tortor imperdiet venenatis. Duis elementum auctor accumsan. 
                      Aliquam in felis sit amet augue.
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h3>Hello.</h3>
                                    </div>
                                    <div class="panel-body">
                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis pharetra varius quam sit amet vulputate. 
                      Quisque mauris augue, molestie tincidunt condimentum vitae, gravida a libero. Aenean sit amet felis 
                      dolor, in sagittis nisi. Sed ac orci quis tortor imperdiet venenatis. Duis elementum auctor accumsan. 
                      Aliquam in felis sit amet augue.
                                    </div>
                                </div>
                            </div>
                        </div>
                        <hr>
                        <h2 id="sec2">Section 2</h2>
                        <p>
                            Rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae 
                dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia cor magni dolores 
                eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, 
                sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. 
                Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut!
                        </p>
                        <hr>
                        <h2 id="sec3">Section 3</h2>
                        Images are responsive sed @mdo but sum are more fun peratis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, 
                totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae 
                dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia cor magni dolores 
                eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, 
                sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. 
                Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut..
                        <br>Fos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, 
                sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. 
                Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut..
                        <h2 id="sec4">Section 4</h2>
                        Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, 
                totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae 
                dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia cor magni dolores 
                eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, 
                sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. 
                Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut
                        <hr>
                        <h4><a href="http://bootply.com/100993">Edit on Bootply</a></h4>
                        <hr>
                    </div>
                </div>
            </div>
        </form>
</asp:Content>
