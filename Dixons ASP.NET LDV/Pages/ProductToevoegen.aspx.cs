using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV.Pages
{
    public partial class ProductToevoegen : System.Web.UI.Page
    {
        private Database.Database db;
        private Administratie administratie = new Administratie();
        public int idSubCat;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Categorie categorie = db.SelectCategorie(1);
            //tbxNaam.Text = categorie.CategorieNaam;
            //LoadAlleCategorien();
            FillBezorgtijd();
            

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


        protected void ddlCategorien_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = ddlCategorien.SelectedItem.Text;

            List<Categorie> parentCategorien = db.GetAlleParentCategorien();

            foreach (Categorie c in parentCategorien)
            {
                if (c.CategorieNaam == selected)
                {
                    int catId = c.CategorieId;
                    LoadAlleSubCategorien(catId);
                }
            }
        }

        protected void ddlSubCategorien_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = ddlCategorien.SelectedItem.Text;

            List<Categorie> parentCategorien = db.GetAlleParentCategorien();
            List<Categorie> childCategorien = new List<Categorie>();

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
                    idSubCat = c.CategorieId;
                    LoadAlleSecondSubCategorien(idSubCat);
                }
            }
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
                        var product = new Product(0, tbxNaam.Text, Convert.ToDecimal(tbxPrijs.Text), tbxBeschrijving.Text,
                            ddlBezorgtijd.Text, tbxAfbeeldingpath.Text, c, null);
                        administratie.AddProduct(product);
                        Response.Redirect("/Pages/Homepage.aspx");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Er is iets niet ingevuld");
            }


        }

        public void FillBezorgtijd()
        {
            ddlBezorgtijd.Items.Add("Op voorraad");
        }
    }
}