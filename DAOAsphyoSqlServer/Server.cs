using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEUAsphyo.Exception;


namespace DAOAsphyoSqlServer {
    public class Server {

        public DataTable getTables(String database) {
            try {
                var msSQLC = new SqlCommand("SELECT TABLE_NAME AS TableName FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG = @Database");
                msSQLC.Parameters.AddWithValue("@Database", database);
                return new Connection(database).Select(msSQLC);

            }
            catch( BEUExceptionDAO ex ) {
                throw new BEUExceptionDAO("Cannot retrive the server Schema...", ex);
            }
        }

        public DataTable getAllDataBases() {
            try {
                return new Connection().Select(new SqlCommand("SELECT name [Database] FROM sys.databases"));
            }
            catch( BEUExceptionDAO ex ) {
                throw new BEUExceptionDAO("Cannot retrive the server Schema...", ex);
            }
        }

        public bool tryConnection() {
            return new Connection().TestConnection();
        }


        public DataTable getTableInformation(String database, String table) {
            try {
                String Query = @"SELECT 
                                    c.name 'COLUMN_NAME',
                                    t.Name 'DATA_TYPE',
	                                c.is_identity 'IS_AUTO_INCREMENT',
                                    ISNULL(i.is_primary_key, 0) 'IS_PRIMARY'
                                FROM    
                                    sys.columns c
                                    INNER JOIN sys.types t ON c.user_type_id = t.user_type_id
                                    LEFT OUTER JOIN sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id
                                    LEFT OUTER JOIN sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id
                                WHERE
                                    c.object_id = OBJECT_ID(@TableName)";
                SqlCommand oSQLC = new SqlCommand(Query);
                oSQLC.Parameters.AddWithValue("@TableName", table);
                return new Connection(database).Select(oSQLC);
            }
            catch( Exception ex ) {

                throw new BEUExceptionBL("Cannot retrive table information", ex);
            }
        }
    }
}

