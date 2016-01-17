using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV.Pages
{
    public partial class BlogToevoegen : System.Web.UI.Page
    {
        private Administratie administratie;
        protected void Page_Load(object sender, EventArgs e)
        {
            administratie = new Administratie();

            if (!Page.IsPostBack)
            {
                administratie = new Administratie();
                LoadAlleCategorien();
            }
            else
            {
                administratie = new Administratie();
            }
        }
        private void LoadAlleCategorien()
        {
            List<Categorie> parentCategorien = administratie.LaadParentCategories();

            ddlCategorien.DataSource = parentCategorien;
            ddlCategorien.DataBind();
        }

        private void LoadAlleSubCategorien(int parentId)
        {
            List<Categorie> childCategorien = administratie.LaadSubCategories(parentId);

            ddlSubCategorien.DataSource = childCategorien;
            ddlSubCategorien.DataBind();
        }

        private void LoadAlleSecondSubCategorien(int parentId)
        {
            List<Categorie> subChildCategorien = administratie.LaadSubSubCategories(parentId);

            ddlSecondSubCategorien.DataSource = subChildCategorien;
            ddlSecondSubCategorien.DataBind();
        }

        protected void ddlCategorien_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAlleSubCategorien(administratie.FindCategorieFromList(ddlCategorien.Text, administratie.LaadParentCategories()));
        }

        protected void ddlSubCategorien_OnSelectedIndexChanged(object sender, EventArgs e)
        {
        LoadAlleSecondSubCategorien(administratie.FindCategorieFromList(ddlSubCategorien.Text, administratie.LaadSubCategories(administratie.FindCategorieFromList(ddlCategorien.Text, administratie.LaadParentCategories()))));
        }

        protected void ddlSecondSubCategorien_OnSelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void LoadListbox()
        {
            string selected = ddlCategorien.SelectedItem.Text;
            int parentId = 0;

            List<Categorie> parentCategorien = administratie.LaadParentCategories();
            List<Categorie> childCategorien = new List<Categorie>();
            List<Categorie> subChildCategorien = new List<Categorie>();

            foreach (Categorie c in parentCategorien)
            {
                if (c.CategorieNaam == selected)
                {
                    int catId = c.CategorieId;
                    childCategorien = administratie.LaadSubCategories(catId);
                }
            }

            selected = ddlSubCategorien.SelectedItem.Text;

            foreach (Categorie c in childCategorien)
            {
                if (c.CategorieNaam == selected)
                {
                    parentId = c.CategorieId;
                    subChildCategorien = administratie.LaadSubSubCategories(parentId);
                }
            }
        }

        protected void OnClick(object sender, EventArgs e)
        {
            string titel = tbxTitel.Text;
            DateTime vandaag = DateTime.Now;
            string tekst = tbxTekst.Text;
            string afbeeldingpath = tbxAfbeeldingpath.Text;

            List<Categorie> parentCategorien = administratie.LaadParentCategories();
            List<Categorie> childCategorien = new List<Categorie>();
            List<Categorie> subChildCategorien = new List<Categorie>();
            string selected = ddlCategorien.SelectedItem.Text;

            foreach (Categorie c in parentCategorien)
            {
                if (c.CategorieNaam == selected)
                {
                    int catId = c.CategorieId;
                    childCategorien = administratie.LaadSubCategories(catId);
                }
            }

            selected = ddlSubCategorien.SelectedItem.Text;
            int parentId;
            foreach (Categorie c in childCategorien)
            {
                if (c.CategorieNaam == selected)
                {
                    parentId = c.CategorieId;
                    subChildCategorien = administratie.LaadSubSubCategories(parentId);
                }
            }

            string catNaam = ddlSecondSubCategorien.Text;
            try
            {
                foreach (Categorie c in subChildCategorien)
                {
                    if (c.CategorieNaam == catNaam)
                    {
                        BlogBericht blogBericht = new BlogBericht(0, titel, vandaag, tekst, afbeeldingpath, c);
                        administratie.InsertBlogBericht(blogBericht);
                        Response.Redirect("Blog.aspx");
                    }
                }
            }
            catch (Exception)
            {
                
            }            
            

            
        }
    }
}