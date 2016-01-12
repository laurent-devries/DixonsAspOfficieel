using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV.Database
{
    public partial class Database
    {
        public void DeleteProduct(Product product)
        {
            using (OracleConnection connection = Connection)
            {
                string delete = "DELETE PRODUCT WHERE PRODUCTID = :ParaID";
                using (OracleCommand command = new OracleCommand(delete, connection))
                {
                    command.Parameters.Add(new OracleParameter("ParaID", product.ProductId));
                    command.ExecuteNonQuery();
                }
            }

        }
    }
}