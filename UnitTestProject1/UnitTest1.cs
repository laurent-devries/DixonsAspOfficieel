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
            Assert.AreEqual(blogBericht.AfbeeldingPath, "blogImage.jpg");
        }

        [TestMethod]
        //Test de classes 
        public void AccountTest()
        {
            Account account = new Particulier(1, "Voornaam", "Achternaam", "0619199919", true, 
                "0677766543", DateTime.Now, null, true, "email@email.nl","wachtwoord", "soort");
            
            Assert.AreEqual("Voornaam", account.Voornaam);
            Assert.AreEqual("Achternaam", account.Achternaam);
            Assert.AreEqual("0619199919", account.Telefoonnummer);
            Assert.IsTrue(account.SmsFunctie);
            Assert.AreEqual("0677766543", account.MobielNummer);
            Assert.IsNull(account.Twitter);
            Assert.IsTrue(account.Nieuwsbrief);
            Assert.AreEqual("email@email.nl", account.Email);
            Assert.AreEqual("wachtwoord", account.Wachtwoord);
            Assert.AreEqual("soort", account.Soort);
        }

        [TestMethod]
        public void AdresTest()
        {
            Adres adres = new Adres(99, "postcode", 99, "straat", "plaats");
            Assert.AreEqual(99, adres.AdresId);
            Assert.AreEqual("postcode", adres.Postcode);
            Assert.AreEqual(99, adres.Huisnummer);
            Assert.AreEqual("straat", adres.Straat);
            Assert.AreEqual("plaats", adres.Plaats);
        }

        [TestMethod]
        public void Bedrijf()
        {
            Bedrijf bedrijf = new Bedrijf(1, "voornaam", "achternaam", "telefoonnummer", true, 
                "mobielnummer", DateTime.Now, "twitter", true, "email", "wachtwoord",
                "soort", "bedrijfsnaam", "ondernemingsnummer", "btwnummer");

            Assert.AreEqual(1, bedrijf.AccountId);
            Assert.AreEqual("voornaam", bedrijf.Voornaam);
            Assert.AreEqual("achternaam", bedrijf.Achternaam);
            Assert.AreEqual("telefoonnummer", bedrijf.Telefoonnummer);
            Assert.IsTrue(bedrijf.SmsFunctie);
            Assert.AreEqual("mobielnummer", bedrijf.MobielNummer);
            Assert.AreEqual("twitter", bedrijf.Twitter);
            Assert.IsTrue(bedrijf.Nieuwsbrief);
            Assert.AreEqual("email", bedrijf.Email);
            Assert.AreEqual("wachtwoord", bedrijf.Wachtwoord);
            Assert.AreEqual("soort", bedrijf.Soort);
            Assert.AreEqual("bedrijfsnaam", bedrijf.Bedrijfsnaam);
            Assert.AreEqual("ondernemingsnummer", bedrijf.Ondernemingsnummer);
            Assert.AreEqual("btwnummer", bedrijf.BtwNummer);

        }


        [TestMethod]
        public void BerichtTest()
        {
            Bericht bericht = new Bericht(1, "onderwerp", "tekst");
            Assert.AreEqual(1, bericht.BerichtId);
            Assert.AreEqual("onderwerp", bericht.Onderwerp);
            Assert.AreEqual("tekst", bericht.Tekst);
        }

        [TestMethod]
        public void BlogBerichtTest()
        {
            BlogBericht blogBericht = new BlogBericht(1, "titel", DateTime.Now, 
                "tekst", "afbeeldingpath", null);
            Assert.AreEqual(1, blogBericht.BlogBerichtId);
            Assert.AreEqual("titel", blogBericht.Titel);
            Assert.AreEqual("tekst", blogBericht.Tekst);
            Assert.AreEqual("afbeeldingpath", blogBericht.AfbeeldingPath);
            Assert.IsNull(blogBericht.Categorie);
        }

        [TestMethod]
        public void CategorieTest()
        {
            Categorie categorieTest = new Categorie(1, "naam", 2);
            Assert.AreEqual(1, categorieTest.CategorieId);
            Assert.AreEqual("naam", categorieTest.CategorieNaam);
            Assert.AreEqual(2, categorieTest.CategorieIdParent);
        }

        [TestMethod]
        public void ExemplaarTest()
        {
            Exemplaar exemplaar = new Exemplaar(1, 1, null);
            Assert.AreEqual(1, exemplaar.Serienummer);
            Assert.AreEqual(1, exemplaar.Verkoopprijs);
            Assert.IsNull(exemplaar.Product);
        }

        [TestMethod]
        public void OrderTest()
        {
            Order order = new Order(1, null, DateTime.Now, null, null, null);
            Assert.AreEqual(1, order.OrderId);
            Assert.IsNull(order.Exemplaren);
            Assert.IsNull(order.Account);
            Assert.IsNull(order.BezorgAdres);
            Assert.IsNull(order.FactuurAdres);
        }

        [TestMethod]
        public void ProductTest()
        {
            Product product = new Product(1, "naam", 1, "beschrijving", "bezorgtijd",
                "afbeeldingpath", null, null);
            
            Assert.AreEqual(1, product.ProductId);
            Assert.AreEqual("naam", product.Naam);
            Assert.AreEqual(1, product.Prijs);
            Assert.AreEqual("beschrijving", product.Beschrijving);
            Assert.AreEqual("bezorgtijd", product.Bezorgtijd);
            Assert.IsNull(product.Specificaties);
            Assert.IsNull(product.Categorie);
        }

        [TestMethod]
        public void SpecificatieTest()
        {
            Specificatie specificatie = new Specificatie(1, "naam");
            Assert.AreEqual(1, specificatie.SpecificatieId);
            Assert.AreEqual("naam", specificatie.Naam);
        }
    }
}
