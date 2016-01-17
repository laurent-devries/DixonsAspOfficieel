using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV.Pages
{
    public partial class CategoriePage : System.Web.UI.Page
    {
        private Administratie administratie;
        protected void Page_Load(object sender, EventArgs e)
        {
            administratie = new Administratie();
            int categorieId;
            List<Product> productenVanCategorie = new List<Product>();
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                categorieId = Convert.ToInt32(Request.QueryString["id"]);
                List<Categorie> alleSubCategories = administratie.LaadSubCategories(categorieId);

                foreach (Categorie c in alleSubCategories)
                {
                    foreach (Categorie c2 in administratie.LaadSubSubCategories(c.CategorieId))
                    {
                        foreach (Product p in administratie.GetProductenPerCategorie(c2.CategorieId))
                        {
                            productenVanCategorie.Add(p);
                        }
                    }
                }

            }


            if (productenVanCategorie != null)
            {
                foreach (Product p in productenVanCategorie)
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
                    productPanel.Controls.Add(new Literal { Text = "<br/>" });
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br/>" });
                    productPanel.Controls.Add(lblPrice);

                    pnlProducts.Controls.Add(productPanel);
                }
            }
            else pnlProducts.Controls.Add(new Literal { Text = "no products found!" });
        }
    }
}
