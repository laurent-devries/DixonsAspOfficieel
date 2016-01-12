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
    public partial class Winkelwagen : System.Web.UI.Page
    {
        private Administratie administratie;

        protected void Page_Load(object sender, EventArgs e)
        {
            administratie = new Administratie();
            ArrayList allAddedProducts = (ArrayList) Session["Cart"];
            List<Product> products = new List<Product>(allAddedProducts.Count);

            foreach (int i in allAddedProducts)
            {
                products.Add(administratie.GetProduct(i));
            }
            //TODO products[] niet hardcoded
            int numrows = allAddedProducts.Count;
            int numcells = 1;
            for (int j = 0; j < numrows; j++)
            {
                TableRow r = new TableRow();
                for (int i = 0; i < numcells; i++)
                {
                    TableCell c = new TableCell();
                    TableCell d = new TableCell();
                    c.Controls.Add(new LiteralControl(products[0].Naam));
                    d.Controls.Add(new LiteralControl(products[0].Prijs.ToString()));
                    r.Cells.Add(c);
                    r.Cells.Add(d);
                }
                Table1.Rows.Add(r);
            }


            
        }

    }
}