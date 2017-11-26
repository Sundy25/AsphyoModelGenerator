using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEUAsphyo.Engines;

namespace BLAsphyo {
    public class BLDatabaseEngine {

        public enum DataSource {
            SqlServer = 0,
            MySQL = 1
        };

        public static DataSource EngineInUse { get; set; }

        public static void ChangeCredentials(BEUMicrosoftSQLServer Credentials) {
            EngineInUse = DataSource.SqlServer;
            DAOAsphyoSqlServer.DAOSqlServerCredentials.oBEUSqlServer = Credentials;
        }

        public static void ChangeCredentials(BEUMySQL Credentials) {
            EngineInUse = DataSource.MySQL;
            DAOAsphyoMySql.DAOMySqlCredentials.oBEUMySQL = Credentials;
        }
    }
}
