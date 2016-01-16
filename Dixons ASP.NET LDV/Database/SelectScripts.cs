using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using Dixons_ASP.NET_LDV.Csharp;
using Oracle.ManagedDataAccess.Client;

namespace Dixons_ASP.NET_LDV.Database
{
    public partial class Database
    {
        public Particulier selectAccountFromId(int accountId)
        {
            Particulier account = null;
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM ACCOUNT WHERE ACCOUNTID = :ID";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("ID", accountId));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            account = CreateParticulierFromReader(reader);
                        }
                    }
                }
            }
            return account;
        }

        public BlogBericht SelectBlogberichtFromId(int id)
        {
            BlogBericht blogBericht = null;
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM BLOGBERICHT WHERE BLOGBERICHTID = :ID";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("ID", id));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            blogBericht = CreateBlogBerichtFromReader(reader);
                        }
                    }
                }
            }
            return blogBericht;
        }

        public List<BlogBericht> SelectAlleBlogberichten()
        {
            List<BlogBericht> blogBerichts = new List<BlogBericht>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM BLOGBERICHT";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BlogBericht blogbericht = CreateBlogBerichtFromReader(reader);
                            blogBerichts.Add(blogbericht);
                        }
                    }
                }
            }
            return blogBerichts;
        } 
       

        public int SelectAccountIdFromUsername(string email, string wachtwoord)
        {
            int accountId = 0;

            using (OracleConnection connection = Connection)
            {
                string query = "SELECT ACCOUNTID FROM ACCOUNT WHERE EMAIL = :email AND WACHTWOORD = :wachtwoord";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("email", email));
                    command.Parameters.Add(new OracleParameter("wachtwoord", wachtwoord));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accountId = Convert.ToInt32(reader["ACCOUNTID"]);
                        }
                    }
                }
            }
            return accountId;
        }


        public List<Product> GetProductenPerCategorie(int categorieId)
        {
            List<Product> productList = new List<Product>();

            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM PRODUCT WHERE CATEGORIEID = :ParaID";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("ParaID", categorieId));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = CreateProductFromReader(reader);
                            productList.Add(product);
                        }
                    }
                }
            }
            return productList;
        }

        public List<Product> GetAlleProducten()
        {
            List<Product> productList = new List<Product>();

            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM PRODUCT";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = CreateProductFromReader(reader);
                            productList.Add(product);
                        }
                    }
                }
            }
            return productList;
        } 

        public Product SelectProduct(int productId)
        {
            Product product = null;
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM PRODUCT WHERE PRODUCTID = :ParaID";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("ParaID", productId));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product = CreateProductFromReader(reader);
                        }

                    }
                }
            }
            return product;
        }

        public Categorie SelectCategorie(int CATEGORIEID)
        {
            Categorie categorie = null;
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM CATEGORIE WHERE CATEGORIEID = :ParaID";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("ParaID", CATEGORIEID));
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorie = CreateCategorieFromReader(reader);
                        }

                    }
                }
            }
            return categorie;
        }

        public List<Categorie> GetAlleCategorien()
        {
            List<Categorie>categorieList = new List<Categorie>();

            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM CATEGORIE";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categorie categorie = CreateCategorieFromReader(reader);
                            categorieList.Add(categorie);
                        }
                    }
                }
            }
            return categorieList;
        }

        public List<Categorie> GetAlleParentCategorien()
        {
            List<Categorie> categorien = GetAlleCategorien();
            List<Categorie> parentCategorien = new List<Categorie>();
            foreach (Categorie c in categorien)
            {
                if (c.CategorieIdParent == 0)
                {
                    parentCategorien.Add(c);
                }
            }
            return parentCategorien;
        }

        public List<Categorie> GetAllChildCategorien(int parentId)
        {
            List<Categorie> categorien = GetAlleCategorien();
            List<Categorie> childCategorien = new List<Categorie>();

            foreach (Categorie c in categorien)
            {
                if (c.CategorieIdParent == parentId)
                {
                    childCategorien.Add(c);
                }
            }
            return childCategorien;
        }

        public List<Categorie> GetAllSecondChildCategorien(int parentId)
        {
            List<Categorie> categorien = GetAllChildCategorien(parentId);
            List<Categorie> secondChildCategorien = new List<Categorie>();

            foreach (Categorie c in categorien)
            {
                if (c.CategorieIdParent == parentId)
                {
                    secondChildCategorien.Add(c);
                }
            }
            return secondChildCategorien;
        } 

        /*
        public Particulier SelectParticulier()
        {
            List<Particulier> particulierenlList = new List<Particulier>();
            List<int> accountIdList = SelectAllAccountIdParticulier();

            using (OracleConnection connection = Connection)
            {
                foreach (int i in accountIdList)
                {
                    string query = "SELECT * FROM ACCOUNT WHERE ID = :ParaID Order by ACCOUNTID";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("ParaID", i));
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                accountIdList.Add(Convert.ToInt32(reader));
                            }
                        }
                    }
                }

            }
            return null;
        }

        public List<int> SelectAllAccountIdParticulier()
        {
            List<int> accountIdList = new List<int>();

            using (OracleConnection connection = Connection)
            {
                string query = "SELECT ACCOUNTID FROM PARTICULIER order by ACCOUNTID";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accountIdList.Add(Convert.ToInt32(reader));
                        }
                    }
                }
            }
            return accountIdList;
        }
        */

    }
}