using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using BEUAsphyo.Exception;
using BEUAsphyo.Engines;
using System.Data;

namespace DAOAsphyoMySql {
    public class Connection {

        private MySqlConnection myCN;

        public Connection() {
            this.myCN = new MySqlConnection(DAOMySqlCredentials.getConnectionString());
        }
        public Connection(String Database) {
            this.myCN = new MySqlConnection(DAOMySqlCredentials.getConnectionString(Database));
        }

        private bool OpenConnection() { //Public for connection testing
            try {
                this.myCN.Open();
                return true;
            }
            catch( Exception ex ) {
                throw new BEUExceptionDAO("Cannot open the conecction with MySQL, please varify the server", ex);
            }

        }

        private bool CloseConnection() {
            try {
                if( myCN.State != ConnectionState.Closed ) {
                    myCN.Close();
                }
                return true;
            }
            catch( Exception ex ) {
                throw new BEUExceptionDAO("Error closing the connection", ex);
            }
        }

        public bool CMD(MySqlCommand mySQLC) {
            if( OpenConnection() ) {
                using( MySqlTransaction mySQLTR = myCN.BeginTransaction() ) {
                    try {
                        mySQLC.Connection = myCN;
                        mySQLC.Transaction = mySQLTR;
                        mySQLC.ExecuteNonQuery();
                        mySQLTR.Commit();

                    }
                    catch( Exception ex ) {
                        mySQLTR.Rollback();
                        throw new BEUExceptionDAO("Cannot execute an internal function, please report the issues\nUnhandled Error: " + ex.Message, ex);
                    }
                }
            }
            throw new BEUExceptionDAO("Cannot establish connection");
        }

        public DataTable Select(MySqlCommand oSQLC) {
            try {
                oSQLC.Connection = this.myCN;
                MySqlDataAdapter oSQLDA = new MySqlDataAdapter(oSQLC);
                DataTable oDT = new DataTable();
                if( OpenConnection() ) {
                    oSQLDA.Fill(oDT);
                    return oDT;
                }
                throw new BEUExceptionDAO("Cannot establish connection, please reconect");
            }
            catch( Exception ex ) { throw new BEUExceptionDAO("Cannot execute an internal function, please report the issues\nUnhandled Error: " + ex.Message, ex); }
        }

        public bool Exists(MySqlCommand oSQLC) {
            try {
                oSQLC.Connection = this.myCN;
                MySqlDataReader oSQLDR = null;
                if( OpenConnection() ) {
                    oSQLDR = oSQLC.ExecuteReader();
                    bool HasRows = oSQLDR.HasRows;
                    oSQLDR.Close();
                    return HasRows;
                }
                throw new BEUExceptionDAO("Cannot establish connection, please reconect");
            }
            catch( Exception ex ) { throw new BEUExceptionDAO("Cannot execute an internal function, please report the issues\nUnhandled Error: " + ex.Message, ex); }
        }

        public bool TestConnection() {
            try {
                if( OpenConnection() ) {
                    CloseConnection();
                    return true;
                }
                throw new BEUExceptionDAO("The connection is closed, please verify");
            }
            catch( BEUExceptionDAO ex ) {
                throw ex;
            }

        }
    }
}
