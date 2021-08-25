using CallLogTracker.backend.database.wrappers;
using CallLogTracker.utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.backend.database
{
    public class CallConnector
    {
        public static Call GetCall(int id)
        {
            Call c = null;
            string q = Queries.BuildQuery(QType.SELECT, "Calls", null, null, $"call_id={id}");

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            try
                            {
                                reader.Read();
                                c = new Call
                                {
                                    ID = reader.GetInt32(0),
                                    CompanyID = reader.GetInt32(1),
                                    UserID = reader.GetInt32(2),
                                    CallerName = reader.GetString(3),
                                    CallerPhone = reader.GetString(4),
                                    Message = reader.GetString(6),
                                    IsUrgent = reader.GetBoolean(7),
                                    Date = DateTime.Parse(reader.GetString(8)),
                                    Timestamp = reader.GetDateTime(9),
                                    IsResolved = reader.GetBoolean(10)
                                };

                                if (reader.IsDBNull(5))
                                    c.CallerEmail = "N/A";
                                else
                                    c.CallerEmail = reader.GetString(5);
                            }
                            catch (Exception e)
                            {
                                Global.Instance.MainForm.GetConsole().AddEntry("An exception has occured in GetCall(): {e.Message}");
                            }
                        }
                    }
                }
                con.Close();
            }
            return c;
        }

        public static SortableBindingList<Call> GetCalls(CallDisplay displayOption)
        {
            SortableBindingList<Call> calls = new SortableBindingList<Call>();

            if (Global.Instance.CurrentCompany == null)
            {
                Global.Instance.MainForm.GetConsole().AddEntry(": Company was null while attempting to fetch calls. Returning an empty list...");
                return calls;
            }

            string q = Queries.GetDisplayQuery(displayOption);

            if (q.Equals(";"))
                return calls;

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            try
                            {
                                while (reader.Read())
                                {
                                    Call c = new Call
                                    {
                                        ID = reader.GetInt32(0),
                                        CompanyID = reader.GetInt32(1),
                                        UserID = reader.GetInt32(2),
                                        CallerName = reader.GetString(3),
                                        CallerPhone = reader.GetString(4),
                                        Message = reader.GetString(6),
                                        IsUrgent = reader.GetBoolean(7),
                                        Date = DateTime.Parse(reader.GetString(8)),
                                        Timestamp = reader.GetDateTime(9),
                                        IsResolved = reader.GetBoolean(10)
                                    };

                                    if (reader.IsDBNull(5))
                                        c.CallerEmail = "N/A";
                                    else
                                        c.CallerEmail = reader.GetString(5);

                                    calls.Add(c);
                                }
                            }
                            catch (Exception e)
                            {
                                Global.Instance.MainForm.GetConsole().AddEntry($"An exception has occured in GetCalls({displayOption.DisplayOption.ToDescriptionString()}): {e.Message}");
                            }
                        }
                    }
                }
                con.Close();
            }
            return calls;
        }

        public static int InsertCall(Call c)
        {
            int affectedRows = 0;
            ArrayList columns = Database.GetColumns("Calls");
            columns.RemoveAt(0); //remove id column
            columns.RemoveAt(columns.Count - 2);//remove timestamp column
            columns.TrimToSize();
            string q = Queries.BuildQuery(QType.INSERT, "Calls", null, columns);

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlTransaction tr = con.BeginTransaction())
                    {
                        cmd.CommandText = q;
                        cmd.Transaction = tr;
                        cmd.Parameters.AddWithValue("@0", c.CompanyID);
                        cmd.Parameters.AddWithValue("@1", c.UserID);
                        cmd.Parameters.AddWithValue("@2", c.CallerName);
                        cmd.Parameters.AddWithValue("@3", c.CallerPhone);

                        if (c.CallerEmail == null)
                            cmd.Parameters.AddWithValue("@4", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@4", c.CallerEmail);

                        cmd.Parameters.AddWithValue("@5", c.Message);
                        cmd.Parameters.AddWithValue("@6", c.IsUrgent);
                        cmd.Parameters.AddWithValue("@7", c.Date.ToShortDateString());
                        cmd.Parameters.AddWithValue("@8", c.IsResolved);

                        cmd.Connection = con;
                        affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            tr.Commit();
                        }
                        else
                        {
                            tr.Rollback();
                        }
                    }
                }
                con.Close();
            }
            return affectedRows != 0 ? Database.GetLastRowIDInserted("Calls") : 0;
        }

        public static bool UpdateCall(Call c)
        {
            int affectedRows = 0;
            ArrayList columns = Database.GetColumns("Calls");
            columns.RemoveAt(columns.Count - 2); //remove timestamp column
            columns.TrimToSize();

            string q = Queries.BuildQuery(QType.UPDATE, "Calls", null, columns, $"call_id={c.ID}");

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlTransaction tr = con.BeginTransaction())
                    {
                        cmd.CommandText = q;
                        cmd.Transaction = tr;
                        cmd.Parameters.AddWithValue("@0", c.ID);
                        cmd.Parameters.AddWithValue("@1", c.CompanyID);
                        cmd.Parameters.AddWithValue("@2", c.UserID);
                        cmd.Parameters.AddWithValue("@3", c.CallerName);
                        cmd.Parameters.AddWithValue("@4", c.CallerPhone);

                        if (c.CallerEmail == null)
                            cmd.Parameters.AddWithValue("@5", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@5", c.CallerEmail);

                        cmd.Parameters.AddWithValue("@6", c.Message);
                        cmd.Parameters.AddWithValue("@7", c.IsUrgent);
                        cmd.Parameters.AddWithValue("@8", c.Date.ToShortDateString());
                        cmd.Parameters.AddWithValue("@9", c.IsResolved);

                        cmd.Connection = con;
                        affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            tr.Commit();
                        }
                        else
                        {
                            tr.Rollback();
                        }
                    }
                }
                con.Close();
            }
            return affectedRows != 0;
        }

        public static bool DeleteCall(Call c)
        {
            int affectedRows = 0;
            string q = Queries.BuildQuery(QType.DELETE, "Calls", null, null, $"call_id={c.ID}");

            using (MySqlConnection con = Database.GetConnection())
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlTransaction tr = con.BeginTransaction())
                        {
                            cmd.CommandText = q;
                            cmd.Transaction = tr;
                            cmd.Connection = con;
                            affectedRows = cmd.ExecuteNonQuery();

                            if (affectedRows > 0)
                                tr.Commit();
                            else
                                tr.Rollback();
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    Global.Instance.MainForm.GetConsole().AddEntry("An exception has occured in DeleteCall(): {ex.Message}");
                    con.Close();
                    return false;
                }
            }

            return affectedRows != 0;
        }
    }
}
