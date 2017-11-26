using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLAsphyo {
    public class BLGenerator {


        public async Task<bool> FormatedBEUClass(String FilePath, String Database, List<String> SelectedTables, bool AsphyoReferences) {

            return await Task.Run(async () => {

                if( Directory.Exists(FilePath + "\\Model\\Domain") || Directory.Exists(FilePath + "\\Model\\DAO") ) {
                    throw new BEUAsphyo.Exception.BEUExceptionBL("The path has already a Asphyo Model folder, please move it");
                }
                if( !AsphyoReferences ) {
                    if( Directory.Exists(FilePath + "\\Model\\Databases") ) {
                        throw new BEUAsphyo.Exception.BEUExceptionBL("The path has already a Asphyo Model folder, please move it");
                    }
                    Directory.CreateDirectory(FilePath + "\\Model\\Databases");
                    File.WriteAllText(FilePath + "\\Model\\Databases\\MySQL.php", CreateConnectionClass(), new UTF8Encoding(false));
                }
                Directory.CreateDirectory(FilePath + "\\Model\\Domain");
                Directory.CreateDirectory(FilePath + "\\Model\\DAO");


                foreach( String Table in SelectedTables ) {
                    try {
                        DataTable oDT = await new BLServer().getTableInformation(Database, Table);
                        String TableName = Table.First().ToString().ToUpper() + Table.Substring(1);
                        String ModelStributes = "";
                        String InsideConstructor = "";
                        String ParametersConstructor = "";
                        String Propiertes = "";
                        String TOJSON = "$array" + TableName + " = array();"+Environment.NewLine+"\t\t\t";
                        List<String> Columns = oDT.AsEnumerable().Select(x => x["COLUMN_NAME"].ToString()).ToList();
                        foreach( String Column in Columns ) {
                            ModelStributes += "private $" + Column + ";"+Environment.NewLine+"\t\t";
                            InsideConstructor += "$instance->" + Column + "=$" + Column + ";"+Environment.NewLine+"\t\t\t";
                            ParametersConstructor += "$" + Column + ", ";
                            TOJSON += "$array" + TableName + "[" + Column + "] = $this->FK_[" + Column + "];"+Environment.NewLine+"\t\t\t";
                            Propiertes += Environment.NewLine +"\t\tpublic function get" + Column + "(){"+Environment.NewLine+"\t\t\treturn $this->" + Column + ";"+Environment.NewLine+"\t\t}"+Environment.NewLine + Environment.NewLine+"\t\tpublic function set" + Column + "($" + Column + ") {"+Environment.NewLine+"\t\t\t$this->" + Column + " = $" + Column + ";"+Environment.NewLine+"\t\t}"+Environment.NewLine+Environment.NewLine+"\t\t\t\t\t";
                        }
                        ParametersConstructor = ParametersConstructor.Substring(0, ParametersConstructor.Count() - 2);
                        String generated = CreateBEUClass(TableName, ModelStributes, InsideConstructor, ParametersConstructor, Propiertes, TOJSON, AsphyoReferences).Trim();
                        File.WriteAllText(FilePath + "\\Model\\Domain\\" + TableName + ".php", generated, new UTF8Encoding(false));
                    }
                    catch( Exception ex ) {
                        throw new BEUAsphyo.Exception.BEUExceptionBL("Error writting the table: " + Table, ex);
                    }
                }
                return true;
            });
        }

        public Task<bool> FormatedDAOClass(String FilePath, String Database, List<String> SelectedTables, bool AsphyoReferences, String Engine) {
            return Task.Run(async () => {
                foreach( String Table in SelectedTables ) {
                    try {
                        DataTable oDT = await new BLServer().getTableInformation(Database, Table);
                        List<String> Cols = oDT.AsEnumerable().Where(x => !Convert.ToBoolean(x["IS_AUTO_INCREMENT"]) && !Convert.ToBoolean(x["IS_PRIMARY"])).Select(x => x["COLUMN_NAME"].ToString()).Distinct().ToList();
                        List<String> PrimaryKey = oDT.AsEnumerable().Where(x => Convert.ToBoolean(x["IS_PRIMARY"])).Select(x => x["COLUMN_NAME"].ToString()).ToList();
                        /*
                         *  NOMBRE DE LA TABLA A GENERAR CON PRIMERA LETRA EN MATUSCULA
                         */
                        String TableName = Table.First().ToString().ToUpper() + Table.Substring(1);
                        /*
                         *  VARIABLES CON QUERYS DE SQL
                         */
                        String INSERT_TABLE_BEGIN = "INSERT INTO " + TableName + "(";
                        String INSERT_TABLE_END = "(";
                        String UPDATE_TABLE = "UPDATE " + TableName + " SET ";
                        String DELETE_TABLE = "DELETE FROM " + TableName + " WHERE ";
                        String SELECT_UNIQUE_TABLE = "SELECT * FROM " + TableName + " WHERE ";
                        String SELECT_ALL_TABLE = "SELECT * FROM " + TableName + ";";
                        String EXIST_TABLE = "SELECT EXISTS(SELECT 1 FROM " + TableName + " WHERE ";
                        /*
                         *  VATIABLES CON TIPO DE DATOS DE CADA PARAMETRO
                         */
                        String TypeParamsDelete = "$Params = ";
                        String TypeParamnsInsert = "$Params = ";
                        String TypeParamsUpdate = "$Params = ";
                        String TypeParamsSelectUnique = "$Params = ";
                        String TypeParamsExist = "$Params = "; 
                        /*
                         *   VARIABLES LOCALES PARA GUARDAR LOS DATOS A INSERTAR
                         */
                        String LocalVariablesInsert = "";
                        String LocalVariablesUpdate = "";
                        String LocalVariablesDelete = "";
                        String LocalVariablesSelectUnique = "";
                        String LocalVariablesExist = "";
                        /*
                         *   VARIABLES INSERTANDO EL VALOR DE CADA PARAMETRO
                         */
                        String BindingParamsInsert = "$STMT->bind_param($Params,";
                        String BindingParamsUpdate = "$STMT->bind_param($Params,";
                        String BindingParamsDelete = "$STMT->bind_param($Params,";
                        String BindingParamsSelectUnique = "$STMT->bind_param($Params,";
                        String BindingParamsExist = "$STMT->bind_param($Params,";

                        for( int i = 0; i < Cols.Count; i++ ) {
                            if( i == Cols.Count - 1 ) {
                                INSERT_TABLE_BEGIN += Cols[i] + ") VALUES "; //Close params of insert query (after naming the tablw);
                                INSERT_TABLE_END += "?);"; //Close params of insert query (end of the query (values));
                                UPDATE_TABLE += Cols[i] + " = ? WHERE "; //Close final parms of update query (all the columns to update) before Where statment

                                TypeParamnsInsert += "parent::TypeParam($o" + TableName + "->get" + Cols[i] + "());" + Environment.NewLine + "\t\t\t"; //GET THE PARaMETER DATATYPE

                                BindingParamsInsert += " $"+Cols[i]+");" + Environment.NewLine + "\t\t\t";  //BINDING THE LOCAL VARIABLES IN THE PREPARED STATMENT
                            } else {
                                INSERT_TABLE_BEGIN += Cols[i] + ", ";
                                INSERT_TABLE_END += "?, ";
                                UPDATE_TABLE += Cols[i] + " = ?, ";

                                TypeParamnsInsert += "parent::TypeParam($o" + TableName + "->get" + Cols[i] + "()) . "; //GET THE PARaMETER DATATYPE

                                BindingParamsInsert += " $"+Cols[i]+", "; //BINDING THE LOCAL VARIABLES IN THE PREPARED STATMENT
                            }

                            BindingParamsUpdate += " $" + Cols[i] + ", ";//BINDING THE LOCAL VARIABLES IN THE PREPARED STATMENT

                            TypeParamsUpdate += "parent::TypeParam($o" + TableName + "->get" + Cols[i] + "()) . ";

                            LocalVariablesInsert += "$" + Cols[i] + " = $o" + TableName + "->get" + Cols[i] + "();" + Environment.NewLine + "\t\t\t"; //Save in local variables valuas of the new object
                            LocalVariablesUpdate += "$" + Cols[i] + " = $o" + TableName + "->get" + Cols[i] + "();" + Environment.NewLine + "\t\t\t"; //Save in local variables values of the updated objectS

                        }
                        
                        for( int i = 0; i < PrimaryKey.Count; i++ ) {
                            if( i == PrimaryKey.Count - 1 ) {
                                UPDATE_TABLE += PrimaryKey[i] + " = ?;";
                                SELECT_UNIQUE_TABLE += PrimaryKey[i] + " = ?;";
                                EXIST_TABLE += PrimaryKey[i] + " = ? LIMIT 1);";
                                DELETE_TABLE += PrimaryKey[i] + " = ?;";

                                BindingParamsUpdate += " $" + PrimaryKey[i] + ");" + Environment.NewLine + "\t\t\t";
                                BindingParamsDelete += " $" + PrimaryKey[i] + ");" + Environment.NewLine + "\t\t\t";
                                BindingParamsSelectUnique += " $" + PrimaryKey[i] + ");" + Environment.NewLine + "\t\t\t";
                                BindingParamsExist += " $" + PrimaryKey[i] + ");" + Environment.NewLine + "\t\t\t";

                                TypeParamsDelete += "parent::TypeParam($o" + TableName + "->get" + PrimaryKey[i] + "());" + Environment.NewLine + "\t\t\t";
                                TypeParamsUpdate += "parent::TypeParam($o" + TableName + "->get" + PrimaryKey[i] + "());" + Environment.NewLine + "\t\t\t";
                                TypeParamsSelectUnique += "parent::TypeParam($o" + TableName + "->get" + PrimaryKey[i] + "());" + Environment.NewLine + "\t\t\t";
                                TypeParamsExist += "parent::TypeParam($o" + TableName + "->get" + PrimaryKey[i] + "());" + Environment.NewLine + "\t\t\t";
                            } else {
                                UPDATE_TABLE += PrimaryKey[i] + " = ? AND ";
                                SELECT_UNIQUE_TABLE += PrimaryKey[i] + " = ? AND ";
                                EXIST_TABLE += PrimaryKey[i] + " = ? AND ";
                                DELETE_TABLE += PrimaryKey[i] + " = ? AND ";

                                BindingParamsUpdate += " $" + PrimaryKey[i] + ", ";
                                BindingParamsDelete += " $" + PrimaryKey[i] + ", ";
                                BindingParamsSelectUnique += " $" + PrimaryKey[i] + ", ";

                                TypeParamsDelete += "parent::TypeParam($o" + TableName + "->get" + PrimaryKey[i] + "()) . ";
                                TypeParamsUpdate += "parent::TypeParam($o" + TableName + "->get" + PrimaryKey[i] + "()) . ";
                                TypeParamsSelectUnique += "parent::TypeParam($o" + TableName + "->get" + PrimaryKey[i] + "()) . ";
                                TypeParamsExist += "parent::TypeParam($o" + TableName + "->get" + PrimaryKey[i] + "()) . ";
                            }

                            LocalVariablesUpdate += "$" + PrimaryKey[i] + " = $o" + TableName + "->get" + PrimaryKey[i] + "();" + Environment.NewLine + "\t\t\t";
                            LocalVariablesDelete += "$" + PrimaryKey[i] + " = $o" + TableName + "->get" + PrimaryKey[i] + "();" + Environment.NewLine + "\t\t\t";
                            LocalVariablesSelectUnique += "$" + PrimaryKey[i] + " = $o" + TableName + "->get" + PrimaryKey[i] + "();" + Environment.NewLine + "\t\t\t"; //Save in local variables value of the uniquer select (Where);
                            LocalVariablesExist += "$" + PrimaryKey[i] + " = $o" + TableName + "->get" + PrimaryKey[i] + "();" + Environment.NewLine + "\t\t\t";
                        }
                        String INSERT_QUERY = INSERT_TABLE_BEGIN + INSERT_TABLE_END;
                        String INSERT_FUNCTION = Environment.NewLine + "\t\t\t"  + TypeParamnsInsert + Environment.NewLine + "\t\t\t" + LocalVariablesInsert + Environment.NewLine + "\t\t\t" + BindingParamsInsert;

                        String UPDATE_QUERY = UPDATE_TABLE;
                        String UPDATE_FUNCTION = Environment.NewLine + "\t\t\t" + TypeParamsUpdate + Environment.NewLine + "\t\t\t" + LocalVariablesUpdate + Environment.NewLine + "\t\t\t" + BindingParamsUpdate;

                        String DELETE_QUERY = DELETE_TABLE;
                        String DELETE_FUNCTION = Environment.NewLine + "\t\t\t" + TypeParamsDelete + Environment.NewLine + "\t\t\t" + LocalVariablesDelete + Environment.NewLine + "\t\t\t" + BindingParamsDelete;

                        String SELECT_UNIQUE_QUERY = SELECT_UNIQUE_TABLE;
                        String SELECT_UNIQUE_FUNCTION = Environment.NewLine + "\t\t\t" + TypeParamsSelectUnique + Environment.NewLine + "\t\t\t" + LocalVariablesSelectUnique + Environment.NewLine + "\t\t\t" + BindingParamsSelectUnique;

                        String SELECT_ALL_QUERY = SELECT_ALL_TABLE;
                        //SELECT ALL DOESN'T NEED FUNTION (IT DOESNT HAVE ANY PARAMETERS);

                        String EXIST_ALL_QUERY = EXIST_TABLE;
                        String EXIST_FUNCTION = Environment.NewLine + TypeParamsExist + Environment.NewLine + "\t\t\t" + LocalVariablesExist + Environment.NewLine + BindingParamsExist;

                        String FILE = CreateDAOClass(TableName, INSERT_QUERY, INSERT_FUNCTION, UPDATE_QUERY, UPDATE_FUNCTION, DELETE_QUERY, DELETE_FUNCTION, SELECT_UNIQUE_QUERY, SELECT_UNIQUE_FUNCTION, SELECT_ALL_TABLE, EXIST_TABLE, EXIST_FUNCTION,AsphyoReferences, Engine).Trim();
                        File.WriteAllText(FilePath + "\\Model\\DAO\\" + TableName + "DAO.php", FILE, new UTF8Encoding(false));
                    }
                    catch( Exception ex ) {
                        throw new BEUAsphyo.Exception.BEUExceptionBL("Error writting the table: " + Table, ex);
                    }
                }
                return true;
            });
        }

        private String CreateConnectionClass() {
            return new BEUAsphyo.Templates.BEUTemplates().getConnectionFile().Trim();
        }

        private String CreateBEUClass(String TableName, String ModelAtributes, String InsideConstructor, String ParametersConstructor, String Propiertes, String TOJSON, bool AsphyoReferences) {
            String Template = AsphyoReferences ? new BEUAsphyo.Templates.BEUTemplates().getBEUWithAsphyoReferences() : new BEUAsphyo.Templates.BEUTemplates().getBEUNormal();
            Template = Template.Replace("{{TableName}}", TableName);
            Template = Template.Replace("{{ModelAtributes}}", ModelAtributes);
            Template = Template.Replace("{{InsideConstructor}}", InsideConstructor);
            Template = Template.Replace("{{ParametersConstructor}}", ParametersConstructor);
            Template = Template.Replace("{{Propiertes}}", Propiertes);
            Template = Template.Replace("{{TOJSON}}", TOJSON);
            return Template;
        }

        private String CreateDAOClass(String TableName, String INSERT_QUERY, String INSERT_FUNCTION, String UPDATE_QUERY, String UPDATE_FUNCTION, String DELETE_QUERY, String DELETE_FUNCTION, String SELECT_UNIQUE_QUERY, String SELECT_UNIQUE_FUNCTION, String SELECT_ALL_TABLE, String EXIST_QUERY, String EXIST_FUNCTION, bool AsphyoReferences, String Engine) {
            String Template = AsphyoReferences ? new BEUAsphyo.Templates.BEUTemplates().getDAOWithAsphyoReferences() : new BEUAsphyo.Templates.BEUTemplates().getDAONormal();
            Template = Template.Replace("{{TableName}}", TableName);
            Template = Template.Replace("{{INSERT_TABLE}}", INSERT_QUERY);
            Template = Template.Replace("{{UPDATE_TABLE}}", UPDATE_QUERY);
            Template = Template.Replace("{{DELETE_TABLE}}", DELETE_QUERY);
            Template = Template.Replace("{{SELECT_UNIQUE_TABLE}}", SELECT_UNIQUE_QUERY);
            Template = Template.Replace("{{EXISTL_TABLE}}", EXIST_QUERY);
            Template = Template.Replace("{{SELECT_ALL_TABLE}}", SELECT_ALL_TABLE);
            Template = Template.Replace("{{ParametersInsert}}", INSERT_FUNCTION);
            Template = Template.Replace("{{ParametersDelete}}", DELETE_FUNCTION);
            Template = Template.Replace("{{ParametersUpdate}}", UPDATE_FUNCTION);
            Template = Template.Replace("{{ParametersSelectUnique}}", SELECT_UNIQUE_FUNCTION);
            Template = Template.Replace("{{ParametersExists}}", SELECT_UNIQUE_FUNCTION);
            Template = Template.Replace("{{DATABASE_ENGINE}}", Engine);
            return Template;
        }
    }
}
