using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV
{
    public partial class Homepage : System.Web.UI.Page
    {
        private Administratie administratie;
        protected void Page_Load(object sender, EventArgs e)
        {
            administratie = new Administratie();
            

            if (Session["email"] != null)
            {
                lblIngelogd.Text = "Ingelogd als: " + Session["email"].ToString();
            }

            foreach (Categorie c in administratie.LaadSubCategories(1))
            {
                lbSubCats1.Items.Add(c.ToString());
            }
            foreach (Categorie c in administratie.LaadSubCategories(2))
            {
                lbSubCats2.Items.Add(c.ToString());
            }
            foreach (Categorie c in administratie.LaadSubCategories(3))
            {
                lbSubCats3.Items.Add(c.ToString());
            }
            foreach (Categorie c in administratie.LaadSubCategories(4))
            {
                lbSubCats4.Items.Add(c.ToString());
            }
        }
    }
}