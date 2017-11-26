using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAOAsphyoSqlServer {
    public class DAOSqlServerCredentials {

        public static BEUAsphyo.Engines.BEUMicrosoftSQLServer oBEUSqlServer;

        internal static String getConnectionString() {
            var Builder = new SqlConnectionStringBuilder();
            Builder.DataSource = oBEUSqlServer.DataSource;
            Builder.UserID = oBEUSqlServer.Username;
            Builder.Password = oBEUSqlServer.Password;
            Builder.IntegratedSecurity = oBEUSqlServer.IntegratedSecurity;
            return Builder.ConnectionString;
        }

        internal static String getConnectionString(String database) {
            var Builder = new SqlConnectionStringBuilder();
            Builder.DataSource = oBEUSqlServer.DataSource;
            Builder.UserID = oBEUSqlServer.Username;
            Builder.Password = oBEUSqlServer.Password;
            Builder.IntegratedSecurity = oBEUSqlServer.IntegratedSecurity;
            Builder.InitialCatalog = database;
            return Builder.ConnectionString;
        }
    }
}
