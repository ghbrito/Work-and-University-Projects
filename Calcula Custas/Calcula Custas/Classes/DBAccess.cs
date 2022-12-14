using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Odbc;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;


//Class used to access the 3 databases used in the project:
//  1-Remote server database (FIREBIRD) that hosts the data for the SAN System(Notas)
//  2-Remote server database (ODBC) that hosts the data for the CARTOSOFT System (Registro Civil)
//  3-Local database(SQL Server) that stores the data on the services done in the Cartório that were pulled from both legacy databases
namespace Calcula_Custas.Classes
{
    public class DBAccess
    {
        private string stringConn;
        private string stringConn2;
        private SqlConnection connDB;
        private OdbcConnection connODBC;
        private FbConnection connFB;
        private int codDB;

        public DBAccess(int CodDB)
        {
            this.codDB = CodDB;
            try
            {
                if (this.codDB == 1)
                {
                    //stringConn = @"Data Source = localhost; Database = D:\bkp BDs cart\SAN.fdb; User ID = SYSDBA; password = masterkey";
                    stringConn = @"Data Source = bdserver; Database = C:\sistemas\Lyon\SAN\Data\SAN.FDB; User ID = SYSDBA; password = masterkey";
                    connFB = new FbConnection(stringConn);
                    connFB.Open();
                }
                else
                {
                    if (this.codDB == 2)
                    {
                        //stringConn = @"DRIVER={MySQL ODBC 8.0 Unicode Driver};" + "SERVER=localhost;" + "DATABASE=bd_cart;" + "UID=root;" + "PASSWORD=masterkey;" + "SslMode=REQUIRED;";
                        stringConn = @"DRIVER={MySQL ODBC 3.51 Driver};" + "SERVER=bdserver01;" + "DATABASE=bd_cart;" + "UID=cartoadmin;" + "PASSWORD=mdacarto;" + "SslMode=REQUIRED;";
                        connODBC = new OdbcConnection(stringConn);
                        connODBC.Open();
                        //MessageBox.Show("abriu odbc");
                    }
                    else
                    {
                        if (this.codDB == 3)
                        {
                            stringConn = "Data Source=LAPTOP-QQAL12IV;Initial Catalog=cartoassistdb;User ID=sa;Password=master13";
                            connDB = new SqlConnection(stringConn);
                            connDB.Open();
                        }
                        else
                        {
                            if (this.codDB == 4)
                            {
                                stringConn = @"Data Source = localhost; Database = D:\bkp BDs cart\SAN.fdb; User ID = SYSDBA; password = masterkey";
                                connFB = new FbConnection(stringConn);
                                connFB.Open();
                                stringConn2 = "Dsn=cartosoft;uid=root;Password=masterkey";
                                connDB = new SqlConnection(stringConn2);
                                connDB.Open();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SQLQuery(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                if (this.codDB == 1)
                {
                    var myCommand = new FbCommand(SQL, connFB);
                    myCommand.CommandTimeout = 0;
                    var myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                }
                else
                {
                    if (this.codDB == 2)
                    {
                        var myCommand = new OdbcCommand(SQL, connODBC);
                        myCommand.CommandTimeout = 0;
                        var myReader = myCommand.ExecuteReader();
                        dt.Load(myReader);
                        myReader.Close();
                    }
                    else
                    {
                        var myCommand = new SqlCommand(SQL, connDB);
                        myCommand.CommandTimeout = 0;
                        var myReader = myCommand.ExecuteReader();
                        dt.Load(myReader);
                        myReader.Close();
                    }
                }
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            return dt;
        }

        public string SQLQuerySimples(string SQL)
        {
            string resultado = "";
            DataTable dt = new DataTable();
            try
            {
                if (this.codDB == 1)
                {
                    var myCommand = new FbCommand(SQL, connFB);
                    myCommand.CommandTimeout = 0;
                    var myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    resultado = dt.Rows[0][0].ToString();
                    myReader.Close();
                }
                else
                {
                    if (this.codDB == 2)
                    {
                        var myCommand = new OdbcCommand(SQL, connODBC);
                        myCommand.CommandTimeout = 0;
                        var myReader = myCommand.ExecuteReader();
                        dt.Load(myReader);
                        resultado = dt.Rows[0][0].ToString();
                        myReader.Close();
                    }
                    else
                    {
                        var myCommand = new SqlCommand(SQL, connDB);
                        myCommand.CommandTimeout = 0;
                        var myReader = myCommand.ExecuteReader();
                        dt.Load(myReader);
                        resultado = dt.Rows[0][0].ToString();
                        myReader.Close();
                    }
                }
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            return resultado;
        }

        public string SQLCommand(string SQL)
        {
            try
            {
                if (this.codDB == 1)
                {
                    var myCommand = new FbCommand(SQL, connFB);
                    myCommand.CommandTimeout = 0;
                    var myReader = myCommand.ExecuteReader();
                    myReader.Close();
                    return "";
                }
                else
                {
                    if (this.codDB == 2)
                    {
                        var myCommand = new OdbcCommand(SQL, connODBC);
                        myCommand.CommandTimeout = 0;
                        var myReader = myCommand.ExecuteReader();
                        myReader.Close();
                        return "";
                    }
                    else
                    {
                        var myCommand = new SqlCommand(SQL, connDB);
                        myCommand.CommandTimeout = 0;
                        var myReader = myCommand.ExecuteReader();
                        myReader.Close();
                        return "";
                    }
                }

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        public bool KeyExists(string key, string tabela, string nomeKey)
        {

            string SQL = "SELECT " + nomeKey + " FROM " + tabela + " WHERE " + nomeKey + " = '" + key + "'";

            try
            {
                var exists = new SqlCommand(SQL, connDB);
                exists.CommandTimeout = 0;
                var existsReader = exists.ExecuteReader();
                bool existe = existsReader.HasRows;
                existsReader.Close();
                return existe;
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        public bool KeyExists(string key1, string nomeKey1, string key2, string nomeKey2)
        {
            string SQL = "SELECT " + nomeKey1 + " FROM SELOSATOS WHERE " + nomeKey1 + " = '" + key1 + "' AND " + nomeKey2 + " = '" + key2 + "'";
            try
            {
                var exists = new SqlCommand(SQL, connDB);
                exists.CommandTimeout = 0;
                var existsReader = exists.ExecuteReader();
                bool existe = existsReader.HasRows;
                existsReader.Close();
                return existe;
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }



        public string SQLReplace(string key, string codato, string dataPratica, string termo, string folha, string substituiSelo, string status, string tributacao)
        {

            try
            {
                string query = "";
                if (KeyExists(key, "SELOSATOS", "SELO"))
                {
                    query = "UPDATE SELOSATOS SET CODATO = '" + codato + "', TRIBUTACAO = '" + tributacao + "', DATAPRATICA = '" + dataPratica + "', TERMO = '" + termo + "', FOLHA = '" + folha + "', STATUS = '" + status + "' WHERE SELO = '" + key + "'";
                }
                else
                {
                    query = "INSERT INTO SELOSATOS (SELO, CODATO, DATAPRATICA, TERMO, FOLHA, STATUS, TRIBUTACAO) VALUES ('" + key + "', '" + codato + "', '" + dataPratica + "', '" + termo + "', '" + folha + "', '" + status + "', '" + tributacao + "')";
                }

                var myCommand = new SqlCommand(query, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                myReader.Close();
                return "";

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        public string SQLReplaceGenerico(string key, string tabela, string[] colunas, string[] valores)
        {

            try
            {
                string query = "";
                if (KeyExists(key, tabela, colunas[0]))
                {
                    query = "UPDATE " + tabela + " SET";
                    for (int i = 0; i < (colunas.Length - 1); i++)
                    {
                        query = query + " " + colunas[i] + " = '" + valores[i] + "',";
                    }
                    query = query + " " + colunas[colunas.Length - 1] + " = '" + valores[colunas.Length - 1] + "' WHERE " + colunas[0] + " = '" + key + "'";
                }
                else
                {
                    query = "INSERT INTO " + tabela + " (";
                    for (int i = 0; i < (colunas.Length - 1); i++)
                    {
                        query = query + colunas[i] + ", ";
                    }
                    query = query + " " + colunas[colunas.Length - 1] + ") VALUES ('";

                    for (int i = 0; i < (colunas.Length - 1); i++)
                    {
                        query = query + valores[i] + "', '";
                    }
                    query = query + valores[colunas.Length - 1] + "')";
                }

                var myCommand = new SqlCommand(query, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                myReader.Close();
                return "";
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        public DataTable ConsultaTodosBD()
        {
            DataTable dt = new DataTable();
            try
            {
                if (this.codDB == 1)
                {
                    var myCommand = new FbCommand("", connFB);
                    myCommand.CommandTimeout = 0;
                    var myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                }
                else
                {
                    var myCommand = new SqlCommand("", connDB);
                    myCommand.CommandTimeout = 0;
                    var myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                }
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            return dt;
        }

        public double consultaEmolumentos(string codigoAto, string valorConsultado, string anoRef)
        {
            double valor = 0;
            string SQL = "";
            try
            {
                SQL = "SELECT " + valorConsultado + " FROM EMOLUMENTOSATOS WHERE CODATO = " + codigoAto + " AND ANOREF = " + anoRef;
                var myCommand = new SqlCommand(SQL, connDB);
                myCommand.CommandTimeout = 0;
                if (myCommand.Parameters != null && Double.TryParse(myCommand.ExecuteScalar().ToString(), out valor))
                {
                    valor = Double.Parse(myCommand.ExecuteScalar().ToString());
                }
                else
                {
                    MessageBox.Show("ERRO! O código (" + codigoAto + ") não está registrado no Banco de Dados.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return valor;
        }

        public string SQLBulkInsert(DataTable dt)
        {
            try
            {
                //create object of SqlBulkCopy to insert  
                SqlBulkCopy objbulk = new SqlBulkCopy(connDB);
                //assign Destination table name  
                objbulk.DestinationTableName = "ATOSPAGOS";
                objbulk.ColumnMappings.Add("SELO", "SELO");
                objbulk.ColumnMappings.Add("CODIGO", "CODATO");
                objbulk.ColumnMappings.Add("LIVRO", "LIVRO");
                objbulk.ColumnMappings.Add("FOLHA", "FOLHA");
                objbulk.ColumnMappings.Add("CLINOM", "CLINOM");
                objbulk.ColumnMappings.Add("CLICPFCGC", "CLICPF");
                objbulk.ColumnMappings.Add("DATAHIST", "DATAPRATICA");
                //insert bulk Records into DataBase.  
                objbulk.WriteToServer(dt);
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
            return "Inclusão feita com sucesso no Banco de Dados";
        }

        public void CloseConn()
        {
            if (this.codDB == 1)
            {
                connFB.Close();
            }
            else
            {
                if (this.codDB == 2)
                {
                    connODBC.Close();
                }
                else
                {
                    connDB.Close();
                }
            }
        }
    }

}

