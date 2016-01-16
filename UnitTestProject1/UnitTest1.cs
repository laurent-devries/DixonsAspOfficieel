using System;
using Dixons_ASP.NET_LDV.Csharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnittestAdministratie
    {
        //Hoofdvariabelen aanmaken
        public Administratie admin;
        public Product startProduct;
        public Product controleProduct;
        public Categorie categorie;

        //Belangrijkste variabelen initialiseren.
        [TestInitialize]
        public void Initialize()
        {
            admin = new Administratie();
            categorie = new Categorie(16, "Werkgeheugen", 13);
        }




        [TestMethod]
        public void TestProductToevoegen()
        {
            startProduct = new Product(1, "TestProduct", 1, "TestBeschrijving", "TestBezorgtijd", "AfbeeldingPath", categorie, null);
            admin.AddProduct(startProduct);
            Assert.AreEqual(startProduct.Naam, "TestProduct");
            Assert.AreEqual(startProduct.Prijs, 1);
            Assert.AreEqual(startProduct.Beschrijving, "TestBeschrijving");
            Assert.AreEqual(startProduct.Bezorgtijd, "TestBezorgtijd");
            Assert.AreEqual(startProduct.AfbeeldingPath, "AfbeeldingPath");
            Assert.AreEqual(startProduct.Categorie, categorie);

            Assert.AreEqual("TestProduct", startProduct.Naam);
            Assert.AreEqual(1, startProduct.Prijs);
            Assert.AreEqual("TestBeschrijving", startProduct.Beschrijving);
            Assert.AreEqual("TestBezorgtijd", startProduct.Bezorgtijd);
            Assert.AreEqual("AfbeeldingPath", startProduct.AfbeeldingPath);
            Assert.AreEqual(categorie, startProduct.Categorie);

            admin.DeleteProduct(startProduct);
        }

        //Controleer of de functie GetProduct het juiste product teruggeeft.
        [TestMethod]
        public void TestGetProduct()
        {
            /* gebruikte insert:
           insert into Product(PRODUCTID, CATEGORIEID, NAAM, PRIJS, BESCHRIJVING, BEZORGTIJD, AFBEELDINGPATH)
           VALUES(seq_Product_ID.NEXTVAL, 6, 'HP 14-ac002nd', 249.00, 'Een ingebouwde Intel Celeron processor zorgt voor goede prestaties. Deze processor is geschikt voor Office, e-mail, browsen en het afspelen van multimedia. Het maakt deze laptop geschikt voor de alledaagse taken, 
           die het zonder poespas zal uitvoeren.', 'Alleen af te halen', 'laptop.jpg'); */
            //TODO

            controleProduct = admin.GetProduct(1);
            Assert.AreEqual(1, controleProduct.ProductId);
            Assert.AreEqual(6, controleProduct.Categorie.CategorieId);
            Assert.AreEqual("HP 14-ac002nd", controleProduct.Naam);
            Assert.AreEqual((decimal)249.00, controleProduct.Prijs);
            Assert.IsNotNull(controleProduct.Beschrijving);
            Assert.AreEqual("Alleen af te halen", controleProduct.Bezorgtijd);
            Assert.AreEqual("laptop.jpg", controleProduct.AfbeeldingPath);
        }

        [TestMethod]
        public void FindParticulier()
        {
            int particulierId = admin.FindParticulier("laurent-devries@outlook.com", "pizza123");
            Assert.AreEqual(1, particulierId);
        }

         
        [TestMethod]
        public void getBlogBerichtById()
        {
            /*
            VALUES(1, 1, null, 'Schiet de meest prachtige kiekjes met je smartphone', 
            '01-10-2015', 'Bijna iedereen heeft vandaag de dag een ontzettend goede camera op zak: 
            namelijk de camera van je smartphone!', null);*/

            BlogBericht blogBericht = admin.GetBlogberichtFromId(1);
            Assert.AreEqual(1, blogBericht.BlogBerichtId, "id fout");
            Assert.AreEqual(1, blogBericht.Categorie.CategorieId, "categorieId fout");
            Assert.IsNotNull(blogBericht.Tekst, "Text fout");
            Assert.AreEqual(blogBericht.AfbeeldingPath, "");
        }
    }
}
