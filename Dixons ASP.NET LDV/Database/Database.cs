using Oracle.ManagedDataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dixons_ASP.NET_LDV.Database
{
    //http://stackoverflow.com/questions/10113532/how-do-i-fix-the-visual-studio-compile-error-mismatch-between-processor-archit
    public partial class Database
    {
        //In partial class Database van de Database klasse worden de instellingen van de database opgeslagen. 
        //Vanaf hier wordt de verbinding met de database gelegd wanneer er een Connection wordt aangevraagd.

        //Username en Password voor database instellingen
        private static string dataUser = "DIXONS";
        private static string dataPass = "DIXONS";
        private static string dataSrc = "//localhost:1521/XE";

        public static readonly string ConnectionString = "User Id=" + dataUser + ";Password=" + dataPass +
                                                         ";Data Source=" + dataSrc + ";";

        public static OracleConnection Connection
        {
            get
            {
                OracleConnection connection = new OracleConnection(ConnectionString);
                connection.Open();
                return connection;
            }
        }
    }
}