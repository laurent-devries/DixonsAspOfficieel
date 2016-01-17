using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV.Pages
{
    public partial class BlogVerwijderen : System.Web.UI.Page
    {
        private Administratie administratie;
        protected void Page_Load(object sender, EventArgs e)
        {
            administratie = new Administratie();
            if (!Page.IsPostBack)
            {
                reloadBlogBerichtList();   
            }
            
        }

        protected void OnClick(object sender, EventArgs e)
        {
            if (lbBlogs.SelectedItem != null)
            {
                foreach (BlogBericht blogBericht in administratie.GetAllBlogBerichts())
                {
                    if (blogBericht.Titel == lbBlogs.SelectedItem.Text)
                    {
                        administratie.DeleteBlogBericht(blogBericht);
                        reloadBlogBerichtList();
                    }
                }
            }
        }

        public void reloadBlogBerichtList()
        {
            List<BlogBericht> blogberichten = administratie.GetAllBlogBerichts();
            lbBlogs.DataSource = blogberichten;
            lbBlogs.DataBind();
        }
    }
}