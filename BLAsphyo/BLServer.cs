using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BEUAsphyo;

namespace BLAsphyo {
    public class BLServer {

        public Task<bool> testConnection() {
            return Task.Run(() => {
                if( BLDatabaseEngine.EngineInUse.Equals(BLDatabaseEngine.DataSource.SqlServer) )
                    return new DAOAsphyoSqlServer.Connection().TestConnection();


                if( BLDatabaseEngine.EngineInUse.Equals(BLDatabaseEngine.DataSource.MySQL) )
                    return new DAOAsphyoMySql.Connection().TestConnection();

                throw new BEUAsphyo.Exception.BEUExceptionBL("Unhandled error");
            });
        }

        public Task<DataTable> getListDatabases() {
            return Task.Run(() => {
                if( BLDatabaseEngine.EngineInUse.Equals(BLDatabaseEngine.DataSource.MySQL) )
                    return new DAOAsphyoMySql.Server().getAllDataBases();

                if( BLDatabaseEngine.EngineInUse.Equals(BLDatabaseEngine.DataSource.SqlServer) )
                    return new DAOAsphyoSqlServer.Server().getAllDataBases();

                throw new BEUAsphyo.Exception.BEUExceptionBL("Unhandled error");
            });
        }

        public Task<List<String>> getListTables(String Database) {
            return Task.Run(() => {
                if( BLDatabaseEngine.EngineInUse.Equals(BLDatabaseEngine.DataSource.MySQL) ) {
                    List<String> oList = new DAOAsphyoMySql.Server().getTables(Database).AsEnumerable().Select(dr => dr.Field<String>("TableName")).ToList();
                    if( !oList.Any() )
                        throw new BEUAsphyo.Exception.BEUExceptionBL("Databases doesn´t have any tables");
                    return oList;
                }
                if( BLDatabaseEngine.EngineInUse.Equals(BLDatabaseEngine.DataSource.SqlServer) ) {
                    List<String> oList = new DAOAsphyoSqlServer.Server().getTables(Database).AsEnumerable().Select(dr => dr.Field<String>("TableName")).ToList();
                    if( !oList.Any() )
                        throw new BEUAsphyo.Exception.BEUExceptionBL("Databases doesn´t have any tables");
                    return oList;
                }
                throw new BEUAsphyo.Exception.BEUExceptionBL("Unhandled error");
            });
        }

        public Task<DataTable> getTableInformation(String Database, String Table) {
            return Task.Run(() => {
                if( BLDatabaseEngine.EngineInUse.Equals(BLDatabaseEngine.DataSource.MySQL) ) {
                    DataTable oDT = new DAOAsphyoMySql.Server().getTableInformation(Database, Table);
                    if( !oDT.Rows.GetEnumerator().MoveNext() )
                        throw new BEUAsphyo.Exception.BEUExceptionBL("Databases doesn´t have any tables");
                    return oDT;
                }
                if( BLDatabaseEngine.EngineInUse.Equals(BLDatabaseEngine.DataSource.SqlServer) ) {
                    DataTable oDT = new DAOAsphyoSqlServer.Server().getTableInformation(Database, Table);
                    if( !oDT.Rows.GetEnumerator().MoveNext() )
                        throw new BEUAsphyo.Exception.BEUExceptionBL("Databases doesn´t have any tables");
                    return oDT;
                }
                throw new BEUAsphyo.Exception.BEUExceptionBL("Unhandled error");
            });
        }
    }
}
