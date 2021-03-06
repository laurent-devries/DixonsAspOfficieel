﻿using System;
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
        private List<Product> products;
        protected void Page_Load(object sender, EventArgs e)
        {
            administratie = new Administratie();
            ArrayList allAddedProducts = (ArrayList)Session["Cart"];
            if (allAddedProducts != null)
            {
                products = new List<Product>(allAddedProducts.Count);

                foreach (int i in allAddedProducts)
                {
                    products.Add(administratie.GetProduct(i));
                }


                int numrows = allAddedProducts.Count;
                int numcells = 1;
                for (int j = 0; j < numrows; j++)
                {
                    TableRow r = new TableRow();
                    for (int i = 0; i < numcells; i++)
                    {
                        TableCell c = new TableCell();
                        TableCell d = new TableCell();
                        c.Controls.Add(new LiteralControl(products[j].Naam));
                        d.Controls.Add(new LiteralControl(products[j].Prijs.ToString()));
                        r.Cells.Add(c);
                        r.Cells.Add(d);
                    }
                    Table1.Rows.Add(r);
                }

                decimal totaalPrijs = 0;
                foreach (Product p in products)
                {
                    totaalPrijs += p.Prijs;
                }
                TableRow totaalPrijsRow = new TableRow();
                TableCell t = new TableCell();
                TableCell prijs = new TableCell();
                t.Controls.Add(new LiteralControl("Totaalprijs"));
                prijs.Controls.Add(new LiteralControl(totaalPrijs.ToString()));
                totaalPrijsRow.Cells.Add(t);
                totaalPrijsRow.Cells.Add(prijs);
                Table1.Rows.Add(totaalPrijsRow);

            }
        }

        protected void btnBestel_OnClick(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                int currentAccountId = administratie.FindParticulier(Session["email"].ToString(), Session["wachtwoord"].ToString());
                Particulier particulier = administratie.getParticulierFromId(currentAccountId);
                DateTime datum = DateTime.Now;
                List<Exemplaar> exemplarenList = new List<Exemplaar>();

                foreach (Product p in products)
                {
                    int nummer = administratie.selectLastExemplaar() + 1;
                    Exemplaar exemplaar = new Exemplaar(nummer, p.Prijs, p);
                    administratie.InsertExemplaar(exemplaar, null);
                    exemplarenList.Add(exemplaar);
                }


                Adres adres = new Adres(1, "6961PL", 3, "Zonnedauw", "Eerbeek");
                Adres adres2 = new Adres(2, "5612BT", 2, "Visserstraat", "Eindhoven");

                Order order = new Order(0, particulier, datum, exemplarenList, adres, adres2);
                administratie.InsertOrder(order);
                int orderId = administratie.lastOrderId();

                foreach (Exemplaar exemplaar in exemplarenList)
                {
                    administratie.UpdateExemplaarOrderId(exemplaar.Serienummer, orderId);
                    Response.Redirect("Homepage.aspx");
                }

            }



        }
    }
}