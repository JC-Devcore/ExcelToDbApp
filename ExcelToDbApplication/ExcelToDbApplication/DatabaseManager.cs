using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToDbApplication {
    class DatabaseManager {

        // enum
        public enum FIELDS_DATATYPE
        {
            CHAR_ITEM = 0,
            INT_ITEM,
            CURRENCY_ITEM,
            DATETIME_ITEM
        }

        //struct
        public struct TableFieldParam {
            public string sName;
            public FIELDS_DATATYPE eDataType;

        }

        //struct
        public struct CreateTableParam
        {
            public String sTableName;
            public List<TableFieldParam> vsFields;
        }

        //struct
        public struct TableContent
        {
            public String FieldName;
            public String FieldContent;
            public FIELDS_DATATYPE eDataType;
        }

        //struct
        public struct AddTableItemContentParam
        {
            public String sTableName;
            public List<TableContent> vsTableContent;
        }

        //create database
        public struct CreateDatabaseParam
        {
            public string sDbName;
            public string sPath;
            public string sMDfSize;
            public string sMDFMaxSize;
            public string sMDFPercentFileGrowth;
            public string sLDFSize;
            public string sLDFMaxSize;
            public string sIDFPercentFileGrowth;
        }



        // Global Buffers
        private string ConnectionString;


        public DatabaseManager() {
            ConnectionString = "Server = localhost;";
            ConnectionString += "Integrated security = SSPI;";
            ConnectionString += "database = master";
        }

        private bool executeSqlStatement(string sql) {
            bool bStatus = false;
            using (var conn = new SqlConnection(ConnectionString)) {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn)) {
                    try {
                        cmd.ExecuteNonQuery();
                        bStatus = true;
                    }
                    catch (SqlException ex) {
                        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bStatus =  false;
                    }
                }
            }

            return bStatus;
        }

        public void establishSqlConnectionServer()
        {
            SqlConnectionStringBuilder cBuilder = new SqlConnectionStringBuilder();

            cBuilder.DataSource = "LocalHost";
            cBuilder.UserID = "root";
            cBuilder.Password = "123456";
            cBuilder.InitialCatalog = "master";

            ConnectionString = cBuilder.ConnectionString;
            try {
                using (SqlConnection conn = new SqlConnection(cBuilder.ConnectionString)) {
                    conn.Open();
                    Console.WriteLine("Connect Done");
                }
            }
            catch(SqlException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    
        // This method creates a new SQL Server database
        public bool createDatabase(CreateDatabaseParam tInputParam)
        {
           String str;

            try {
                // Build Create database sql command
                str = "CREATE DATABASE "
                    + tInputParam.sDbName
                    + " ON PRIMARY (NAME = "
                    + tInputParam.sDbName
                    + "_Data, FILENAME = '"
                    + tInputParam.sPath
                    + tInputParam.sDbName
                    + "Data.mdf', SIZE = "
                    + tInputParam.sMDfSize
                    + "MB, MAXSIZE = "
                    + tInputParam.sMDFMaxSize
                    + "MB, FILEGROWTH = "
                    + tInputParam.sMDFPercentFileGrowth
                    + "%) LOG ON (NAME = "
                    + tInputParam.sDbName
                    + "_Log, FILENAME = '"
                    + tInputParam.sPath
                    + tInputParam.sDbName
                    + "Log.ldf', "
                    + "SIZE = "
                    + tInputParam.sLDFSize
                    + "MB, MAXSIZE = "
                    + tInputParam.sLDFMaxSize
                    + "MB, FILEGROWTH = "
                    + tInputParam.sIDFPercentFileGrowth
                    + "%)";

                return executeSqlStatement(str);
            }
            catch(SqlException ex) {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool createTable(CreateTableParam tInputParam)
        {
            string sql;
            string sFields = "";

            try {
                foreach (TableFieldParam tElem in tInputParam.vsFields) {
                    sFields += " ";
                    sFields += tElem.sName;
                    sFields += " ";

                    switch (tElem.eDataType) {
                        case FIELDS_DATATYPE.CHAR_ITEM:
                            sFields += "CHAR(100),";
                            break;
                        case FIELDS_DATATYPE.INT_ITEM:
                            sFields += "INT,";
                            break;
                        case FIELDS_DATATYPE.CURRENCY_ITEM:
                            sFields += "FLOAT,";
                            break;
                        case FIELDS_DATATYPE.DATETIME_ITEM:
                            sFields += "DATETIME,";
                            break;
                        default:
                            sFields += "CHAR(100),";
                            break;
                    }
                }

                // remove whitespaces and trailling character
                sFields = sFields.Trim();
                sFields = sFields.TrimEnd(',');


                // build command
                sql = "CREATE TABLE "
                    + tInputParam.sTableName
                    + "("+ tInputParam.sTableName+"RefId INTEGER CONSTRAINT PKey"+ tInputParam.sTableName + " PRIMARY KEY,"
                    + sFields
                    + ")";
                
                // Execute sql command
                return executeSqlStatement(sql);
            }
            catch(SqlException ex) {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AddTableItems(AddTableItemContentParam tInputParam)
        {
            string sql;
            string sFieldName = "";
            string sFieldContent = "";

            try {

                foreach (TableContent tElem in tInputParam.vsTableContent) {

                    // Field names
  
                    sFieldName += " ";
                    sFieldName += tElem.FieldName;
                    sFieldName += ",";

                    // Field Value
                    sFieldContent += " ";
                    if ((tElem.eDataType == FIELDS_DATATYPE.CHAR_ITEM)||(tElem.eDataType == FIELDS_DATATYPE.DATETIME_ITEM))
                        sFieldContent += "'";
                    sFieldContent += tElem.FieldContent;
                    if ((tElem.eDataType == FIELDS_DATATYPE.CHAR_ITEM) || (tElem.eDataType == FIELDS_DATATYPE.DATETIME_ITEM))
                        sFieldContent += "'";
                    sFieldContent += ",";
                }

                // remove whitespaces and trailling character
                sFieldName = sFieldName.Trim();
                sFieldName = sFieldName.TrimEnd(',');
                sFieldContent = sFieldContent.Trim();
                sFieldContent = sFieldContent.TrimEnd(',');

                // Adding records the table
                sql = "INSERT INTO "
                    + tInputParam.sTableName
                    + "("
                    + sFieldName
                    + ") " 
                    + "VALUES ("
                    + sFieldContent
                    + " ) ";


              //  MessageBox.Show(sql, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
             //   return true;

                // Execute sql command
                return executeSqlStatement(sql);
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CheckDatabaseExists(string connString, string databaseName)
        {
            using (var connection = new SqlConnection(connString)) {
                using (var command = new SqlCommand($"SELECT db_id('{databaseName}')", connection)) {
                    connection.Open();
                    return (command.ExecuteScalar() != DBNull.Value);
                }
            }
        }


        public void testDataCreateTable()
        {
            DatabaseManager cDebug = new DatabaseManager();
            DatabaseManager.CreateTableParam tTable;
            DatabaseManager.TableFieldParam tFields;

            tTable.sTableName = "debugTable";
            tTable.vsFields = new List<DatabaseManager.TableFieldParam>();


            //Item 1
            tFields.sName = "Field1";
            tFields.eDataType = DatabaseManager.FIELDS_DATATYPE.INT_ITEM;
            tTable.vsFields.Add(tFields);

            //Item 2
            tFields.sName = "Field2";
            tFields.eDataType = DatabaseManager.FIELDS_DATATYPE.CHAR_ITEM;
            tTable.vsFields.Add(tFields);

            //Item 3
            tFields.sName = "Field3";
            tFields.eDataType = DatabaseManager.FIELDS_DATATYPE.CURRENCY_ITEM;
            tTable.vsFields.Add(tFields);

            //Item 4
            tFields.sName = "Field4";
            tFields.eDataType = DatabaseManager.FIELDS_DATATYPE.DATETIME_ITEM;
            tTable.vsFields.Add(tFields);

            cDebug.createTable(tTable);

        }

        public void testDataInputContent()
        {
            DatabaseManager cDebug = new DatabaseManager();
            DatabaseManager.AddTableItemContentParam tTable;
            DatabaseManager.TableContent tFields;

            tTable.sTableName = "debugTable";
            tTable.vsTableContent = new List<DatabaseManager.TableContent>();

            //keys
            int iCurrentNumberOfRecords;
            iCurrentNumberOfRecords = cDebug.getTableNumberOfRecords(tTable.sTableName);
            iCurrentNumberOfRecords++;

            tFields.FieldName = tTable.sTableName+"RefId";
            tFields.eDataType = DatabaseManager.FIELDS_DATATYPE.INT_ITEM;
            tFields.FieldContent = Convert.ToString(iCurrentNumberOfRecords);
            tTable.vsTableContent.Add(tFields);


            //Item 1
            tFields.FieldName = "Field1";
            tFields.eDataType = DatabaseManager.FIELDS_DATATYPE.INT_ITEM;
            tFields.FieldContent = "100";
            tTable.vsTableContent.Add(tFields);

            //Item 2
            tFields.FieldName = "Field2";
            tFields.eDataType = DatabaseManager.FIELDS_DATATYPE.CHAR_ITEM;
            tFields.FieldContent = "Item A";
            tTable.vsTableContent.Add(tFields);

            //Item 3
            tFields.FieldName = "Field3";
            tFields.eDataType = DatabaseManager.FIELDS_DATATYPE.CURRENCY_ITEM;
            tFields.FieldContent = "29.25";
            tTable.vsTableContent.Add(tFields);

            //Item 4
            tFields.FieldName = "Field4";
            tFields.eDataType = DatabaseManager.FIELDS_DATATYPE.DATETIME_ITEM;
            tFields.FieldContent = "2018-07-07 12:30:12";
            tTable.vsTableContent.Add(tFields);

            cDebug.AddTableItems(tTable);

        }

        public int getTableNumberOfRecords(string sTableName)
        {
            String sql;
            int iCount = 0;

            sql = "SELECT COUNT(*) from "
                + sTableName;

            using (var conn = new SqlConnection(ConnectionString)) {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn)) {
                    try {
                        iCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (SqlException ex) {
                        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        iCount = 0;
                    }
                }
            }

            return iCount;
        }
    }
}
