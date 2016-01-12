using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV.Pages
{
    public partial class ProductPage : System.Web.UI.Page
    {
        private Administratie administratie;
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            administratie = new Administratie();
            

            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                Product product = administratie.GetProduct(id);

                //Fill page with data
                lblTitle.Text = product.Naam;
                lblDescription.Text = product.Beschrijving;
                lblPrice.Text = "€" + product.Prijs;

                imgProduct.ImageUrl = "~/Images/Products/" + product.AfbeeldingPath;
                
            }

        }

        protected void btnBestel_OnClick(object sender, EventArgs e)
        {
            ArrayList winkelwagen = new ArrayList();
            if (Session["Cart"] != null)
            {
                winkelwagen = (ArrayList)Session["Cart"];
            }
            winkelwagen.Add(id);
            Session["Cart"] = winkelwagen;
        }
    }
}