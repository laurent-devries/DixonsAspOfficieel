using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dixons_ASP.NET_LDV.Csharp;
using Oracle.ManagedDataAccess.Client;

namespace Dixons_ASP.NET_LDV.Database
{
    public partial class Database
    {
        public void InsertBlogBericht(BlogBericht blog)
        {
            using (OracleConnection connection = Connection)
            {
                string insert = "INSERT INTO BLOGBERICHT VALUES (seq_BlogBericht_ID.nextval, :CATEGORIEID, :PRODUCTID, :TITEL, :DATUM, :TEKST, :AFBEELDINGPATH)";
                using (OracleCommand command = new OracleCommand(insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("CATEGORIEID", blog.Categorie.CategorieId));
                    command.Parameters.Add(new OracleParameter("PRODUCTID", null));
                    command.Parameters.Add(new OracleParameter("TITEL", blog.Titel));
                    command.Parameters.Add(new OracleParameter("DATUM", blog.Datum));
                    command.Parameters.Add(new OracleParameter("TEKST", blog.Tekst));
                    command.Parameters.Add(new OracleParameter("AFBEELDINGPATH", blog.AfbeeldingPath));
                    command.ExecuteNonQuery();
                }
            }
        }


        public void InsertExemplaar(Exemplaar exemplaar, Order order)
        {
            using (OracleConnection connection = Connection)
            {
                string insert = "INSERT INTO EXEMPLAAR VALUES (seq_Exemplaar_ID.nextval, :ORDERID, :PRODUCTID, :VERKOOPPRIJS)";
                using (OracleCommand command = new OracleCommand(insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("ORDERID", null));
                    command.Parameters.Add(new OracleParameter("PRODUCT", exemplaar.Product.ProductId));
                    command.Parameters.Add(new OracleParameter("VERKOOPPRIJS", exemplaar.Verkoopprijs));
                    command.ExecuteNonQuery();
                }
            }
        }
        
        public void InsertOrderAdres(Order order)
        {
            using (OracleConnection connection = Connection)
            {
                string insert = "INSERT INTO ORDER_ADRES VALUES(:ORDERID, :ADRESID, 'BEZORGADRES')";
                using (OracleCommand command = new OracleCommand(insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("ORDERID", order.OrderId));
                    command.Parameters.Add(new OracleParameter("ADRESID", order.BezorgAdres.AdresId));
                    command.ExecuteNonQuery();
                    
                }
            }
        }

        public void InsertOrderAdres2(Order order)
        {
            using (OracleConnection connection = Connection)
            {
                string insert2 = "INSERT INTO ORDER_ADRES VALUES (:ORDERID, :ADRESID, 'OFFERTEADRES')";
                using (OracleCommand command2 = new OracleCommand(insert2, connection))
                {
                    command2.Parameters.Add(new OracleParameter("ORDERID", order.OrderId));
                    command2.Parameters.Add(new OracleParameter("ADRESID", order.FactuurAdres.AdresId));
                    command2.ExecuteNonQuery();
                }
            }
        }


        public void InsertOrder(Order order)
        {
            string dagstring = DateTime.Now.Day.ToString();
            if (dagstring.Length < 2)
            {
                dagstring = '0' + dagstring;
            }
            string datumString = dagstring +
                '-' + DateTime.Now.Month.ToString() +
                '-' + DateTime.Now.Year.ToString();

            using (OracleConnection connection = Connection)
            {
                string insert = "INSERT INTO \"Order\" VALUES (seq_Order_ID.nextval, :ACCOUNTID, TO_DATE(:DATUM, 'DD-MM-YYYY'))";
                using (OracleCommand command = new OracleCommand(insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("ACCOUNTID", order.Account.AccountId.ToString()));
                    command.Parameters.Add(new OracleParameter("DATUM", datumString));
                    command.ExecuteNonQuery();
                }
            }

            
        }

        public void InsertProduct(Product product)
        {
            using (OracleConnection connection = Connection)
            {
                string insert = "INSERT INTO PRODUCT VALUES (seq_Product_ID.nextval, :CategorieID, :NAAM, :PRIJS, :BESCHRIJVING, :BEZORGTIJD, :Afbeeldingpath)";
                using (OracleCommand command = new OracleCommand(insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("CategorieID", product.Categorie.CategorieId));
                    command.Parameters.Add(new OracleParameter("NAAM", product.Naam));
                    command.Parameters.Add(new OracleParameter("PRIJS", product.Prijs));
                    command.Parameters.Add(new OracleParameter("BESCHRIJVING", product.Beschrijving));
                    command.Parameters.Add(new OracleParameter("BEZORGTIJD", product.Bezorgtijd));
                    command.Parameters.Add(new OracleParameter("Afbeeldingpath", product.AfbeeldingPath));
                    command.ExecuteNonQuery();
                }
            }
            
        }

        public void InsertParticulierAccount(Particulier particulier)
        {
            int smsFunctie;
            if (particulier.SmsFunctie){ smsFunctie = 1;}
            else{ smsFunctie = 0;}

            int nieuwsBrief;
            if (particulier.Nieuwsbrief)
            {
                nieuwsBrief = 1;
            }
            else
            {
                nieuwsBrief = 0;
            }
            string dagstring = particulier.Geboortedatum.Day.ToString();
            if (dagstring.Length < 2)
            {
                dagstring = '0' + dagstring;
            }
            string geboortedatum = dagstring + '-' + particulier.Geboortedatum.Month.ToString() + '-' + particulier.Geboortedatum.Year.ToString();
            

            using (OracleConnection connection = Connection)
            {
                string insert = "INSERT INTO ACCOUNT VALUES (seq_Account_ID.nextval, :VOORNAAM, :ACHTERNAAM, :TELEFOONNUMMER, :SMSFUNCTIE, :MOBIELNUMMER, TO_DATE(:GEBOORTEDATUM, 'DD-MM-YYYY'), null," +
                                " :NIEUWSBRIEF, :EMAIL, :WACHTWOORD)";
                using (OracleCommand command = new OracleCommand(insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("VOORNAAM", particulier.Voornaam));
                    command.Parameters.Add(new OracleParameter("ACHTERNAAM", particulier.Achternaam));
                    command.Parameters.Add(new OracleParameter("TELEFOONNUMMER", particulier.Telefoonnummer));
                    command.Parameters.Add(new OracleParameter("SMSFUNCTIE", smsFunctie));
                    command.Parameters.Add(new OracleParameter("MOBIELNUMMER", particulier.MobielNummer));
                    command.Parameters.Add(new OracleParameter("GEBOORTEDATUM", geboortedatum));
                    command.Parameters.Add(new OracleParameter("NIEUWSBRIEF", nieuwsBrief));
                    command.Parameters.Add(new OracleParameter("EMAIL", particulier.Email));
                    command.Parameters.Add(new OracleParameter("WACHTWOORD", particulier.Wachtwoord));
                    command.ExecuteNonQuery();
                }
            }

            //Toevoegen aan Particulier
            /*
            using (OracleConnection connection = Connection)
            {
                string insert = "INSERT INTO PARTICULIER VALUES (seq_Particulier_ID.nextval, :ACCOUNTID)";
                using (OracleCommand command = new OracleCommand(insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("ACCOUNTID", particulier.AccountId));
                    command.ExecuteNonQuery();
                }
            }
            */

            
        }


    }
}