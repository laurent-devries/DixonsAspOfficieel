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
        public void UpdateExemplaarMetOrder(int serienummer, int orderId)
        {
            using (OracleConnection connection = Connection)
            {
                string update = "UPDATE EXEMPLAAR SET ORDERID = :ORDERID WHERE SERIENUMMER = :SERIENUMMER";
                using (OracleCommand command = new OracleCommand(update, connection))
                {
                    command.Parameters.Add(new OracleParameter("ORDERID", orderId));
                    command.Parameters.Add(new OracleParameter("SERIENUMMER", serienummer));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}