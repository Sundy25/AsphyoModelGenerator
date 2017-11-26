using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEUAsphyo.Exception;
using BEUAsphyo.Engines;
using System.Data;
using System.Data.SqlClient;

namespace DAOAsphyoSqlServer {
    public class Connection {

        private SqlConnection msCN;

        public Connection() {
            this.msCN = new SqlConnection(DAOSqlServerCredentials.getConnectionString());
        }
        public Connection(String Database) {
            this.msCN = new SqlConnection(DAOSqlServerCredentials.getConnectionString(Database));
        }

        private bool OpenConnection() {
            try {
                this.msCN.Open();
                return true;
            }
            catch( Exception ex ) {
                throw new BEUExceptionDAO("Cannot open the conecction with Microsoft SQLServer, please varify the server", ex);
            }
        }

        private bool CloseConnection() {
            try {
                if( msCN.State != ConnectionState.Closed ) {
                    msCN.Close();
                }
                return true;
            }
            catch( Exception ex ) {
                throw new BEUExceptionDAO("Error closing the connection", ex);
            }
        }

        public bool CMD(SqlCommand msSQLC) {
            if( OpenConnection() ) {
                using( SqlTransaction mySQLTR = msCN.BeginTransaction() ) {
                    try {
                        msSQLC.Connection = msCN;
                        msSQLC.Transaction = mySQLTR;
                        msSQLC.ExecuteNonQuery();
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

        public DataTable Select(SqlCommand oSQLC) {
            try {
                oSQLC.Connection = this.msCN;
                SqlDataAdapter oSQLDA = new SqlDataAdapter(oSQLC);
                DataTable oDT = new DataTable();
                if( OpenConnection() ) {
                    oSQLDA.Fill(oDT);
                    return oDT;
                }
                throw new BEUExceptionDAO("Cannot establish connection, please reconect");
            }
            catch( Exception ex ) { throw new BEUExceptionDAO("Cannot execute an internal function, please report the issues\nUnhandled Error: " + ex.Message, ex); }
        }

        public bool Exists(SqlCommand oSQLC) {
            try {
                oSQLC.Connection = this.msCN;
                SqlDataReader oSQLDR = null;
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
