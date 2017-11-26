using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAOAsphyoMySql {
    public class DAOMySqlCredentials {

        public static BEUAsphyo.Engines.BEUMySQL oBEUMySQL;

        internal static String getConnectionString() {
            var Builder = new MySqlConnectionStringBuilder();
            Builder.Server = oBEUMySQL.ServerName;
            Builder.Port = oBEUMySQL.Port;
            Builder.UserID = oBEUMySQL.Username;
            Builder.Password = oBEUMySQL.Password;
            Builder.SslMode = MySqlSslMode.None;
            return Builder.GetConnectionString(true);
        }

        internal static String getConnectionString(String database) {
            var Builder = new MySqlConnectionStringBuilder();
            Builder.Server = oBEUMySQL.ServerName;
            Builder.Port = oBEUMySQL.Port;
            Builder.UserID = oBEUMySQL.Username;
            Builder.Password = oBEUMySQL.Password;
            Builder.Database = database;
            Builder.SslMode = MySqlSslMode.None;
            return Builder.GetConnectionString(true);
        }
    }
}
