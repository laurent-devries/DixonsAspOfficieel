using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV
{
    public partial class Laptop : System.Web.UI.Page
    {
        private Administratie administratie;
        protected void Page_Load(object sender, EventArgs e)
        {
            administratie = new Administratie();
            List<Product> products = administratie.GetAlleProducten();

            if (products != null)
            {
                foreach (Product p in products)
                {
                    Panel productPanel = new Panel
                    {
                        CssClass = "productPaginaProductPanel"
                    };
                    ImageButton imageButton = new ImageButton
                    {
                        ImageUrl = "~/Images/Products/" + p.AfbeeldingPath,
                        CssClass = "productImage",
                        PostBackUrl = string.Format("~/Pages/ProductPage.aspx?id={0}", p.ProductId)
                    };
                    Label lblName = new Label
                    {
                        Text = p.Naam,
                        CssClass = "productname"
                    };
                    Label lblPrice = new Label
                    {
                        Text = "$" + p.Prijs,
                        CssClass = "productPrice"
                    };

                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal {Text = "<br/>"});
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal {Text = "<br/>"});
                    productPanel.Controls.Add(lblPrice);

                    pnlProducts.Controls.Add(productPanel);
                }
            }
            else pnlProducts.Controls.Add(new Literal {Text = "no products found!"});
        }
    }
}