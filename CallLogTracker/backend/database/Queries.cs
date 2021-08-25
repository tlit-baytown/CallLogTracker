using System;
using System.Collections;
using System.Text;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.backend.database
{
    /// <summary>
    /// This is a class responsible for building dynamic SQL queries using one static method: <see cref="BuildQuery(QType, string, ArrayList, ArrayList, string)"/>
    /// </summary>
    public class Queries
    {
        /// <summary>
        /// Builds a query string based on the supplied arguments.
        /// </summary>
        /// <param name="qtype">The type of query to build. See <see cref="QType"/> for valid options.</param>
        /// <param name="tableName">The table name this query is for.</param>
        /// <param name="values">A <see cref="ArrayList"/> of values for Inserting or Updating.</param>
        /// <param name="columnNames">A <see cref="ArrayList"/> of column names that should be considered.</param>
        /// <param name="condition">The condition, if any, the query should include.</param>
        /// <returns>A new string that represents the query and can be passed to a DB connection for execution. If for some reason the query could not be built,
        /// returns an empty query <c>';'</c></returns>
        public static string BuildQuery(QType qtype, string tableName, ArrayList values = null, ArrayList columnNames = null, string condition = null)
        {
            StringBuilder s = new StringBuilder();

            switch (qtype)
            {
                case QType.INSERT:
                {
                    if (columnNames != null)
                    {
                        s.Append("INSERT INTO ");
                        s.Append($"{tableName} (");

                        for (int i = 0; i <= columnNames.Count - 2; i++)
                            s.Append($"{columnNames[i]}, ");
                        s.Append($"{columnNames[columnNames.Count - 1]}) ");

                        s.Append("VALUES (");

                        for (int i = 0; i <= columnNames.Count - 2; i++)
                            s.Append("@").Append($"{i}, ");
                        s.Append("@").Append($"{columnNames.Count - 1});");

                        return s.ToString();
                    }
                    else
                        return ";";
                }
                case QType.UPDATE:
                {
                    if (values != null && columnNames != null && condition != null)
                    {
                        s.Append($"UPDATE {tableName} SET ");

                        for (int i = 0; i <= columnNames.Count - 2; i++)
                            s.Append($"{columnNames[i]} = {values[i]}, ");
                        s.Append($"{columnNames[columnNames.Count - 1]} = {values[values.Count - 1]} ");

                        s.Append($"WHERE ({condition});");
                        return s.ToString();
                    }
                    else if (columnNames != null && condition != null)
                    {
                        s.Append($"UPDATE {tableName} SET ");

                        for (int i = 0; i < columnNames.Count - 1; i++)
                        {
                            s.Append($"{columnNames[i]} = @{i}, ");
                        }
                        s.Append($"{columnNames[columnNames.Count - 1]} = @{columnNames.Count - 1} ");

                        s.Append($"WHERE ({condition});");
                        return s.ToString();
                    }
                    else
                    {
                        return ";";
                    }
                }
                case QType.DELETE:
                {
                    if (condition != null)
                    {
                        s.Append($"DELETE FROM {tableName} WHERE ({condition});");
                        return s.ToString();
                    }
                    else
                    {
                        return ";";
                    }
                }
                case QType.SELECT:
                {
                    if (columnNames != null)
                    {
                        if (condition != null)
                        {
                            s.Append("SELECT ");
                            for (int i = 0; i < columnNames.Count - 1; i++)
                                s.Append($"{columnNames[i]}, ");
                            s.Append($"{columnNames[columnNames.Count - 1]} FROM {tableName} WHERE ({condition});");
                        }
                        else
                        {
                            s.Append("SELECT ");
                            for (int i = 0; i < columnNames.Count - 1; i++)
                                s.Append($"{columnNames[i]}, ");
                            s.Append($"{columnNames[columnNames.Count - 1]} FROM {tableName};");
                        }
                    }
                    else if (condition != null)
                    {
                        s.Append($"SELECT * FROM {tableName} WHERE ({condition});");
                    }
                    else
                    {
                        s.Append($"SELECT * FROM {tableName};");
                    }
                    return s.ToString();
                }
                default:
                {
                    return ";";
                }
            }
        }

        /// <summary>
        /// Get a SQL query for retriving a list of calls from the database based on the supplied display option.
        /// </summary>
        /// <param name="displayOption">The <see cref="CallDisplay"/> struct instance which holds a valid value for displaying.</param>
        /// <returns>If <paramref name="displayOption"/> is <see cref="CallDisplayOption.None"/>: returns <c>;</c>
        /// Otherwise, returns a query ready to be sent to the SQL connector.
        /// <para>Also note, if the query requires the use of Global values such as the Current User and/or the Current Company and these values
        /// are <c>null</c>, this method returns <c>;</c> instead of throwing any errors.</para></returns>
        public static string GetDisplayQuery(CallDisplay displayOption)
        {
            CallDisplayOption option = displayOption.DisplayOption;
            if (option == CallDisplayOption.None || (Global.Instance.CurrentUser == null 
                                                    || Global.Instance.CurrentCompany == null))
                return ";";

            switch (option)
            {
                case CallDisplayOption.AllCalls:
                    return $"SELECT * FROM Calls WHERE company_id={Global.Instance.CurrentCompany.ID};";

                case CallDisplayOption.AllCallsCurrentUser:
                    return $"SELECT * FROM Calls WHERE " +
                        $"(user_id={Global.Instance.CurrentUser.ID} AND " +
                        $"company_id={Global.Instance.CurrentCompany.ID});";

                case CallDisplayOption.AllCallsCurrentUserUnresolved:
                    return $"SELECT * FROM Calls WHERE is_resolved=0 AND" +
                        $"(user_id={Global.Instance.CurrentUser.ID} AND " +
                        $"company_id={Global.Instance.CurrentCompany.ID});";

                case CallDisplayOption.AllCallsToday:
                    return $"SELECT * FROM Calls WHERE date_recorded='{DateTime.Now.Date.ToShortDateString()}' AND " +
                            $"company_id={Global.Instance.CurrentCompany.ID};";

                case CallDisplayOption.AllCallsTodayCurrentUser:
                    return $"SELECT * FROM Calls WHERE date_recorded='{DateTime.Now.Date.ToShortDateString()}' AND " +
                            $"(user_id={Global.Instance.CurrentUser.ID} AND " +
                            $"company_id={Global.Instance.CurrentCompany.ID});";

                case CallDisplayOption.AllCallsTodayCurrentUserUnresolved:
                    return $"SELECT * FROM Calls WHERE date_recorded='{DateTime.Now.Date.ToShortDateString()}' AND " +
                            $"is_resolved=0 AND (user_id={Global.Instance.CurrentUser.ID} AND " +
                            $"company_id={Global.Instance.CurrentCompany.ID});";

                case CallDisplayOption.AllCallsTodayUnresolved:
                    return $"SELECT * FROM Calls WHERE date_recorded='{DateTime.Now.Date.ToShortDateString()}' AND " +
                            $"is_resolved=0 AND company_id={Global.Instance.CurrentCompany.ID};";

                case CallDisplayOption.AllCallsUnresolved:
                    return $"SELECT * FROM Calls WHERE is_resolved=0 AND company_id={Global.Instance.CurrentCompany.ID};";
            }

            return ";";
        }
    }
}
