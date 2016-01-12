using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dixons_ASP.NET_LDV.Csharp;
using Dixons_ASP.NET_LDV.Pages;
using Oracle.ManagedDataAccess.Client;


namespace Dixons_ASP.NET_LDV.Database
{
    public partial class Database
    {
        public Order CreateOrderFromReader(OracleDataReader reader)
        {
            int orderId;
            DateTime datum;
            List<Exemplaar> exemplaren;
            Adres bezorgAdres;
            Adres factuurAdres;

            Order order = null;
            return order;
        }

        public Adres CreateAdresFromReader(OracleDataReader reader)
        {
            int adresId = Convert.ToInt32(reader["ADRESID"]);
            string postcode = Convert.ToString(reader["POSTCODE"]);
            int huisnummer = Convert.ToInt32(reader["HUISNUMMER"]);
            string straat = Convert.ToString(reader["STRAAT"]);
            string plaats = Convert.ToString(reader["PLAATS"]);

            return new Adres(adresId, postcode, huisnummer, straat, plaats);
        }


        public Exemplaar CreateExemplaarFromReader(OracleDataReader reader)
        {
            int serienummer = Convert.ToInt32(reader["SERIENUMMER"]);
            decimal verkoopprijs = Convert.ToDecimal(reader["VERKOOPPRIJS"]);
            int productId = Convert.ToInt32(reader["PRODUCTID"]);

            Product product = null;
            foreach (Product p in GetAlleProducten())
            {
                if (p.ProductId == productId)
                {
                    product = p;
                }
            }

            return new Exemplaar(serienummer, verkoopprijs, product);
        }


        public BlogBericht CreateBlogBerichtFromReader(OracleDataReader reader)
        {
            int blogBerichtId = Convert.ToInt32(reader["BLOGBERICHTID"]);

            int categorieId = Convert.ToInt32(reader.GetOrdinal("CATEGORIEID"));
            int actualCategorieId = SafeGetInt(reader, categorieId);

            int productId = Convert.ToInt32(reader.GetOrdinal("PRODUCTID"));
            int actualProductId = SafeGetInt(reader, productId);

            string titel = Convert.ToString(reader["TITEL"]);
            DateTime datum = Convert.ToDateTime(reader["DATUM"]);
            string tekst = Convert.ToString(reader["TEKST"]);

            int afbeeldingPath = Convert.ToInt32(reader.GetOrdinal("AFBEELDINGPATH"));
            string actualAfbeeldingPath = SafeGetString(reader, afbeeldingPath);

            Categorie c = null;
            foreach (Categorie categorie in GetAlleCategorien())
            {
                if (categorie.CategorieId == categorieId)
                {
                    c = categorie;
                }
            }

            return new BlogBericht(blogBerichtId, titel, datum, tekst, actualAfbeeldingPath, c);
        }


        public Particulier CreateParticulierFromReader(OracleDataReader reader)
        {
            int accountId = Convert.ToInt32(reader["AccountID"]);
            string voornaam = Convert.ToString(reader["Voornaam"]);
            string achternaam = Convert.ToString(reader["Achternaam"]);
            string telefoonnummer = Convert.ToString(reader["Telefoonnummer"]);

            bool smsFunctie;
            if (Convert.ToInt32(reader["SMSFunctie"]) == 1)
            {
                smsFunctie = true;
            }
            else
            {
                smsFunctie = false;
            }
            string mobielnummer = Convert.ToString(reader["Mobielnummer"]);
            DateTime geboorteDatum = Convert.ToDateTime(reader["Geboortedatum"]);

            bool nieuwsbrief;
            if (Convert.ToInt32(reader["Nieuwsbrief"]) == 1)
            {
                nieuwsbrief = true;
            }
            else
            {
                nieuwsbrief = false;
            }

            string email = Convert.ToString(reader["Email"]);
            string wachtwoord = Convert.ToString(reader["Wachtwoord"]);

            return new Particulier(accountId, voornaam, achternaam, telefoonnummer, smsFunctie, mobielnummer, geboorteDatum, null, nieuwsbrief, email, wachtwoord, "Particulier");
        }

        public Categorie CreateCategorieFromReader(OracleDataReader reader)
        {
            int categorieId = Convert.ToInt32(reader["CATEGORIEID"]);

            int parentId = Convert.ToInt32(reader.GetOrdinal("CATEGORIEID_PARENT"));
            int actualParentId = SafeGetInt(reader, parentId);

            string categorieNaam = Convert.ToString(reader["CATEGORIENAAM"]);

            return new Categorie(categorieId, categorieNaam, actualParentId);
        }


        public Product CreateProductFromReader(OracleDataReader reader)
        {
            int productId = Convert.ToInt32(reader["PRODUCTID"]);
            int categorieId = Convert.ToInt32(reader["CATEGORIEID"]);
            string naam = Convert.ToString(reader["NAAM"]);
            decimal prijs = Convert.ToDecimal(reader["PRIJS"]);
            string beschrijving = Convert.ToString(reader["BESCHRIJVING"]);
            string bezorgtijd = Convert.ToString(reader["BEZORGTIJD"]);

            int testAfbeeldingPath = Convert.ToInt32(reader.GetOrdinal("AFBEELDINGPATH"));
            string actualAfbeeldingPath = SafeGetString(reader, testAfbeeldingPath);

            foreach (Categorie c in GetAlleCategorien())
            {
                if (c.CategorieId == categorieId)
                {
                    return new Product(productId, naam, prijs, beschrijving, bezorgtijd,actualAfbeeldingPath, c, null);
                }
            }
            return null;
        }


        private static string SafeGetString(OracleDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            else
                return string.Empty;
        }

        
        private static int SafeGetInt(OracleDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetInt32(colIndex);
            else
                return 0;
        }
        


    }
}