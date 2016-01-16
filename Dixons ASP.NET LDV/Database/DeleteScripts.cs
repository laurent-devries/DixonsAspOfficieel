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
        /*
         * In de DeleteScript partial class van de Database klasse worden alle functies voor het verwijderen van een object 
         * uit de database geinitialiseerd. Elke functienaam begint met Delete en vervolgens het object dat verwijderd moet
         * worden. Er wordt een object meegegeven omdat alle nodige eigenschappen van het object nodig zijn om het object te verwijderen.
         * 
        */
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