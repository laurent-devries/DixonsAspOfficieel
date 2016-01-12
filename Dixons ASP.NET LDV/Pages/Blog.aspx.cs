using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV.Pages
{
    public partial class Blog : System.Web.UI.Page
    {
        private Administratie _administratie;
        protected void Page_Load(object sender, EventArgs e)
        {
            _administratie = new Administratie();
            List<BlogBericht> blogs = _administratie.GetAllBlogBerichts();

            if (blogs != null)
            {
                foreach (BlogBericht b in blogs)
                {
                    Panel blogPanel = new Panel
                    {
                        CssClass = "blogberichtBlogPanel"
                    };

                    ImageButton imageButton = new ImageButton
                    {
                        ImageUrl = "~/Images/Blog/" + b.AfbeeldingPath,
                        CssClass = "blogberichtImage",
                        PostBackUrl = string.Format("~/Pages/Bloglezer.aspx?id={0}", b.BlogBerichtId)
                    };
                    Label lblName = new Label
                    {
                        Text = b.Titel,
                        CssClass = "blogberichtTitel"
                    };
                    Label lblTekst = new Label
                    {
                        Text = b.Tekst,
                        CssClass = "blogberichtTekst"
                    };

                    blogPanel.Controls.Add(imageButton);
                    blogPanel.Controls.Add(new Literal { Text = "<br/>" });
                    blogPanel.Controls.Add(lblName);
                    blogPanel.Controls.Add(new Literal { Text = "<br/>" });
                    blogPanel.Controls.Add(lblTekst);

                    pnlBlogs.Controls.Add(blogPanel);
                }
            }
            else pnlBlogs.Controls.Add(new Literal { Text = "no products found!" });
        }
    }
}