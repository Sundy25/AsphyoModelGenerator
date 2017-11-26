using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEUAsphyo.Exception;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace DAOAsphyoMySql {
    public class Server {

        public DataTable getTables(String database) {
            try {
                var oSQLC = new MySqlCommand("SELECT table_name AS TableName FROM information_schema.tables where table_schema = @Database");
                oSQLC.Parameters.AddWithValue("@Database", database);
                return new Connection(database).Select(oSQLC);
            }
            catch( BEUExceptionDAO ex ) {
                throw new BEUExceptionDAO("Cannot retrive the server Schema...", ex);
            }
        }

        public DataTable getAllDataBases() {
            try {
                return new Connection().Select(new MySqlCommand("Show databases"));
            }
            catch( BEUExceptionDAO ex ) {
                throw new BEUExceptionDAO("Cannot retrive the server Schema...", ex);
            }
        }

        public bool tryConnection() {
            return new Connection().TestConnection();
        }

        public DataTable getTableInformation(String database, String table) {
            String Query = @"SELECT 
                                COLUMN_NAME, 
		                        DATA_TYPE,
		                        CASE EXTRA WHEN  'auto_increment' 
		                            THEN 1 
                                    ELSE 0 END as 'IS_AUTO_INCREMENT',
                                CASE COLUMN_KEY WHEN 'PRI'
                                THEN 1
                                ELSE 0 END as 'IS_PRIMARY'
                            FROM 
                                information_schema.COLUMNS  
                            WHERE TABLE_NAME = @TableName AND 
                            TABLE_SCHEMA = @Database";
            MySqlCommand oSQLC = new MySqlCommand(Query);
            oSQLC.Parameters.AddWithValue("@TableName", table);
            oSQLC.Parameters.AddWithValue("@Database", database);
            return new Connection(database).Select(oSQLC);
        }
    }
}

