using CallLogTracker.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend.database
{
    public class Database
    {
        /// <summary>
        /// The hostname of the database connection
        /// </summary>
        public static string Server { get; set; } = "";

        /// <summary>
        /// The port the database connection is listening on
        /// </summary>
        public static string Port { get; set; } = "";

        /// <summary>
        /// The name of the database to connect to
        /// </summary>
        public static string DB { get; set; } = "";

        /// <summary>
        /// The user name for the database
        /// </summary>
        public static string Username { get; set; } = "";

        /// <summary>
        /// The password for the database
        /// </summary>
        public static string Password { get; set; } = "";

        /// <summary>
        /// The full connection string
        /// </summary>
        public static string ConnectionString { get; private set; }

        /// <summary>
        /// Initializes properties with values from the connection string saved in settings.
        /// Sets the <see cref="ConnectionString"/> property using these values.
        /// </summary>
        public static void Initialize()
        {
            string connection = Settings.Default.ConnectionString;
            if (connection != null && !connection.Equals(""))
            {
                string[] conParts = connection.Split(';');
                string[] conParams = new string[conParts.Length];

                for (int i = 0; i < conParts.Length; i++)
                {
                    conParams[i] = conParts[i].Substring(conParts[i].IndexOf('=') + 1);
                }

                Server = conParams[0];
                Username = conParams[1];
                Password = conParams[2];
                Port = conParams[3];
                DB = conParams[4];

                ConnectionString = $"server={Server};UID={Username};PASSWORD={Password};port={Port};Database={DB};Pooling=True;sqlservermode=True;";
            }
        }

        /// <summary>
        /// Used to save the connection string to settings
        /// </summary>
        public static void SaveConnectionString()
        {
            ConnectionString = $"server={Server};UID={Username};PASSWORD={Password};port={Port};Database={DB};Pooling=True;sqlservermode=True;";
            Settings.Default.ConnectionString = ConnectionString;
            Settings.Default.Save();
        }

        /// <summary>
        /// Creates a database connection on the given connection string and tests that it can be opened and closed.
        /// </summary>
        /// <returns>An <see cref="MySqlException"/> if an error occured while checking connection; <c>null</c> otherwise.</returns>
        public static MySqlException CheckConnection()
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    con.Close();
                    Global.Instance.DatabaseConnected = true;
                }
                catch (MySqlException ex)
                {
                    Global.Instance.DatabaseConnected = false;
                    return ex;
                }
                finally
                {
                    con.Dispose();
                }
                return null;
            }
        }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        /// <summary>
        /// Get a MySql Error Message based on the supplied <paramref name="exception"/>. The exception can be retrieved from the <see cref="CheckConnection"/> method.
        /// <para>If the exception is <c>null</c>, meaning no error occured, this method simply returns <c>NO ERROR</c> as a string.</para>
        /// </summary>
        /// <param name="exception">The exception to get the message of.</param>
        /// <returns>A string containing the error message.</returns>
        public static string GetErrorMessage(MySqlException exception = null)
        {
            if (exception == null)
                return "NO ERROR";
            return exception.Message;
        }

        /// <summary>
        /// Retrieve a list of column names from the specified table.
        /// </summary>
        /// <param name="tableName">The table to get the columns of</param>
        /// <returns>An <see cref="ArrayList"/> of type <see cref="string"/> containing the column names.</returns>
        public static ArrayList GetColumns(string tableName)
        {
            ArrayList columns = new ArrayList();
            string q = $"SELECT `COLUMN_NAME` FROM `INFORMATION_SCHEMA`.`COLUMNS` WHERE `TABLE_SCHEMA`= '{DB}' AND `TABLE_NAME`= '{tableName}';";

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columns.Add(reader.GetString(0));
                        }
                    }
                }
                con.Close();
            }
            return columns;
        }

        /// <summary>
        /// Get the last row id inserted in the specified table.
        /// </summary>
        /// <param name="tablename">The table's name to search</param>
        /// <returns>The id of the last row inserted</returns>
        public static int GetLastRowIDInserted(string tablename)
        {
            int lastRowID = 0;
            ArrayList columns = GetColumns(tablename);
            string q = $"SELECT * FROM {tablename} order by {columns[0]} desc limit 1;";

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lastRowID = reader.GetInt32(0);
                        }
                    }
                }
                con.Close();
            }
            return lastRowID;
        }

        public static int GetNumberOfRows(string tableName)
        {
            int numOfRows = 0;
            string q = $"SELECT COUNT(*) FROM {tableName};";

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        numOfRows = reader.GetInt32(0);
                    }
                }
                con.Close();
            }
            return numOfRows;
        }
    }
}
