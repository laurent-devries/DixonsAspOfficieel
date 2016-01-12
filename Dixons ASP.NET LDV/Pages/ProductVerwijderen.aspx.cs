using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV.Pages
{
    public partial class ProductVerwijderen : System.Web.UI.Page
    {
        private Database.Database db;
        private Administratie administratie = new Administratie();
        public int idSubCat;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                db = new Database.Database();
                LoadAlleCategorien();
            }
            else
            {
                db = new Database.Database();
            }
        }

        protected void ddlCategorien_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAlleSubCategorien(administratie.FindCategorieFromList(ddlCategorien.Text, db.GetAlleParentCategorien()));
        }

        protected void ddlSubCategorien_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAlleSecondSubCategorien(administratie.FindCategorieFromList(ddlSubCategorien.Text, db.GetAllChildCategorien(
                administratie.FindCategorieFromList(ddlCategorien.Text, db.GetAlleParentCategorien()))));
        }

        protected void ddlSecondSubCategorien_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListbox();
        }

        protected void OnClick(object sender, EventArgs e)
        {
            string selected = ddlCategorien.SelectedItem.Text;
            int parentId = 0;

            List<Categorie> parentCategorien = db.GetAlleParentCategorien();
            List<Categorie> childCategorien = new List<Categorie>();
            List<Categorie> subChildCategorien = new List<Categorie>();

            foreach (Categorie c in parentCategorien)
            {
                if (c.CategorieNaam == selected)
                {
                    int catId = c.CategorieId;
                    childCategorien = db.GetAllChildCategorien(catId);
                }
            }

            selected = ddlSubCategorien.SelectedItem.Text;

            foreach (Categorie c in childCategorien)
            {
                if (c.CategorieNaam == selected)
                {
                    parentId = c.CategorieId;
                    subChildCategorien = db.GetAllSecondChildCategorien(parentId);
                }
            }

            string catNaam = ddlSecondSubCategorien.Text;
            try
            {
                foreach (Categorie c in subChildCategorien)
                {
                    if (c.CategorieNaam == catNaam)
                    {
                        List<Product> products = administratie.GetProductenPerCategorie(c.CategorieId);

                        foreach (Product p in products)
                        {
                            if (p.Naam == lbProducten.SelectedItem.Text)
                            {
                                administratie.DeleteProduct(p);
                                LoadListbox();
                            }
                        }
                    }
                }
            }
            catch
            {
                
            }
        }

        private void LoadAlleCategorien()
        {
            List<Categorie> parentCategorien = db.GetAlleParentCategorien();

            ddlCategorien.DataSource = parentCategorien;
            ddlCategorien.DataBind();
        }

        private void LoadAlleSubCategorien(int parentId)
        {
            List<Categorie> childCategorien = db.GetAllChildCategorien(parentId);

            ddlSubCategorien.DataSource = childCategorien;
            ddlSubCategorien.DataBind();
        }

        private void LoadAlleSecondSubCategorien(int parentId)
        {
            List<Categorie> subChildCategorien = db.GetAllSecondChildCategorien(parentId);

            ddlSecondSubCategorien.DataSource = subChildCategorien;
            ddlSecondSubCategorien.DataBind();
        }

        public void LoadListbox()
        {
            string selected = ddlCategorien.SelectedItem.Text;
            int parentId = 0;

            List<Categorie> parentCategorien = db.GetAlleParentCategorien();
            List<Categorie> childCategorien = new List<Categorie>();
            List<Categorie> subChildCategorien = new List<Categorie>();

            foreach (Categorie c in parentCategorien)
            {
                if (c.CategorieNaam == selected)
                {
                    int catId = c.CategorieId;
                    childCategorien = db.GetAllChildCategorien(catId);
                }
            }

            selected = ddlSubCategorien.SelectedItem.Text;

            foreach (Categorie c in childCategorien)
            {
                if (c.CategorieNaam == selected)
                {
                    parentId = c.CategorieId;
                    subChildCategorien = db.GetAllSecondChildCategorien(parentId);
                }
            }

            string catNaam = ddlSecondSubCategorien.Text;
            try
            {
                foreach (Categorie c in subChildCategorien)
                {
                    if (c.CategorieNaam == catNaam)
                    {
                        List<Product> products = administratie.GetProductenPerCategorie(c.CategorieId);
                        lbProducten.DataSource = products;
                        lbProducten.DataBind();
                    }
                }
            }
            catch
            {
            }
        }

    }
}