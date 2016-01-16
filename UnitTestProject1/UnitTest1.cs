using System;
using Dixons_ASP.NET_LDV.Csharp; 
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void Initialize(){
             admin = new Administratie();
             categorie = new Categorie(9999, "TestCategorieNaam", 0);
        }

        //Controleer of de functie GetProduct het juiste product teruggeeft.
        [TestMethod]
        public void TestGetProduct()
        {
            //TODO
            controleProduct = admin.GetProduct(1);
            Assert.AreEqual(1, controleProduct.ProductId);
        }


        [TestMethod]
        public void TestProductToevoegen()
        {
            startProduct = new Product(1, "TestProduct", 1, "TestBeschrijving", "TestBezorgtijd", "AfbeeldingPath", categorie, null);
            admin.AddProduct(startProduct);
        }

    }
}
