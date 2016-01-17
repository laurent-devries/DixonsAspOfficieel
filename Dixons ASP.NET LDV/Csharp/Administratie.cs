using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public class Administratie
    {
        Database.Database db;



        public Administratie()
        {
            db = new Database.Database();
            
        }

        public Particulier getParticulierFromId(int accountId)
        {
            Particulier particulier = db.selectAccountFromId(accountId);
            return particulier;
        }
        
        
        public Product GetProduct(int productId)
        {
            Product product = db.SelectProduct(productId);
            return product;
        }

        public List<Product> GetAlleProducten()
        {
            List<Product> products = db.GetAlleProducten();
            return products;
        } 


        public void AddProduct(Product product)
        {
            db.InsertProduct(product);
        }
        /*
        public List<Product> GetAlleProducten()
        {
            db.GetAlleProducten();
        } 
        */

        public List<Product> GetProductenPerCategorie(int categorieId)
        {
            List<Product> products = db.GetProductenPerCategorie(categorieId);
            return products;
        }

        public void DeleteProduct(Product product)
        {
            db.DeleteProduct(product);
        }

        public void InsertParticulierAccount(Particulier particulier)
        {
            db.InsertParticulierAccount(particulier);
        }

        public int FindParticulier(string email, string wachtwoord)
        {
            int accountId = db.SelectAccountIdFromUsername(email, wachtwoord);
            return accountId;
        }

        public List<BlogBericht> GetAllBlogBerichts()
        {
            List <BlogBericht> blogBerichts = db.SelectAlleBlogberichten();
            return blogBerichts;
        }

        public BlogBericht GetBlogberichtFromId(int id)
        {
            BlogBericht blogBericht = db.SelectBlogberichtFromId(id);
            return blogBericht;
        }

        public int FindCategorieFromList(string selectedName, List<Categorie> categorieList)
        {
            foreach (Categorie c in categorieList)
            {
                if (c.CategorieNaam == selectedName)
                {
                    return c.CategorieId;
                }
            }
            return 0;
        }

        public int lastOrderId()
        {
            return db.SelectLastOrderId();
        }
        

        public void InsertOrder(Order order)
        {
            db.InsertOrder(order);
            order.OrderId = db.SelectLastOrderId();
            db.InsertOrderAdres(order);
            db.InsertOrderAdres2(order);
        }

        public int selectLastExemplaar()
        {
            int lastEx = db.SelectLastExemplaar();
            return lastEx;
        }

        public void InsertExemplaar(Exemplaar exemplaar, Order order)
        {
            db.InsertExemplaar(exemplaar, order);
        }

        public void UpdateExemplaarOrderId(int serienummer, int orderId)
        {
           db.UpdateExemplaarMetOrder(serienummer, orderId);   
        }
    }
}