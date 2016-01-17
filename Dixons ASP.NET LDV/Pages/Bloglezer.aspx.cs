using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV.Pages
{
    public partial class Bloglezer : System.Web.UI.Page
    {
        private Administratie administratie;
        protected void Page_Load(object sender, EventArgs e)
        {
            administratie = new Administratie();

            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                BlogBericht blogBericht = administratie.GetBlogberichtFromId(id);

                

                //Fill page with data
                lblTitle.Text = blogBericht.Titel;
                lblText.Text = blogBericht.Tekst;
                lblDatum.Text = blogBericht.Datum.ToString();
                imgImage.ImageUrl = "~/Images/Blog/" + blogBericht.AfbeeldingPath;
            }
        }
    }
}